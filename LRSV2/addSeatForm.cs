namespace LRSV2;

public partial class addSeatForm : Form
{
    public addSeatForm()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, EventArgs e)
    {
        string room = roomInput.Text;
        string seat = seatInput.Text;
        if (string.IsNullOrEmpty(room) || string.IsNullOrEmpty(seat))
        {
            MessageBox.Show("所有字段都不能为空");
            return;
        }
        if (!int.TryParse(room, out int roomNum) || !int.TryParse(seat, out int seatNum))
        {
            MessageBox.Show("房间号和座位号必须是数字");
            return;
        }
        int roomInt = int.Parse(roomInput.Text);
        int seatInt = int.Parse(seatInput.Text);
        if (Dll.addSeat(Program.SeatHead, roomInt, seatInt,0) != 0)
        {
            MessageBox.Show("添加失败，请检查房间号和座位号");
            return;
        }
        Dll.saveSeats(Program.SeatHead);
        MessageBox.Show("添加成功");
        Close();
        
    }
}