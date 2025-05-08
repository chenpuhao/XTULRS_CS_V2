using System.ComponentModel;

namespace LRSV2;

partial class Welcome
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
        label1 = new AntdUI.Label();
        label2 = new AntdUI.Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new Font("楷体", 36F, FontStyle.Regular, GraphicsUnit.Point, 134);
        label1.Location = new Point(163, 166);
        label1.Name = "label1";
        label1.Size = new Size(724, 333);
        label1.TabIndex = 0;
        label1.Text = "湘潭大学图书馆\n预约系统";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Font = new Font("楷体", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 134);
        label2.Location = new Point(21, 24);
        label2.Name = "label2";
        label2.Size = new Size(276, 68);
        label2.TabIndex = 1;
        label2.Text = "欢迎使用";
        // 
        // Welcome
        // 
        AutoScaleDimensions = new SizeF(14F, 31F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1066, 651);
        ControlBox = false;
        Controls.Add(label2);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MdiChildrenMinimizedAnchorBottom = false;
        MinimizeBox = false;
        Name = "Welcome";
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterScreen;
        ResumeLayout(false);
    }

    #endregion

    private AntdUI.Label label1;
    private AntdUI.Label label2;
}