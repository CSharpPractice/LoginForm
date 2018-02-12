namespace LoginForm
{
    partial class categoAdd
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
            this.lstBxCategoryDisp = new System.Windows.Forms.ListBox();
            this.cmbCategoryList = new System.Windows.Forms.ComboBox();
            this.btnAddCatoryData = new System.Windows.Forms.Button();
            this.txtBxNewCategoryAdd = new System.Windows.Forms.TextBox();
            this.btnCloseReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBxCategoryDisp
            // 
            this.lstBxCategoryDisp.FormattingEnabled = true;
            this.lstBxCategoryDisp.ItemHeight = 15;
            this.lstBxCategoryDisp.Location = new System.Drawing.Point(281, 35);
            this.lstBxCategoryDisp.Name = "lstBxCategoryDisp";
            this.lstBxCategoryDisp.Size = new System.Drawing.Size(288, 139);
            this.lstBxCategoryDisp.TabIndex = 0;
            // 
            // cmbCategoryList
            // 
            this.cmbCategoryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryList.FormattingEnabled = true;
            this.cmbCategoryList.Location = new System.Drawing.Point(44, 35);
            this.cmbCategoryList.Name = "cmbCategoryList";
            this.cmbCategoryList.Size = new System.Drawing.Size(181, 23);
            this.cmbCategoryList.TabIndex = 1;
            this.cmbCategoryList.SelectionChangeCommitted += new System.EventHandler(this.cmbCategoryList_SelectionChangeCommitted);
            // 
            // btnAddCatoryData
            // 
            this.btnAddCatoryData.Location = new System.Drawing.Point(150, 90);
            this.btnAddCatoryData.Name = "btnAddCatoryData";
            this.btnAddCatoryData.Size = new System.Drawing.Size(75, 23);
            this.btnAddCatoryData.TabIndex = 2;
            this.btnAddCatoryData.Text = "Add";
            this.btnAddCatoryData.UseVisualStyleBackColor = true;
            this.btnAddCatoryData.Click += new System.EventHandler(this.btnAddCatoryData_Click);
            // 
            // txtBxNewCategoryAdd
            // 
            this.txtBxNewCategoryAdd.Location = new System.Drawing.Point(44, 88);
            this.txtBxNewCategoryAdd.Name = "txtBxNewCategoryAdd";
            this.txtBxNewCategoryAdd.Size = new System.Drawing.Size(100, 25);
            this.txtBxNewCategoryAdd.TabIndex = 3;
            // 
            // btnCloseReturn
            // 
            this.btnCloseReturn.Location = new System.Drawing.Point(494, 242);
            this.btnCloseReturn.Name = "btnCloseReturn";
            this.btnCloseReturn.Size = new System.Drawing.Size(75, 23);
            this.btnCloseReturn.TabIndex = 4;
            this.btnCloseReturn.Text = "Close";
            this.btnCloseReturn.UseVisualStyleBackColor = true;
            this.btnCloseReturn.Click += new System.EventHandler(this.btnCloseReturn_Click);
            // 
            // categoAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 298);
            this.Controls.Add(this.btnCloseReturn);
            this.Controls.Add(this.txtBxNewCategoryAdd);
            this.Controls.Add(this.btnAddCatoryData);
            this.Controls.Add(this.cmbCategoryList);
            this.Controls.Add(this.lstBxCategoryDisp);
            this.Name = "categoAdd";
            this.Text = "Category Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxCategoryDisp;
        private System.Windows.Forms.ComboBox cmbCategoryList;
        private System.Windows.Forms.Button btnAddCatoryData;
        private System.Windows.Forms.TextBox txtBxNewCategoryAdd;
        private System.Windows.Forms.Button btnCloseReturn;
    }
}