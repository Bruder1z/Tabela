using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace treinotabela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            

            
                Equacao equacao = new Equacao();
                equacao.setA(txt_a.Text);
                equacao.setB(txt_b.Text);

              
                if (EquacaoBLL.validaDados(equacao))
                {
                   
                    //chart_equacao.Series[0].Points.Clear();
                    
                    float a = float.Parse(equacao.getA());
                    float b = float.Parse(equacao.getB());

                   
                    for (int i = 0; i < 100; i++)
                    {
                     chart_equacao.Series[0].Points.AddXY(i, a * i + b);
                    }

              
                
                }
                else
                {
                    
                    MessageBox.Show(Erro.getMens(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
                txt_a.Clear();
                txt_b.Clear();

            }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            chart_equacao.Series[0].Points.Clear();

        }
    }
}
