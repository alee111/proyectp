using System.Windows.Forms;

namespace por_ciento_de_descuento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTotal_Click(object sender, System.EventArgs e)
        {
            por_ciento_de_descuento p = new por_ciento_de_descuento();
            double precio, desc, total;
            double operacion = ((int)numPrecio.Value);
            lblResultado.Text = operacion.ToString();
        }
    }
}
