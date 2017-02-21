using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_de_Dados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int count1 = new int();
            int count2 = new int();

            do
            {
                Random j1 = new Random();
                int valor1 = j1.Next(1, 7);


                Random j2 = new Random();
                int valor2 = j1.Next(1, 7);

                MessageBox.Show("Jogador 1 tirou ="+valor1 +"| Jogador 2 tirou = "+valor2);

                if (valor1 > valor2)
                {
                    count1++;
                    if (count1 == 2)
                    {
                        MessageBox.Show("Jogador 1 venceu o jogo!");
                        break;
                    }
                    else MessageBox.Show("Jogador 2 venceu esta rodada.");
                }
                else if (valor2 > valor1)
                {
                    count2++;
                    if (count2 == 2)
                    {
                        MessageBox.Show("Jogador 2 venceu o jogo!");
                        break;
                    }
                    else MessageBox.Show("Jogador 2 venceu esta rodada");
                }
                else if (valor1 == valor2)
                    MessageBox.Show("Empate");
         
            } while(count1<3 || count2<3);
        }
    }
}
