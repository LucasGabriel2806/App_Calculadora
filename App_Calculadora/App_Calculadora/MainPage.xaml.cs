using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Calculadora
{
    public partial class MainPage : ContentPage
    {
        /**
         * Variáveis usadas para memorizar a operação,
         * memória de cálculo e o que aparece no visor da
         * calculadora.
         */
        string operacao = null;

        double memoria_de_calculo_pre_operacao = 0.0;
        double memoria_de_calculo_pos_operacao = 0.0;

        string para_aparecer_no_visor = "";

        /**
         * Método construtor da Classe
         */
        public MainPage()
        {
            InitializeComponent();
        }

        /**
         * Método para remover os sinais do visor quando for
         * digitar números.
         */
        private void remover_sinais_visor()
        {
            if (para_aparecer_no_visor == "+" || para_aparecer_no_visor == "-" ||
                para_aparecer_no_visor == "*" || para_aparecer_no_visor == "/")
            {
                para_aparecer_no_visor = "";
            }
        }

       

        /**
         * Botão para executar a operação desejada pelo usuário
         * conforme a memória de cálculo.
         */
        private void igual_Clicked(object sender, EventArgs e)
        {
            try
            {
                memoria_de_calculo_pos_operacao = Convert.ToDouble(visor.Text);

                double resultado = 0;

                switch (operacao)
                {
                    case "+":
                        resultado = memoria_de_calculo_pos_operacao + memoria_de_calculo_pos_operacao;
                        break;
                    case "-":
                        resultado = memoria_de_calculo_pos_operacao - memoria_de_calculo_pos_operacao;
                        break;
                    case "*":
                        resultado = memoria_de_calculo_pos_operacao * memoria_de_calculo_pos_operacao;
                        break;
                    case "/":
                        resultado = memoria_de_calculo_pos_operacao / memoria_de_calculo_pos_operacao;
                        break;
                }
                visor.Text = resultado.ToString();

            }
            catch (Exception ex)
            {
                visor.Text = ex.Message;
            }

        }

        /**
         * Comportamento das Operações
         */
        private void somar_Clicked(object sender, EventArgs e)
        {
            memoria_de_calculo_pre_operacao = Convert.ToDouble(visor.Text);

            para_aparecer_no_visor = "+";
            operacao = "+";
            visor.Text = para_aparecer_no_visor;

        }
        private void subtrair_Clicked(object sender, EventArgs e)
        {
            memoria_de_calculo_pre_operacao = Convert.ToDouble(visor.Text);

            para_aparecer_no_visor = "-";
            operacao = "-";
            visor.Text = para_aparecer_no_visor;
        }

        
        private void multiplicar_Clicked(object sender, EventArgs e)
        {
            memoria_de_calculo_pre_operacao = Convert.ToDouble(visor.Text);

            para_aparecer_no_visor = "*";
            operacao = "*";
            visor.Text = para_aparecer_no_visor;
        }
        private void dividir_Clicked(object sender, EventArgs e)
        {
            memoria_de_calculo_pre_operacao = Convert.ToDouble(visor.Text);

            para_aparecer_no_visor = "/";
            operacao = "/";
            visor.Text = para_aparecer_no_visor;
        }

        private void zerar_Clicked(object sender, EventArgs e)
        {
            visor.Text = "0";
            para_aparecer_no_visor = "";
            memoria_de_calculo_pos_operacao = 0.0;
            memoria_de_calculo_pre_operacao = 0.0;
            operacao = null;
        }

        private void maismenos_Clicked(object sender, EventArgs e)
        {
            double valor_visor = Convert.ToDouble(visor.Text); ;

            valor_visor = valor_visor * -1;
            visor.Text = valor_visor.ToString();
        }

        private void porcento_Clicked(object sender, EventArgs e)
        {
            double valor_visor = Convert.ToDouble(visor.Text); ;

            valor_visor = valor_visor / 100;
            visor.Text = valor_visor.ToString();
        }

        private void ponto_Clicked(object sender, EventArgs e)
        {
            para_aparecer_no_visor += ponto.Text;
            visor.Text = para_aparecer_no_visor;
        }

        /**
          * Comportamento dos Botões 0 a 9. 
          * 
          */

        private void num0_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();

            para_aparecer_no_visor += num0.Text;
            visor.Text = para_aparecer_no_visor;
        }
        private void num1_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();

            para_aparecer_no_visor += num1.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void num2_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();

            para_aparecer_no_visor += num2.Text;
            visor.Text = para_aparecer_no_visor;
        }
        private void num3_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();

            para_aparecer_no_visor += num3.Text;
            visor.Text = para_aparecer_no_visor;
        }
        private void num4_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();

            para_aparecer_no_visor += num4.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void num5_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();

            para_aparecer_no_visor += num5.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void num6_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();

            para_aparecer_no_visor += num6.Text;
            visor.Text = para_aparecer_no_visor;
        }
        private void num7_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();

            para_aparecer_no_visor += num7.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void num8_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();

            para_aparecer_no_visor += num8.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void num9_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();

            para_aparecer_no_visor += num9.Text;
            visor.Text = para_aparecer_no_visor;
        }

        
    }
}
