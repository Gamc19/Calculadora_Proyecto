using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Proyecto
{
    internal class Operadores
    {
        private double resultado;
        private string operador;
        
        public double getResultado()
        {
            return resultado;
        }
        public void clear()
        {
            resultado = 0;
            operador = "";
        }
        public void operacion(double num, string op)
        {
            
                igual(num);
                operador = op;
        }

        public void igual(double num)
        {
            switch (operador)
            {
                case "+":
                    resultado += num;
                    break;
                case "-":
                    resultado -= num;
                    break;
                case "x":
                    resultado *= num;
                    break;
                case "*":
                    resultado *= num;
                    break;
                case "/":
                    resultado /= num;
                    break;
                case "xʸ":
                    resultado = Math.Pow(resultado, num);
                    break;
                case "√":
                    resultado = Math.Pow(resultado, 1.0 / num);
                    break;
                case "Log₁₀":
                    resultado = Math.Log10(resultado);
                    break;
                case "Ln":
                    resultado = Math.Log(resultado);
                    break;
                case "1/x":
                    resultado = 1.0 / num;
                    break;
                case "%":
                    resultado %= num;
                    break;
                case "π":
                    resultado *= Math.PI;
                    break;
                case "e":
                    resultado *= Math.E;
                    break;
                case "sin":
                    resultado = Math.Sin(resultado);
                    break;
                case "cos":
                    resultado = Math.Cos(resultado);
                    break;
                case "tan":
                    resultado = Math.Tan(resultado);
                    break;
                default:
                    resultado = num;
                    break;
                    
            }
        }
       

        public double cambiarSigno(double num)
        {
            num = -num;
            return num;
        }

       
        public string eliminaCaracter(string num) {


            num = num.Replace("π","");
            num = num.Replace("e","");
            num = num.Replace("Log₁₀", "");
            num = num.Replace("ln", "");
            num = num.Replace("sin", "");
            num = num.Replace("cos", "");
            num = num.Replace("tan", "");
            return num;
        }

        
    }

}
