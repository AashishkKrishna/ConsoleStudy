namespace ClientWindowsFormsAppStudy
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
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.txtBoxInsertName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comBoxInsertGender = new System.Windows.Forms.ComboBox();
            this.comBoxUpdateGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxUpdateName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxUpdateId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.dgRetrieve = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgRetrieve)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRUD Operations";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Perform";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(48, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(52, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Insert";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(48, 79);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(66, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Retrieve";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(48, 102);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(61, 17);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Update";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(48, 175);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(57, 17);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Delete";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // txtBoxInsertName
            // 
            this.txtBoxInsertName.Location = new System.Drawing.Point(81, 55);
            this.txtBoxInsertName.Name = "txtBoxInsertName";
            this.txtBoxInsertName.Size = new System.Drawing.Size(119, 20);
            this.txtBoxInsertName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gender";
            // 
            // comBoxInsertGender
            // 
            this.comBoxInsertGender.FormattingEnabled = true;
            this.comBoxInsertGender.Items.AddRange(new object[] {
            "He",
            "She"});
            this.comBoxInsertGender.Location = new System.Drawing.Point(254, 52);
            this.comBoxInsertGender.Name = "comBoxInsertGender";
            this.comBoxInsertGender.Size = new System.Drawing.Size(50, 21);
            this.comBoxInsertGender.TabIndex = 10;
            // 
            // comBoxUpdateGender
            // 
            this.comBoxUpdateGender.FormattingEnabled = true;
            this.comBoxUpdateGender.Items.AddRange(new object[] {
            "He",
            "She"});
            this.comBoxUpdateGender.Location = new System.Drawing.Point(254, 122);
            this.comBoxUpdateGender.Name = "comBoxUpdateGender";
            this.comBoxUpdateGender.Size = new System.Drawing.Size(50, 21);
            this.comBoxUpdateGender.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Name";
            // 
            // txtBoxUpdateName
            // 
            this.txtBoxUpdateName.Location = new System.Drawing.Point(81, 125);
            this.txtBoxUpdateName.Name = "txtBoxUpdateName";
            this.txtBoxUpdateName.Size = new System.Drawing.Size(119, 20);
            this.txtBoxUpdateName.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "ID";
            // 
            // txtBoxUpdateId
            // 
            this.txtBoxUpdateId.Location = new System.Drawing.Point(149, 151);
            this.txtBoxUpdateId.Name = "txtBoxUpdateId";
            this.txtBoxUpdateId.Size = new System.Drawing.Size(60, 20);
            this.txtBoxUpdateId.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "label7";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(49, 229);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 18;
            // 
            // dgRetrieve
            // 
            this.dgRetrieve.AllowUserToAddRows = false;
            this.dgRetrieve.AllowUserToDeleteRows = false;
            this.dgRetrieve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRetrieve.Location = new System.Drawing.Point(52, 229);
            this.dgRetrieve.Name = "dgRetrieve";
            this.dgRetrieve.ReadOnly = true;
            this.dgRetrieve.Size = new System.Drawing.Size(240, 150);
            this.dgRetrieve.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 318);
            this.Controls.Add(this.dgRetrieve);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxUpdateId);
            this.Controls.Add(this.comBoxUpdateGender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxUpdateName);
            this.Controls.Add(this.comBoxInsertGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxInsertName);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgRetrieve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox txtBoxInsertName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comBoxInsertGender;
        private System.Windows.Forms.ComboBox comBoxUpdateGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxUpdateName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxUpdateId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.DataGridView dgRetrieve;
    }
}

