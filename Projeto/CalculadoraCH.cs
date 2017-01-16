using System;
using System.Windows.Forms;

namespace CalculadoraCH
{
    public partial class CalculadoraCH : Form
    {
        public CalculadoraCH()
        {
            InitializeComponent();
        }

        private double calcCirurgiao;
        private double calcAuxiliar1;
        private double calcAuxiliar2;

        //Fazer o calculo ao haver mudança no texto
        private void txtCH_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCH.Text, "[^0-9]")) //Checa se o input não é 0-9 ou
            {
                txtCH.Text = txtCH.Text.Remove(txtCH.Text.Length - 1); //Caso o input não seja um numero, remove o input
            }

            if (txtCH.Text.Length > 0) //Se o textbox é maior do que 0, calcular
                {
                    int CH = int.Parse(txtCH.Text); //Converter o valor para int

                    //CH de 0-1000 AMB92
                    if ((CH >= 0) & (CH <= 1000) & (rdoAMB92.Checked))
                    {
                        calcCirurgiao = (CH * 1.5 * 0.30);
                        calcAuxiliar1 = ((CH * 1.5 * 0.30) * 0.30);
                        calcAuxiliar2 = ((CH * 1.5 * 0.30) * 0.20);
                        parseString();
                    }

                    //CH de 0-1000 TUSS
                    if ((CH >= 0) & (CH <= 1000) & (rdoTUSS.Checked))
                    {
                        calcCirurgiao = ((CH * 1.5 * 0.30) * 0.60);
                        calcAuxiliar1 = (((CH * 1.5 * 0.30) * 0.30) * 0.60);
                        calcAuxiliar2 = (((CH * 1.5 * 0.30) * 0.20) * 0.60);
                        parseString();
                    }

                    //CH de 1001-1500 AMB92
                    if ((CH >= 1001) & (CH <= 1500) & (rdoAMB92.Checked))
                    {
                        calcCirurgiao = (CH * 1.8 * 0.30);
                        calcAuxiliar1 = ((CH * 1.8 * 0.30) * 0.30);
                        calcAuxiliar2 = ((CH * 1.8 * 0.30) * 0.20);
                        parseString();
                    }

                    //CH de 1001-1500 TUSS
                    if ((CH >= 1001) & (CH <= 1500) & (rdoTUSS.Checked))
                    {
                        calcCirurgiao = ((CH * 1.8 * 0.30) * 0.60);
                        calcAuxiliar1 = (((CH * 1.8 * 0.30) * 0.30) * 0.60);
                        calcAuxiliar2 = (((CH * 1.8 * 0.30) * 0.20) * 0.60);
                        parseString();
                    }

                    //CH maior que 1500 AMB92
                    if ((CH > 1500) & (rdoAMB92.Checked))
                    {
                        calcCirurgiao = (CH * 2.0 * 0.30);
                        calcAuxiliar1 = ((CH * 2.0 * 0.30) * 0.30);
                        calcAuxiliar2 = ((CH * 2.0 * 0.30) * 0.20);
                        parseString();
                    }

                    //CH maior que 1500 TUSS
                    if ((CH > 1500) & (rdoTUSS.Checked))
                    {
                        calcCirurgiao = ((CH * 2.0 * 0.30));
                        calcAuxiliar1 = (((CH * 2.0 * 0.30) * 0.30));
                        calcAuxiliar2 = (((CH * 2.0 * 0.30) * 0.20));
                        parseString();
                    }
               }
          }

        //CHs já calculados para string & exibir
        private void parseString()
        {
            string valorCirurgiao = "R$ " + calcCirurgiao.ToString();
            string valorAuxiliar1 = "R$ " + calcAuxiliar1.ToString();
            string valorAuxiliar2 = "R$ " + calcAuxiliar2.ToString();
            txtCirurgiao.Text = valorCirurgiao;
            txtAuxiliar_1.Text = valorAuxiliar1;
            txtAuxiliar_2.Text = valorAuxiliar2;
        }

        //Limpa a textbox de CH para resetar o valor na mudança de opção, corrigindo ao valor necessario
        private void rdoAMB92_Click(object sender, EventArgs e)
        {
            string _reset = txtCH.Text;
            txtCH.Clear();
            txtCH.Text = _reset;
        }

        //Limpa a textbox de CH para resetar o valor na mudança de opção, corrigindo ao valor necessario
        private void rdoTUSS_Click(object sender, EventArgs e)
        {
            string _reset = txtCH.Text;
            txtCH.Clear();
            txtCH.Text = _reset;
        }
    }
}