using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pertemuan03
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            else 
            { 
            decimal hargaBeli = Convert.ToDecimal(txtHarga.Text);
            int jumlahUnit = Convert.ToInt32(txtJumlah.Text);
            int potongan = Convert.ToInt32(txtPersen.Text);

            decimal total = hargaBeli * jumlahUnit;

            decimal nilaiPotongan = total * potongan / 100;
            decimal totalAkhir = total - nilaiPotongan;

            lblPotongan.Text = $"Rp {nilaiPotongan:n2}";
            lblKeterangan.Text = $"Besaran total dari pembelian anda adalah Rp{totalAkhir:n2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex)
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }
    }


}
