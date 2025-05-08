using System.ComponentModel;

namespace LRSV2;

partial class addUserForm
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(addUserForm));
        regButton = new AntdUI.Button();
        usernameInput = new AntdUI.Input();
        label2 = new AntdUI.Label();
        psdInput = new AntdUI.Input();
        label3 = new AntdUI.Label();
        emailInput = new AntdUI.Input();
        label1 = new AntdUI.Label();
        label4 = new AntdUI.Label();
        isAdmin = new AntdUI.Select();
        SuspendLayout();
        // 
        // regButton
        // 
        regButton.Font = new Font("宋体", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
        regButton.Location = new Point(301, 393);
        regButton.Name = "regButton";
        regButton.Size = new Size(198, 103);
        regButton.TabIndex = 11;
        regButton.Text = "注册";
        regButton.Click += regButton_Click;
        // 
        // usernameInput
        // 
        usernameInput.Location = new Point(222, 26);
        usernameInput.Name = "usernameInput";
        usernameInput.Size = new Size(481, 76);
        usernameInput.TabIndex = 8;
        // 
        // label2
        // 
        label2.Font = new Font("宋体", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
        label2.Location = new Point(74, 26);
        label2.Name = "label2";
        label2.Size = new Size(163, 89);
        label2.TabIndex = 5;
        label2.Text = "用户名:";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // psdInput
        // 
        psdInput.Location = new Point(222, 217);
        psdInput.Name = "psdInput";
        psdInput.PasswordChar = '*';
        psdInput.Size = new Size(481, 76);
        psdInput.TabIndex = 9;
        // 
        // label3
        // 
        label3.Font = new Font("宋体", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
        label3.Location = new Point(99, 217);
        label3.Name = "label3";
        label3.Size = new Size(138, 89);
        label3.TabIndex = 6;
        label3.Text = "密码:";
        label3.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // emailInput
        // 
        emailInput.Location = new Point(222, 122);
        emailInput.Name = "emailInput";
        emailInput.Size = new Size(481, 76);
        emailInput.TabIndex = 10;
        // 
        // label1
        // 
        label1.Font = new Font("宋体", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
        label1.Location = new Point(99, 122);
        label1.Name = "label1";
        label1.Size = new Size(138, 89);
        label1.TabIndex = 7;
        label1.Text = "邮箱:";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label4
        // 
        label4.Font = new Font("宋体", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
        label4.Location = new Point(74, 312);
        label4.Name = "label4";
        label4.Size = new Size(163, 89);
        label4.TabIndex = 6;
        label4.Text = "管理员:";
        label4.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // isAdmin
        // 
        isAdmin.Location = new Point(222, 312);
        isAdmin.Name = "isAdmin";
        isAdmin.Size = new Size(184, 76);
        isAdmin.TabIndex = 12;
        // 
        // addUserForm
        // 
        AutoScaleDimensions = new SizeF(14F, 31F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 526);
        Controls.Add(isAdmin);
        Controls.Add(regButton);
        Controls.Add(usernameInput);
        Controls.Add(label2);
        Controls.Add(psdInput);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(emailInput);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MdiChildrenMinimizedAnchorBottom = false;
        MinimizeBox = false;
        Name = "addUserForm";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "湘潭大学图书馆预约系统 新增用户";
        Load += addSeatForm_Load;
        ResumeLayout(false);
    }

    #endregion

    private AntdUI.Button regButton;
    private AntdUI.Input usernameInput;
    private AntdUI.Label label2;
    private AntdUI.Input psdInput;
    private AntdUI.Label label3;
    private AntdUI.Input emailInput;
    private AntdUI.Label label1;
    private AntdUI.Label label4;
    private AntdUI.Select isAdmin;
}