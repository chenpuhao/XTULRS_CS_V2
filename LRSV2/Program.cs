
namespace LRSV2;

internal static class Program
{
    public static IntPtr UserHead = Dll.getUserHead();
    public static IntPtr SeatHead = Dll.getSeatHead();
    public static IntPtr StatisticHead = Dll.getStatisticHead();
    public static string Username = "";
    public static string Seat = "";
    public static string UserEmail = "";
    [STAThread]
    private static void Main()
    {
        if(UserHead == IntPtr.Zero || SeatHead == IntPtr.Zero || StatisticHead == IntPtr.Zero)
        {
            MessageBox.Show("初始化失败，请检查DLL文件");
            return;
        }

        Dll.loadUser(UserHead);
        Dll.loadSeat(SeatHead);
        Dll.loadStatistic(StatisticHead);
        ApplicationConfiguration.Initialize();
        using (var welcome = new Welcome())
        {
            welcome.Show();
            Task.Delay(3000).Wait();
        }
        var login = new Login();
        login.ShowDialog(); 
        if (!login.IsLogin)
        {
            return;
        }
        var userInfo = login.UserInfo;
        Username = userInfo.Name;
        UserEmail = userInfo.Email;
        Seat = !string.IsNullOrEmpty(login.UserInfo.Seat) ? login.UserInfo.Seat : "none";
        if (userInfo.IsAdmin == 0)
        {
            Application.Run(new User());
        }
        else
        {
            Application.Run(new Admin());
        }
    }
}