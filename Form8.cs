using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIrmaAdelaide
{
    public partial class Form8 : Form
    {
        //Linha de baixo cria nova Thread (Tem que criar: using System.Threading)
        Thread t1;
        Thread t2;
        Thread t3;

        public Form8()
        {
            InitializeComponent();
            //Linha de baixo abre a janela Form maximizada
            this.WindowState = FormWindowState.Maximized;
        }

        private void voltar05_Click(object sender, EventArgs e)
        {
            //Configuração para abrir nova janela criando o comando "abrirjanela"
            this.Close();
            t1 = new Thread(voltar005);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        //Executando o comando "abrirjanela"
        private void voltar005(object obj)
        {
            Application.Run(new Form3());
        }

        private void anterior05_Click(object sender, EventArgs e)
        {
            //Configuração para abrir nova janela criando o comando "abrirjanela"
            this.Close();
            t2 = new Thread(anterior005);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }

        //Executando o comando "abrirjanela"
        private void anterior005(object obj)
        {
            Application.Run(new Form7());
        }

        private void proximo05_Click(object sender, EventArgs e)
        {
            //Configuração para abrir nova janela criando o comando "abrirjanela"
            this.Close();
            t3 = new Thread(proximo005);
            t3.SetApartmentState(ApartmentState.STA);
            t3.Start();
        }

        private void proximo005(object obj)
        {
            Application.Run(new Form9());
        }
    }
}
