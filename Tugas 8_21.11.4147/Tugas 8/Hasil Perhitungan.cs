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
    public partial class HasilPerhitungan : Form
    {
        private IList<Operasi> listOfCalculator = new List<Operasi>();
        public HasilPerhitungan()
        {
            InitializeComponent();
        }

        private void HasilPerhitungan_OnCreate(Operasi cal)
        {
            listOfCalculator.Add(cal);
            lstHasil.Items.Add(cal.Hasil);
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            Calculator hitung = new Calculator("Calculator");
            hitung.OnCreate += HasilPerhitungan_OnCreate;
            hitung.ShowDialog();
        }

        private void lstHasil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
