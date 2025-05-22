using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figuras;

namespace Taller_Estrella
{
    public partial class FrmStar2 : Form
    {
        private static FrmStar2 _instance = null;
        private Star2 star; // Variable para la estrella

        public FrmStar2()
        {
            InitializeComponent();

            // Habilitar la captura de teclas a nivel de formulario
            this.KeyPreview = true;

            // Agregar el evento KeyDown para procesar las teclas
            this.KeyDown += FrmStar2_KeyDown;
        }

        public static FrmStar2 GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmStar2();
            }
            return _instance;
        }

        private void FrmStar2_Load(object sender, EventArgs e)
        {
            // Inicializar la estrella con un tamaño predeterminado
            star = new Star2(5.0f);

            // Configurar el trackBar
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 10;
            trackBar1.Value = 5;
            txt_val.Text = trackBar1.Value.ToString();

            // Asignar el evento Paint al PictureBox
            picCanvas.Paint += PicCanvas_Paint;

            // Primera actualización de la pantalla
            picCanvas.Invalidate();

            // Establecer el foco en el picCanvas para evitar que los botones
            // reciban el foco al iniciar la aplicación
            picCanvas.Focus();

            // Opcional: Hacer que el PictureBox pueda recibir el foco
            picCanvas.TabStop = true;
        }

        // Manejar eventos de teclado
        private void FrmStar2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    star.MoveUp();
                    picCanvas.Invalidate();
                    break;
                case Keys.Down:
                    star.MoveDown();
                    picCanvas.Invalidate();
                    break;
                case Keys.Left:
                    star.MoveLeft();
                    picCanvas.Invalidate();
                    break;
                case Keys.Right:
                    star.MoveRight();
                    picCanvas.Invalidate();
                    break;
            }

            // Marcar el evento como manejado para evitar que se propague
            e.Handled = true;
        }

        private void PicCanvas_Paint(object sender, PaintEventArgs e)
        {
            // Dibujar la estrella en el PictureBox
            if (star != null)
                star.PlotShape(e, picCanvas);
        }

        private void btnTurnLeft_Click(object sender, EventArgs e)
        {
            // Rotar la estrella a la izquierda
            star.Rotate(-15);

            // Actualizar el canvas
            picCanvas.Invalidate();

            // Devolver el foco al PictureBox
            picCanvas.Focus();
        }

        private void btnTurnRigth_Click(object sender, EventArgs e)
        {
            // Rotar la estrella a la derecha
            star.Rotate(15);

            // Actualizar el canvas
            picCanvas.Invalidate();

            // Devolver el foco al PictureBox
            picCanvas.Focus();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // Actualizar el tamaño de la estrella según el valor del trackBar
            star = new Star2(trackBar1.Value);

            // Actualizar el textbox con el valor actual
            txt_val.Text = trackBar1.Value.ToString();

            // Actualizar el canvas
            picCanvas.Invalidate();

            // Devolver el foco al PictureBox
            picCanvas.Focus();
        }
    }
}
