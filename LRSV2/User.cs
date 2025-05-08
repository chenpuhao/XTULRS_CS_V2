using System.Runtime.InteropServices;
using System.Text.Json;
using static LRSV2.Classes;

namespace LRSV2;

public partial class User : Form
{
    public User()
    {
        InitializeComponent();
    }

    private void User_Load(object sender, EventArgs e)
    {
        welcome.Text = "你好，" + Program.Username;
        if (Program.Seat == "none")
        {
            res.Text = "你当前没有预约座位哦，快去预约吧！";
        }
        else
        {
            Reservation seat = JsonSerializer.Deserialize<Reservation>(Program.Seat, options);
            res.Text = "你当前预约的座位是" + seat.Room + "的" + seat.Seat + "号";
        }
        seatDataTable.Columns.Add("Room", "房间号");
        seatDataTable.Columns.Add("Seat", "座位号");
        seatDataTable.Columns.Add("isOccupied", "是否被占用");
        string seatsJson = Marshal.PtrToStringAnsi(Dll.returnAllSeats(Program.SeatHead));
        if (!string.IsNullOrEmpty(seatsJson))
        {
            AddData(seatsJson);
        }
        PopulateComboBoxes();
        if (Program.Seat == "none")
        {
            resButton.Enabled = true;
            cancelResButton.Enabled = false;
        }
        else
        {
            resButton.Enabled = false;
            cancelResButton.Enabled = true;
        }
    }
    private void AddData(string seatsJson)
    {
        seatDataTable.Rows.Clear();

        var seatsList = JsonSerializer.Deserialize<List<Seats>>(seatsJson, options);
        if (seatsList != null)
        {
            foreach (var seat in seatsList)
            {
                seatDataTable.Rows.Add(seat.Room, seat.Seat, seat.IsOccupied == 1 ? "被占用" : "空闲");
            }
        }
    }
    private void PopulateComboBoxes()
    {
        roomSelect.Items.Clear();
        seatSelect.Items.Clear();
        resSelect.Items.Clear();

        // 添加是否空闲选项
        resSelect.Items.Add("空闲");
        resSelect.Items.Add("被占用");

        // 获取座位数据
        string seatsJson = Marshal.PtrToStringAnsi(Dll.returnAllSeats(Program.SeatHead));
        if (!string.IsNullOrEmpty(seatsJson))
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            // 反序列化座位数据
            var seatsList = JsonSerializer.Deserialize<List<Seats>>(seatsJson, options);
            if (seatsList != null)
            {
                // 使用 HashSet 去重
                var roomSet = new HashSet<int>();
                var seatSet = new HashSet<int>();

                foreach (var seat in seatsList)
                {
                    roomSet.Add(seat.Room);
                    seatSet.Add(seat.Seat);
                }

                foreach (var room in roomSet)
                {
                    roomSelect.Items.Add(room);
                }

                foreach (var seat in seatSet)
                {
                    seatSelect.Items.Add(seat);
                }
            }
        }
    }

    private void filterButton_Click(object sender, EventArgs e)
    {
        IntPtr rooms = Dll.returnAllSeats(Program.SeatHead);
        string roomsJson = Marshal.PtrToStringAnsi(rooms);
        if (roomSelect.SelectedValue != null)
        {
            int selectedRoom = (int)roomSelect.SelectedValue;
            IntPtr temp = Dll.findSeatByRoom(Program.SeatHead, selectedRoom);
            string seatsJson = Marshal.PtrToStringAnsi(temp);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var allSeats = JsonSerializer.Deserialize<List<Seats>>(roomsJson, options);
            var filteredSeats = JsonSerializer.Deserialize<List<Seats>>(seatsJson, options);

            if (allSeats != null && filteredSeats != null)
            {
                var commonSeats = allSeats.Where(seat =>
                    filteredSeats.Any(filtered =>
                        filtered.Room == seat.Room && filtered.Seat == seat.Seat)).ToList();

                // 将筛选后的片段重新序列化为 JSON
                roomsJson = JsonSerializer.Serialize(commonSeats);
                AddData(roomsJson);
            }
        }

        if (seatSelect.SelectedValue != null)
        {
            int selectedSeat = (int)seatSelect.SelectedValue;
            IntPtr temp = Dll.findSeatBySeat(Program.SeatHead, selectedSeat);
            string seatsJson = Marshal.PtrToStringAnsi(temp);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var allSeats = JsonSerializer.Deserialize<List<Seats>>(roomsJson, options);
            var filteredSeats = JsonSerializer.Deserialize<List<Seats>>(seatsJson, options);

            if (allSeats != null && filteredSeats != null)
            {
                var commonSeats = allSeats.Where(seat =>
                    filteredSeats.Any(filtered =>
                        filtered.Room == seat.Room && filtered.Seat == seat.Seat)).ToList();

                // 将筛选后的片段重新序列化为 JSON
                roomsJson = JsonSerializer.Serialize(commonSeats);
                AddData(roomsJson);
            }
        }

        if (resSelect.SelectedValue != null)
        {
            string selectedIsFree = (string)resSelect.SelectedValue;
            IntPtr temp = Dll.findSeatByIsOccupied(Program.SeatHead, selectedIsFree == "空闲" ? 0 : 1);
            string seatsJson = Marshal.PtrToStringAnsi(temp);
            var allSeats = JsonSerializer.Deserialize<List<Seats>>(roomsJson, options);
            var filteredSeats = JsonSerializer.Deserialize<List<Seats>>(seatsJson, options);

            if (allSeats != null && filteredSeats != null)
            {
                var commonSeats = allSeats.Where(seat =>
                    filteredSeats.Any(filtered =>
                        filtered.Room == seat.Room && filtered.Seat == seat.Seat)).ToList();

                // 将筛选后的片段重新序列化为 JSON
                roomsJson = JsonSerializer.Serialize(commonSeats);
                AddData(roomsJson);
            }
        }
    }

    private void cancelFiltterButtton_Click(object sender, EventArgs e)
    {
        roomSelect.SelectedValue = null;
        seatSelect.SelectedValue = null;
        resSelect.SelectedValue = null;
        string seatsJson = Marshal.PtrToStringAnsi(Dll.returnAllSeats(Program.SeatHead));
        if (!string.IsNullOrEmpty(seatsJson))
        {
            AddData(seatsJson);
        }
    }

    private void resButton_Click(object sender, EventArgs e)
    {
        if (seatDataTable.SelectedCells.Count > 0)
        {
            int selectedRowIndex = seatDataTable.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = seatDataTable.Rows[selectedRowIndex];
            int room = Convert.ToInt32(selectedRow.Cells["Room"].Value);
            int seat = Convert.ToInt32(selectedRow.Cells["Seat"].Value);
            if (Dll.reserveSeat(Program.SeatHead, room, seat, Login.LoginUser, Program.StatisticHead) == 0)
            {
                MessageBox.Show("预约成功");
                Program.Seat = JsonSerializer.Serialize(new Reservation { Room = room, Seat = seat });
                res.Text = "你当前预约的座位是" + room + "的" + seat + "号";
                resButton.Enabled = false;
                cancelResButton.Enabled = true;
                Dll.saveSeats(Program.SeatHead);
                Dll.saveStatistic(Program.StatisticHead);
                Dll.saveUser(Program.UserHead);
                string seatsJson = Marshal.PtrToStringAnsi(Dll.returnAllSeats(Program.SeatHead));
                if (!string.IsNullOrEmpty(seatsJson))
                {
                    AddData(seatsJson);
                }
            }
            else
            {
                MessageBox.Show("预约失败，请检查座位是否已被占用");
            }
        }
        else
        {
            MessageBox.Show("你还没有选择座位哦，单击表格任意一行可以选择该座位");
        }
    }

    private void cancelResButton_Click(object sender, EventArgs e)
    {
        if (Dll.cancelReservation(Program.SeatHead, Login.LoginUser) == 0)
        {
            MessageBox.Show("取消预约成功");
            Program.Seat = "none";
            res.Text = "你当前没有预约座位哦，快去预约吧！";
            resButton.Enabled = true;
            cancelResButton.Enabled = false;
            Dll.saveSeats(Program.SeatHead);
            Dll.saveUser(Program.UserHead);
            string seatsJson = Marshal.PtrToStringAnsi(Dll.returnAllSeats(Program.SeatHead));
            if (!string.IsNullOrEmpty(seatsJson))
            {
                AddData(seatsJson);
            }
        }
        else
        {
            MessageBox.Show("取消预约失败，请检查座位是否已被占用");
        }
    }

    private void myInfoButton_Click(object sender, EventArgs e)
    {
        using var userInfo = new Info();
        userInfo.ShowDialog();
    }

    private void exitButton_Click(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("确定要退出吗？", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            Dll.saveSeats(Program.SeatHead);
            Dll.saveUser(Program.UserHead);
            Dll.saveStatistic(Program.StatisticHead);
            Dll.freeSeat(Program.SeatHead);
            Dll.freeUser(Program.UserHead);
            Dll.freeStatistic(Program.StatisticHead);
            Application.Exit();
        }
    }
}