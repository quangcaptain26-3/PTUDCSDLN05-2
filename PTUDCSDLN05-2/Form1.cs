using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
