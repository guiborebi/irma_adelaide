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
    public partial class Form10 : Form
    {
        //Linha de baixo cria nova Thread (Tem que criar: using System.Threading)
        Thread t1;
        Thread t2;
        Thread t3;

        public Form10()
        {
            InitializeComponent();
            //Linha de baixo abre a janela Form maximizada
            this.WindowState = FormWindowState.Maximized;
        }

        private void voltar07_Click(object sender, EventArgs e)
        {
            //Configuração para abrir nova janela criando o comando "abrirjanela"
            this.Close();
            t1 = new Thread(voltar007);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        //Executando o comando "abrirjanela"
        private void voltar007(object obj)
        {
            Application.Run(new Form3());
        }

        private void anterior07_Click(object sender, EventArgs e)
        {
            //Configuração para abrir nova janela criando o comando "abrirjanela"
            this.Close();
            t2 = new Thread(anterior007);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }

        //Executando o comando "abrirjanela"
        private void anterior007(object obj)
        {
            Application.Run(new Form9());
        }

        private void proximo07_Click(object sender, EventArgs e)
        {
            //Configuração para abrir nova janela criando o comando "abrirjanela"
            this.Close();
            t3 = new Thread(proximo007);
            t3.SetApartmentState(ApartmentState.STA);
            t3.Start();
        }

        private void proximo007(object obj)
        {
            Application.Run(new Form11());
        }
    }
}
