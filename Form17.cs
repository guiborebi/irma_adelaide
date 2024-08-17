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
    public partial class Form17 : Form
    {
        //Linha de baixo cria nova Thread (Tem que criar: using System.Threading)
        Thread t1;
        Thread t2;
        Thread t3;

        public Form17()
        {
            InitializeComponent();
            //Linha de baixo abre a janela Form maximizada
            this.WindowState = FormWindowState.Maximized;
        }

        private void anterior14_Click(object sender, EventArgs e)
        {
            //Configuração para abrir nova janela criando o comando "abrirjanela"
            this.Close();
            t2 = new Thread(anterior014);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }

        //Executando o comando "abrirjanela"
        private void anterior014(object obj)
        {
            Application.Run(new Form16());
        }

        private void voltar14_Click(object sender, EventArgs e)
        {
            //Configuração para abrir nova janela criando o comando "abrirjanela"
            this.Close();
            t1 = new Thread(voltar014);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        //Executando o comando "abrirjanela"
        private void voltar014(object obj)
        {
            Application.Run(new Form3());
        }

        private void proximo14_Click(object sender, EventArgs e)
        {
            //Configuração para abrir nova janela criando o comando "abrirjanela"
            this.Close();
            t3 = new Thread(proximo014);
            t3.SetApartmentState(ApartmentState.STA);
            t3.Start();
        }

        private void proximo014(object obj)
        {
            Application.Run(new Form18());
        }
    }
}
