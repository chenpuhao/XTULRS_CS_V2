using System.Runtime.InteropServices;

namespace LRSV2;


public partial class Register : Form
{
    public Register()
    {
        InitializeComponent();
    }

    private void regButton_Click(object sender, EventArgs e)
    {
        string email = emailInput.Text;
        string password = psdInput.Text;
        string confirmPassword = confirmInput.Text;
        string name = usernameInput.Text;

        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(name))
        {
            MessageBox.Show("所有字段都不能为空");
            return;
        }

        if (password != confirmPassword)
        {
            MessageBox.Show("密码不匹配");
            return;
        }
        if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
        {
            MessageBox.Show("邮箱格式不正确");
            return;
        }
        if (!System.Text.RegularExpressions.Regex.IsMatch(name, @"^[a-zA-Z]+$"))
        {
            MessageBox.Show("用户名只能包含字母");
            return;
        }
        if (!System.Text.RegularExpressions.Regex.IsMatch(password, @"^(?=.*[a-zA-Z])(?=.*\d)[a-zA-Z\d]{8,}$"))
        {
            MessageBox.Show("密码必须包含字母和数字，并且至少8位");
            return;
        }
        //加密密码
        string encryptedPassword = Encryption.Encrypt(password);
        IntPtr namePtr = Marshal.StringToHGlobalAnsi(name);
        IntPtr emailPtr = Marshal.StringToHGlobalAnsi(email);
        IntPtr passwordPtr = Marshal.StringToHGlobalAnsi(encryptedPassword);
        if (Dll.addUser(Program.UserHead, namePtr, emailPtr, passwordPtr, 0, IntPtr.Zero) != 0)
        {
            MessageBox.Show("注册失败，请检查邮箱和密码");
            return;
        }
        Dll.saveUser(Program.UserHead);
        MessageBox.Show("注册成功,请登录");
        Close();
    }
}