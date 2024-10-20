using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramPassword
{
    public partial class Form1 : Form
    {
        private const string MY_PASSWORD = "password";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lblCount.Text = $"{this.txtInput.TextLength}";
            this.btnMasuk.Enabled = false; 
            
        }
        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMasuk_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();  
            form.ShowDialog();
            this.Show();
            this.txtInput.Clear();
            btnValidasi.Enabled = true;
            btnMasuk.Enabled = false;
            lblKeterangan.Text = "";
            txtInput.Focus();
        }

        private void btnValidasi_Click(object sender, EventArgs e)
        {
            if (!this.txtInput.Text.Equals(""))
            {
                if (this.txtInput.Text.Equals(MY_PASSWORD))
                {
                    this.lblKeterangan.Text = "Password Benar";
                    this.lblKeterangan.ForeColor = Color.Green;
                    this.btnMasuk.Enabled = true ;
                    this.btnKeluar.Enabled = false;
                }
                else
                {
                    this.lblKeterangan.Text = "Password Salah ! Ulangi lagi!";
                    this.lblKeterangan.ForeColor = Color.Red;
                    
                }
            }
        }

        private void txtInput_Enter(object sender, EventArgs e)
        {
            txtInput.BackColor = Color.FromKnownColor(KnownColor.LightGreen);
        }

        private void txtInput_Leave(object sender, EventArgs e)
        {
            txtInput.BackColor = Color.FromKnownColor(KnownColor.Window);
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            lblCount.Text = $"{this.txtInput.TextLength}";
        }
    }
}
