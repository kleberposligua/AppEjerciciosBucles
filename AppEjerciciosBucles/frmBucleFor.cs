using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEjerciciosBucles
{
    public partial class frmBucleFor : Form
    {
        public frmBucleFor()
        {
            InitializeComponent();
        }

        private void btnLlenarLista_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            this.lstNumeros.Sorted = false;
            this.lstNumeros.Items.Clear(); //vaciar la lista
            for (int i=0; i<10; i++)
            {
                int num = r.Next(0, 9);
                this.lstNumeros.Items.Add(num);
            }

        }

        private void btnOrdenarLista_Click(object sender, EventArgs e)
        {
            this.lstNumeros.Sorted = true;
        }
    }
}
