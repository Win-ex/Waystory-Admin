using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugas_5_pizza
{
    public partial class Form1 : Form
    {
        string Ukuran = "";
        string Pinggiran = "";
        string Makan = "";
        List<string> Toppings = new List<string>();

        public Form1()
        {
            InitializeComponent();

        }
        public void CekTopping()
        {
            CheckBox[] checkbox = { chkExtraCheese, chkMushrooms, chkOnions, chkGreenPeppers, chkTomatoes, chkBlackOlives };
            for (int i = 0; i < checkbox.Length; i++)
            {
                if (checkbox[i].Checked)
                {
                    Toppings.Add(checkbox[i].Text);
                }

            }

            if(!Toppings.Any())
            {
                Toppings.Add("No Toppings");
            }
        }

        public void reset()
        {
            RadioButton[] radioButton = { rdoSmall, rdoMedium, rdoLarge, rdoSosis, rdoNugget, rdoKeju, rdoEatIn,rdoTakeOut };
            for (int i = 0; i < radioButton.Length; i++)
            {
                if (radioButton[i].Checked)
                {
                    radioButton[i].Checked = false;
                }
            }

            CheckBox[]checkbox = { chkExtraCheese,chkMushrooms, chkOnions,chkGreenPeppers,chkTomatoes,chkBlackOlives };
            for (int i = 0; i < checkbox.Length; i++)
            {
                if(checkbox[i].Checked)
                {
                    checkbox[i].Checked = false;
                }
            }

            lblOutput.Text = "";
            Ukuran = "";
            Pinggiran = "";
            Makan = "";
            Toppings.Clear();
        }
        

        private void rdoSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSmall.Checked)
            {
                Ukuran = "Small Pizza";
            }
            else if (rdoMedium.Checked)
            {
                Ukuran = "Medium Pizza";
            }
            else if(rdoLarge.Checked)
            {
                Ukuran = "Large Pizza";
            }
        }

        private void rdoKeju_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoKeju.Checked)
            {
                Pinggiran = "Keju";
            }
            else if(rdoSosis.Checked)
            {
                Pinggiran = "Sosis";
            }
            else if (rdoNugget.Checked)
            {
                Pinggiran = "Nugget";
            }
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            if (Ukuran != ""&&Pinggiran != "" && Makan !="")
            {
                Toppings.Clear();
                CekTopping();
                string toppingsText = string.Join("\n", Toppings); ;
                lblOutput.Text = "\n" +
                    $"Print Order {Makan}\n" +
                    $"-----------------------------------\n" +
                    $"Ukuran :{Ukuran}\n" +
                    $"Pinggiran :{Pinggiran}\n" +
                    $"-----------------------------------\n" +
                    $"Topping\n"+
                    $"{toppingsText}";
            }
            else
            {
                MessageBox.Show("Sorry bagian ukuran,pinggiran, dan Dine IN / Take Out harus di isi ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKosong_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void rdoEatIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoEatIn.Checked) 
            {
                Makan = "Eat In";
            }
            else 
            {
                Makan = "Take out";
            }
        }
    }
}
