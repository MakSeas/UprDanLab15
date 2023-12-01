namespace UprDanLab15
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.RoleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ServiceAI_InsertButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ExtractFromSubjectsButton = new System.Windows.Forms.Button();
            this.CreateNewTestButton = new System.Windows.Forms.Button();
            this.SubjectIDtextBox = new System.Windows.Forms.TextBox();
            this.ChamberIDtextBox = new System.Windows.Forms.TextBox();
            this.WTTimeTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DateParameterPicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BallPicture = new System.Windows.Forms.PictureBox();
            this.BounceLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TestIDTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.NewDateDatePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BallPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(51, 100);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 22);
            this.NameTextBox.TabIndex = 0;
            // 
            // RoleTextBox
            // 
            this.RoleTextBox.Location = new System.Drawing.Point(157, 100);
            this.RoleTextBox.Name = "RoleTextBox";
            this.RoleTextBox.Size = new System.Drawing.Size(100, 22);
            this.RoleTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Role";
            // 
            // ServiceAI_InsertButton
            // 
            this.ServiceAI_InsertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ServiceAI_InsertButton.Location = new System.Drawing.Point(12, 128);
            this.ServiceAI_InsertButton.Name = "ServiceAI_InsertButton";
            this.ServiceAI_InsertButton.Size = new System.Drawing.Size(278, 85);
            this.ServiceAI_InsertButton.TabIndex = 4;
            this.ServiceAI_InsertButton.Text = "Добавить даные запросом";
            this.ServiceAI_InsertButton.UseVisualStyleBackColor = true;
            this.ServiceAI_InsertButton.Click += new System.EventHandler(this.ServiceAI_InsertButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Таблица ServiceAIs";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(363, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(425, 113);
            this.dataGridView1.TabIndex = 6;
            // 
            // ExtractFromSubjectsButton
            // 
            this.ExtractFromSubjectsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ExtractFromSubjectsButton.Location = new System.Drawing.Point(363, 129);
            this.ExtractFromSubjectsButton.Name = "ExtractFromSubjectsButton";
            this.ExtractFromSubjectsButton.Size = new System.Drawing.Size(425, 84);
            this.ExtractFromSubjectsButton.TabIndex = 7;
            this.ExtractFromSubjectsButton.Text = "Извлечь данные из таблицы Subjects";
            this.ExtractFromSubjectsButton.UseVisualStyleBackColor = true;
            this.ExtractFromSubjectsButton.Click += new System.EventHandler(this.ExtractFromSubjectsButton_Click);
            // 
            // CreateNewTestButton
            // 
            this.CreateNewTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CreateNewTestButton.Location = new System.Drawing.Point(18, 341);
            this.CreateNewTestButton.Name = "CreateNewTestButton";
            this.CreateNewTestButton.Size = new System.Drawing.Size(219, 67);
            this.CreateNewTestButton.TabIndex = 8;
            this.CreateNewTestButton.Text = "Создать новое испытание";
            this.CreateNewTestButton.UseVisualStyleBackColor = true;
            this.CreateNewTestButton.Click += new System.EventHandler(this.CreateNewTestButton_Click);
            // 
            // SubjectIDtextBox
            // 
            this.SubjectIDtextBox.Location = new System.Drawing.Point(18, 313);
            this.SubjectIDtextBox.Name = "SubjectIDtextBox";
            this.SubjectIDtextBox.Size = new System.Drawing.Size(39, 22);
            this.SubjectIDtextBox.TabIndex = 9;
            // 
            // ChamberIDtextBox
            // 
            this.ChamberIDtextBox.Location = new System.Drawing.Point(63, 313);
            this.ChamberIDtextBox.Name = "ChamberIDtextBox";
            this.ChamberIDtextBox.Size = new System.Drawing.Size(39, 22);
            this.ChamberIDtextBox.TabIndex = 10;
            // 
            // WTTimeTextBox
            // 
            this.WTTimeTextBox.Location = new System.Drawing.Point(108, 313);
            this.WTTimeTextBox.Name = "WTTimeTextBox";
            this.WTTimeTextBox.Size = new System.Drawing.Size(39, 22);
            this.WTTimeTextBox.TabIndex = 11;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(153, 313);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(39, 22);
            this.ResultTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(4, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "SubjectID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(50, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Chamber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(92, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "WTTime";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(149, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Result";
            // 
            // DateParameterPicker
            // 
            this.DateParameterPicker.Location = new System.Drawing.Point(198, 313);
            this.DateParameterPicker.Name = "DateParameterPicker";
            this.DateParameterPicker.Size = new System.Drawing.Size(44, 22);
            this.DateParameterPicker.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(197, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BallPicture
            // 
            this.BallPicture.Image = global::UprDanLab15.Properties.Resources.Balls;
            this.BallPicture.Location = new System.Drawing.Point(938, 116);
            this.BallPicture.Name = "BallPicture";
            this.BallPicture.Size = new System.Drawing.Size(112, 111);
            this.BallPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BallPicture.TabIndex = 21;
            this.BallPicture.TabStop = false;
            // 
            // BounceLabel
            // 
            this.BounceLabel.AutoSize = true;
            this.BounceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BounceLabel.Location = new System.Drawing.Point(979, 230);
            this.BounceLabel.Name = "BounceLabel";
            this.BounceLabel.Size = new System.Drawing.Size(27, 29);
            this.BounceLabel.TabIndex = 22;
            this.BounceLabel.Text = "0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(319, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 67);
            this.button1.TabIndex = 23;
            this.button1.Text = "Изменить дату проведения испытания";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(394, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "TestID";
            // 
            // TestIDTextBox
            // 
            this.TestIDTextBox.Location = new System.Drawing.Point(414, 313);
            this.TestIDTextBox.Name = "TestIDTextBox";
            this.TestIDTextBox.Size = new System.Drawing.Size(39, 22);
            this.TestIDTextBox.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(485, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "NewDate";
            // 
            // NewDateDatePicker
            // 
            this.NewDateDatePicker.Location = new System.Drawing.Point(500, 311);
            this.NewDateDatePicker.Name = "NewDateDatePicker";
            this.NewDateDatePicker.Size = new System.Drawing.Size(44, 22);
            this.NewDateDatePicker.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 666);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.NewDateDatePicker);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TestIDTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BounceLabel);
            this.Controls.Add(this.BallPicture);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DateParameterPicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.WTTimeTextBox);
            this.Controls.Add(this.ChamberIDtextBox);
            this.Controls.Add(this.SubjectIDtextBox);
            this.Controls.Add(this.CreateNewTestButton);
            this.Controls.Add(this.ExtractFromSubjectsButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ServiceAI_InsertButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoleTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BallPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox RoleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ServiceAI_InsertButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ExtractFromSubjectsButton;
        private System.Windows.Forms.Button CreateNewTestButton;
        private System.Windows.Forms.TextBox SubjectIDtextBox;
        private System.Windows.Forms.TextBox ChamberIDtextBox;
        private System.Windows.Forms.TextBox WTTimeTextBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DateParameterPicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox BallPicture;
        private System.Windows.Forms.Label BounceLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TestIDTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker NewDateDatePicker;
    }
}

