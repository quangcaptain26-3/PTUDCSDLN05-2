namespace PTUDCSDLN05_2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLoaiHang = new System.Windows.Forms.DataGridView();
            this.colMaLoaiHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLoaiHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLoaiHang = new System.Windows.Forms.TextBox();
            this.txtTenLoaiHang = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoaiHang
            // 
            this.dgvLoaiHang.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvLoaiHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoaiHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLoaiHang,
            this.colTenLoaiHang});
            this.dgvLoaiHang.Location = new System.Drawing.Point(59, 297);
            this.dgvLoaiHang.Name = "dgvLoaiHang";
            this.dgvLoaiHang.ReadOnly = true;
            this.dgvLoaiHang.RowHeadersWidth = 51;
            this.dgvLoaiHang.RowTemplate.Height = 24;
            this.dgvLoaiHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiHang.Size = new System.Drawing.Size(734, 244);
            this.dgvLoaiHang.TabIndex = 0;
            this.dgvLoaiHang.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiHang_RowEnter);
            // 
            // colMaLoaiHang
            // 
            this.colMaLoaiHang.DataPropertyName = "MaLoaiHang";
            this.colMaLoaiHang.HeaderText = "Mã Loại Hàng";
            this.colMaLoaiHang.MinimumWidth = 6;
            this.colMaLoaiHang.Name = "colMaLoaiHang";
            this.colMaLoaiHang.ReadOnly = true;
            this.colMaLoaiHang.Width = 125;
            // 
            // colTenLoaiHang
            // 
            this.colTenLoaiHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenLoaiHang.DataPropertyName = "TenLoaiHang";
            this.colTenLoaiHang.HeaderText = "Tên Loại Hàng";
            this.colTenLoaiHang.MinimumWidth = 6;
            this.colTenLoaiHang.Name = "colTenLoaiHang";
            this.colTenLoaiHang.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã loại hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên hàng";
            // 
            // txtMaLoaiHang
            // 
            this.txtMaLoaiHang.Location = new System.Drawing.Point(146, 51);
            this.txtMaLoaiHang.Name = "txtMaLoaiHang";
            this.txtMaLoaiHang.Size = new System.Drawing.Size(219, 22);
            this.txtMaLoaiHang.TabIndex = 3;
            // 
            // txtTenLoaiHang
            // 
            this.txtTenLoaiHang.Location = new System.Drawing.Point(146, 159);
            this.txtTenLoaiHang.Name = "txtTenLoaiHang";
            this.txtTenLoaiHang.Size = new System.Drawing.Size(219, 22);
            this.txtTenLoaiHang.TabIndex = 4;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(57, 222);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(112, 41);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(220, 222);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(112, 41);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Xoá";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(386, 222);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(112, 41);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Sửa";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 568);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txtTenLoaiHang);
            this.Controls.Add(this.txtMaLoaiHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLoaiHang);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoaiHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaLoaiHang;
        private System.Windows.Forms.TextBox txtTenLoaiHang;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLoaiHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoaiHang;
    }
}

