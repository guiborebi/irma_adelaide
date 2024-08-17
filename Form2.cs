using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProjetoIrmaAdelaide
{
    public partial class Form2 : Form
    {
        //Linha de baixo cria nova Thread (Tem que criar: using System.Threading)
        Thread t1;

        public Form2()
        {
            InitializeComponent();
            //Linha de baixo abre a janela Form maximizada
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void imagem_creditos_Click(object sender, EventArgs e)
        {

        }

        private void imagem_logo_Click(object sender, EventArgs e)
        {

        }

        private void botao_voltar_Click(object sender, EventArgs e)
        {
            //Configuração para abrir nova janela criando o comando "abrirjanela"
            this.Close();
            t1 = new Thread(abrirjanelainicial);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        //Executando o comando "abrirjanela"
        private void abrirjanelainicial(object obj)
        {
            Application.Run(new Form3());
        }
    }
}
