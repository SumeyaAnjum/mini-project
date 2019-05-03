namespace WindowsFormsApplication1
{
    partial class advisor
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
            this.dataGridViewadvisor = new System.Windows.Forms.DataGridView();
            this.btnupdateadvsr = new System.Windows.Forms.Button();
            this.btndeleteadvsr = new System.Windows.Forms.Button();
            this.btnaddadvsr = new System.Windows.Forms.Button();
            this.combogender = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combodesignation = new System.Windows.Forms.ComboBox();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewadvisor)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewadvisor
            // 
            this.dataGridViewadvisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewadvisor.Location = new System.Drawing.Point(47, 222);
            this.dataGridViewadvisor.Name = "dataGridViewadvisor";
            this.dataGridViewadvisor.Size = new System.Drawing.Size(819, 255);
            this.dataGridViewadvisor.TabIndex = 43;
            this.dataGridViewadvisor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewadvisor_CellContentClick);
            this.dataGridViewadvisor.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewadvisor_RowHeaderMouseClick_1);
            // 
            // btnupdateadvsr
            // 
            this.btnupdateadvsr.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnupdateadvsr.Font = new System.Drawing.Font("Harrington", 14.25F);
            this.btnupdateadvsr.Location = new System.Drawing.Point(605, 3);
            this.btnupdateadvsr.Name = "btnupdateadvsr";
            this.btnupdateadvsr.Size = new System.Drawing.Size(105, 30);
            this.btnupdateadvsr.TabIndex = 42;
            this.btnupdateadvsr.Text = "Update Info";
            this.btnupdateadvsr.UseVisualStyleBackColor = false;
            this.btnupdateadvsr.Click += new System.EventHandler(this.btnupdateadvsr_Click);
            // 
            // btndeleteadvsr
            // 
            this.btndeleteadvsr.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btndeleteadvsr.Font = new System.Drawing.Font("Harrington", 14.25F);
            this.btndeleteadvsr.Location = new System.Drawing.Point(716, 3);
            this.btndeleteadvsr.Name = "btndeleteadvsr";
            this.btndeleteadvsr.Size = new System.Drawing.Size(100, 30);
            this.btndeleteadvsr.TabIndex = 41;
            this.btndeleteadvsr.Text = "Delete Info";
            this.btndeleteadvsr.UseVisualStyleBackColor = false;
            this.btndeleteadvsr.Click += new System.EventHandler(this.btndeleteadvsr_Click);
            // 
            // btnaddadvsr
            // 
            this.btnaddadvsr.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnaddadvsr.Font = new System.Drawing.Font("Harrington", 14.25F);
            this.btnaddadvsr.Location = new System.Drawing.Point(503, 3);
            this.btnaddadvsr.Name = "btnaddadvsr";
            this.btnaddadvsr.Size = new System.Drawing.Size(96, 30);
            this.btnaddadvsr.TabIndex = 38;
            this.btnaddadvsr.Text = "Add Info";
            this.btnaddadvsr.UseVisualStyleBackColor = false;
            this.btnaddadvsr.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // combogender
            // 
            this.combogender.FormattingEnabled = true;
            this.combogender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.combogender.Location = new System.Drawing.Point(640, 90);
            this.combogender.Name = "combogender";
            this.combogender.Size = new System.Drawing.Size(121, 21);
            this.combogender.TabIndex = 37;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(640, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 20);
            this.dateTimePicker1.TabIndex = 36;
            this.dateTimePicker1.Value = new System.DateTime(2019, 3, 13, 9, 58, 2, 0);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(222, 150);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 20);
            this.txtemail.TabIndex = 35;
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(222, 121);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(100, 20);
            this.txtcontact.TabIndex = 34;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(222, 95);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(100, 20);
            this.txtlastname.TabIndex = 33;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(222, 69);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(100, 20);
            this.txtfirstname.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(468, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Gender ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Date Of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Last Name ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, -50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 34);
            this.label2.TabIndex = 25;
            this.label2.Text = "Information";
            // 
            // combodesignation
            // 
            this.combodesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combodesignation.FormattingEnabled = true;
            this.combodesignation.Items.AddRange(new object[] {
            "Professor",
            "Associate Professor",
            "Assisstant Professor",
            "Lecturer",
            "Industry Professional"});
            this.combodesignation.Location = new System.Drawing.Point(637, 122);
            this.combodesignation.Name = "combodesignation";
            this.combodesignation.Size = new System.Drawing.Size(200, 21);
            this.combodesignation.TabIndex = 47;
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(637, 154);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(201, 20);
            this.txtsalary.TabIndex = 46;
            this.txtsalary.TextChanged += new System.EventHandler(this.txtsalary_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Designation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(468, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Salary";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Harrington", 14.25F);
            this.button1.Location = new System.Drawing.Point(721, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 30);
            this.button1.TabIndex = 48;
            this.button1.Text = "Back ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label10.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(294, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(276, 34);
            this.label10.TabIndex = 49;
            this.label10.Text = "Advisor Information";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btndeleteadvsr);
            this.flowLayoutPanel1.Controls.Add(this.btnupdateadvsr);
            this.flowLayoutPanel1.Controls.Add(this.btnaddadvsr);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(47, 180);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(819, 44);
            this.flowLayoutPanel1.TabIndex = 50;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(47, 483);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(819, 36);
            this.flowLayoutPanel2.TabIndex = 51;
            // 
            // advisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 525);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.combodesignation);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridViewadvisor);
            this.Controls.Add(this.combogender);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "advisor";
            this.Text = "advisor";
            this.Load += new System.EventHandler(this.advisor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewadvisor)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewadvisor;
        private System.Windows.Forms.Button btnupdateadvsr;
        private System.Windows.Forms.Button btndeleteadvsr;
        private System.Windows.Forms.Button btnaddadvsr;
        private System.Windows.Forms.ComboBox combogender;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combodesignation;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}