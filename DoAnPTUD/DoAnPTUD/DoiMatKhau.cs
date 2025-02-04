using BLL;
using DAL;
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
    public partial class DoiMatKhau : Form
    {
        BLL_ThongTinKH bll_ThongTinKH = new BLL_ThongTinKH();
        BLL_TaiKhoan bll_TaiKhoan = new BLL_TaiKhoan();
        private DTO_TaiKhoan tk;
        public DoiMatKhau(DTO_TaiKhoan tk)
        {
            InitializeComponent();
            this.tk = tk;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Settings st = new Settings();
            st.Show();
            this.Hide();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string mk_old = txtMatKhauCu.Text;
            string mk = txtMatKhau.Text;
            string mk_confirm = txtNhapLaiMatKhau.Text;

            if (txtMatKhauCu.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được để trống!");
            }
            else if (txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu cũ không được để trống!");
            }
            else if (txtNhapLaiMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Nhập lại mật khẩu mới không được để trống!");
            }
            else
            {
                bool kTra = kiemTraMatKhau(mk_old);
                if (kTra)
                {
                    if (mk_confirm != mk)
                    {
                        MessageBox.Show("Mật khẩu mới không khớp!");
                    }
                    else
                    {
                        bll_TaiKhoan.SuaMK(mk,tk.IdTaiKhoan.ToString());
                        MessageBox.Show("Sủa thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ sai. Vui lòng nhập lại!");
                }
            }
        }
        private bool IsPasswordValid(string password)
        { // Kiểm tra xem mật khẩu có chứa ít nhất một chữ in hoa, một số và một ký tự đặc biệt
            bool hasUpperCase = password.Any(char.IsUpper);
            bool hasDigit = password.Any(char.IsDigit);
            bool hasSpecialChar = password.Any(ch => !char.IsLetterOrDigit(ch));
            return hasUpperCase && hasDigit && hasSpecialChar;
        }
        private bool kiemTraMatKhau(string mkCu)
        {
            var th= tk;
            return tk.Matkhau.Trim()==mkCu.Trim();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            string password = txtMatKhau.Text;
            txtMatKhau.PasswordChar = '*';
            if (IsPasswordValid(password))
            {
                errorProvider1.SetError(txtMatKhau, string.Empty);
            }
            else
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu phải chứa ít nhất một chữ in hoa, một số và một ký tự đặc biệt.");
            }
        }

        private void txtNhapLaiMatKhau_TextChanged(object sender, EventArgs e)
        {
            string password = txtNhapLaiMatKhau.Text;
            txtNhapLaiMatKhau.PasswordChar = '*';
            if (IsPasswordValid(password))
            {
                errorProvider1.SetError(txtNhapLaiMatKhau, string.Empty);
            }
            else
            {
                errorProvider1.SetError(txtNhapLaiMatKhau, "Mật khẩu phải chứa ít nhất một chữ in hoa, một số và một ký tự đặc biệt.");
            }
        }

        private void txtMatKhauCu_TextChanged(object sender, EventArgs e)
        {
            string password = txtMatKhauCu.Text;
            txtMatKhauCu.PasswordChar = '*';
        }
    }
}
