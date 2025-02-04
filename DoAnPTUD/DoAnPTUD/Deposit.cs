using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPTUD
{

    public partial class Deposit : Form
    {
        public DTO_TaiKhoan use;
        public BLL_ChiTietGiaoDich giaoDich = new BLL_ChiTietGiaoDich();
        DTO_ThongTinKH b;


        public Deposit(DTO_TaiKhoan use)
        {
            InitializeComponent();
            cbSoTien.KeyPress += new KeyPressEventHandler(cbSoTien_KeyPress);

            this.use = use;
            txtSoTK.Text = use.IdTaiKhoan.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void Deposit_Load(object sender, EventArgs e)
        {

        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeUser us = new HomeUser(use, b);
            us.Show();
            this.Hide();

        }



        private void btnNap_Click_2(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(cbSoTien.Text))
            {
                if (giaoDich.timid(txtSoTK.Text.ToString()) == use.IdTaiKhoan)
                {
                    giaoDich.naptien(txtSoTK.Text, decimal.Parse(cbSoTien.Text));
                    MessageBox.Show("Nạp tiền Thành Công ", "Thông Báo", 0, MessageBoxIcon.Question);

                }
                else
                {
                    MessageBox.Show("Không lấy được số tài khoản của bạn vui lòng thử lại");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập số tiền cần nạp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbSoTien.Focus();
            }
        }

        private void cbSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Ngăn không cho nhập ký tự
                e.Handled = true;
            }
        }
    }
}
