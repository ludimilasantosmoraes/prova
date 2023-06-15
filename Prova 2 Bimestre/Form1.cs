namespace Prova_2_Bimestre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Impostos I = new Impostos();
            double valor = Convert.ToDouble(valorr.Text);
            double lucroo = Convert.ToDouble(lucro.Text);
            double piss = Convert.ToDouble(pis.Text);
            double icmss = Convert.ToDouble(icms.Text);
            double confinss = Convert.ToDouble(confins.Text);
            double pisss = Convert.ToDouble(pis.Text);
            string unidadee = Convert.ToString(unidade.Text);
           
            MessageBox.Show(I.CalcularImpostos().ToString());
            Resultado.Text = $"{I.CalcularImpostos().ToString("00.00")}";
        }
    }
}