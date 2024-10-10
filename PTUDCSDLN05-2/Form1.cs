using System;
using System.Windows.Forms;

namespace PTUDCSDLN05_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadDgvLoaiHang();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void loadDgvLoaiHang()
        {

            dgvLoaiHang.DataSource = Database.Query("SELECT * from LoaiHang");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Database.Execute("INSERT LoaiHang VALUES ('" + txtMaLoaiHang.Text + "', N'" + txtTenLoaiHang.Text + "')");
            loadDgvLoaiHang();
        }

        private void dgvLoaiHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLoaiHang.Text = dgvLoaiHang.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenLoaiHang.Text = dgvLoaiHang.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Database.Execute("DELETE LoaiHang WHERE MaLoaiHang = '" + dgvLoaiHang.CurrentRow.Cells[0].Value.ToString() + "'");
            loadDgvLoaiHang();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
           Database.Execute("UPDATE LoaiHang SET MaLoaiHang = '" + txtMaLoaiHang.Text + "', TenLoaiHang = N'" + txtTenLoaiHang.Text 
               + "' WHERE MaLoaiHang = '" + dgvLoaiHang.CurrentRow.Cells[0].Value.ToString() + "'");
            loadDgvLoaiHang();
          
        }

        private void txtMaLoaiHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTenLoaiHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}