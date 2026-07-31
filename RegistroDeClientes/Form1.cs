namespace RegistroDeClientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int numero = 0;

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtTelefono.Text == "" || txtCorreo.Text == "")
            {
                MessageBox.Show("Por favor, llena todos los campos (Nombre, Teléfono y Correo).");
                return;
            }

            if (txtCorreo.Text.Contains("@") == false || txtCorreo.Text.Contains(".") == false)
            {
                MessageBox.Show("Por favor, escribe un correo electrónico válido");
                return;
            }

            long numeroTelefono = 0;

            if (txtTelefono.Text.Length < 9)
            {
                MessageBox.Show("Por favor escriba un numero de telefono de mínimo 9 digitos.");
                return;
            }
            else if (long.TryParse(txtTelefono.Text, out numeroTelefono) == false)
            {
                MessageBox.Show("Por favor, escribe un número de teléfono válido.");
                return;

            }

            numero += 1;
            string cliente = "Cliente No. " + numero + ": " + "Nombre: " + txtNombre.Text + " - Telefono: " + txtTelefono.Text + " - Correo: " + txtCorreo.Text;

            lstClientes.Items.Add(cliente);

            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        }

    }
}
