namespace WindowsFormsApplication1
{
    partial class Group_Project
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
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerassignmentdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewgroupproject = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.dateTimePickercreatedon = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprojectname = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewgroupproject)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Group Project";
            // 
            // dateTimePickerassignmentdate
            // 
            this.dateTimePickerassignmentdate.Location = new System.Drawing.Point(151, 85);
            this.dateTimePickerassignmentdate.Name = "dateTimePickerassignmentdate";
            this.dateTimePickerassignmentdate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerassignmentdate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Assignment Date";
            // 
            // dataGridViewgroupproject
            // 
            this.dataGridViewgroupproject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewgroupproject.Location = new System.Drawing.Point(102, 211);
            this.dataGridViewgroupproject.Name = "dataGridViewgroupproject";
            this.dataGridViewgroupproject.Size = new System.Drawing.Size(441, 150);
            this.dataGridViewgroupproject.TabIndex = 8;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(376, 381);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePickercreatedon
            // 
            this.dateTimePickercreatedon.Location = new System.Drawing.Point(151, 108);
            this.dateTimePickercreatedon.Name = "dateTimePickercreatedon";
            this.dateTimePickercreatedon.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickercreatedon.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Created On";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Title";
            // 
            // txtprojectname
            // 
            this.txtprojectname.Location = new System.Drawing.Point(151, 134);
            this.txtprojectname.Name = "txtprojectname";
            this.txtprojectname.Size = new System.Drawing.Size(200, 20);
            this.txtprojectname.TabIndex = 13;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(468, 381);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 15;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Group_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 431);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtprojectname);
            this.Controls.Add(this.dateTimePickercreatedon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dataGridViewgroupproject);
            this.Controls.Add(this.dateTimePickerassignmentdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "Group_Project";
            this.Text = "Group_Project";
            this.Load += new System.EventHandler(this.Group_Project_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewgroupproject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerassignmentdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewgroupproject;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DateTimePicker dateTimePickercreatedon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtprojectname;
        private System.Windows.Forms.Button btnback;
    }
}