using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_4_Pembayaran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            grpCash.Enabled = false;
            grpKredit.Enabled = false;
        }

        private void txtPembelian_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back) e.Handled = false;
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtPembelian.Text.Trim() == "")
                    throw new Exception("Sorry, Nilai harga tidak boleh kosong . . . ");
                else if (!this.rdoCash.Checked && !this.rdoKredit.Checked)
                    throw new Exception("Sorry, Tombol cash atau kredit wajib di isi . . . ");
               
                
                else
                {
                    
                    //harga ini dikeluarkan dalam if biar si kredit msh bisa dipake karena harganya ga kekurung di dalam ruang cash
                    double harga = Convert.ToDouble(this.txtPembelian.Text); //ARTINYA SAYA MAU BAGIAN TEXTBOXPEMBELIAN DI ISIKAN KE VARIABLE BARU SAYA YANG BERNAMA "harga". JADI JIKA USER MENGINPUT NILAI DI TXTBOXPEMBELIAN MAKA AKAN OTOMATIS TERSIMPAN DI VARIABLE HARGA
                    
                    if (rdoCash.Checked)
                    {
                        if (this.txtDiskon.Text.Trim() != "") //JIKA TXTDISKON TIDAK KOSONG MAKA JALANKAN YANG DIBAWAHNYA
                        {   
                            //LOGIKA UNTUK HITUNG CASH

                            double diskon = Convert.ToDouble(this.txtDiskon.Text); //SAMA KAYAK YANG DI ATAS

                            //UNTUK MENAMPILKAN HASIL/HARGA PEMBELIAN KITA

                            double hasilNominalDiskon = harga * diskon / 100; // INI LOGIKA UNTUK HITUNG SAJA. NAMA hasilNominalDiskon BEBAS DIISI APA SAJA SESUAI DENGAN KEBUTUHAN KITA. INTINYA ITU SEBAGAI VARIABLE UNTUK MENYIMPAN HASIL HARGA KITA
                            lblNominalDiskon.Text = $"Rp {hasilNominalDiskon:n0}"; //.TEXT AGAR  BISA MENAMPILKAN HASILNYA. IBARATKAN SEPERTI PRINT

                            double totalHarga = harga - hasilNominalDiskon; // SAMA KAYAK DIATAS
                            lblTotalCash.Text = $"Rp {totalHarga:n0}";
                        }
                        else
                        {
                            throw new Exception("Sorry, Nilai diskon tidak boleh kosong . . . ");
                        }

                        
                    }

                    else if (rdoKredit.Checked)
                    {
                        if (this.txtJumlahCicilan.Text.Trim() != "")
                        {
                            //LOGIKA HITUNG KREDIT
                            double cicilan = Convert.ToDouble(this.txtJumlahCicilan.Text);
                            double hasilKredit = harga / cicilan;
                            lblBesaranCicilan.Text = $"Rp {hasilKredit:n0}";

                        }

                        else
                        {
                            throw new Exception("Sorry, Nilai cicilan tidak boleh kosong . . . ");
                        }
                    }
                }
            }
            catch (Exception ex) // bagian (ex) bebas kita isi apa. berguna sebagai penanda untuk messagenya
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtPembelian_TextChanged(object sender, EventArgs e)
        {
            if (this.txtPembelian.Text.Trim() != "") //JIKA TXTBOX PEMBELIANNYA TIDAK KOSONG FUNGSI DARI Trim() adalah untuk mengecek
            {
                if(double.TryParse(this.txtPembelian.Text, out double NILAI)) //MAKA JALANKAN INI. mengkonversi TXTPEMBELIAAN MENJADI TIPE DOUBLE DAN KEMUDIA DI SIMPAN DALAM VARIABLE BARU YANG BERNAMA NILAI
                {
                    this.txtPembelian.Text = $"{NILAI:n0}";
                    this.txtPembelian.SelectionStart = this.txtPembelian.TextLength;// AGAR SETELAH mengubah format teks (SEPERTI 1.000), kursor ditempatkan di akhir agar pengguna dapat melanjutkan mengetik tanpa harus menggulir ke posisi akhir secara manual.
                }
            }
            
        }

        private void rdoCash_CheckedChanged(object sender, EventArgs e)
        {
            grpKredit.Enabled = false;
            grpCash.Enabled = true;
        }

        private void rdoKredit_CheckedChanged(object sender, EventArgs e)
        {
            grpKredit.Enabled = true;
            grpCash.Enabled = false;
        }

        private void txtDiskon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                string textdiskon = txtDiskon.Text + e.KeyChar.ToString();
                if(int.TryParse(textdiskon, out int textdiskonrange))
                {
                    if (textdiskonrange <= 100)
                    {
                        e.Handled = false;
                    }
                    

                }
                if (e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                }
            }
        }
    }
}
