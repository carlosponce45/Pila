
namespace Pila
{
    public partial class Form1 : Form
    {
        Pila pila = new Pila();

        public Form1()
        {
            InitializeComponent();

            pila.Listar(lstPila);
        }

        private void cmdInsertar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDato.Text))
            {
                pila.Insertar(int.Parse(txtDato.Text));
                pila.Listar(lstPila);
                txtDato.Clear();
            }

        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pila.Eliminar());
            pila.Listar(lstPila);
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            if (pila.Buscar(int.Parse(txtDato.Text))) MessageBox.Show("El elemento existe");
            else MessageBox.Show("El elemento no existe");
        }
    }
}