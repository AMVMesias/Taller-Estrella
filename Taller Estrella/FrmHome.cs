using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_Estrella
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

        }

        private void estrellaLineasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStar1 cuadrado = FrmStar1.GetInstance();
            //aqui le decimos que el formulario Home es el padre
            cuadrado.MdiParent = this;
            cuadrado.Show();
        }

        private void estrellaPrincipal_Click(object sender, EventArgs e)
        {
            FrmStar2 cuadrado = FrmStar2.GetInstance();
            //aqui le decimos que el formulario Home es el padre
            cuadrado.MdiParent = this;
            cuadrado.Show();
        }
    }
}
