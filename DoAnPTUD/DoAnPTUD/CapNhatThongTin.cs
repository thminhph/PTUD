﻿using BLL;
using BUS;
using DTO;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Interop;

namespace DoAnPTUD
{
    public partial class CapNhatThongTin : Form
    {
        DTO_ThongTinKH thongTinKH;
        DTO_TaiKhoan user;
        BLL_LoadValue bll_Load = new BLL_LoadValue();
        BLL_ThongTinKH bll_KH = new BLL_ThongTinKH();
        public BLL_TaiKhoan Tk = new BLL_TaiKhoan();

        public CapNhatThongTin(DTO_TaiKhoan user, DTO_ThongTinKH kh)
        {
            InitializeComponent();
            this.thongTinKH = kh;
            this.user = user;
        }

        //private void btnTroVe_Click(object sender, EventArgs e)
        //{
        //    Settings st = new Settings(user);
        //    st.Show();
        //    this.Hide();
        //}

        private void CapNhatThongTin_Load(object sender, EventArgs e)
        {
           
            DTO_ThongTinKH tt= thongTinKH;
            txtTenKH.Text = thongTinKH.TenKhachHang;
            txtEmail.Text = thongTinKH.Email;
            cboNganhChinh.DataSource = bll_Load.XemNganhChinh();
            cboNganhChinh.DisplayMember = "TenNganh";
            cboNganhChinh.ValueMember = "IdNganhChinh";
            cboNganhChinh.SelectedValue = thongTinKH.NganhChinh;
            cboIdNganh.DataSource = bll_Load.XemNganh(int.Parse(cboNganhChinh.SelectedValue.ToString()));
            cboIdNganh.DisplayMember = "TenNganh";
            cboIdNganh.ValueMember = "IdNganh";
            cboIdNganh.SelectedValue = thongTinKH.Nganh;

            if (thongTinKH.Avarta != null)
            {
                picBoxAvatar.Image = ByteArrayToImage(thongTinKH.Avarta);
                //Bitmap bitmap = new Bitmap(ms);
                //    picBoxAvatar.Image = bitmap;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cboNganhChinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNganhChinh.SelectedIndex != 0)
            {
                cboIdNganh.DataSource = bll_Load.XemNganh(int.Parse(cboNganhChinh.SelectedValue.ToString()));
            }
        }
 



        //private void btnXacNhan_Click(object sender, EventArgs e)
        //{
            
        //}

        private void picBoxAvatar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn tệp đã chọn
                    string filePath = openFileDialog.FileName;

                    // Chuyển đổi tệp ảnh thành Bitmap và hiển thị trong PictureBox
                    picBoxAvatar.Image = new Bitmap(filePath);
                }
            }
        }

        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            if (imageIn == null)
            {
                return new byte[0]; // Trả về mảng byte trống nếu không có dữ liệu
            }
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif); // Sử dụng định dạng GIF
                return ms.ToArray();
            }
        }

        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }

        private void btnXacNhan_Click_1(object sender, EventArgs e)
        {
            if (txtTenKH.Text != string.Empty && txtEmail.Text != string.Empty && !string.IsNullOrEmpty(cboIdNganh.Text) && !string.IsNullOrEmpty(cboNganhChinh.Text) )
            {
                
                if (picBoxAvatar.Image != null)
                {
                    thongTinKH.Avarta = ImageToByteArray(picBoxAvatar.Image);
                }
                thongTinKH.TenKhachHang = txtTenKH.Text;
                thongTinKH.Email = txtEmail.Text;
                thongTinKH.Nganh = int.Parse(cboIdNganh.SelectedValue.ToString());
                thongTinKH.NganhChinh = int.Parse(cboNganhChinh.SelectedValue.ToString());
                bll_KH.capnhat(thongTinKH);

                if (MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    HomeUser _user = new HomeUser(user, thongTinKH);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKH.Focus();
                //try
                //{
                //Them avatar vao doi tuong thong tin KH

                //}
                //catch (Exception ex)
                //{
                //    throw new Exception(ex.ToString());
                //}
            }
        }
            

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (email.EndsWith("@gmail.com"))
            {
                errorProvider1.SetError(txtEmail, string.Empty);
            }
            else
            {
                errorProvider1.SetError(txtEmail, "Email phải có đuôi '@gmail.com'.");
            }

        }

        private void cboIdNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNganhChinh.SelectedIndex != 0)
            {
                cboIdNganh.DataSource = bll_Load.XemNganh(int.Parse(cboNganhChinh.SelectedValue.ToString()));
            }
        }

        private void cboNganhChinh_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
