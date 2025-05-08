using System.Runtime.InteropServices;
using System.Text.Json;
using OfficeOpenXml;

namespace LRSV2;

public partial class Admin : Form
{
    public Admin()
    {
        InitializeComponent();
    }

    private void Admin_Load(object sender, EventArgs e)
    {
        welcome.Text = "你好:" + Program.Username;

        PopulateComboBoxes();

        seatDataBox.Columns.Add("Room", "房间号");
        seatDataBox.Columns.Add("Seat", "座位号");
        seatDataBox.Columns.Add("isOccupied", "是否被占用");
        string seatsJson = Marshal.PtrToStringAnsi(Dll.returnAllSeats(Program.SeatHead));
        if (!string.IsNullOrEmpty(seatsJson))
        {
            AddSeatData(seatsJson);
        }


        //预约管理
        resDataBox.Columns.Add("Name", "用户名");
        resDataBox.Columns.Add("room", "房间号");
        resDataBox.Columns.Add("seat", "座位号");
        resDataBox.Columns.Add("Time", "时间");
        string resJson = Marshal.PtrToStringAnsi(Dll.returnAllStatistic(Program.StatisticHead, Login.LoginUser));
        if (!string.IsNullOrEmpty(resJson))
        {
            AddResData(resJson);
        }

        userDataBox.Columns.Add("Name", "用户名");
        userDataBox.Columns.Add("Email", "邮箱");
        userDataBox.Columns.Add("Password", "密码");
        userDataBox.Columns.Add("IsAdmin", "是否管理员");
        userDataBox.Columns.Add("room", "占用的房间号");
        userDataBox.Columns.Add("seat", "占用的座位号");
        IntPtr userInfo = Dll.returnAllUser(Program.UserHead, Marshal.StringToHGlobalAnsi(Program.UserEmail));
        string userInfoJson = Marshal.PtrToStringAnsi(userInfo);
        AddUserData(userInfoJson);
    }

    private void AddSeatData(string seatsJson)
    {
        seatDataBox.Rows.Clear();

        var seatsList = JsonSerializer.Deserialize<List<Classes.Seats>>(seatsJson, Classes.options);
        if (seatsList != null)
        {
            foreach (var seat in seatsList)
            {
                seatDataBox.Rows.Add(seat.Room, seat.Seat, seat.IsOccupied == 1 ? "被占用" : "空闲");
            }
        }


    }

    private void AddResData(string resJson)
    {
        resDataBox.Rows.Clear();
        var resList = JsonSerializer.Deserialize<List<Classes.Statistics>>(resJson, Classes.options);
        if (resList != null)
        {
            foreach (var res in resList)
            {
                resDataBox.Rows.Add(res.User, res.Room, res.Seat, res.Time);
            }
        }
    }

    private void AddUserData(String json)
    {
        userDataBox.Rows.Clear();
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        var userDataList = JsonSerializer.Deserialize<List<Classes.UserInfo>>(json, options);
        if (userDataList != null)
        {
            foreach (var userData in userDataList)
            {
                string seats = userData.Seat;
                if (seats != "" && seats != "none")
                {
                    seats = "[" + seats + "]";
                    var seatOptions = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    var seatDataList = JsonSerializer.Deserialize<List<Classes.Reservation>>(seats, seatOptions);
                    if (seatDataList != null)
                    {
                        foreach (var s in seatDataList)
                        {
                            userDataBox.Rows.Add(userData.Name, userData.Email, Encryption.Decrypt(userData.Password), userData.IsAdmin == 1 ? "是" : "否", s.Room, s.Seat);
                        }
                    }
                }
                else
                {
                    userDataBox.Rows.Add(userData.Name, userData.Email, Encryption.Decrypt(userData.Password), userData.IsAdmin == 1 ? "是" : "否", "", "");
                }
            }
        }
    }

