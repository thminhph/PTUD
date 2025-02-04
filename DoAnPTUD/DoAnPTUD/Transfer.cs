using BLL;
using DoAnPTUD.Properties;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Media;

namespace DoAnPTUD
{
    public partial class Transfer : Form
    {
        int pos = 1;
        public DTO_TaiKhoan use;
        public DTO_ThongTinKH a;
        public DTO_ThongTinKH b = new DTO_ThongTinKH();
        public DTO_SoDuTk sd;
        public BLL_SoDuTk sdtk = new BLL_SoDuTk();
        public BLL_ChiTietGiaoDich giaoDich = new BLL_ChiTietGiaoDich();
        public DTO_ChiTietGiaoDich dich;
        public Transfer(DTO_TaiKhoan us, DTO_ThongTinKH th)
        {
            InitializeComponent();
            textBox1.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
            txtSoTien.KeyPress += new KeyPressEventHandler(txtSoTien_KeyPress);

            this.use = us;
            this.a = th;
        }

        private void lbTien_Click(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {

            if (btnXem.ImageIndex == 7)
            {
                btnXem.ImageIndex = 8;
                lbTien.Text = "   *******   ";
            }
            else
            {
                btnXem.ImageIndex = 7;
                //thay bảng dữ liệu database
                sd = sdtk.sodu(use.IdTaiKhoan.ToString());
                if (sd != null)
                {
                    lbTien.Text = sd.SoDuTK1.ToString("N") + use.TienTe.ToString();
                }
                else
                {
                    lbTien.Text = "0";
                }

            }
        }
        public void loaddata()
        {
            sd = sdtk.sodu(use.IdTaiKhoan.ToString());
            if (sd != null)
            {
                lbTien.Text = sd.SoDuTK1.ToString("N") + use.TienTe.ToString();
            }
            else
            {
                lbTien.Text = "0";
            }


        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            Bitmap the = new Bitmap(Resources.thenganhang);
            Bitmap tiet = new Bitmap(Resources.tietkiem);
            List<Bitmap> list = new List<Bitmap>();
            list.Add(the);
            list.Add(tiet);
            if (pos >= list.Count - 1)

            {
                pictureBox1.Image = list[pos++];
                pos = 0;
            }
            else
            {
                pictureBox1.Image = list[pos++];

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập số tài khoản!", "Thông báo");
            }
            else
            {
                a = giaoDich.tim(textBox1.Text);
                if (a != null)
                {
                    if (giaoDich.giaoDich(use.IdTaiKhoan.ToString(), textBox1.Text, decimal.Parse(txtSoTien.Text), rictxtDienGia.Text) == true)
                    {

                        DTO_ChiTietGiaoDich ich = new DTO_ChiTietGiaoDich(use.IdTaiKhoan, long.Parse(textBox1.Text), decimal.Parse(txtSoTien.Text), DateTime.Now, rictxtDienGia.Text);
                        TransferDetails transfer = new TransferDetails(use, ich, b);
                        MessageBox.Show("Giao Dịch Thành Công, ok để xem chi tiết giao dịch", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        {

                            transfer.WindowState = FormWindowState.Maximized;
                            transfer.TopLevel = false;
                            tableLayoutPanel1.Controls.Clear();
                            tableLayoutPanel1.Controls.Add(transfer);
                            tableLayoutPanel1.Tag = transfer;
                            transfer.BringToFront();
                            transfer.Show();
                        }


                    }

                }
                else
                {
                    if (giaoDich.giaoDichsdt(use.IdTaiKhoan.ToString(), textBox1.Text, decimal.Parse(txtSoTien.Text), rictxtDienGia.Text) == true)
                    {

                        DTO_ChiTietGiaoDich ich = new DTO_ChiTietGiaoDich(use.IdTaiKhoan, long.Parse(textBox1.Text), decimal.Parse(txtSoTien.Text), DateTime.Now, rictxtDienGia.Text);
                        TransferDetails transfer = new TransferDetails(use, ich,b);
                        MessageBox.Show("Giao Dịch Thành Công, ok để xem chi tiết giao dịch", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        {

                            transfer.WindowState = FormWindowState.Maximized;
                            transfer.TopLevel = false;
                            tableLayoutPanel1.Controls.Clear();
                            tableLayoutPanel1.Controls.Add(transfer);
                            tableLayoutPanel1.Tag = transfer;
                            transfer.BringToFront();
                            transfer.Show();
                        }

                    }
                    else
                    {
                        if (MessageBox.Show("số dư không đủ vui lòng kiểm tra lại hoặc bạn có muốn trở về trang chủ không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            panel4.Controls.Clear();
                            panel2.Controls.Clear();


                        }
                        else
                        {

                            txtSoTien.Clear();

                        }
                    }
                }

            }

        }

       
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString().Length == 10)
            {
                b = giaoDich.timsdt(textBox1.Text);
                if (textBox1.Text != a.SoDienThoai && b != null)
                {
                    txtSoTK.Text = b.TenKhachHang;
                }
                else
                {
                    MessageBox.Show("đây là số điện thoại của bạn vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox1.Clear();
                    txtSoTien.Clear();
                    txtSoTK.Clear();
                  
                }
            }
            else if (textBox1.Text.ToString().Length == 11)
            {
                b = giaoDich.tim(textBox1.Text);
                if (textBox1.Text != use.IdTaiKhoan.ToString() && b != null)
                {
                    txtSoTK.Text = b.TenKhachHang;

                }
                else
                {
                    MessageBox.Show("đây là số tài khoản của bạn vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox1.Clear();
                    txtSoTien.Clear();
                    txtSoTK.Clear();
                    
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại vui lòng kiểm tra lại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.Clear();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { 
                // Ngăn không cho nhập ký tự
                e.Handled = true; 
            }
            }

        private void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Ngăn không cho nhập ký tự
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



