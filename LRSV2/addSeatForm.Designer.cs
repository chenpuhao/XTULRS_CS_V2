using System.ComponentModel;

namespace LRSV2;

partial class addSeatForm
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(addSeatForm));
        roomInput = new AntdUI.Input();
        label2 = new AntdUI.Label();
        label1 = new AntdUI.Label();
        seatInput = new AntdUI.Input();
        Button = new AntdUI.Button();
        SuspendLayout();
        // 
        // roomInput
        // 
        roomInput.Location = new Point(223, 57);
        roomInput.Name = "roomInput";
        roomInput.Size = new Size(481, 76);
        roomInput.TabIndex = 10;
        // 
        // label2
        // 
        label2.Font = new Font("宋体", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
        label2.Location = new Point(75, 57);
        label2.Name = "label2";
        label2.Size = new Size(163, 89);
        label2.TabIndex = 9;
        label2.Text = "房间号:";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label1
        // 
        label1.Font = new Font("宋体", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
        label1.Location = new Point(75, 152);
        label1.Name = "label1";
        label1.Size = new Size(163, 89);
        label1.TabIndex = 9;
        label1.Text = "座位号:";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // seatInput
        // 
        seatInput.Location = new Point(223, 152);
        seatInput.Name = "seatInput";
        seatInput.Size = new Size(481, 76);
        seatInput.TabIndex = 10;
        // 
        // Button
        // 
        Button.Font = new Font("宋体", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 134);
        Button.Location = new Point(294, 283);
        Button.Name = "Button";
        Button.Size = new Size(198, 103);
        Button.TabIndex = 12;
        Button.Text = "确定";
        Button.Click += Button_Click;
        // 
        // addSeatForm
        // 
        AutoScaleDimensions = new SizeF(14F, 31F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(Button);
        Controls.Add(seatInput);
        Controls.Add(label1);
        Controls.Add(roomInput);
        Controls.Add(label2);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MdiChildrenMinimizedAnchorBottom = false;
        MinimizeBox = false;
        Name = "addSeatForm";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "湘潭大学图书馆预约系统 新增座位";
        ResumeLayout(false);
    }

    #endregion

    private AntdUI.Input roomInput;
    private AntdUI.Label label2;
    private AntdUI.Label label1;
    private AntdUI.Input seatInput;
    private AntdUI.Button Button;
}