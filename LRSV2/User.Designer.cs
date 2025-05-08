using System.ComponentModel;

namespace LRSV2;

partial class User
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(User));
        seatDataTable = new DataGridView();
        welcome = new AntdUI.Label();
        res = new AntdUI.Label();
        label1 = new AntdUI.Label();
        roomSelect = new AntdUI.Select();
        label2 = new AntdUI.Label();
        seatSelect = new AntdUI.Select();
        label3 = new AntdUI.Label();
        resSelect = new AntdUI.Select();
        filterButton = new AntdUI.Button();
        cancelFiltterButtton = new AntdUI.Button();
        resButton = new AntdUI.Button();
        cancelResButton = new AntdUI.Button();
        exitButton = new AntdUI.Button();
        myInfoButton = new AntdUI.Button();
        ((ISupportInitialize)seatDataTable).BeginInit();
        SuspendLayout();
        // 
        // seatDataTable
        // 
        seatDataTable.AllowUserToAddRows = false;
        seatDataTable.AllowUserToDeleteRows = false;
        seatDataTable.AllowUserToResizeColumns = false;
        seatDataTable.AllowUserToResizeRows = false;
        seatDataTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        seatDataTable.BackgroundColor = SystemColors.Window;
        seatDataTable.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
        seatDataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        seatDataTable.Location = new Point(-10, 166);
        seatDataTable.MultiSelect = false;
        seatDataTable.Name = "seatDataTable";
        seatDataTable.ReadOnly = true;
        seatDataTable.RowHeadersWidth = 82;
        seatDataTable.SelectionMode = DataGridViewSelectionMode.CellSelect;
        seatDataTable.Size = new Size(1786, 871);
        seatDataTable.TabIndex = 0;
        // 
        // welcome
        // 
        welcome.Font = new Font("宋体", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 134);
        welcome.Location = new Point(12, 12);
        welcome.Name = "welcome";
        welcome.Size = new Size(464, 65);
        welcome.TabIndex = 1;
        welcome.Text = "你好，{user}";
        // 
        // res
        // 
        res.Font = new Font("宋体", 16.125F);
        res.Location = new Point(482, 12);
        res.Name = "res";
        res.Size = new Size(883, 65);
        res.TabIndex = 2;
        res.Text = "{res}";
        // 
        // label1
        // 
        label1.Font = new Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
        label1.Location = new Point(2, 95);
        label1.Name = "label1";
        label1.Size = new Size(119, 65);
        label1.TabIndex = 3;
        label1.Text = "房间号:";
        // 
        // roomSelect
        // 
        roomSelect.Font = new Font("宋体", 9F);
        roomSelect.Location = new Point(113, 95);
        roomSelect.MaxCount = 10;
        roomSelect.Name = "roomSelect";
        roomSelect.Size = new Size(236, 65);
        roomSelect.TabIndex = 4;
        // 
        // label2
        // 
        label2.Font = new Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
        label2.Location = new Point(357, 95);
        label2.Name = "label2";
        label2.Size = new Size(119, 65);
        label2.TabIndex = 3;
        label2.Text = "座位号:";
        // 
        // seatSelect
        // 
        seatSelect.Font = new Font("宋体", 9F);
        seatSelect.Location = new Point(468, 95);
        seatSelect.MaxCount = 10;
        seatSelect.Name = "seatSelect";
        seatSelect.Size = new Size(236, 65);
        seatSelect.TabIndex = 4;
        // 
        // label3
        // 
        label3.Font = new Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
        label3.Location = new Point(716, 95);
        label3.Name = "label3";
        label3.Size = new Size(143, 65);
        label3.TabIndex = 3;
        label3.Text = "占用情况:";
        // 
        // resSelect
        // 
        resSelect.Font = new Font("宋体", 9F);
        resSelect.Location = new Point(850, 95);
        resSelect.MaxCount = 10;
        resSelect.Name = "resSelect";
        resSelect.Size = new Size(236, 65);
        resSelect.TabIndex = 4;
        // 
        // filterButton
        // 
        filterButton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
        filterButton.Location = new Point(1092, 95);
        filterButton.Name = "filterButton";
        filterButton.Size = new Size(150, 65);
        filterButton.TabIndex = 5;
        filterButton.Text = "筛选";
        filterButton.Click += filterButton_Click;
        // 
        // cancelFiltterButtton
        // 
        cancelFiltterButtton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
        cancelFiltterButtton.Location = new Point(1248, 95);
        cancelFiltterButtton.Name = "cancelFiltterButtton";
        cancelFiltterButtton.Size = new Size(150, 65);
        cancelFiltterButtton.TabIndex = 5;
        cancelFiltterButtton.Text = "取消筛选";
        cancelFiltterButtton.Click += cancelFiltterButtton_Click;
        // 
        // resButton
        // 
        resButton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
        resButton.Location = new Point(1404, 95);
        resButton.Name = "resButton";
        resButton.Size = new Size(150, 65);
        resButton.TabIndex = 5;
        resButton.Text = "预约";
        resButton.Click += resButton_Click;
        // 
        // cancelResButton
        // 
        cancelResButton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
        cancelResButton.Location = new Point(1560, 95);
        cancelResButton.Name = "cancelResButton";
        cancelResButton.Size = new Size(150, 65);
        cancelResButton.TabIndex = 5;
        cancelResButton.Text = "取消预约";
        cancelResButton.Click += cancelResButton_Click;
        // 
        // exitButton
        // 
        exitButton.Font = new Font("宋体", 9F);
        exitButton.Location = new Point(1560, 12);
        exitButton.Name = "exitButton";
        exitButton.Size = new Size(150, 65);
        exitButton.TabIndex = 6;
        exitButton.Text = "退出系统";
        exitButton.Click += exitButton_Click;
        // 
        // myInfoButton
        // 
        myInfoButton.Font = new Font("宋体", 9F);
        myInfoButton.Location = new Point(1404, 12);
        myInfoButton.Name = "myInfoButton";
        myInfoButton.Size = new Size(150, 65);
        myInfoButton.TabIndex = 6;
        myInfoButton.Text = "我的信息";
        myInfoButton.Click += myInfoButton_Click;
        // 
        // User
        // 
        AutoScaleDimensions = new SizeF(14F, 31F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1775, 1034);
        Controls.Add(myInfoButton);
        Controls.Add(exitButton);
        Controls.Add(cancelResButton);
        Controls.Add(resButton);
        Controls.Add(cancelFiltterButtton);
        Controls.Add(filterButton);
        Controls.Add(resSelect);
        Controls.Add(label3);
        Controls.Add(seatSelect);
        Controls.Add(label2);
        Controls.Add(roomSelect);
        Controls.Add(label1);
        Controls.Add(res);
        Controls.Add(welcome);
        Controls.Add(seatDataTable);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MdiChildrenMinimizedAnchorBottom = false;
        Name = "User";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "湘潭大学图书馆预约系统 用户端";
        Load += User_Load;
        ((ISupportInitialize)seatDataTable).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.DataGridView seatDataTable;
    private AntdUI.Label welcome;
    private AntdUI.Label res;
    private AntdUI.Label label1;
    private AntdUI.Select roomSelect;
    private AntdUI.Label label2;
    private AntdUI.Select seatSelect;
    private AntdUI.Label label3;
    private AntdUI.Select resSelect;
    private AntdUI.Button filterButton;
    private AntdUI.Button cancelFiltterButtton;
    private AntdUI.Button resButton;
    private AntdUI.Button cancelResButton;
    private AntdUI.Button exitButton;
    private AntdUI.Button myInfoButton;
}