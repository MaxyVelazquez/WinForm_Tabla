namespace WinFormsApp_Tabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            this.MuestraTabla();
        }

        private void MuestraTabla()
        {
            int n = Convert.ToInt32(this.textBoxNumero.Text);
            string tabla = "";
            for (int i = 1; i <= 10; i++)
            {
                tabla = tabla + n + "x" + i + "=" + (n * i) + "\n";
            }
            this.richTextBoxTabla.AppendText(tabla);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCommit_TextChanged(object sender, EventArgs e)
        {
            string commit = "commit";
            this.txtCommit.Text = commit;
        }
    }
}
