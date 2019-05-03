namespace WindowsFormsApplication1
{
    partial class Evaluation
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
            this.txttotalweightage = new System.Windows.Forms.TextBox();
            this.txttotalmarks = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DataGridViewevaluations = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnupdateevaluation = new System.Windows.Forms.Button();
            this.btndeleteevaluation = new System.Windows.Forms.Button();
            this.btnaddevaluation = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewevaluations)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Evaluation";
            // 
            // txttotalweightage
            // 
            this.txttotalweightage.Location = new System.Drawing.Point(202, 149);
            this.txttotalweightage.Name = "txttotalweightage";
            this.txttotalweightage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txttotalweightage.Size = new System.Drawing.Size(100, 20);
            this.txttotalweightage.TabIndex = 42;
            // 
            // txttotalmarks
            // 
            this.txttotalmarks.Location = new System.Drawing.Point(202, 123);
            this.txttotalmarks.Name = "txttotalmarks";
            this.txttotalmarks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txttotalmarks.Size = new System.Drawing.Size(100, 20);
            this.txttotalmarks.TabIndex = 41;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(202, 97);
            this.txtname.Name = "txtname";
            this.txtname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 149);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Total Weightage ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 123);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Total Marks ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 97);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DataGridViewevaluations
            // 
            this.DataGridViewevaluations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewevaluations.Location = new System.Drawing.Point(33, 216);
            this.DataGridViewevaluations.Name = "DataGridViewevaluations";
            this.DataGridViewevaluations.Size = new System.Drawing.Size(614, 249);
            this.DataGridViewevaluations.TabIndex = 44;
            this.DataGridViewevaluations.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewevauations_RowHeaderMouseClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Harrington", 14.25F);
            this.button1.Location = new System.Drawing.Point(640, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 34);
            this.button1.TabIndex = 52;
            this.button1.Text = "Back ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnupdateevaluation
            // 
            this.btnupdateevaluation.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnupdateevaluation.Font = new System.Drawing.Font("Harrington", 14.25F);
            this.btnupdateevaluation.Location = new System.Drawing.Point(424, 3);
            this.btnupdateevaluation.Name = "btnupdateevaluation";
            this.btnupdateevaluation.Size = new System.Drawing.Size(91, 36);
            this.btnupdateevaluation.TabIndex = 51;
            this.btnupdateevaluation.Text = "Update Info";
            this.btnupdateevaluation.UseVisualStyleBackColor = false;
            this.btnupdateevaluation.Click += new System.EventHandler(this.btnupdateevaluation_Click);
            // 
            // btndeleteevaluation
            // 
            this.btndeleteevaluation.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btndeleteevaluation.Font = new System.Drawing.Font("Harrington", 14.25F);
            this.btndeleteevaluation.Location = new System.Drawing.Point(521, 3);
            this.btndeleteevaluation.Name = "btndeleteevaluation";
            this.btndeleteevaluation.Size = new System.Drawing.Size(90, 36);
            this.btndeleteevaluation.TabIndex = 50;
            this.btndeleteevaluation.Text = "Delete Info";
            this.btndeleteevaluation.UseVisualStyleBackColor = false;
            this.btndeleteevaluation.Click += new System.EventHandler(this.btndeleteevaluation_Click);
            // 
            // btnaddevaluation
            // 
            this.btnaddevaluation.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnaddevaluation.Font = new System.Drawing.Font("Harrington", 14.25F);
            this.btnaddevaluation.Location = new System.Drawing.Point(332, 3);
            this.btnaddevaluation.Name = "btnaddevaluation";
            this.btnaddevaluation.Size = new System.Drawing.Size(86, 32);
            this.btnaddevaluation.TabIndex = 49;
            this.btnaddevaluation.Text = "Add Info";
            this.btnaddevaluation.UseVisualStyleBackColor = false;
            this.btnaddevaluation.Click += new System.EventHandler(this.btnaddadvsr_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 471);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(737, 38);
            this.flowLayoutPanel1.TabIndex = 53;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btndeleteevaluation);
            this.flowLayoutPanel2.Controls.Add(this.btnupdateevaluation);
            this.flowLayoutPanel2.Controls.Add(this.btnaddevaluation);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(33, 174);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(614, 42);
            this.flowLayoutPanel2.TabIndex = 54;
            // 
            // Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 509);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.DataGridViewevaluations);
            this.Controls.Add(this.txttotalweightage);
            this.Controls.Add(this.txttotalmarks);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Evaluation";
            this.Text = "Evaluation";
            this.Load += new System.EventHandler(this.Evaluation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewevaluations)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttotalweightage;
        private System.Windows.Forms.TextBox txttotalmarks;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DataGridViewevaluations;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnupdateevaluation;
        private System.Windows.Forms.Button btndeleteevaluation;
        private System.Windows.Forms.Button btnaddevaluation;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}