namespace WinFormsApp1.Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            markaLabel = new Label();
            modelLabel = new Label();
            rokLabel = new Label();
            markaBox = new TextBox();
            modelBox = new TextBox();
            rokBox = new TextBox();
            acceptBtn = new Button();
            listView1 = new ListView();
            id = new ColumnHeader();
            mark = new ColumnHeader();
            model = new ColumnHeader();
            year = new ColumnHeader();
            accessibility = new ColumnHeader();
            button4 = new Button();
            button5 = new Button();
            saveBtn = new Button();
            loadBtn = new Button();
            raportBtn = new Button();
            closeBtn = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 21);
            button1.Name = "button1";
            button1.Size = new Size(117, 55);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnClick1;
            // 
            // button2
            // 
            button2.Location = new Point(150, 21);
            button2.Name = "button2";
            button2.Size = new Size(117, 55);
            button2.TabIndex = 1;
            button2.Text = "Drop";
            button2.UseVisualStyleBackColor = true;
            button2.Click += BtnClick2;
            // 
            // button3
            // 
            button3.Location = new Point(285, 21);
            button3.Name = "button3";
            button3.Size = new Size(117, 55);
            button3.TabIndex = 2;
            button3.Text = "Display";
            button3.UseVisualStyleBackColor = true;
            button3.Click += BtnClick3;
            // 
            // markaLabel
            // 
            markaLabel.AutoSize = true;
            markaLabel.Font = new Font("Segoe UI", 15F);
            markaLabel.Location = new Point(12, 222);
            markaLabel.Name = "markaLabel";
            markaLabel.Size = new Size(56, 28);
            markaLabel.TabIndex = 3;
            markaLabel.Text = "mark";
            markaLabel.Visible = false;
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Font = new Font("Segoe UI", 15F);
            modelLabel.Location = new Point(12, 266);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(68, 28);
            modelLabel.TabIndex = 4;
            modelLabel.Text = "model";
            modelLabel.Visible = false;
            // 
            // rokLabel
            // 
            rokLabel.AutoSize = true;
            rokLabel.Font = new Font("Segoe UI", 15F);
            rokLabel.Location = new Point(12, 312);
            rokLabel.Name = "rokLabel";
            rokLabel.Size = new Size(175, 28);
            rokLabel.TabIndex = 5;
            rokLabel.Text = "year of production";
            rokLabel.Visible = false;
            // 
            // markaBox
            // 
            markaBox.Location = new Point(98, 227);
            markaBox.Name = "markaBox";
            markaBox.Size = new Size(288, 23);
            markaBox.TabIndex = 6;
            markaBox.Visible = false;
            // 
            // modelBox
            // 
            modelBox.Location = new Point(98, 271);
            modelBox.Name = "modelBox";
            modelBox.Size = new Size(288, 23);
            modelBox.TabIndex = 7;
            modelBox.Visible = false;
            // 
            // rokBox
            // 
            rokBox.Location = new Point(193, 320);
            rokBox.Name = "rokBox";
            rokBox.Size = new Size(239, 23);
            rokBox.TabIndex = 8;
            rokBox.Visible = false;
            // 
            // acceptBtn
            // 
            acceptBtn.Location = new Point(285, 385);
            acceptBtn.Name = "acceptBtn";
            acceptBtn.Size = new Size(117, 39);
            acceptBtn.TabIndex = 9;
            acceptBtn.Text = "Confirm";
            acceptBtn.UseVisualStyleBackColor = true;
            acceptBtn.Visible = false;
            acceptBtn.Click += ConfirmBtn;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { id, mark, model, year, accessibility });
            listView1.Location = new Point(177, 108);
            listView1.Name = "listView1";
            listView1.Size = new Size(494, 413);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.Visible = false;
            // 
            // id
            // 
            id.Text = "id";
            id.Width = 50;
            // 
            // mark
            // 
            mark.Text = "mark";
            mark.Width = 120;
            // 
            // model
            // 
            model.Text = "model";
            model.Width = 120;
            // 
            // year
            // 
            year.Text = "year of production";
            year.Width = 110;
            // 
            // accessibility
            // 
            accessibility.Text = "accessibility";
            accessibility.Width = 90;
            // 
            // button4
            // 
            button4.Location = new Point(423, 21);
            button4.Name = "button4";
            button4.Size = new Size(117, 55);
            button4.TabIndex = 11;
            button4.Text = "Rent";
            button4.UseVisualStyleBackColor = true;
            button4.Click += RentReturnBtn;
            // 
            // button5
            // 
            button5.Location = new Point(567, 21);
            button5.Name = "button5";
            button5.Size = new Size(117, 55);
            button5.TabIndex = 12;
            button5.Text = "Return";
            button5.UseVisualStyleBackColor = true;
            button5.Click += RentReturnBtn;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(768, 21);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(117, 55);
            saveBtn.TabIndex = 13;
            saveBtn.Text = "Save to file";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += SaveBtn;
            // 
            // loadBtn
            // 
            loadBtn.Location = new Point(768, 96);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(117, 55);
            loadBtn.TabIndex = 14;
            loadBtn.Text = "Load from file";
            loadBtn.UseVisualStyleBackColor = true;
            loadBtn.Click += LoadBtn;
            // 
            // raportBtn
            // 
            raportBtn.Location = new Point(768, 171);
            raportBtn.Name = "raportBtn";
            raportBtn.Size = new Size(117, 55);
            raportBtn.TabIndex = 15;
            raportBtn.Text = "Raport";
            raportBtn.UseVisualStyleBackColor = true;
            raportBtn.Click += RaportBtn;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(760, 543);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(125, 54);
            closeBtn.TabIndex = 16;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += CloseBtn;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 609);
            Controls.Add(closeBtn);
            Controls.Add(raportBtn);
            Controls.Add(loadBtn);
            Controls.Add(saveBtn);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(listView1);
            Controls.Add(acceptBtn);
            Controls.Add(rokBox);
            Controls.Add(modelBox);
            Controls.Add(markaBox);
            Controls.Add(rokLabel);
            Controls.Add(modelLabel);
            Controls.Add(markaLabel);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Cars Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label markaLabel;
        private Label modelLabel;
        private Label rokLabel;
        private TextBox markaBox;
        private TextBox modelBox;
        private TextBox rokBox;
        private Button acceptBtn;
        private ListView listView1;
        private ColumnHeader mark;
        private ColumnHeader model;
        private ColumnHeader year;
        private ColumnHeader accessibility;
        private Button button4;
        private Button button5;
        private Button saveBtn;
        private Button loadBtn;
        private Button raportBtn;
        private Button closeBtn;
        private ColumnHeader id;
    }
}
