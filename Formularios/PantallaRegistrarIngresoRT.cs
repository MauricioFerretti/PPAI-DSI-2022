using System.Windows.Forms;
using PPAI_DSI_2022.Negocio;

namespace PPAI_DSI_2022.Formularios
{
    public partial class PantallaRegistrarIngresoRT : Form
    {
        private GestorRegistrarIngresoRT gestorRegistrarIngresoRT  = new GestorRegistrarIngresoRT();
        public PantallaRegistrarIngresoRT()
        {
            InitializeComponent();
            this.seleccionarOpcionRegistrarIngresoRTEnMC();
        }

        public void seleccionarOpcionRegistrarIngresoRTEnMC()
        {
            habilitarPantalla();
            gestorRegistrarIngresoRT.tomarSeleccionRegristrarIngresoRTenMC();
        }

        public void habilitarPantalla()
        {
            this.Enabled = true;
        }

        private void groupBox1_Enter(object sender, System.EventArgs e)
        {

        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }
    }
}
