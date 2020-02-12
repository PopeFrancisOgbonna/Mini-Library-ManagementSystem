namespace ECO_Dept
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnUpdateIn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtRemain = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReturned = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnSaveIn = new System.Windows.Forms.Button();
            this.btnClearIn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantityIn = new System.Windows.Forms.TextBox();
            this.txtItemIn = new System.Windows.Forms.TextBox();
            this.txtNameIn = new System.Windows.Forms.TextBox();
            this.txtServiceIn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturned = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateIn
            // 
            this.btnUpdateIn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnUpdateIn.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateIn.ForeColor = System.Drawing.Color.White;
            this.btnUpdateIn.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateIn.Image")));
            this.btnUpdateIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateIn.Location = new System.Drawing.Point(1057, 451);
            this.btnUpdateIn.Name = "btnUpdateIn";
            this.btnUpdateIn.Size = new System.Drawing.Size(121, 44);
            this.btnUpdateIn.TabIndex = 5;
            this.btnUpdateIn.Text = "Update";
            this.btnUpdateIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateIn.UseVisualStyleBackColor = false;
            this.btnUpdateIn.Visible = false;
            this.btnUpdateIn.Click += new System.EventHandler(this.btnUpdateIn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1195, 433);
            this.panel1.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(183, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(286, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Returned Manual Records";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(505, 6);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(682, 421);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtRemark);
            this.groupBox1.Controls.Add(this.txtRemain);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtReturned);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.btnSaveIn);
            this.groupBox1.Controls.Add(this.btnClearIn);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtQuantityIn);
            this.groupBox1.Controls.Add(this.txtItemIn);
            this.groupBox1.Controls.Add(this.txtNameIn);
            this.groupBox1.Controls.Add(this.txtServiceIn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(10, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 388);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personnel Detail";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Remarks";
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.Location = new System.Drawing.Point(178, 249);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(295, 75);
            this.txtRemark.TabIndex = 20;
            this.txtRemark.TextChanged += new System.EventHandler(this.txtRemark_TextChanged);
            // 
            // txtRemain
            // 
            this.txtRemain.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemain.Location = new System.Drawing.Point(178, 213);
            this.txtRemain.Name = "txtRemain";
            this.txtRemain.Size = new System.Drawing.Size(93, 30);
            this.txtRemain.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Qty Remanining";
            // 
            // txtReturned
            // 
            this.txtReturned.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturned.Location = new System.Drawing.Point(380, 174);
            this.txtReturned.Name = "txtReturned";
            this.txtReturned.Size = new System.Drawing.Size(93, 30);
            this.txtReturned.TabIndex = 17;
            this.txtReturned.TextChanged += new System.EventHandler(this.txtReturned_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Returned";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(103, 136);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(46, 30);
            this.txtID.TabIndex = 15;
            this.txtID.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(66, 140);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(34, 21);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
            // 
            // btnSaveIn
            // 
            this.btnSaveIn.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSaveIn.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveIn.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveIn.Image")));
            this.btnSaveIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveIn.Location = new System.Drawing.Point(194, 335);
            this.btnSaveIn.Name = "btnSaveIn";
            this.btnSaveIn.Size = new System.Drawing.Size(102, 43);
            this.btnSaveIn.TabIndex = 13;
            this.btnSaveIn.Text = "Save";
            this.btnSaveIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveIn.UseVisualStyleBackColor = false;
            this.btnSaveIn.Visible = false;
            this.btnSaveIn.Click += new System.EventHandler(this.btnSaveIn_Click);
            // 
            // btnClearIn
            // 
            this.btnClearIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearIn.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearIn.Location = new System.Drawing.Point(332, 330);
            this.btnClearIn.Name = "btnClearIn";
            this.btnClearIn.Size = new System.Drawing.Size(141, 43);
            this.btnClearIn.TabIndex = 12;
            this.btnClearIn.Text = "Clear Fields";
            this.btnClearIn.UseVisualStyleBackColor = true;
            this.btnClearIn.Visible = false;
            this.btnClearIn.Click += new System.EventHandler(this.btnClearIn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(324, 210);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 28);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date ";
            // 
            // txtQuantityIn
            // 
            this.txtQuantityIn.Enabled = false;
            this.txtQuantityIn.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantityIn.Location = new System.Drawing.Point(178, 174);
            this.txtQuantityIn.Name = "txtQuantityIn";
            this.txtQuantityIn.Size = new System.Drawing.Size(93, 30);
            this.txtQuantityIn.TabIndex = 8;
            // 
            // txtItemIn
            // 
            this.txtItemIn.Enabled = false;
            this.txtItemIn.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemIn.Location = new System.Drawing.Point(178, 96);
            this.txtItemIn.Multiline = true;
            this.txtItemIn.Name = "txtItemIn";
            this.txtItemIn.Size = new System.Drawing.Size(295, 70);
            this.txtItemIn.TabIndex = 7;
            // 
            // txtNameIn
            // 
            this.txtNameIn.Enabled = false;
            this.txtNameIn.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameIn.Location = new System.Drawing.Point(178, 62);
            this.txtNameIn.Name = "txtNameIn";
            this.txtNameIn.Size = new System.Drawing.Size(295, 30);
            this.txtNameIn.TabIndex = 6;
            // 
            // txtServiceIn
            // 
            this.txtServiceIn.Enabled = false;
            this.txtServiceIn.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceIn.Location = new System.Drawing.Point(178, 26);
            this.txtServiceIn.Name = "txtServiceIn";
            this.txtServiceIn.Size = new System.Drawing.Size(295, 30);
            this.txtServiceIn.TabIndex = 5;
            this.txtServiceIn.TextChanged += new System.EventHandler(this.txtService_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Items Collected";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity Collected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service No.";
            // 
            // btnReturned
            // 
            this.btnReturned.BackColor = System.Drawing.Color.Teal;
            this.btnReturned.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturned.ForeColor = System.Drawing.Color.White;
            this.btnReturned.Location = new System.Drawing.Point(710, 451);
            this.btnReturned.Name = "btnReturned";
            this.btnReturned.Size = new System.Drawing.Size(186, 44);
            this.btnReturned.TabIndex = 6;
            this.btnReturned.Text = "Returned Items";
            this.btnReturned.UseVisualStyleBackColor = false;
            this.btnReturned.Click += new System.EventHandler(this.btnReturned_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.BlueViolet;
            this.btnAdd.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(12, 346);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 36);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 507);
            this.Controls.Add(this.btnReturned);
            this.Controls.Add(this.btnUpdateIn);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1232, 546);
            this.MinimumSize = new System.Drawing.Size(1232, 546);
            this.Name = "SignIn";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SignIn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUpdateIn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnSaveIn;
        private System.Windows.Forms.Button btnClearIn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuantityIn;
        private System.Windows.Forms.TextBox txtItemIn;
        private System.Windows.Forms.TextBox txtNameIn;
        private System.Windows.Forms.TextBox txtServiceIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtRemain;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReturned;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnReturned;
        private System.Windows.Forms.Button btnAdd;
    }
}