using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIrmaAdelaide
{
    public partial class Form3 : Form
    {
        //Linha de baixo cria nova Thread (Tem que criar: using System.Threading)
        Thread t1; //Botão Créditos

        Thread t2; //Orientação 01 - Ori01
        Thread t3; //Orientação 02 - Ori02
        Thread t4; //Orientação 03 - Ori03
        Thread t5; //Orientação 04 - Ori04
        Thread t6; //Orientação 05 - Ori05
        Thread t7; //Orientação 06 - Ori06
        Thread t8; //Orientação 07 - Ori07
        Thread t9; //Orientação 08 - Ori08
        Thread t10; //Orientação 09 - Ori09
        Thread t11; //Orientação 10 - Ori10
        Thread t12; //Orientação 11 - Ori11
        Thread t13; //Orientação 12 - Ori12
        Thread t14; //Orientação 13 - Ori13
        Thread t15; //Orientação 14 - Ori14
        Thread t16; //Orientação 15 - Ori15
        Thread t17; //Orientação 16 - Ori16
        Thread t18; //Orientação 17 - Ori17
        Thread t19; //Orientação 18 - Ori18
        Thread t20; //Orientação 19 - Ori19
        Thread t21; //Orientação 20 - Ori20

        public Form3()
        {
            InitializeComponent();
            //Linha de baixo abre a janela Form maximizada
            this.WindowState = FormWindowState.Maximized;
        }

        private DataTable dtOrientacoes;

        private void Form3_Load(object sender, EventArgs e)
        {
            lista_orientacoes.DataSource = GetData();
            lista_orientacoes.DisplayMember = "Orientacoes";
        }

        private DataTable GetData()
        {
            dtOrientacoes = new DataTable();

            dtOrientacoes.Columns.Add("Orientacoes", typeof(string));

            dtOrientacoes.Rows.Add("1. Como armazenar corretamente os medicamentos");
            dtOrientacoes.Rows.Add("2. Manter uma rotina é importante");
            dtOrientacoes.Rows.Add("3. Leia sempre a bula ao iniciar o uso de um medicamento");
            dtOrientacoes.Rows.Add("4. A importância do papel do paciente e dos seus familiares");
            dtOrientacoes.Rows.Add("5. Medicamentos “de marca”,  genéricos e similares");
            dtOrientacoes.Rows.Add("6. Não utilize  medicamentos indicados por outras pessoas");
            dtOrientacoes.Rows.Add("7. Interações medicamentosas e alimentos");
            dtOrientacoes.Rows.Add("8. Cuidados com efeitos colaterais");
            dtOrientacoes.Rows.Add("9. O que fazer em caso de esquecer de tomar o remédio na hora certa");
            dtOrientacoes.Rows.Add("10. Plantas medicinais x fitoterapia");
            dtOrientacoes.Rows.Add("11. Importância das tarjas  dos medicamentos");
            dtOrientacoes.Rows.Add("12. Modo correto para descartar medicamentos vencidos");
            dtOrientacoes.Rows.Add("13. Idosos resistem a tomar remédios");
            dtOrientacoes.Rows.Add("14. Remédios de alto custo: como obter a gratuidade");
            dtOrientacoes.Rows.Add("15. Medicamentos potencialmente inadequados para idosos");
            dtOrientacoes.Rows.Add("16. Anticolinérgicos: o que isso significa?");
            dtOrientacoes.Rows.Add("17. Qual médico devo procurar");
            dtOrientacoes.Rows.Add("18. Motivos para contratar cuidador de idosos");
            dtOrientacoes.Rows.Add("19. Alcoolismo na terceira idade");
            dtOrientacoes.Rows.Add("20. Doenças crônicas podem ser silenciosas");
            
            return dtOrientacoes;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Configuração para abrir nova janela criando o comando "abrirjanela"
            this.Close();
            t1 = new Thread(abrirjanelacreditos);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirjanelacreditos(object obj)
        {
            Application.Run(new Form2());
        }

        private void imagem_titulo_indice_Click(object sender, EventArgs e)
        {

        }

        private void texto_pesquisar_Click(object sender, EventArgs e)
        {

        }

        private void botao_pesquisar_Click(object sender, EventArgs e)
        {

        }

        private void campo_pesquisar_TextChanged(object sender, EventArgs e)
        {
            DataView dvOrientacoes = dtOrientacoes.DefaultView;

            dvOrientacoes.RowFilter = "Orientacoes LIKE '%" + campo_pesquisar.Text + "%'";
        }

        private void lista_orientacoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lista_orientacoes.ClearSelected();
        }

        private void lista_orientacoes_MouseClick(object sender, MouseEventArgs e)
        {
            if (lista_orientacoes.Text == "1. Como armazenar corretamente os medicamentos")
            {
                this.Close();
                t2 = new Thread(Ori01);
                t2.SetApartmentState(ApartmentState.STA);
                t2.Start();
            }
            else if (lista_orientacoes.Text == "2. Manter uma rotina é importante")
            {
                this.Close();
                t3 = new Thread(Ori02);
                t3.SetApartmentState(ApartmentState.STA);
                t3.Start();
            }
            else if (lista_orientacoes.Text == "3. Leia sempre a bula ao iniciar o uso de um medicamento")
            {
                this.Close();
                t4 = new Thread(Ori03);
                t4.SetApartmentState(ApartmentState.STA);
                t4.Start();
            }
            else if (lista_orientacoes.Text == "4. A importância do papel do paciente e dos seus familiares")
            {
                this.Close();
                t5 = new Thread(Ori04);
                t5.SetApartmentState(ApartmentState.STA);
                t5.Start();
            }
            else if (lista_orientacoes.Text == "5. Medicamentos “de marca”,  genéricos e similares")
            {
                this.Close();
                t6 = new Thread(Ori05);
                t6.SetApartmentState(ApartmentState.STA);
                t6.Start();
            }
            else if (lista_orientacoes.Text == "6. Não utilize  medicamentos indicados por outras pessoas")
            {
                this.Close();
                t7 = new Thread(Ori06);
                t7.SetApartmentState(ApartmentState.STA);
                t7.Start();
            }
            else if (lista_orientacoes.Text == "7. Interações medicamentosas e alimentos")
            {
                this.Close();
                t8 = new Thread(Ori07);
                t8.SetApartmentState(ApartmentState.STA);
                t8.Start();
            }
            else if (lista_orientacoes.Text == "8. Cuidados com efeitos colaterais")
            {
                this.Close();
                t9 = new Thread(Ori08);
                t9.SetApartmentState(ApartmentState.STA);
                t9.Start();
            }
            else if (lista_orientacoes.Text == "9. O que fazer em caso de esquecer de tomar o remédio na hora certa")
            {
                this.Close();
                t10 = new Thread(Ori09);
                t10.SetApartmentState(ApartmentState.STA);
                t10.Start();
            }
            else if (lista_orientacoes.Text == "10. Plantas medicinais x fitoterapia")
            {
                this.Close();
                t11 = new Thread(Ori10);
                t11.SetApartmentState(ApartmentState.STA);
                t11.Start();
            }
            else if (lista_orientacoes.Text == "11. Importância das tarjas  dos medicamentos")
            {
                this.Close();
                t12 = new Thread(Ori11);
                t12.SetApartmentState(ApartmentState.STA);
                t12.Start();
            }
            else if (lista_orientacoes.Text == "12. Modo correto para descartar medicamentos vencidos")
            {
                this.Close();
                t13 = new Thread(Ori12);
                t13.SetApartmentState(ApartmentState.STA);
                t13.Start();
            }
            else if (lista_orientacoes.Text == "13. Idosos resistem a tomar remédios")
            {
                this.Close();
                t14 = new Thread(Ori13);
                t14.SetApartmentState(ApartmentState.STA);
                t14.Start();
            }
            else if (lista_orientacoes.Text == "14. Remédios de alto custo: como obter a gratuidade")
            {
                this.Close();
                t15 = new Thread(Ori14);
                t15.SetApartmentState(ApartmentState.STA);
                t15.Start();
            }
            else if (lista_orientacoes.Text == "15. Medicamentos potencialmente inadequados para idosos")
            {
                this.Close();
                t16 = new Thread(Ori15);
                t16.SetApartmentState(ApartmentState.STA);
                t16.Start();
            }
            else if (lista_orientacoes.Text == "16. Anticolinérgicos: o que isso significa?")
            {
                this.Close();
                t17 = new Thread(Ori16);
                t17.SetApartmentState(ApartmentState.STA);
                t17.Start();
            }
            else if (lista_orientacoes.Text == "17. Qual médico devo procurar")
            {
                this.Close();
                t18 = new Thread(Ori17);
                t18.SetApartmentState(ApartmentState.STA);
                t18.Start();
            }
            else if (lista_orientacoes.Text == "18. Motivos para contratar cuidador de idosos")
            {
                this.Close();
                t19 = new Thread(Ori18);
                t19.SetApartmentState(ApartmentState.STA);
                t19.Start();
            }
            else if (lista_orientacoes.Text == "19. Alcoolismo na terceira idade")
            {
                this.Close();
                t20 = new Thread(Ori19);
                t20.SetApartmentState(ApartmentState.STA);
                t20.Start();
            }
            else if (lista_orientacoes.Text == "20. Doenças crônicas podem ser silenciosas")
            {
                this.Close();
                t21 = new Thread(Ori20);
                t21.SetApartmentState(ApartmentState.STA);
                t21.Start();
            }
        }

        private void Ori01(object obj)
        {
            Application.Run(new Form4());
        }

        private void Ori02(object obj)
        {
            Application.Run(new Form5());
        }

        private void Ori03(object obj)
        {
            Application.Run(new Form6());
        }

        private void Ori04(object obj)
        {
            Application.Run(new Form7());
        }

        private void Ori05(object obj)
        {
            Application.Run(new Form8());
        }

        private void Ori06(object obj)
        {
            Application.Run(new Form9());
        }

        private void Ori07(object obj)
        {
            Application.Run(new Form10());
        }

        private void Ori08(object obj)
        {
            Application.Run(new Form11());
        }

        private void Ori09(object obj)
        {
            Application.Run(new Form12());
        }

        private void Ori10(object obj)
        {
            Application.Run(new Form13());
        }

        private void Ori11(object obj)
        {
            Application.Run(new Form14());
        }

        private void Ori12(object obj)
        {
            Application.Run(new Form15());
        }

        private void Ori13(object obj)
        {
            Application.Run(new Form16());
        }

        private void Ori14(object obj)
        {
            Application.Run(new Form17());
        }

        private void Ori15(object obj)
        {
            Application.Run(new Form18());
        }

        private void Ori16(object obj)
        {
            Application.Run(new Form19());
        }

        private void Ori17(object obj)
        {
            Application.Run(new Form20());
        }

        private void Ori18(object obj)
        {
            Application.Run(new Form21());
        }

        private void Ori19(object obj)
        {
            Application.Run(new Form22());
        }

        private void Ori20(object obj)
        {
            Application.Run(new Form23());
        }
    }
}
