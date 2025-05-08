namespace LRSV2;

using System;
using System.Windows.Forms;

public static class InputBox
{
    public static string Show(string title, string promptText,bool isPSD)
    {
        Form form = new Form();
        Label label = new Label();
        TextBox textBox = new TextBox();
        Button buttonOk = new Button();
        Button buttonCancel = new Button();
        form.Text = title;
        form.StartPosition = FormStartPosition.CenterScreen;
        form.FormBorderStyle = FormBorderStyle.FixedDialog;
        form.MinimizeBox = false;
        form.MaximizeBox = false;
        form.ClientSize = new System.Drawing.Size(400, 200);
        label.Text = promptText;
        label.AutoSize = true;
        label.SetBounds(20, 20, 360, 20); 
        textBox.SetBounds(20, 50, 360, 25);
        if (isPSD)
        {
            textBox.PasswordChar = '*';
        }
        buttonOk.Text = "确认";
        buttonOk.Size = new Size(120, 40); 
        buttonCancel.Text = "取消";
        buttonCancel.Size = new Size(120, 40); 
        int buttonTop = 120; 
        int buttonSpacing = 20; 
        int totalButtonWidth = buttonOk.Width + buttonCancel.Width + buttonSpacing;
        int buttonLeftStart = (form.ClientSize.Width - totalButtonWidth) / 2;
        buttonOk.Location = new Point(buttonLeftStart, buttonTop);
        buttonCancel.Location = new Point(buttonLeftStart + buttonOk.Width + buttonSpacing, buttonTop);
        buttonOk.DialogResult = DialogResult.OK;
        buttonCancel.DialogResult = DialogResult.Cancel;
        form.Controls.AddRange(label, textBox, buttonOk, buttonCancel );
        form.AcceptButton = buttonOk;
        form.CancelButton = buttonCancel;
        DialogResult dialogResult = form.ShowDialog();
        return dialogResult == DialogResult.OK ? textBox.Text : null;
    }
}