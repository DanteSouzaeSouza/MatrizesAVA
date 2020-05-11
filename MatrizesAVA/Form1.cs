using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrizesAVA
{
    public partial class FrmMatriz : Form
    {
        public FrmMatriz()
        {
            InitializeComponent();
        }

        private void btnPreenche_Click(object sender, EventArgs e)
        {
            lstMatriz.Items.Clear();
            lstTransposta.Items.Clear();

            //variáveis para acessar as posições dos índices da matriz
            // linha - representa linha
            // coluna - representa coluna

            int linha, coluna;

            //declara a variável numeros com 5 linhas e 4 colunas

            int[,] numeros = new int[5, 4];    //dimensão da matriz 5 x 4

            for (linha = 0; linha < 5; linha++)
            {
                for (coluna = 0; coluna < 4; coluna++)
                {
                    numeros[linha, coluna] = linha * coluna;  //atribui o valor de linha * coluna
                }
            }

            //exibindo os dados no ListBox

            for (linha = 0; linha < 5; linha++)
            {
                
                for (coluna = 0; coluna < 4; coluna++)
                {
                    lstMatriz.Items.Add("elemento = " + numeros[linha, coluna]);
                }
            }

            for (coluna = 0; coluna < 4; coluna++)
            {

                for (linha = 0; linha < 5; linha++)
                {
                    lstTransposta.Items.Add("elemento = " + numeros[linha, coluna]);
                }
            }
        }
    }
}
