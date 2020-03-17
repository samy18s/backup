namespace WindowsFormsApp4
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.No = new System.Windows.Forms.TextBox();
            this.sName = new System.Windows.Forms.TextBox();
            this.Course = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.TextBox();
            this.View = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Pick = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.View)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Course";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            // 
            // No
            // 
            this.No.Location = new System.Drawing.Point(329, 21);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(100, 20);
            this.No.TabIndex = 4;
            // 
            // sName
            // 
            this.sName.Location = new System.Drawing.Point(329, 47);
            this.sName.Name = "sName";
            this.sName.Size = new System.Drawing.Size(100, 20);
            this.sName.TabIndex = 5;
            // 
            // Course
            // 
            this.Course.Location = new System.Drawing.Point(329, 75);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(100, 20);
            this.Course.TabIndex = 6;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(329, 104);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(100, 20);
            this.Date.TabIndex = 7;
            this.Date.TextChanged += new System.EventHandler(this.Date_TextChanged);
            // 
            // View
            // 
            this.View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View.Location = new System.Drawing.Point(376, 229);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(240, 150);
            this.View.TabIndex = 8;
            this.View.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.View_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ALL",
            "COURSE",
            "DATE"});
            this.comboBox1.Location = new System.Drawing.Point(34, 228);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(329, 171);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 10;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(456, 171);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 11;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(574, 171);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 12;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(187, 171);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 13;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pick
            // 
            this.Pick.CustomFormat = "yyyy-MM-dd";
            this.Pick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Pick.Location = new System.Drawing.Point(34, 359);
            this.Pick.Name = "Pick";
            this.Pick.Size = new System.Drawing.Size(200, 20);
            this.Pick.TabIndex = 15;
            this.Pick.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(598, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 430);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Pick);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.View);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.sName);
            this.Controls.Add(this.No);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Student Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox No;
        private System.Windows.Forms.TextBox sName;
        private System.Windows.Forms.TextBox Course;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.DataGridView View;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker Pick;
        private System.Windows.Forms.Button button2;
    }
}

