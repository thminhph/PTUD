﻿using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace DoAnPTUD
{
    public partial class DangNhap : Form
    {
        public static DTO_TaiKhoan user;
        public DTO_ThongTinKH kh;
        private  BLL_TaiKhoan bll_taiKhoan  = new BLL_TaiKhoan();
        public DangNhap()
        {
            InitializeComponent();
            this.AcceptButton = btnDangNhap;
        }

 

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
        }

        
        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string txtDN = txtDangNhap.Text;
            string txtMK = txtMatKhau.Text;
            if (txtDN.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!"); ;
            }
            else if (txtMK.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!"); ;
            }


            if (txtDangNhap.Text == "admin" && txtMatKhau.Text == "123")
            {
                frm_Main frm_Main = new frm_Main();
                frm_Main.Show();
                this.Hide();
            }
            else
            {


                    var la = bll_taiKhoan.dangNhap(txtDangNhap.Text, txtMatKhau.Text);
                    //DTO_ThongTinKH use = bll_taiKhoan.ganthongtin(txtDN, txtMK);
                    if (la != null)
                    {
                        HomeUser us = new HomeUser(la,kh);
                        us.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mặt khẩu không đúng!!");
                    }
            }
        }
           
            //HomeUser.user = 
            //HomeUser  us=new HomeUser();
            //us.Show();
            //this.Hide();
        

        private void txtDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void lkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy us = new DangKy();
            us.Show();
            this.Hide();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            //string password = txtMatKhau.Text;
            if (btnHide.ImageIndex == 8)
            {
                btnHide.ImageIndex = 7;
                
                txtMatKhau.PasswordChar = '\0';
            }
            else
            {
                btnHide.ImageIndex = 8;
               
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
