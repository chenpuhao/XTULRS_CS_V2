using System.Runtime.InteropServices;
using System.Text.Json;

namespace LRSV2;

public partial class Login : Form
{
    public Classes.User UserInfo;
    public bool IsLogin;
    public static IntPtr LoginUser;
    public Login()
    {
        InitializeComponent();
    }

    private void regButton_Click(object sender, EventArgs e)
    {
        using var register = new Register();
        register.ShowDialog();
    }

    private void loginButton_Click(object sender, EventArgs e)
    {
        string email = emailInput.Text;
        string password = Encryption.Encrypt(psdInput.Text);

        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show("邮箱和密码不能为空");
            return;
        }

        LoginUser = Dll.login(Program.UserHead, Marshal.StringToHGlobalAnsi(email),
            Marshal.StringToHGlobalAnsi(password));
        if (LoginUser == IntPtr.Zero)
        {
            MessageBox.Show("登录失败，请检查邮箱和密码");
            return;
        }
        IntPtr userInfo = Dll.getUserInfo(LoginUser);
        string userInfoJson = Marshal.PtrToStringAnsi(userInfo);
        UserInfo = JsonSerializer.Deserialize<Classes.User>(userInfoJson,Classes.options);
        IsLogin = true;
        Close();
    }
}