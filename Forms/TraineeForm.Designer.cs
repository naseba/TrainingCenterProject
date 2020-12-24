namespace TrainingCenterProject
{
    partial class TraineeForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Pricelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Trainerlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Durationlabel = new System.Windows.Forms.Label();
            this.Descriptionlabel = new System.Windows.Forms.Label();
            this.CourseNamelabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoursePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseDeliveryMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Backbutton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(516, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Courses";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(318, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(240, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Wishlist";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Web Development",
            "Data Science",
            "Mobile Development",
            "Programming Languages",
            "Game Development",
            "Software Testing",
            "Software Engineering",
            "Development Tools"});
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Web Development",
            "Data Science",
            "Mobile Development",
            "Programming Languages",
            "Game Development",
            "Software Testing",
            "Software Engineering",
            "Development Tools"});
            this.comboBox1.Location = new System.Drawing.Point(117, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Catigoryies";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(192, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "My Courses";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(1, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 396);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Pricelabel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Trainerlabel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Durationlabel);
            this.panel2.Controls.Add(this.Descriptionlabel);
            this.panel2.Controls.Add(this.CourseNamelabel);
            this.panel2.Location = new System.Drawing.Point(1, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(616, 390);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Duration : ";
            // 
            // Pricelabel
            // 
            this.Pricelabel.AutoSize = true;
            this.Pricelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pricelabel.Location = new System.Drawing.Point(482, 220);
            this.Pricelabel.Name = "Pricelabel";
            this.Pricelabel.Size = new System.Drawing.Size(77, 20);
            this.Pricelabel.TabIndex = 6;
            this.Pricelabel.Text = "Pricelabel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price : ";
            // 
            // Trainerlabel
            // 
            this.Trainerlabel.AutoSize = true;
            this.Trainerlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trainerlabel.Location = new System.Drawing.Point(183, 313);
            this.Trainerlabel.Name = "Trainerlabel";
            this.Trainerlabel.Size = new System.Drawing.Size(110, 24);
            this.Trainerlabel.TabIndex = 4;
            this.Trainerlabel.Text = "Trainerlabel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Created by : ";
            // 
            // Durationlabel
            // 
            this.Durationlabel.AutoSize = true;
            this.Durationlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Durationlabel.Location = new System.Drawing.Point(169, 220);
            this.Durationlabel.Name = "Durationlabel";
            this.Durationlabel.Size = new System.Drawing.Size(139, 25);
            this.Durationlabel.TabIndex = 2;
            this.Durationlabel.Text = "Durationlabel";
            this.Durationlabel.Click += new System.EventHandler(this.Durationlabel_Click);
            // 
            // Descriptionlabel
            // 
            this.Descriptionlabel.AutoSize = true;
            this.Descriptionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descriptionlabel.Location = new System.Drawing.Point(60, 118);
            this.Descriptionlabel.Name = "Descriptionlabel";
            this.Descriptionlabel.Size = new System.Drawing.Size(188, 29);
            this.Descriptionlabel.TabIndex = 1;
            this.Descriptionlabel.Text = "Descriptionlabel";
            // 
            // CourseNamelabel
            // 
            this.CourseNamelabel.AutoSize = true;
            this.CourseNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseNamelabel.Location = new System.Drawing.Point(170, 19);
            this.CourseNamelabel.Name = "CourseNamelabel";
            this.CourseNamelabel.Size = new System.Drawing.Size(322, 55);
            this.CourseNamelabel.TabIndex = 0;
            this.CourseNamelabel.Text = "Course Name";
            this.CourseNamelabel.Click += new System.EventHandler(this.CourseNamelabel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseID,
            this.CourseName,
            this.CoursePrice,
            this.CourseDuration,
            this.CourseDeliveryMethod,
            this.TrainerID,
            this.TrainerName});
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(616, 372);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // CourseID
            // 
            this.CourseID.DataPropertyName = "CourseID";
            this.CourseID.HeaderText = "ID";
            this.CourseID.Name = "CourseID";
            this.CourseID.ReadOnly = true;
            this.CourseID.Visible = false;
            // 
            // CourseName
            // 
            this.CourseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.HeaderText = "Course ";
            this.CourseName.MinimumWidth = 10;
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            // 
            // CoursePrice
            // 
            this.CoursePrice.DataPropertyName = "CoursePrice";
            this.CoursePrice.HeaderText = "Price";
            this.CoursePrice.Name = "CoursePrice";
            this.CoursePrice.ReadOnly = true;
            // 
            // CourseDuration
            // 
            this.CourseDuration.DataPropertyName = "CourseDuration";
            this.CourseDuration.HeaderText = "Duration";
            this.CourseDuration.Name = "CourseDuration";
            this.CourseDuration.ReadOnly = true;
            // 
            // CourseDeliveryMethod
            // 
            this.CourseDeliveryMethod.DataPropertyName = "CourseDeliveryMethod";
            this.CourseDeliveryMethod.HeaderText = "Delivery Method";
            this.CourseDeliveryMethod.Name = "CourseDeliveryMethod";
            this.CourseDeliveryMethod.ReadOnly = true;
            // 
            // TrainerID
            // 
            this.TrainerID.DataPropertyName = "TrainerID";
            this.TrainerID.HeaderText = "TrainerID";
            this.TrainerID.Name = "TrainerID";
            this.TrainerID.ReadOnly = true;
            this.TrainerID.Visible = false;
            // 
            // TrainerName
            // 
            this.TrainerName.DataPropertyName = "TrainerName";
            this.TrainerName.HeaderText = "Trainer";
            this.TrainerName.Name = "TrainerName";
            this.TrainerName.ReadOnly = true;
            // 
            // Backbutton
            // 
            this.Backbutton.Location = new System.Drawing.Point(12, 12);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(75, 23);
            this.Backbutton.TabIndex = 8;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Visible = false;
            this.Backbutton.Click += new System.EventHandler(this.button4_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(414, 313);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Enroll";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(43, 217);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(528, 178);
            this.listBox1.TabIndex = 9;
            // 
            // TraineeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 455);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "TraineeForm";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.TraineeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoursePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseDeliveryMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainerName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Trainerlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Durationlabel;
        private System.Windows.Forms.Label Descriptionlabel;
        private System.Windows.Forms.Label CourseNamelabel;
        private System.Windows.Forms.Label Pricelabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
    }
}