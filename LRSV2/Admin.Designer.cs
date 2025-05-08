using System.ComponentModel;

namespace LRSV2;

partial class Admin
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(Admin));
        tabControl1 = new TabControl();
        tabPage1 = new TabPage();
        cancelSeat = new AntdUI.Button();
        exportSeat = new AntdUI.Button();
        importSeat = new AntdUI.Button();
        removeSeat = new AntdUI.Button();
        addSeat = new AntdUI.Button();
        cancelFiltterButton = new AntdUI.Button();
        filterButton = new AntdUI.Button();
        resSelect = new AntdUI.Select();
        label3 = new AntdUI.Label();
        seatSelect = new AntdUI.Select();
        label2 = new AntdUI.Label();
        roomSelect = new AntdUI.Select();
        label1 = new AntdUI.Label();
        seatDataBox = new DataGridView();
        tabPage2 = new TabPage();
        clearResButton = new AntdUI.Button();
        setAsUserButton = new AntdUI.Button();
        setAsAdminButton = new AntdUI.Button();
        changePasswordButton = new AntdUI.Button();
        changeUsernameButton = new AntdUI.Button();
        deleteUserButton = new AntdUI.Button();
        addUserButton = new AntdUI.Button();
        userDataBox = new DataGridView();
        tabPage3 = new TabPage();
        exportAsExcel = new AntdUI.Button();
        exportAsJson = new AntdUI.Button();
        removeAllResButton = new AntdUI.Button();
        removeResButton = new AntdUI.Button();
        cancelFilterResButton = new AntdUI.Button();
        filterResButton = new AntdUI.Button();
        dateRange = new AntdUI.DatePickerRange();
        userRes = new AntdUI.Select();
        label6 = new AntdUI.Label();
        seatRes = new AntdUI.Select();
        label4 = new AntdUI.Label();
        roomRes = new AntdUI.Select();
        label8 = new AntdUI.Label();
        label7 = new AntdUI.Label();
        label5 = new AntdUI.Label();
        resDataBox = new DataGridView();
        welcome = new AntdUI.Label();
        refreshButton = new AntdUI.Button();
        exitButton = new AntdUI.Button();
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        ((ISupportInitialize)seatDataBox).BeginInit();
        tabPage2.SuspendLayout();
        ((ISupportInitialize)userDataBox).BeginInit();
        tabPage3.SuspendLayout();
        ((ISupportInitialize)resDataBox).BeginInit();
        SuspendLayout();
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Controls.Add(tabPage3);
        tabControl1.Location = new Point(1, 55);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(1775, 982);
        tabControl1.TabIndex = 0;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(cancelSeat);
        tabPage1.Controls.Add(exportSeat);
        tabPage1.Controls.Add(importSeat);
        tabPage1.Controls.Add(removeSeat);
        tabPage1.Controls.Add(addSeat);
        tabPage1.Controls.Add(cancelFiltterButton);
        tabPage1.Controls.Add(filterButton);
        tabPage1.Controls.Add(resSelect);
        tabPage1.Controls.Add(label3);
        tabPage1.Controls.Add(seatSelect);
        tabPage1.Controls.Add(label2);
        tabPage1.Controls.Add(roomSelect);
        tabPage1.Controls.Add(label1);
        tabPage1.Controls.Add(seatDataBox);
        tabPage1.Location = new Point(8, 45);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(1759, 929);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "座位管理";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // cancelSeat
        // 
        cancelSeat.Font = new Font("宋体", 9F);
        cancelSeat.Location = new Point(1219, 66);
        cancelSeat.Name = "cancelSeat";
        cancelSeat.Size = new Size(200, 65);
        cancelSeat.TabIndex = 14;
        cancelSeat.Text = "解除占用";
        cancelSeat.Click += cancelSeat_Click;
        // 
        // exportSeat
        // 
        exportSeat.Font = new Font("宋体", 9F);
        exportSeat.Location = new Point(986, 66);
        exportSeat.Name = "exportSeat";
        exportSeat.Size = new Size(200, 65);
        exportSeat.TabIndex = 14;
        exportSeat.Text = "导出座位";
        exportSeat.Click += exportSeat_Click;
        // 
        // importSeat
        // 
        importSeat.Font = new Font("宋体", 9F);
        importSeat.Location = new Point(754, 66);
        importSeat.Name = "importSeat";
        importSeat.Size = new Size(200, 65);
        importSeat.TabIndex = 14;
        importSeat.Text = "导入座位";
        importSeat.Click += importSeat_Click;
        // 
        // removeSeat
        // 
        removeSeat.Font = new Font("宋体", 9F);
        removeSeat.Location = new Point(523, 66);
        removeSeat.Name = "removeSeat";
        removeSeat.Size = new Size(200, 65);
        removeSeat.TabIndex = 14;
        removeSeat.Text = "删除座位";
        removeSeat.Click += removeSeat_Click;
        // 
        // addSeat
        // 
        addSeat.Font = new Font("宋体", 9F);
        addSeat.Location = new Point(293, 66);
        addSeat.Name = "addSeat";
        addSeat.Size = new Size(200, 65);
        addSeat.TabIndex = 14;
        addSeat.Text = "新增座位";
        addSeat.Click += addSeat_Click;
        // 
        // cancelFiltterButton
        // 
        cancelFiltterButton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
        cancelFiltterButton.Location = new Point(1422, 6);
        cancelFiltterButton.Name = "cancelFiltterButton";
        cancelFiltterButton.Size = new Size(150, 65);
        cancelFiltterButton.TabIndex = 12;
        cancelFiltterButton.Text = "取消筛选";
        cancelFiltterButton.Click += cancelFiltterButton_Click;
        // 
        // filterButton
        // 
        filterButton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
        filterButton.Location = new Point(1266, 6);
        filterButton.Name = "filterButton";
        filterButton.Size = new Size(150, 65);
        filterButton.TabIndex = 13;
        filterButton.Text = "筛选";
        filterButton.Click += filterButton_Click;
        // 
        // resSelect
        // 
        resSelect.Font = new Font("宋体", 9F);
        resSelect.Location = new Point(1024, 6);
        resSelect.MaxCount = 10;
        resSelect.Name = "resSelect";
        resSelect.Size = new Size(236, 65);
        resSelect.TabIndex = 9;
        // 
        // label3
        // 
        label3.Font = new Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
        label3.Location = new Point(890, 6);
        label3.Name = "label3";
        label3.Size = new Size(143, 65);
        label3.TabIndex = 6;
        label3.Text = "占用情况:";
        // 
        // seatSelect
        // 
        seatSelect.Font = new Font("宋体", 9F);
        seatSelect.Location = new Point(642, 6);
        seatSelect.MaxCount = 10;
        seatSelect.Name = "seatSelect";
        seatSelect.Size = new Size(236, 65);
        seatSelect.TabIndex = 10;
        // 
        // label2
        // 
        label2.Font = new Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
        label2.Location = new Point(531, 6);
        label2.Name = "label2";
        label2.Size = new Size(119, 65);
        label2.TabIndex = 7;
        label2.Text = "座位号:";
        // 
        // roomSelect
        // 
        roomSelect.Font = new Font("宋体", 9F);
        roomSelect.Location = new Point(287, 6);
        roomSelect.MaxCount = 10;
        roomSelect.Name = "roomSelect";
        roomSelect.Size = new Size(236, 65);
        roomSelect.TabIndex = 11;
        // 
        // label1
        // 
        label1.Font = new Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
        label1.Location = new Point(176, 6);
        label1.Name = "label1";
        label1.Size = new Size(119, 65);
        label1.TabIndex = 8;
        label1.Text = "房间号:";
        // 
        // seatDataBox
        // 
        seatDataBox.AllowUserToAddRows = false;
        seatDataBox.AllowUserToDeleteRows = false;
        seatDataBox.AllowUserToResizeColumns = false;
        seatDataBox.AllowUserToResizeRows = false;
        seatDataBox.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        seatDataBox.BackgroundColor = SystemColors.Window;
        seatDataBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        seatDataBox.Location = new Point(-8, 137);
        seatDataBox.MultiSelect = false;
        seatDataBox.Name = "seatDataBox";
        seatDataBox.ReadOnly = true;
        seatDataBox.RowHeadersWidth = 82;
        seatDataBox.SelectionMode = DataGridViewSelectionMode.CellSelect;
        seatDataBox.Size = new Size(1775, 800);
        seatDataBox.TabIndex = 1;
        // 
        // tabPage2
        // 
        tabPage2.Controls.Add(clearResButton);
        tabPage2.Controls.Add(setAsUserButton);
        tabPage2.Controls.Add(setAsAdminButton);
        tabPage2.Controls.Add(changePasswordButton);
        tabPage2.Controls.Add(changeUsernameButton);
        tabPage2.Controls.Add(deleteUserButton);
        tabPage2.Controls.Add(addUserButton);
        tabPage2.Controls.Add(userDataBox);
        tabPage2.Location = new Point(8, 45);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(1759, 929);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "用户管理";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // clearResButton
        // 
        clearResButton.Font = new Font("宋体", 9F);
        clearResButton.Location = new Point(1376, 38);
        clearResButton.Name = "clearResButton";
        clearResButton.Size = new Size(200, 65);
        clearResButton.TabIndex = 15;
        clearResButton.Text = "清除预约";
        clearResButton.Click += clearResButton_Click;
        // 
        // setAsUserButton
        // 
        setAsUserButton.Font = new Font("宋体", 9F);
        setAsUserButton.Location = new Point(1170, 38);
        setAsUserButton.Name = "setAsUserButton";
        setAsUserButton.Size = new Size(200, 65);
        setAsUserButton.TabIndex = 15;
        setAsUserButton.Text = "设为用户";
        setAsUserButton.Click += setAsUserButton_Click;
        // 
        // setAsAdminButton
        // 
        setAsAdminButton.Font = new Font("宋体", 9F);
        setAsAdminButton.Location = new Point(964, 38);
        setAsAdminButton.Name = "setAsAdminButton";
        setAsAdminButton.Size = new Size(200, 65);
        setAsAdminButton.TabIndex = 15;
        setAsAdminButton.Text = "设为管理员";
        setAsAdminButton.Click += setAsAdminButton_Click;
        // 
        // changePasswordButton
        // 
        changePasswordButton.Font = new Font("宋体", 9F);
        changePasswordButton.Location = new Point(758, 38);
        changePasswordButton.Name = "changePasswordButton";
        changePasswordButton.Size = new Size(200, 65);
        changePasswordButton.TabIndex = 15;
        changePasswordButton.Text = "修改密码";
        changePasswordButton.Click += changePasswordButton_Click;
        // 
        // changeUsernameButton
        // 
        changeUsernameButton.Font = new Font("宋体", 9F);
        changeUsernameButton.Location = new Point(552, 38);
        changeUsernameButton.Name = "changeUsernameButton";
        changeUsernameButton.Size = new Size(200, 65);
        changeUsernameButton.TabIndex = 15;
        changeUsernameButton.Text = "修改用户名";
        changeUsernameButton.Click += changeUsernameButton_Click;
        // 
        // deleteUserButton
        // 
        deleteUserButton.Font = new Font("宋体", 9F);
        deleteUserButton.Location = new Point(346, 38);
        deleteUserButton.Name = "deleteUserButton";
        deleteUserButton.Size = new Size(200, 65);
        deleteUserButton.TabIndex = 15;
        deleteUserButton.Text = "删除用户";
        deleteUserButton.Click += deleteUserButton_Click;
        // 
        // addUserButton
        // 
        addUserButton.Font = new Font("宋体", 9F);
        addUserButton.Location = new Point(140, 38);
        addUserButton.Name = "addUserButton";
        addUserButton.Size = new Size(200, 65);
        addUserButton.TabIndex = 15;
        addUserButton.Text = "新增用户";
        addUserButton.Click += addUserButton_Click;
        // 
        // userDataBox
        // 
        userDataBox.AllowUserToAddRows = false;
        userDataBox.AllowUserToDeleteRows = false;
        userDataBox.AllowUserToResizeColumns = false;
        userDataBox.AllowUserToResizeRows = false;
        userDataBox.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        userDataBox.BackgroundColor = SystemColors.Window;
        userDataBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        userDataBox.Location = new Point(-8, 137);
        userDataBox.MultiSelect = false;
        userDataBox.Name = "userDataBox";
        userDataBox.ReadOnly = true;
        userDataBox.RowHeadersWidth = 82;
        userDataBox.SelectionMode = DataGridViewSelectionMode.CellSelect;
        userDataBox.Size = new Size(1775, 800);
        userDataBox.TabIndex = 3;
        // 
        // tabPage3
        // 
        tabPage3.Controls.Add(exportAsExcel);
        tabPage3.Controls.Add(exportAsJson);
        tabPage3.Controls.Add(removeAllResButton);
        tabPage3.Controls.Add(removeResButton);
        tabPage3.Controls.Add(cancelFilterResButton);
        tabPage3.Controls.Add(filterResButton);
        tabPage3.Controls.Add(dateRange);
        tabPage3.Controls.Add(userRes);
        tabPage3.Controls.Add(label6);
        tabPage3.Controls.Add(seatRes);
        tabPage3.Controls.Add(label4);
        tabPage3.Controls.Add(roomRes);
        tabPage3.Controls.Add(label8);
        tabPage3.Controls.Add(label7);
        tabPage3.Controls.Add(label5);
        tabPage3.Controls.Add(resDataBox);
        tabPage3.Location = new Point(8, 45);
        tabPage3.Name = "tabPage3";
        tabPage3.Padding = new Padding(3);
        tabPage3.Size = new Size(1759, 929);
        tabPage3.TabIndex = 2;
        tabPage3.Text = "预约记录管理";
        tabPage3.UseVisualStyleBackColor = true;
        // 
        // exportAsExcel
        // 
        exportAsExcel.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
        exportAsExcel.Location = new Point(1548, 66);
        exportAsExcel.Name = "exportAsExcel";
        exportAsExcel.Size = new Size(150, 65);
        exportAsExcel.TabIndex = 17;
        exportAsExcel.Text = "Excel文件";
        exportAsExcel.Click += exportAsExcel_Click;
        // 
        // exportAsJson
        // 
        exportAsJson.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
        exportAsJson.Location = new Point(1392, 66);
        exportAsJson.Name = "exportAsJson";
        exportAsJson.Size = new Size(150, 65);
        exportAsJson.TabIndex = 17;
        exportAsJson.Text = "Json文件";
        exportAsJson.Click += exportAsJson_Click;
        // 
        // removeAllResButton
        // 
        removeAllResButton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
        removeAllResButton.Location = new Point(527, 66);
        removeAllResButton.Name = "removeAllResButton";
        removeAllResButton.Size = new Size(200, 65);
        removeAllResButton.TabIndex = 17;
        removeAllResButton.Text = "删除所有记录";
        removeAllResButton.Click += removeAllResButton_Click;
        // 
        // removeResButton
        // 
        removeResButton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
        removeResButton.Location = new Point(321, 66);
        removeResButton.Name = "removeResButton";
        removeResButton.Size = new Size(200, 65);
        removeResButton.TabIndex = 18;
        removeResButton.Text = "删除单条记录";
        removeResButton.Click += removeResButton_Click;
        // 
        // cancelFilterResButton
        // 
        cancelFilterResButton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
        cancelFilterResButton.Location = new Point(165, 66);
        cancelFilterResButton.Name = "cancelFilterResButton";
        cancelFilterResButton.Size = new Size(150, 65);
        cancelFilterResButton.TabIndex = 17;
        cancelFilterResButton.Text = "取消筛选";
        cancelFilterResButton.Click += cancelFilterResButton_Click;
        // 
        // filterResButton
        // 
        filterResButton.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
        filterResButton.Location = new Point(9, 66);
        filterResButton.Name = "filterResButton";
        filterResButton.Size = new Size(150, 65);
        filterResButton.TabIndex = 18;
        filterResButton.Text = "筛选";
        filterResButton.Click += filterResButton_Click;
        // 
        // dateRange
        // 
        dateRange.Location = new Point(1216, 6);
        dateRange.Name = "dateRange";
        dateRange.Size = new Size(482, 65);
        dateRange.TabIndex = 16;
        dateRange.TextAlign = HorizontalAlignment.Center;
        // 
        // userRes
        // 
        userRes.Font = new Font("宋体", 9F);
        userRes.Location = new Point(832, 6);
        userRes.MaxCount = 10;
        userRes.Name = "userRes";
        userRes.Size = new Size(236, 65);
        userRes.TabIndex = 14;
        // 
        // label6
        // 
        label6.Font = new Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
        label6.Location = new Point(721, 6);
        label6.Name = "label6";
        label6.Size = new Size(119, 65);
        label6.TabIndex = 12;
        label6.Text = "占用者:";
        // 
        // seatRes
        // 
        seatRes.Font = new Font("宋体", 9F);
        seatRes.Location = new Point(475, 6);
        seatRes.MaxCount = 10;
        seatRes.Name = "seatRes";
        seatRes.Size = new Size(236, 65);
        seatRes.TabIndex = 14;
        // 
        // label4
        // 
        label4.Font = new Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
        label4.Location = new Point(364, 6);
        label4.Name = "label4";
        label4.Size = new Size(119, 65);
        label4.TabIndex = 12;
        label4.Text = "座位号:";
        // 
        // roomRes
        // 
        roomRes.Font = new Font("宋体", 9F);
        roomRes.Location = new Point(120, 6);
        roomRes.MaxCount = 10;
        roomRes.Name = "roomRes";
        roomRes.Size = new Size(236, 65);
        roomRes.TabIndex = 15;
        // 
        // label8
        // 
        label8.Font = new Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
        label8.Location = new Point(1076, 66);
        label8.Name = "label8";
        label8.Size = new Size(314, 65);
        label8.TabIndex = 13;
        label8.Text = "将筛选后的记录导出为:";
        // 
        // label7
        // 
        label7.Font = new Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
        label7.Location = new Point(1076, 6);
        label7.Name = "label7";
        label7.Size = new Size(157, 65);
        label7.TabIndex = 13;
        label7.Text = "时间范围:";
        // 
        // label5
        // 
        label5.Font = new Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
        label5.Location = new Point(9, 6);
        label5.Name = "label5";
        label5.Size = new Size(119, 65);
        label5.TabIndex = 13;
        label5.Text = "房间号:";
        // 
        // resDataBox
        // 
        resDataBox.AllowUserToAddRows = false;
        resDataBox.AllowUserToDeleteRows = false;
        resDataBox.AllowUserToResizeColumns = false;
        resDataBox.AllowUserToResizeRows = false;
        resDataBox.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        resDataBox.BackgroundColor = SystemColors.Window;
        resDataBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        resDataBox.Location = new Point(-8, 137);
        resDataBox.MultiSelect = false;
        resDataBox.Name = "resDataBox";
        resDataBox.ReadOnly = true;
        resDataBox.RowHeadersWidth = 82;
        resDataBox.SelectionMode = DataGridViewSelectionMode.CellSelect;
        resDataBox.Size = new Size(1775, 800);
        resDataBox.TabIndex = 2;
        // 
        // welcome
        // 
        welcome.Font = new Font("宋体", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 134);
        welcome.Location = new Point(484, 12);
        welcome.Name = "welcome";
        welcome.Size = new Size(464, 65);
        welcome.TabIndex = 2;
        welcome.Text = "你好，{admin}";
        // 
        // refreshButton
        // 
        refreshButton.Font = new Font("宋体", 9F);
        refreshButton.Location = new Point(1457, 12);
        refreshButton.Name = "refreshButton";
        refreshButton.Size = new Size(150, 65);
        refreshButton.TabIndex = 7;
        refreshButton.Text = "刷新";
        refreshButton.Click += refreshButton_Click;
        // 
        // exitButton
        // 
        exitButton.Font = new Font("宋体", 9F);
        exitButton.Location = new Point(1613, 12);
        exitButton.Name = "exitButton";
        exitButton.Size = new Size(150, 65);
        exitButton.TabIndex = 8;
        exitButton.Text = "退出系统";
        exitButton.Click += exitButton_Click;
        // 
        // Admin
        // 
        AutoScaleDimensions = new SizeF(14F, 31F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1775, 1034);
        Controls.Add(refreshButton);
        Controls.Add(exitButton);
        Controls.Add(welcome);
        Controls.Add(tabControl1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MdiChildrenMinimizedAnchorBottom = false;
        Name = "Admin";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "湘潭大学图书馆预约系统 管理端";
        Load += Admin_Load;
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        ((ISupportInitialize)seatDataBox).EndInit();
        tabPage2.ResumeLayout(false);
        ((ISupportInitialize)userDataBox).EndInit();
        tabPage3.ResumeLayout(false);
        ((ISupportInitialize)resDataBox).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private TabPage tabPage3;
    private DataGridView seatDataBox;
    private AntdUI.Button cancelFiltterButton;
    private AntdUI.Button filterButton;
    private AntdUI.Select resSelect;
    private AntdUI.Label label3;
    private AntdUI.Select seatSelect;
    private AntdUI.Label label2;
    private AntdUI.Select roomSelect;
    private AntdUI.Label label1;
    private DataGridView resDataBox;
    private AntdUI.Select seatRes;
    private AntdUI.Label label4;
    private AntdUI.Select roomRes;
    private AntdUI.Label label5;
    private AntdUI.Select userRes;
    private AntdUI.Label label6;
    private AntdUI.Checkbox checkbox1;
    private AntdUI.DatePickerRange dateRange;
    private AntdUI.Label label7;
    private AntdUI.Button addUserButton;
    private AntdUI.Button cancelSeat;
    private AntdUI.Button exportSeat;
    private AntdUI.Button importSeat;
    private AntdUI.Button removeSeat;
    private AntdUI.Button addSeat;
    private DataGridView userDataBox;
    private AntdUI.Button setAsUserButton;
    private AntdUI.Button setAsAdminButton;
    private AntdUI.Button changePasswordButton;
    private AntdUI.Button changeUsernameButton;
    private AntdUI.Button deleteUserButton;
    private AntdUI.Button clearResButton;
    private AntdUI.Button exportAsExcel;
    private AntdUI.Button exportAsJson;
    private AntdUI.Button cancelFilterResButton;
    private AntdUI.Button filterResButton;
    private AntdUI.Label label8;
    private AntdUI.Button removeAllResButton;
    private AntdUI.Button removeResButton;
    private AntdUI.Label welcome;
    private AntdUI.Button refreshButton;
    private AntdUI.Button exitButton;
}