using System.ComponentModel;

namespace LRSV2;

partial class Info
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        ComponentResourceManager resources = new ComponentResourceManager(typeof(Info));
        usernameLabel = new AntdUI.Label();
        emailLabel = new AntdUI.Label();
        changeUsernameButton = new AntdUI.Button();
        changePasswordButton = new AntdUI.Button();
        SuspendLayout();
        // 
        // usernameLabel
        // 
        usernameLabel.Font = new Font("宋体", 13.875F);
        usernameLabel.Location = new Point(31, 12);
        usernameLabel.Name = "usernameLabel";
        usernameLabel.Size = new Size(570, 95);
        usernameLabel.TabIndex = 0;
        usernameLabel.Text = "用户名:{name}";
        // 
        // emailLabel
        // 
        emailLabel.Font = new Font("宋体", 13.875F);
        emailLabel.Location = new Point(31, 113);
        emailLabel.Name = "emailLabel";
        emailLabel.Size = new Size(570, 95);
        emailLabel.TabIndex = 0;
        emailLabel.Text = "邮箱:{email}";
        // 
        // changeUsernameButton
        // 
        changeUsernameButton.Location = new Point(142, 230);
        changeUsernameButton.Name = "changeUsernameButton";
        changeUsernameButton.Size = new Size(150, 75);
        changeUsernameButton.TabIndex = 1;
        changeUsernameButton.Text = "修改用户名";
        changeUsernameButton.Click += changeUsernameButton_Click;
        // 
        // changePasswordButton
        // 
        changePasswordButton.Location = new Point(307, 230);
        changePasswordButton.Name = "changePasswordButton";
        changePasswordButton.Size = new Size(150, 75);
        changePasswordButton.TabIndex = 1;
        changePasswordButton.Text = "修改密码";
        changePasswordButton.Click += changePasswordButton_Click;
        // 
        // Info
        // 
        AutoScaleDimensions = new SizeF(14F, 31F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(613, 317);
        Controls.Add(changePasswordButton);
        Controls.Add(changeUsernameButton);
        Controls.Add(emailLabel);
        Controls.Add(usernameLabel);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MdiChildrenMinimizedAnchorBottom = false;
        MinimizeBox = false;
        Name = "Info";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "湘潭大学图书馆预约系统 我的信息";
        Load += Info_Load;
        ResumeLayout(false);
    }

    #endregion

    private AntdUI.Label usernameLabel;
    private AntdUI.Label emailLabel;
    private AntdUI.Button changeUsernameButton;
    private AntdUI.Button changePasswordButton;
}