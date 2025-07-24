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
            label1 = new Label();
            modelBox = new TextBox();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(72, 28);
            label1.TabIndex = 2;
            label1.Text = "model:";
            // 
            // modelBox
            // 
            modelBox.Font = new Font("Segoe UI", 15F);
            modelBox.Location = new Point(100, 43);
            modelBox.Name = "modelBox";
            modelBox.Size = new Size(168, 34);
            modelBox.TabIndex = 3;
            // 
            // InputDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 191);
            Controls.Add(modelBox);
            Controls.Add(label1);
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
        private Label label1;
        private TextBox modelBox;
    }
}