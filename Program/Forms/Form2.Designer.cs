using WinFormsApp1.Logic;
namespace WinFormsApp1.Forms
{
    partial class Form2
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
            availableLabel = new Label();
            rentedLabel = new Label();
            available = new Label();
            rented = new Label();
            closeBtn = new Button();
            allLabel = new Label();
            all = new Label();
            saveToFileBtn = new Button();
            SuspendLayout();
            // 
            // availableLabel
            // 
            availableLabel.AutoSize = true;
            availableLabel.Font = new Font("Segoe UI", 15F);
            availableLabel.Location = new Point(11, 48);
            availableLabel.Name = "availableLabel";
            availableLabel.Size = new Size(228, 28);
            availableLabel.TabIndex = 0;
            availableLabel.Text = "number of available cars:";
            // 
            // rentedLabel
            // 
            rentedLabel.AutoSize = true;
            rentedLabel.Font = new Font("Segoe UI", 15F);
            rentedLabel.Location = new Point(11, 92);
            rentedLabel.Name = "rentedLabel";
            rentedLabel.Size = new Size(208, 28);
            rentedLabel.TabIndex = 1;
            rentedLabel.Text = "number of rented cars:";
            // 
            // available
            // 
            available.AutoSize = true;
            available.Font = new Font("Segoe UI", 15F);
            available.Location = new Point(245, 48);
            available.Name = "available";
            available.Size = new Size(56, 28);
            available.TabIndex = 2;
            available.Text = "none";
            // 
            // rented
            // 
            rented.AutoSize = true;
            rented.Font = new Font("Segoe UI", 15F);
            rented.Location = new Point(245, 92);
            rented.Name = "rented";
            rented.Size = new Size(56, 28);
            rented.TabIndex = 3;
            rented.Text = "none";
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(242, 312);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(125, 54);
            closeBtn.TabIndex = 4;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += CloseBtn;
            // 
            // allLabel
            // 
            allLabel.AutoSize = true;
            allLabel.Font = new Font("Segoe UI", 15F);
            allLabel.Location = new Point(11, 135);
            allLabel.Name = "allLabel";
            allLabel.Size = new Size(75, 28);
            allLabel.TabIndex = 5;
            allLabel.Text = "all cars:";
            // 
            // all
            // 
            all.Font = new Font("Segoe UI", 15F);
            all.Location = new Point(242, 135);
            all.Name = "all";
            all.Size = new Size(56, 28);
            all.TabIndex = 6;
            all.Text = "none";
            // 
            // saveToFileBtn
            // 
            saveToFileBtn.Location = new Point(16, 180);
            saveToFileBtn.Name = "saveToFileBtn";
            saveToFileBtn.Size = new Size(139, 33);
            saveToFileBtn.TabIndex = 7;
            saveToFileBtn.Text = "Save raport to file";
            saveToFileBtn.UseVisualStyleBackColor = true;
            saveToFileBtn.Click += SaveToRaportBtn;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 388);
            Controls.Add(saveToFileBtn);
            Controls.Add(all);
            Controls.Add(allLabel);
            Controls.Add(closeBtn);
            Controls.Add(rented);
            Controls.Add(available);
            Controls.Add(rentedLabel);
            Controls.Add(availableLabel);
            Name = "Form2";
            Text = "Raport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label availableLabel;
        private Label rentedLabel;
        private Label available;
        private Label rented;
        private Button closeBtn;
        private Label allLabel;
        private Label all;
        private Button saveToFileBtn;
    }
}