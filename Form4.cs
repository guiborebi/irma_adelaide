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
    public partial class Form4 : Form
    {
        //Linha de baixo cria nova Thread (Tem que criar: using System.Threading)
        Thread t1;
        //Thread t2;
        Thread t3;
        
        public Form4()
        {
            InitializeComponent();
            //Linha de baixo abre a janela Form maximizada
            this.WindowState = FormWindowState.Maximized;
        }

        private void botao_voltar_01_Click(object sender, EventArgs e)
        {
            //Configuração para abrir nova janela criando o comando "abrirjanela"
            this.Close();
            t1 = new Thread(voltar01);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        //Executando o comando "abrirjanela"
        private void voltar01(object obj)
        {
            Application.Run(new Form3());
        }

        private void botao_anterior_01_Click(object sender, EventArgs e)
        {
            
        }

        private void botao_proximo_01_Click(object sender, EventArgs e)
        {
            //Configuração para abrir nova janela criando o comando "abrirjanela"
            this.Close();
            t3 = new Thread(proximo01);
            t3.SetApartmentState(ApartmentState.STA);
            t3.Start();
        }

        //Executando o comando "abrirjanela"
        private void proximo01(object obj)
        {
            Application.Run(new Form5());
        }

        private void conteudo001_TextChanged(object sender, EventArgs e)
        {

        }
    }
}