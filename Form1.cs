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
    public partial class Form1 : Form
    {
        //Linha de baixo cria nova Thread (Tem que criar: using System.Threading)
        Thread t1;

        public Form1()
        {
            InitializeComponent();
            //Linha de baixo abre a janela Form maximizada
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void imagem_titulo_Click(object sender, EventArgs e)
        {

        }

        private void botao_acessar_Click(object sender, EventArgs e)
        {
            //Configuração para abrir nova janela criando o comando "abrirjanela"
            this.Close();
            t1 = new Thread(abrirjanelaindice);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirjanelaindice(object obj)
        {
            Application.Run(new Form3());
        }
    }
}