namespace LoginForm
{
    partial class employeeSrch
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSrch = new System.Windows.Forms.Button();
            this.cmbBxSrch = new System.Windows.Forms.ComboBox();
            this.txtBxSrch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(950, 347);
            this.dataGridView1.TabIndex = 38;
            // 
            // btnSrch
            // 
            this.btnSrch.Location = new System.Drawing.Point(626, 21);
            this.btnSrch.Name = "btnSrch";
            this.btnSrch.Size = new System.Drawing.Size(75, 23);
            this.btnSrch.TabIndex = 34;
            this.btnSrch.Text = "Search";
            this.btnSrch.UseVisualStyleBackColor = true;
            this.btnSrch.Click += new System.EventHandler(this.btnSrch_Click);
            // 
            // cmbBxSrch
            // 
            this.cmbBxSrch.FormattingEnabled = true;
            this.cmbBxSrch.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Company"});
            this.cmbBxSrch.Location = new System.Drawing.Point(488, 21);
            this.cmbBxSrch.Name = "cmbBxSrch";
            this.cmbBxSrch.Size = new System.Drawing.Size(121, 23);
            this.cmbBxSrch.TabIndex = 33;
            // 
            // txtBxSrch
            // 
            this.txtBxSrch.Location = new System.Drawing.Point(127, 21);
            this.txtBxSrch.Name = "txtBxSrch";
            this.txtBxSrch.Size = new System.Drawing.Size(343, 25);
            this.txtBxSrch.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 31;
            this.label9.Text = "Search";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(LoginForm.BizContacts);
            // 
            // employeeSrch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1012, 419);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSrch);
            this.Controls.Add(this.cmbBxSrch);
            this.Controls.Add(this.txtBxSrch);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "employeeSrch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shipped Product Search - Employee";
            this.Load += new System.EventHandler(this.employeeSrch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSrch;
        private System.Windows.Forms.ComboBox cmbBxSrch;
        private System.Windows.Forms.TextBox txtBxSrch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}