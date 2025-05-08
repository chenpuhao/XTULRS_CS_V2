using System.Runtime.InteropServices;

namespace LRSV2;

public partial class Info : Form
{
    public Info()
    {
        InitializeComponent();
    }

    private void Info_Load(object sender, EventArgs e)
    {
        usernameLabel.Text = "用户名: " + Program.Username;
        emailLabel.Text = "邮箱: " + Program.UserEmail;
    }

    private void changeUsernameButton_Click(object sender, EventArgs e)
    {
        string name = InputBox.Show("请输入新的用户名", "修改用户名",false);
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
        if (Dll.changeUsername(Program.UserHead, Marshal.StringToHGlobalAnsi(name),Marshal.StringToHGlobalAnsi(Program.UserEmail)) != 0)
        {
            MessageBox.Show("修改失败，请检查用户名");
            return;
        }
        Program.Username = name;
        usernameLabel.Text = "用户名: " + Program.Username;
        Dll.saveUser(Program.UserHead);
        MessageBox.Show("修改成功，要将新用户名应用到全局，你可能需要重新登录");
    }

    private void changePasswordButton_Click(object sender, EventArgs e)
    {
        string password = InputBox.Show("请输入新的密码", "修改密码",true);
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
        string encryptedPassword = Encryption.Encrypt(password);
        if (Dll.changePassword(Program.UserHead, Marshal.StringToHGlobalAnsi(Program.UserEmail), Marshal.StringToHGlobalAnsi(encryptedPassword)) != 0)
        {
            MessageBox.Show("修改失败，请检查密码");
            return;
        }
        Dll.saveUser(Program.UserHead);
        MessageBox.Show("修改成功，要将新密码应用到全局，你可能需要重新登录");
    }
}