using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vietlot
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            String numberPhone = txtPhone.Text;
            if(numberPhone.Length <0 && numberPhone[0].Equals(0) == false)
            {
                MessageBox.Show("Không phải là số điện thoại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '•';
        }

        private void txtPassAgain_TextChanged(object sender, EventArgs e)
        {
            txtPassAgain.PasswordChar = '•';
            string pass = txtPass.Text;
            if(pass != txtPassAgain.Text)
            {
                //txtPassAgain.BackColor = Color.Red;
                txtPassAgain.BackColor = SystemColors.Window;

            }
            else
            {
            }
        }

        private void btnDKy_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            this.Hide();
            frmLogin.ShowDialog();
            this.Close();
        }
    }
}
