using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Reutilizacion
{
    public partial class PDF_Reader : Form
    {
        public PDF_Reader()
        {
            InitializeComponent();

        }

        private void btn_abrirPDF_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    axAcroPDF1.src = ofd.FileName;
                }
            }
        }

       
    }
}