    private void PopulateComboBoxes()
    {
        roomSelect.Items.Clear();
        seatSelect.Items.Clear();
        resSelect.Items.Clear();

        resSelect.Items.Add("空闲");
        resSelect.Items.Add("被占用");

        string seatsJson = Marshal.PtrToStringAnsi(Dll.returnAllSeats(Program.SeatHead));
        if (!string.IsNullOrEmpty(seatsJson))
        {

            var seatsList = JsonSerializer.Deserialize<List<Classes.Seats>>(seatsJson, Classes.options);
            if (seatsList != null)
            {
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

        roomRes.Items.Clear();
        seatRes.Items.Clear();
        userRes.Items.Clear();
        string resJson = Marshal.PtrToStringAnsi(Dll.returnAllStatistic(Program.StatisticHead, Login.LoginUser));
        if (!string.IsNullOrEmpty(resJson))
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var resList = JsonSerializer.Deserialize<List<Classes.Statistics>>(resJson, options);
            if (resList != null)
            {
                var roomSet = new HashSet<int>();
                var seatSet = new HashSet<int>();
                var userSet = new HashSet<string>();

                foreach (var res in resList)
                {
                    roomSet.Add(res.Room);
                    seatSet.Add(res.Seat);
                    userSet.Add(res.User);
                }

                foreach (var room in roomSet)
                {
                    roomRes.Items.Add(room);
                }

                foreach (var seat in seatSet)
                {
                    seatRes.Items.Add(seat);
                }

                foreach (var user in userSet)
                {
                    userRes.Items.Add(user);
                }
            }
        }
    }

    private void removeSeat_Click(object sender, EventArgs e)
    {
        if (seatDataBox.SelectedCells.Count > 0)
        {
            int selectedRowIndex = seatDataBox.SelectedCells[0].RowIndex;
            string room = seatDataBox.Rows[selectedRowIndex].Cells[0].Value.ToString();
            string seat = seatDataBox.Rows[selectedRowIndex].Cells[1].Value.ToString();
            if (Dll.removeSeat(Program.SeatHead, int.Parse(room), int.Parse(seat)) != 0)
            {
                MessageBox.Show("删除失败，请检查房间号和座位号");
                return;
            }

            MessageBox.Show("删除成功");
            Dll.saveSeats(Program.SeatHead);
            string seatsJson = Marshal.PtrToStringAnsi(Dll.returnAllSeats(Program.SeatHead));
            if (!string.IsNullOrEmpty(seatsJson))
            {
                AddSeatData(seatsJson);
            }
            else
            {
                MessageBox.Show("请先选择一个座位");
            }
        }
    }

    private void importSeat_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
        openFileDialog.Title = "选择要导入的文件";
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string filePath = openFileDialog.FileName;
            string json = File.ReadAllText(filePath);
            IntPtr result = Dll.importSeat(Program.SeatHead, Marshal.StringToHGlobalAnsi(json));
            string seatsJson = Marshal.PtrToStringAnsi(result);
            MessageBox.Show(seatsJson);
            string seatData = Marshal.PtrToStringAnsi(Dll.returnAllSeats(Program.SeatHead));
            if (!string.IsNullOrEmpty(seatData))
            {
                AddSeatData(seatData);
            }
            Dll.saveSeats(Program.SeatHead);
            PopulateComboBoxes();
        }
    }

    private void exportSeat_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Title = "选择保存文件的路径";
        saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
        saveFileDialog.FileName = "seats.json";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            string filePath = saveFileDialog.FileName;
            if (Dll.exportSeat(Program.SeatHead, Marshal.StringToHGlobalAnsi(filePath)) != 0)
            {
                MessageBox.Show("导出失败");
                return;
            }
            MessageBox.Show("导出成功");
        }
    }

    private void cancelSeat_Click(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("该功能仅限取消加入的座位，取消原有座位的预约可能导致系统混乱！", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (result == DialogResult.No)
        {
            return;
        }
        if (seatDataBox.SelectedCells.Count > 0)
        {
            int selectedRowIndex = seatDataBox.SelectedCells[0].RowIndex;
            string room = seatDataBox.Rows[selectedRowIndex].Cells[0].Value.ToString();
            string seat = seatDataBox.Rows[selectedRowIndex].Cells[1].Value.ToString();
            if (Dll.cancelSeat(Program.SeatHead, int.Parse(room), int.Parse(seat)) != 0)
            {
                MessageBox.Show("取消失败，请检查房间号和座位号");
                return;
            }
            MessageBox.Show("取消成功");
            Dll.saveSeats(Program.SeatHead);
            string seatsJson = Marshal.PtrToStringAnsi(Dll.returnAllSeats(Program.SeatHead));
            if (!string.IsNullOrEmpty(seatsJson))
            {
                AddSeatData(seatsJson);
            }
        }
        else
        {
            MessageBox.Show("请先选择一个座位");
        }
    }

    private void addSeat_Click(object sender, EventArgs e)
    {
        using var addSeatForm = new addSeatForm();
        addSeatForm.ShowDialog();
        string seatsJson = Marshal.PtrToStringAnsi(Dll.returnAllSeats(Program.SeatHead));
        if (!string.IsNullOrEmpty(seatsJson))
        {
            AddSeatData(seatsJson);
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

            var allSeats = JsonSerializer.Deserialize<List<Classes.Seats>>(roomsJson, options);
            var filteredSeats = JsonSerializer.Deserialize<List<Classes.Seats>>(seatsJson, options);

            if (allSeats != null && filteredSeats != null)
            {
                var commonSeats = allSeats.Where(seat =>
                    filteredSeats.Any(filtered =>
                        filtered.Room == seat.Room && filtered.Seat == seat.Seat)).ToList();

                roomsJson = JsonSerializer.Serialize(commonSeats);
                AddSeatData(roomsJson);
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

            var allSeats = JsonSerializer.Deserialize<List<Classes.Seats>>(roomsJson, options);
            var filteredSeats = JsonSerializer.Deserialize<List<Classes.Seats>>(seatsJson, options);

            if (allSeats != null && filteredSeats != null)
            {
                var commonSeats = allSeats.Where(seat =>
                    filteredSeats.Any(filtered =>
                        filtered.Room == seat.Room && filtered.Seat == seat.Seat)).ToList();

                roomsJson = JsonSerializer.Serialize(commonSeats);
                AddSeatData(roomsJson);
            }
        }

        if (resSelect.SelectedValue != null)
        {
            string selectedIsFree = (string)resSelect.SelectedValue;
            IntPtr temp = Dll.findSeatByIsOccupied(Program.SeatHead, selectedIsFree == "空闲" ? 0 : 1);
            string seatsJson = Marshal.PtrToStringAnsi(temp);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var allSeats = JsonSerializer.Deserialize<List<Classes.Seats>>(roomsJson, options);
            var filteredSeats = JsonSerializer.Deserialize<List<Classes.Seats>>(seatsJson, options);

            if (allSeats != null && filteredSeats != null)
            {
                var commonSeats = allSeats.Where(seat =>
                    filteredSeats.Any(filtered =>
                        filtered.Room == seat.Room && filtered.Seat == seat.Seat)).ToList();

                roomsJson = JsonSerializer.Serialize(commonSeats);
                AddSeatData(roomsJson);
            }
        }
    }

    private void cancelFiltterButton_Click(object sender, EventArgs e)
    {
        roomSelect.SelectedValue = null;
        seatSelect.SelectedValue = null;
        resSelect.SelectedValue = null;
        string seatsJson = Marshal.PtrToStringAnsi(Dll.returnAllSeats(Program.SeatHead));
        if (!string.IsNullOrEmpty(seatsJson))
        {
            AddSeatData(seatsJson);
        }
    }

    private void addUserButton_Click(object sender, EventArgs e)
    {
        using var addUser = new addUserForm();
        addUser.ShowDialog();
        string userInfo = Marshal.PtrToStringAnsi(Dll.returnAllUser(Program.UserHead, Marshal.StringToHGlobalAnsi(Program.UserEmail)));
        AddUserData(userInfo);
    }

    private void deleteUserButton_Click(object sender, EventArgs e)
    {
        if (userDataBox.SelectedCells.Count > 0)
        {
            int selectedRowIndex = userDataBox.SelectedCells[0].RowIndex;
            string email = userDataBox.Rows[selectedRowIndex].Cells[1].Value.ToString();
            string password = userDataBox.Rows[selectedRowIndex].Cells[2].Value.ToString();
            IntPtr emailPtr = Marshal.StringToHGlobalAnsi(email);
            IntPtr passwordPtr = Marshal.StringToHGlobalAnsi(Encryption.Encrypt(password));
            if (email == Program.UserEmail)
            {
                MessageBox.Show("你不能删除自己");
                return;
            }
            try
            {
                if (Dll.deleteUser(Program.UserHead, emailPtr, passwordPtr) != 0)
                {
                    MessageBox.Show("删除失败，请检查邮箱和密码");
                    return;
                }

                Dll.saveUser(Program.UserHead);
                MessageBox.Show("删除成功");

                string userInfo = Marshal.PtrToStringAnsi(Dll.returnAllUser(Program.UserHead, Marshal.StringToHGlobalAnsi(Program.UserEmail)));
                AddUserData(userInfo);
            }
            finally
            {
                Marshal.FreeHGlobal(emailPtr);
            }
        }
        else
        {
            MessageBox.Show("请先选择一个用户");
        }
    }

    private void changeUsernameButton_Click(object sender, EventArgs e)
    {
        if (userDataBox.SelectedCells.Count > 0)
        {
            int selectedRowIndex = userDataBox.SelectedCells[0].RowIndex;
            string email = userDataBox.Rows[selectedRowIndex].Cells[1].Value.ToString();
            string name = InputBox.Show("请输入新的用户名", "修改用户名", false);
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("用户名不能为空");
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("用户名只能包含字母");
                return;
            }
            if (Dll.changeUsername(Program.UserHead, Marshal.StringToHGlobalAnsi(name), Marshal.StringToHGlobalAnsi(email)) != 0)
            {
                MessageBox.Show("修改失败，请检查用户名");
                return;
            }

            MessageBox.Show("修改成功");
            Dll.saveUser(Program.UserHead);
            string userInfo = Marshal.PtrToStringAnsi(Dll.returnAllUser(Program.UserHead, Marshal.StringToHGlobalAnsi(Program.UserEmail)));
            AddUserData(userInfo);
        }
        else
        {
            MessageBox.Show("请先选择一个用户");
        }
    }

    private void changePasswordButton_Click(object sender, EventArgs e)
    {
        if (userDataBox.SelectedCells.Count > 0)
        {
            int selectedRowIndex = userDataBox.SelectedCells[0].RowIndex;
            string email = userDataBox.Rows[selectedRowIndex].Cells[1].Value.ToString();
            string password = InputBox.Show("请输入新的密码", "修改密码", true);
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("密码不能为空");
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(password, @"^(?=.*[a-zA-Z])(?=.*\d)[a-zA-Z\d]{8,}$"))
            {
                MessageBox.Show("密码必须包含字母和数字，并且至少8位");
                return;
            }
            if (Dll.changePassword(Program.UserHead, Marshal.StringToHGlobalAnsi(email), Marshal.StringToHGlobalAnsi(Encryption.Encrypt(password))) != 0)
            {
                MessageBox.Show("修改失败，请检查密码");
                return;
            }
            MessageBox.Show("修改成功");
            Dll.saveUser(Program.UserHead);
            string userInfo = Marshal.PtrToStringAnsi(Dll.returnAllUser(Program.UserHead, Marshal.StringToHGlobalAnsi(Program.UserEmail)));
            AddUserData(userInfo);
        }
    }

    private void setAsAdminButton_Click(object sender, EventArgs e)
    {
        if (userDataBox.SelectedCells.Count > 0)
        {
            int selectedRowIndex = userDataBox.SelectedCells[0].RowIndex;
            if (userDataBox.Rows[selectedRowIndex].Cells[3].Value.Equals("是"))
            {
                MessageBox.Show("该用户已经是管理员");
                return;
            }

            string email = userDataBox.Rows[selectedRowIndex].Cells[1].Value.ToString();
            IntPtr emailPtr = Marshal.StringToHGlobalAnsi(email);
            try
            {
                if (Dll.setAsAdmin(Program.UserHead, emailPtr) != 0)
                {
                    MessageBox.Show("设置失败，请检查邮箱和密码");
                    return;
                }

                Dll.saveUser(Program.UserHead);
                MessageBox.Show("设置成功");

                string userInfo = Marshal.PtrToStringAnsi(Dll.returnAllUser(Program.UserHead, Marshal.StringToHGlobalAnsi(Program.UserEmail)));
                AddUserData(userInfo);
            }
            finally
            {
                Marshal.FreeHGlobal(emailPtr);
            }
        }
        else
        {
            MessageBox.Show("请先选择一个用户");
        }
    }

    private void setAsUserButton_Click(object sender, EventArgs e)
    {
        if (userDataBox.SelectedCells.Count > 0)
        {
            int selectedRowIndex = userDataBox.SelectedCells[0].RowIndex;
            if (userDataBox.Rows[selectedRowIndex].Cells[3].Value.Equals("否"))
            {
                MessageBox.Show("该用户已经是普通用户");
                return;
            }

            string email = userDataBox.Rows[selectedRowIndex].Cells[1].Value.ToString();
            IntPtr emailPtr = Marshal.StringToHGlobalAnsi(email);
            try
            {
                if (Dll.setAsUser(Program.UserHead, emailPtr) != 0)
                {
                    MessageBox.Show("设置失败，请检查邮箱和密码");
                    return;
                }

                Dll.saveUser(Program.UserHead);
                MessageBox.Show("设置成功");

                string userInfo = Marshal.PtrToStringAnsi(Dll.returnAllUser(Program.UserHead, Marshal.StringToHGlobalAnsi(Program.UserEmail)));
                AddUserData(userInfo);
            }
            finally
            {
                Marshal.FreeHGlobal(emailPtr);
            }
        }
        else
        {
            MessageBox.Show("请先选择一个用户");
        }
    }

    private void clearResButton_Click(object sender, EventArgs e)
    {
        if (userDataBox.SelectedCells.Count > 0)
        {
            int selectedRowIndex = userDataBox.SelectedCells[0].RowIndex;
            string email = userDataBox.Rows[selectedRowIndex].Cells[1].Value.ToString();
            string password = userDataBox.Rows[selectedRowIndex].Cells[2].Value.ToString();
            IntPtr user = Dll.login(Program.UserHead, Marshal.StringToHGlobalAnsi(email),
                Marshal.StringToHGlobalAnsi(Encryption.Encrypt(password)));
            if (user == IntPtr.Zero)
            {
                MessageBox.Show("用户获取失败");
                return;
            }

            if (Dll.cancelReservation(Program.SeatHead, user) == 0)
            {
                MessageBox.Show("清除预约成功");
                string userInfo = Marshal.PtrToStringAnsi(Dll.returnAllUser(Program.UserHead,
                    Marshal.StringToHGlobalAnsi(Program.UserEmail)));
                AddUserData(userInfo);
                Dll.saveUser(Program.UserHead);
            }
            else
            {
                MessageBox.Show("清除预约失败，请检查座位是否已被占用");
            }
        }
    }

    private void filterResButton_Click(object sender, EventArgs e)
    {
        IntPtr res = Dll.returnAllStatistic(Program.StatisticHead, Login.LoginUser);
        string resJson = Marshal.PtrToStringAnsi(res);
        if (roomRes.SelectedValue != null)
        {
            int selectedRoom = (int)roomRes.SelectedValue;
            IntPtr temp = Dll.findStatisticByRoom(Program.StatisticHead, selectedRoom);
            string seatsJson = Marshal.PtrToStringAnsi(temp);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var allSeats = JsonSerializer.Deserialize<List<Classes.Statistics>>(resJson, options);
            var filteredSeats = JsonSerializer.Deserialize<List<Classes.Statistics>>(seatsJson, options);

            if (allSeats != null && filteredSeats != null)
            {
                var commonSeats = allSeats.Where(seat =>
                    filteredSeats.Any(filtered =>
                        filtered.Room == seat.Room && filtered.Seat == seat.Seat)).ToList();

                resJson = JsonSerializer.Serialize(commonSeats);
                AddResData(resJson);
            }
        }

        if (seatRes.SelectedValue != null)
        {
            int selectedSeat = (int)seatRes.SelectedValue;
            IntPtr temp = Dll.findStatisticBySeat(Program.StatisticHead, selectedSeat);
            string seatsJson = Marshal.PtrToStringAnsi(temp);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var allSeats = JsonSerializer.Deserialize<List<Classes.Statistics>>(resJson, options);
            var filteredSeats = JsonSerializer.Deserialize<List<Classes.Statistics>>(seatsJson, options);

            if (allSeats != null && filteredSeats != null)
            {
                var commonSeats = allSeats.Where(seat =>
                    filteredSeats.Any(filtered =>
                        filtered.Room == seat.Room && filtered.Seat == seat.Seat)).ToList();

                resJson = JsonSerializer.Serialize(commonSeats);
                AddResData(resJson);
            }
        }

        if (userRes.SelectedValue != null)
        {
            string selectedUser = (string)userRes.SelectedValue;
            IntPtr temp = Dll.findStatisticByUser(Program.StatisticHead, Marshal.StringToHGlobalAnsi(selectedUser));
            string seatsJson = Marshal.PtrToStringAnsi(temp);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var allSeats = JsonSerializer.Deserialize<List<Classes.Statistics>>(resJson, options);
            var filteredSeats = JsonSerializer.Deserialize<List<Classes.Statistics>>(seatsJson, options);

            if (allSeats != null && filteredSeats != null)
            {
                var commonSeats = allSeats.Where(seat =>
                    filteredSeats.Any(filtered =>
                        filtered.Room == seat.Room && filtered.Seat == seat.Seat)).ToList();

                resJson = JsonSerializer.Serialize(commonSeats);
                AddResData(resJson);
            }
        }
        if (dateRange.Value != null)
        {
            DateTime dateStart = dateRange.Value.First();
            DateTime dateEnd = dateRange.Value.Last();
            if (dateStart > dateEnd)
            {
                MessageBox.Show("开始时间不能大于结束时间");
                return;
            }

            string dateStartString = dateStart.ToString("yyyy-MM-dd");
            string dateEndString = dateEnd.ToString("yyyy-MM-dd");
            IntPtr temp = Dll.findStatisticByTimeRange(Program.StatisticHead, Marshal.StringToHGlobalAnsi(dateStartString), Marshal.StringToHGlobalAnsi(dateEndString));
            string filteredJson = Marshal.PtrToStringAnsi(temp);

            if (string.IsNullOrEmpty(filteredJson))
            {
                MessageBox.Show("未找到符合条件的记录");
                return;
            }

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var filteredSeats = JsonSerializer.Deserialize<List<Classes.Statistics>>(filteredJson, options);
            if (filteredSeats == null)
            {
                MessageBox.Show("筛选数据解析失败");
                return;
            }

            var allSeats = JsonSerializer.Deserialize<List<Classes.Statistics>>(resJson, options);
            if (allSeats == null)
            {
                MessageBox.Show("原始数据解析失败");
                return;
            }

            var commonSeats = allSeats.Where(seat =>
                filteredSeats.Any(filtered =>
                    filtered.Room == seat.Room && filtered.Seat == seat.Seat && filtered.Time == seat.Time)).ToList();

            if (commonSeats.Count == 0)
            {
                MessageBox.Show("未找到符合条件的记录");
                return;
            }

            string resultJson = JsonSerializer.Serialize(commonSeats);
            AddResData(resultJson);
        }
    }

    private void cancelFilterResButton_Click(object sender, EventArgs e)
    {
        roomRes.SelectedValue = null;
        seatRes.SelectedValue = null;
        userRes.SelectedValue = null;
        dateRange.Value = null;
        string resJson = Marshal.PtrToStringAnsi(Dll.returnAllStatistic(Program.StatisticHead, Login.LoginUser));
        if (!string.IsNullOrEmpty(resJson))
        {
            AddResData(resJson);
        }
    }

    private void exportAsJson_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Title = "选择保存文件的路径";
        saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
        saveFileDialog.FileName = "statistics.json";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            string filePath = saveFileDialog.FileName;
            var statisticsList = new List<Classes.Statistics>();
            foreach (DataGridViewRow row in resDataBox.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    statisticsList.Add(new Classes.Statistics
                    {
                        User = row.Cells[0].Value.ToString(),
                        Room = int.Parse(row.Cells[1].Value.ToString()),
                        Seat = int.Parse(row.Cells[2].Value.ToString()),
                        Time = row.Cells[3].Value.ToString()
                    });
                }
            }

            try
            {
                string json = JsonSerializer.Serialize(statisticsList, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                File.WriteAllText(filePath, json);
                MessageBox.Show("导出成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"导出失败: {ex.Message}");
            }
        }
    }

    private void exportAsExcel_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Title = "选择保存文件的路径";
        saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
        saveFileDialog.FileName = "statistics.xlsx";

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            string filePath = saveFileDialog.FileName;

            try
            {
                ExcelPackage.License.SetNonCommercialPersonal("chenpuhao");

                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Statistics");
                    worksheet.Cells[1, 1].Value = "用户名";
                    worksheet.Cells[1, 2].Value = "房间号";
                    worksheet.Cells[1, 3].Value = "座位号";
                    worksheet.Cells[1, 4].Value = "时间";

                    int row = 2;
                    foreach (DataGridViewRow gridRow in resDataBox.Rows)
                    {
                        if (gridRow.Cells[0].Value != null)
                        {
                            worksheet.Cells[row, 1].Value = gridRow.Cells[0].Value.ToString();
                            worksheet.Cells[row, 2].Value = int.Parse(gridRow.Cells[1].Value.ToString());
                            worksheet.Cells[row, 3].Value = int.Parse(gridRow.Cells[2].Value.ToString());
                            worksheet.Cells[row, 4].Value = gridRow.Cells[3].Value.ToString();
                            row++;
                        }
                    }

                    package.SaveAs(new FileInfo(filePath));
                }

                MessageBox.Show("导出成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"导出失败: {ex.Message}");
            }
        }
    }

    private void removeResButton_Click(object sender, EventArgs e)
    {
        if (resDataBox.SelectedCells.Count > 0)
        {
            int selectedRowIndex = resDataBox.SelectedCells[0].RowIndex;
            string room = resDataBox.Rows[selectedRowIndex].Cells[1].Value.ToString();
            string seat = resDataBox.Rows[selectedRowIndex].Cells[2].Value.ToString();
            string time = resDataBox.Rows[selectedRowIndex].Cells[3].Value.ToString();
            if (Dll.deleteStatistic(Program.StatisticHead, int.Parse(room), int.Parse(seat), Marshal.StringToHGlobalAnsi(time)) != 0)
            {
                MessageBox.Show("删除失败，请检查房间号和座位号");
                return;
            }
            MessageBox.Show("删除成功");
            Dll.saveStatistic(Program.StatisticHead);
            string resJson = Marshal.PtrToStringAnsi(Dll.returnAllStatistic(Program.StatisticHead, Login.LoginUser));
            if (resJson != null)
            {
                AddResData(resJson);
            }
            else
            {
                resDataBox.Rows.Clear();
            }
        }
    }

    private void removeAllResButton_Click(object sender, EventArgs e)
    {
        Dll.clearAllStatistic(Program.StatisticHead);
        Dll.saveStatistic(Program.StatisticHead);
        MessageBox.Show("清除成功");
        resDataBox.Rows.Clear();
    }

    private void refreshButton_Click(object sender, EventArgs e)
    {
        string seatsJson = Marshal.PtrToStringAnsi(Dll.returnAllSeats(Program.SeatHead));
        if (!string.IsNullOrEmpty(seatsJson))
        {
            AddSeatData(seatsJson);
        }
        string resJson = Marshal.PtrToStringAnsi(Dll.returnAllStatistic(Program.StatisticHead, Login.LoginUser));
        if (!string.IsNullOrEmpty(resJson))
        {
            AddResData(resJson);
        }
        string userInfo = Marshal.PtrToStringAnsi(Dll.returnAllUser(Program.UserHead, Marshal.StringToHGlobalAnsi(Program.UserEmail)));
        AddUserData(userInfo);
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