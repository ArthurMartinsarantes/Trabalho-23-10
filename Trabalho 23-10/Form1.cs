using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_23_10
{
    public partial class Form1 : Form
    {

        //matriz que ira armazenar as fontes 
        //21 linhas -  em cada linha tera uma letra representada por 62 caracteres + 1 bias (64 no total)
        //Sequencia: Fonte1 (ABCDEJK)  Fonte2 (ABCDEJK)   Fonte3 (ABCDEJK)

        double[,] Fontes = new double[21, 64] 
            {{ -1,-1,1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,1,-1,1,-1,-1,-1,-1,1,-1,1,-1,-1,-1,1,1,1,1,1,-1,-1,1,-1,-1,-1,1,-1,-1,1,-1,-1,-1,1,-1,1,1,1,-1,1,1,1,1}, //A fonte 1
                                              {1,1,1,1,1,1,-1,-1,1,-1,-1,-1,-1,1, -1,1,-1,-1,-1,-1,1,1,1,-1,-1,-1,-1,1,1,1,1,1,1,1,-1,-1,1,-1,-1,-1,-1,1,1,1,-1,-1,-1,-1,1,-1,1,-1,-1,-1,-1,1,1,1,1,1,1,1,-1,1}, // B fonte 1
                                              {-1,-1,1,1,1,1,1, -1,1,-1,-1,-1,-1,1, 1,-1,-1,-1,-1,-1,-1, 1,-1,-1,-1,-1,-1,-1, 1,-1,-1,-1,-1,-1,-1, 1,-1,-1,-1,-1,-1,-1, 1,-1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,1,-1,-1,1,1,1,1,-1,1}, // C fonte 1
                                              {1,1,1,1,1,-1,-1,-1,1,-1,-1,-1,1,-1,-1,1,-1,-1,-1,-1,1, -1,1,-1,-1,-1,-1,1, -1,1,-1,-1,-1,-1,1,1,1,-1,-1,-1,-1,1,1,1,-1,-1,-1,-1,1, -1,1,-1,-1,-1,1,-1, 1,1,1,1,1,-1,-1,1}, // D fonte 1
                                              {1,1,1,1,1,1,1,1,1,-1,-1,-1,-1,1, -1,1,-1,-1,-1,-1,-1, -1,1,-1,1,-1,-1,-1, -1,1,1,1,-1,-1,-1,-1,1,-1,1,-1,-1,-1, -1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,1, 1,1,1,1,1,1,1,1}, // E fonte 1
                                              {-1,-1,-1,1,1,1,1, -1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1, -1,1,-1,-1,-1,1,-1, -1,1,-1,-1,-1,1,-1,-1,-1,1,1,1,-1,-1,1}, //J fonte 1
                                              {1,1,1,-1,-1,1,1, -1,1,-1,-1,1,-1,-1,-1,1,-1,1,-1,-1,-1, -1,1,1,-1,-1,-1,-1,-1,1,1,-1,-1,-1,-1, -1,1,-1,1,-1,-1,-1,-1,1,-1,-1,1,-1,-1,-1,1,-1,-1,-1,1,-1, 1,1,1,-1,-1,1,1,1}, //K fonte 1
                                              {-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,1,-1,1,-1,-1,-1,-1,1,-1,1,-1,-1,-1,1,-1,-1,-1,1,-1,-1,1,1,1,1,1,-1,-1,1,-1,-1,-1,1,-1, -1,1,-1,-1,-1,1,-1,1}, //A fonte 2
                                              { 1,1,1,1,1,1,-1, 1,-1,-1,-1,-1,-1,1, 1,-1,-1,-1,-1,-1,1, 1,-1,-1,-1,-1,-1,1, 1,1,1,1,1,1,-1, 1,-1,-1,-1,-1,-1,1, 1,-1,-1,-1,-1,-1,1, 1,-1,-1,-1,-1,-1,1, 1,1,1,1,1,1,-1,1}, // B fonte 2 
                                              { -1,-1,1,1,1,-1,-1,-1,1,-1,-1,-1,1,-1, 1,-1,-1,-1,-1,-1,1, 1,-1,-1,-1,-1,-1,-1, 1,-1,-1,-1,-1,-1,-1, 1,-1,-1,-1,-1,-1,-1, 1,-1,-1,-1,-1,-1,1, -1,1,-1,-1,-1,1,-1,-1,-1,1,1,1,-1,-1,1}, //C fonte 2 
                                              { 1,1,1,1,1,-1,-1, 1,-1,-1,-1,-1,1,-1, 1,-1,-1,-1,-1,-1,1, 1,-1,-1,-1,-1,-1,1, 1,-1,-1,-1,-1,-1,1, 1,-1,-1,-1,-1,-1,1, 1,-1,-1,-1,-1,-1,1, 1,-1,-1,-1,-1,1,-1, 1,1,1,1,1,-1,-1,1}, // D fonte 2
                                              { 1,1,1,1,1,1,1, 1,-1,-1,-1,-1,-1,-1, 1,-1,-1,-1,-1,-1,-1, 1,-1,-1,-1,-1,-1,-1, 1,1,1,1,1,-1,-1, 1,-1,-1,-1,-1,-1,-1, 1,-1,-1,-1,-1,-1,-1, 1,-1,-1,-1,-1,-1,-1, 1,1,1,1,1,1,1,1}, //E fonte 2
                                              {-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1, -1,1,-1,-1,-1,1,-1, -1,1,-1,-1,-1,1,-1,-1,-1,1,1,1,-1,-1,1}, // J fonte 2
                                              { 1,-1,-1,-1,-1,1,-1, 1,-1,-1,-1,1,-1,-1, 1,-1,-1,1,-1,-1,-1, 1,-1,1,-1,-1,-1,-1, 1,1,-1,-1,-1,-1,-1, 1,-1,1,-1,-1,-1,-1, 1,-1,-1,1,-1,-1,-1, 1,-1,-1,-1,1,-1,-1, 1,-1,-1,-1,-1,1,-1,1}, //K fonte 2
                                              {-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1, -1,-1,-1,1,-1,-1,-1,-1,-1,1,-1,1,-1,-1,-1,-1,1,-1,1,-1,-1,-1,1,-1,-1,-1,1,-1,-1,1,1,1,1,1,-1, -1,1,-1,-1,-1,1,-1, -1,1,-1,-1,-1,1,-1,1}, //A fonte 3 
                                              { 1,1,1,1,1,1,-1, 1,-1,-1,-1,-1,-1,1, 1,-1,-1,-1,-1,-1,1, 1,-1,-1,-1,-1,-1,1,1,1,1,1,1,1,-1, 1,-1,-1,-1,-1,-1,1, 1,-1,-1,-1,-1,-1,1, 1,-1,-1,-1,-1,-1,1, 1,1,1,1,1,1,-1,1}, // B fonte 3 
                                              { -1,-1,1,1,1,-1,-1,-1,1,-1,-1,-1,1,-1, 1,-1,-1,-1,-1,-1,1, 1,-1,-1,-1,-1,-1,-1, 1,-1,-1,-1,-1,-1,-1, 1,-1,-1,-1,-1,-1,-1, 1,-1,-1,-1,-1,-1,1, -1,1,-1,-1,-1,1,-1,-1,-1,1,1,1,-1,-1,1}, //C fonte 3
                                              {1,1,1,1,1,-1,-1,-1,1,-1,-1,-1,1,-1,-1,1,-1,-1,-1,-1,1, -1,1,-1,-1,-1,-1,1, -1,1,-1,-1,-1,-1,1,1,1,-1,-1,-1,-1,1,1,1,-1,-1,-1,-1,1,1,1,-1,-1,-1,1,-1, 1,1,1,1,1,-1,-1,1}, //D fonte 3
                                              {1,1,1,1,1,1,1,1,1,-1,-1,-1,-1,1,1,1,-1,-1,1,-1,-1,-1,1,1,1,1,-1,-1,-1,1,-1,-1,1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1, -1,1,-1,-1,-1,-1,1, 1,1,1,1,1,1,1,1}, // E fonte 3
                                              {-1,-1,-1,-1,1,1,1, -1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,-1,-1,-1,-1,1,-1,-1,1,-1,-1,-1,1,-1,-1,-1,1,1,1,-1,-1,1}, // J fonte 3 
                                              {1,-1,-1,-1,-1,1,-1,1,-1,-1,-1,1,-1,-1,1,-1,-1,1,-1,-1,-1,1,-1,1,-1,-1,-1,-1,1,1,-1,-1,-1,-1,-1,1,-1,1,-1,-1,-1,-1,1,-1,-1,1,-1,-1,-1,1,-1,-1,-1,1,-1,-1,1,-1,-1,-1,-1,1,-1,1} };

        double[,] Saidas_Desejadas = new double[,] { {1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1},//A
                                                     {-1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1,-1, 1, -1, -1, -1, -1, -1 },//B
                                                     {-1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1},//C
                                                     {-1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1,-1, -1, -1, 1, -1, -1, -1 },//D
                                                     {-1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1,-1, -1, -1, -1, 1, -1, -1 },//E
                                                     {-1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1,-1, -1, -1, -1, -1, 1, -1 },//J
                                                     {-1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1,-1, -1, -1, -1, -1, -1, 1 }//K
                                                                                                                                           };
        double[,] Pesos = new double[7, 64];
        double TaxaAprendizagem = 0.002;
        int QuantidadeMaximaCiclos = 1000;
        double ErroMinimo = 0.0001;



        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                for (int i = 0; i <= 9; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();

                    dataGridView2.Rows.Add();
                    dataGridView2.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
                //preencher o grid teste
                for (int Linha = 0; Linha <= 9; Linha++)
                {
                    for (int Coluna = 0; Coluna < 7; Coluna++)
                    {
                       dataGridView2.Rows[Linha].Cells[Coluna].Value = ".";
                    }
                }

                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;

            //mostrar o grafico
            chart1.Series[0].Points.Add(0, 0);
            }
        void PreencherGrid(int index)
        {
            int Linha, Coluna;
            Linha = 0;
            Coluna = 0;

            for (int i = 0; i < 63; i++)
            {
                if (Fontes[index, i] == 1)
                {
                    dataGridView1.Rows[Linha].Cells[Coluna].Value = '#';
                }
                else
                {
                    dataGridView1.Rows[Linha].Cells[Coluna].Value = '.';
                }

                Coluna++;
                if (Coluna == 7)
                {
                    Coluna = 0;
                    Linha++;
                }
            }
        }

        void MostrarLetra()
        {
            int Fonte = comboBox1.SelectedIndex;
            int Letra = comboBox2.SelectedIndex;

            if (Fonte == 0)
            {
                if (Letra == 0)
                    PreencherGrid(0);

                if (Letra == 1)
                    PreencherGrid(1);

                if (Letra == 2)
                    PreencherGrid(2);

                if (Letra == 3)
                    PreencherGrid(3);

                if (Letra == 4)
                    PreencherGrid(4);

                if (Letra == 5)
                    PreencherGrid(5);

                if (Letra == 6)
                    PreencherGrid(6);
            }

            if (Fonte == 1)
            {
                if (Letra == 0)
                    PreencherGrid(7);

                if (Letra == 1)
                    PreencherGrid(8);

                if (Letra == 2)
                    PreencherGrid(9);

                if (Letra == 3)
                    PreencherGrid(10);

                if (Letra == 4)
                    PreencherGrid(11);

                if (Letra == 5)
                    PreencherGrid(12);

                if (Letra == 6)
                    PreencherGrid(13);
            }

            if (Fonte == 2)
            {
                if (Letra == 0)
                    PreencherGrid(14);

                if (Letra == 1)
                    PreencherGrid(15);

                if (Letra == 2)
                    PreencherGrid(16);

                if (Letra == 3)
                    PreencherGrid(17);

                if (Letra == 4)
                    PreencherGrid(18);

                if (Letra == 5)
                    PreencherGrid(19);

                if (Letra == 6)
                    PreencherGrid(20);
            }
        }
       

        private void groupBoxBaseDeTreinamento_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarLetra();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarLetra();
        }

        private void buttonTreinar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 64; j++)
                    Pesos[i, j] = 0;
            }

            chart1.Series[0].Points.Clear();

            double ErroQuadraticoMedio = 1;
            double SomaErroQuadraticoCiclo = 0;
            double ErroQuadraticoMedioAtual = 0;
            double ErroQuadraticoMedioAnterior = 1;
            int Ciclos = 0;

            double Erro = 0;

            while ((Math.Abs(ErroQuadraticoMedioAtual - ErroQuadraticoMedioAnterior) > ErroMinimo) && (Ciclos < QuantidadeMaximaCiclos))
            {
                SomaErroQuadraticoCiclo = 0;
                ErroQuadraticoMedioAnterior = ErroQuadraticoMedioAtual;

                for (int AmostraTreinamento = 0; AmostraTreinamento < 21; AmostraTreinamento++)
                {
                    for (int NeuronioSaida = 0; NeuronioSaida < 7; NeuronioSaida++)
                    {
                        double sinapse = 0;

                        for (int j = 0; j < 64; j++)
                        {
                            sinapse = sinapse + (Fontes[AmostraTreinamento, j] * Pesos[NeuronioSaida, j]);
                        }

                        Erro = Saidas_Desejadas[NeuronioSaida, AmostraTreinamento] - sinapse;

                        for (int j = 0; j < 64; j++)
                        {
                            double DeltaW = Fontes[AmostraTreinamento, j] * Erro * TaxaAprendizagem;
                            Pesos[NeuronioSaida, j] = Pesos[NeuronioSaida, j] + DeltaW;
                        }

                        SomaErroQuadraticoCiclo = SomaErroQuadraticoCiclo + Math.Pow(Erro, 2);
                    }
                }

                ErroQuadraticoMedio = SomaErroQuadraticoCiclo / 21;

                ErroQuadraticoMedioAtual = ErroQuadraticoMedio;

                Ciclos++;

                chart1.Series[0].Points.Add(Math.Abs(ErroQuadraticoMedio));
            }

            labelciclos.Text = Ciclos.ToString();
        }

        private void buttonTestar_Click(object sender, EventArgs e)
        {
            int[] VetorParaSerTestado = new int[64];
            int PosicaoAtual = 0;
            double Resultado;
            int Y;
            string[] Letras = new string[] { "A", "B", "C", "D", "E", "J", "K" };

            labelRespostaRede.Text = "";

            for (int Linha = 0; Linha < 9; Linha++)
            {
                for (int Coluna = 0; Coluna < 7; Coluna++)
                {
                    string entrada = dataGridView2.Rows[Linha].Cells[Coluna].Value.ToString();
                    if (entrada == "#")
                        VetorParaSerTestado[PosicaoAtual] = 1;
                    else if (entrada == ".")
                        VetorParaSerTestado[PosicaoAtual] = -1;
                    else
                    {
                        VetorParaSerTestado[PosicaoAtual] = 0;
                    }

                    PosicaoAtual += 1;
                }
            }

            VetorParaSerTestado[63] = 1;

            for (int NeuronioSaida = 0; NeuronioSaida < 7; NeuronioSaida++)
            {
                Resultado = 0;
                for (int i = 0; i < 64; i++)
                {
                    Resultado = Resultado + (VetorParaSerTestado[i] * Pesos[NeuronioSaida, i]);
                }

                if (Resultado >= 0)
                    labelRespostaRede.Text = labelRespostaRede.Text + " " + Letras[NeuronioSaida];
            }
    }
    }
}
