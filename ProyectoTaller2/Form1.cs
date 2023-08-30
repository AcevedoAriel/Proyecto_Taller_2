namespace ProyectoTaller2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TUsuario.Text == "Admin" && TContraseña.Text == "123")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                LError.Visible = true;
                this.DialogResult = DialogResult.None;
            }
        }
    }
}