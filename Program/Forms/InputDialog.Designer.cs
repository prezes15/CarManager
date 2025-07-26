namespace WinFormsApp1.Forms
{
    partial class InputDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            cancelBtn = new Button();
            sendBtn = new Button();
            idLabel = new Label();
            idBox = new TextBox();
            SuspendLayout();
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(241, 126);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(143, 53);
            cancelBtn.TabIndex = 0;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += CancelBtn;
            // 
            // sendBtn
            // 
            sendBtn.Location = new Point(12, 126);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(143, 53);
            sendBtn.TabIndex = 1;
            sendBtn.Text = "Next";
            sendBtn.UseVisualStyleBackColor = true;
            sendBtn.Click += SendBtn;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI", 15F);
            idLabel.Location = new Point(12, 49);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(33, 28);
            idLabel.TabIndex = 2;
            idLabel.Text = "id:";
            // 
            // idBox
            // 
            idBox.Font = new Font("Segoe UI", 15F);
            idBox.Location = new Point(51, 43);
            idBox.Name = "idBox";
            idBox.Size = new Size(168, 34);
            idBox.TabIndex = 3;
            // 
            // InputDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 191);
            Controls.Add(idBox);
            Controls.Add(idLabel);
            Controls.Add(sendBtn);
            Controls.Add(cancelBtn);
            Name = "InputDialog";
            Text = "InputDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelBtn;
        private Button sendBtn;
        private Label idLabel;
        private TextBox idBox;
    }
}