namespace WindowsFormsApplication1
{
    partial class Project_Advisor
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
            this.lbladvxr = new System.Windows.Forms.Label();
            this.lblassignmentdate = new System.Windows.Forms.Label();
            this.comborole = new System.Windows.Forms.ComboBox();
            this.dateTimePickerasgnmnt = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewprojectadvisor = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewprojectadvisor)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Project Advisor";
            // 
            // lbladvxr
            // 
            this.lbladvxr.AutoSize = true;
            this.lbladvxr.Location = new System.Drawing.Point(65, 100);
            this.lbladvxr.Name = "lbladvxr";
            this.lbladvxr.Size = new System.Drawing.Size(67, 13);
            this.lbladvxr.TabIndex = 6;
            this.lbladvxr.Text = "Advisor Role";
            // 
            // lblassignmentdate
            // 
            this.lblassignmentdate.AutoSize = true;
            this.lblassignmentdate.Location = new System.Drawing.Point(65, 135);
            this.lblassignmentdate.Name = "lblassignmentdate";
            this.lblassignmentdate.Size = new System.Drawing.Size(87, 13);
            this.lblassignmentdate.TabIndex = 7;
            this.lblassignmentdate.Text = "Assignment Date";
            // 
            // comborole
            // 
            this.comborole.FormattingEnabled = true;
            this.comborole.Items.AddRange(new object[] {
            "Industry Advisor",
            "Main Advisor",
            "Co-Advisror"});
            this.comborole.Location = new System.Drawing.Point(168, 97);
            this.comborole.Name = "comborole";
            this.comborole.Size = new System.Drawing.Size(121, 21);
            this.comborole.TabIndex = 8;
            // 
            // dateTimePickerasgnmnt
            // 
            this.dateTimePickerasgnmnt.Location = new System.Drawing.Point(168, 129);
            this.dateTimePickerasgnmnt.Name = "dateTimePickerasgnmnt";
            this.dateTimePickerasgnmnt.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerasgnmnt.TabIndex = 9;
            // 
            // dataGridViewprojectadvisor
            // 
            this.dataGridViewprojectadvisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewprojectadvisor.Location = new System.Drawing.Point(68, 171);
            this.dataGridViewprojectadvisor.Name = "dataGridViewprojectadvisor";
            this.dataGridViewprojectadvisor.Size = new System.Drawing.Size(502, 200);
            this.dataGridViewprojectadvisor.TabIndex = 10;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(414, 377);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(495, 377);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 12;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Project_Advisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 410);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dataGridViewprojectadvisor);
            this.Controls.Add(this.dateTimePickerasgnmnt);
            this.Controls.Add(this.comborole);
            this.Controls.Add(this.lblassignmentdate);
            this.Controls.Add(this.lbladvxr);
            this.Controls.Add(this.label2);
            this.Name = "Project_Advisor";
            this.Text = "Project_Advisor";
            this.Load += new System.EventHandler(this.Project_Advisor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewprojectadvisor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbladvxr;
        private System.Windows.Forms.Label lblassignmentdate;
        private System.Windows.Forms.ComboBox comborole;
        private System.Windows.Forms.DateTimePicker dateTimePickerasgnmnt;
        private System.Windows.Forms.DataGridView dataGridViewprojectadvisor;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnback;
    }
}