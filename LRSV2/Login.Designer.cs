using System.ComponentModel;

namespace LRSV2;

partial class Login
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(Login));
        label1 = new AntdUI.Label();
        emailInput = new AntdUI.Input();
        label2 = new AntdUI.Label();
        psdInput = new AntdUI.Input();
        loginButton = new AntdUI.Button();
        regButton = new AntdUI.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new Font("宋体", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
        label1.Location = new Point(91, 52);
        label1.Name = "label1";
        label1.Size = new Size(138, 89);
        label1.TabIndex = 0;
        label1.Text = "邮箱:";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // emailInput
        // 
        emailInput.Location = new Point(201, 52);
        emailInput.Name = "emailInput";
        emailInput.Size = new Size(481, 76);
        emailInput.TabIndex = 1;
        // 
        // label2
        // 
        label2.Font = new Font("宋体", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
        label2.Location = new Point(91, 158);
        label2.Name = "label2";
        label2.Size = new Size(138, 89);
        label2.TabIndex = 0;
        label2.Text = "密码:";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // psdInput
        // 
        psdInput.Location = new Point(201, 158);
        psdInput.Name = "psdInput";
        psdInput.PasswordChar = '*';
        psdInput.Size = new Size(481, 76);
        psdInput.TabIndex = 1;
        // 
        // loginButton
        // 
        loginButton.Font = new Font("宋体", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
        loginButton.Location = new Point(153, 271);
        loginButton.Name = "loginButton";
        loginButton.Size = new Size(198, 103);
        loginButton.TabIndex = 2;
        loginButton.Text = "登录";
        loginButton.Click += loginButton_Click;
        // 
        // regButton
        // 
        regButton.Font = new Font("宋体", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
        regButton.Location = new Point(388, 271);
        regButton.Name = "regButton";
        regButton.Size = new Size(198, 103);
        regButton.TabIndex = 2;
        regButton.Text = "注册";
        regButton.Click += regButton_Click;
        // 
        // Login
        // 
        AutoScaleDimensions = new SizeF(14F, 31F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(regButton);
        Controls.Add(loginButton);
        Controls.Add(psdInput);
        Controls.Add(label2);
        Controls.Add(emailInput);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        Name = "Login";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "湘潭大学图书馆预约系统 登录";
        ResumeLayout(false);
    }

    #endregion

    private AntdUI.Label label1;
    private AntdUI.Input emailInput;
    private AntdUI.Label label2;
    private AntdUI.Input psdInput;
    private AntdUI.Button loginButton;
    private AntdUI.Button regButton;
}