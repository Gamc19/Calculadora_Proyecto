using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Proyecto
{
    public partial class Calculadorafrm : Form
    {
        private Operadores calculadora;
        public Calculadorafrm()
        {
            InitializeComponent();
            calculadora = new Operadores();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "."; 
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            double num = double.Parse(calculadora.eliminaCaracter(txtResultado.Text));
            string btnsuma = (sender as Button).Text;
            calculadora.operacion(num, btnsuma);
            txtResultado.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            double num = double.Parse(calculadora.eliminaCaracter(txtResultado.Text));
            string btnResta = (sender as Button).Text;
            calculadora.operacion(num, btnResta);
            txtResultado.Clear();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            double num = double.Parse(calculadora.eliminaCaracter(txtResultado.Text));
            txtResultado.Clear();
            calculadora.igual(num);
            txtResultado.Text = calculadora.getResultado().ToString();
            calculadora.clear();
        }

        private void btnCambioSigno_Click(object sender, EventArgs e)
        {
            double num = double.Parse(calculadora.eliminaCaracter(txtResultado.Text));
            txtResultado.Text = calculadora.cambiarSigno(num).ToString();
            calculadora.clear();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            calculadora.clear();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            double num = double.Parse(calculadora.eliminaCaracter(txtResultado.Text));
            string btnMultiplicacion = (sender as Button).Text;
            calculadora.operacion(num, btnMultiplicacion);
            txtResultado.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            double num = double.Parse(calculadora.eliminaCaracter(txtResultado.Text));
            string btnDivision = (sender as Button).Text;
            calculadora.operacion(num, btnDivision);
            txtResultado.Clear();
        }

        private void btnExponente_Click(object sender, EventArgs e)
        {
            double num = double.Parse(calculadora.eliminaCaracter(txtResultado.Text));
            string btnExponente = (sender as Button).Text;
            calculadora.operacion(num, btnExponente);
            txtResultado.Clear();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            double num = double.Parse(calculadora.eliminaCaracter(txtResultado.Text));
            string btnRaiz = (sender as Button).Text;
            calculadora.operacion(num, btnRaiz);
            txtResultado.Clear();
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            
            double num = double.Parse(txtResultado.Text);
            txtResultado.Text += "π";
            string btnPi = (sender as Button).Text;
            calculadora.operacion(num, btnPi);
            
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            
            double num = double.Parse(txtResultado.Text);
            txtResultado.Text += "e";
            string btnE = (sender as Button).Text;
            calculadora.operacion(num, btnE);
            
        }

        private void btnLogNatural_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtResultado.Text);
            txtResultado.Text += "ln";
            string btnLogNatural = (sender as Button).Text;
            calculadora.operacion(num, btnLogNatural);
            
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            double num = double.Parse(calculadora.eliminaCaracter(txtResultado.Text));
            string btnModulo = (sender as Button).Text;
            calculadora.operacion(num, btnModulo);
            txtResultado.Clear();
        }

        private void btnRacional_Click(object sender, EventArgs e)
        {
            double num = double.Parse(calculadora.eliminaCaracter(txtResultado.Text));
            string btnRacional = (sender as Button).Text;
            calculadora.operacion(num, btnRacional);
            
        }

        private void btnLogaritmo_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtResultado.Text);
            txtResultado.Text += "Log₁₀";
            string btnLogaritmo = (sender as Button).Text;
            calculadora.operacion(num, btnLogaritmo);
            
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
