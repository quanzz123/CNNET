
namespace CNNET
{
    partial class frmCategory
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
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExits = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên loại sách (*):";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(137, 61);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(180, 22);
            this.txtCategoryName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(137, 126);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(368, 126);
            this.txtDescription.TabIndex = 1;
            // 
            // dgvCategory
            // 
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(580, 34);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.RowHeadersWidth = 51;
            this.dgvCategory.RowTemplate.Height = 24;
            this.dgvCategory.Size = new System.Drawing.Size(605, 380);
            this.dgvCategory.TabIndex = 2;
            this.dgvCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvCategory.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_RowEnter);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(38, 310);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(82, 37);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.Text = "Thêm mới";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.Location = new System.Drawing.Point(207, 310);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(82, 37);
            this.BtnSua.TabIndex = 3;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(389, 310);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 37);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(38, 385);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(82, 37);
            this.btnGhi.TabIndex = 3;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(207, 385);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 37);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExits
            // 
            this.btnExits.Location = new System.Drawing.Point(389, 385);
            this.btnExits.Name = "btnExits";
            this.btnExits.Size = new System.Drawing.Size(82, 37);
            this.btnExits.TabIndex = 3;
            this.btnExits.Text = "Thoát";
            this.btnExits.UseVisualStyleBackColor = true;
            this.btnExits.Click += new System.EventHandler(this.btnExits_Click);
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 450);
            this.Controls.Add(this.btnExits);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.BtnSua);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.dgvCategory);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.label1);
            this.Name = "frmCategory";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExits;
    }
}

