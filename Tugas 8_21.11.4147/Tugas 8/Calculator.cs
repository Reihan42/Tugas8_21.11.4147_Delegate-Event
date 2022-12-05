using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_8
{
    public partial class Calculator : Form
    {
        public delegate void CreateUpdateEventHandler(Operasi cal);

        public event CreateUpdateEventHandler OnCreate;

        private bool isNewData = true;

        private Operasi cal;
        public Calculator()
        {
            InitializeComponent();
        }

        public Calculator(string title) : this()
        {
            this.Text = title;
        }

        private void cmbOperasi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }        

        private void btnProses_Click(object sender, EventArgs e)
        {
            if (isNewData) cal = new Operasi();
            if (txtNilaiA.Text == "" || txtNilaiB.Text == "")
            {
                MessageBox.Show("Data belum diisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNilaiA.Focus();
            }
            else if (cmbOperasi.Text == "")
            {
                MessageBox.Show("Pilih Operasi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbOperasi.Focus();
            }
            else
            {
                if (cmbOperasi.Text == "Penjumlahan")
                {
                    cal.Hasil = "Hasil Penjumlahan " + txtNilaiA.Text + " + " + txtNilaiB.Text + " = " + ( int.Parse(txtNilaiA.Text) + int.Parse(txtNilaiB.Text) );
                }
                else if (cmbOperasi.Text == "Pengurangan")
                {
                    cal.Hasil = "Hasil Pengurangan " + txtNilaiA.Text + " - " + txtNilaiB.Text + " = " + ( int.Parse(txtNilaiA.Text) - int.Parse(txtNilaiB.Text) );
                }
                else if (cmbOperasi.Text == "Perkalian")
                {
                    cal.Hasil = "Hasil Perkalian " + txtNilaiA.Text + " * " + txtNilaiB.Text + " = " + ( int.Parse(txtNilaiA.Text) * int.Parse(txtNilaiB.Text));
                }
                else if (cmbOperasi.Text == "Pembagian")
                {
                    cal.Hasil = "Hasil Pembagian " + txtNilaiA.Text + " / " + txtNilaiB.Text + " = " + ( Convert.ToDouble(txtNilaiA.Text) / Convert.ToDouble(txtNilaiB.Text));
                }
                if (isNewData) 
                {
                    OnCreate(cal);
                }
                else 
                {
                    this.Close();
                }
            }
        }
    }
}
