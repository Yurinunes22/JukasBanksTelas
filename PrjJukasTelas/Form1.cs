using System.Windows.Forms;

namespace PrjJukasTelas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Mensagem;
        private void btnCriarAcesso_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(txtCpf.Text, out int res) == false)
            {
                Mensagem = "Digite Corretamente1";
                MessageBox.Show(Mensagem);
            }
            else if (int.TryParse(txtSenha.Text, out int res1) == false)
            {
                Mensagem = "Digite Corretamente2";
                MessageBox.Show(Mensagem);
            }

            else
            {
                Mensagem = "qqqqqqqqqqqqq";
                 MessageBox.Show(Mensagem); 
            }
            
        }
    }
}