using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    internal class Matematica 
    {
        private double num1;
        private double num2;
        
        public Matematica(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public double sumar()
        {
            return num1 + num2;
        }
        public double restar()
        {
            return num1 - num2;
        }
        public double multiplicar()
        {
            return num1 * num2;
        }
        public double dividir()
        {
            return num1 / num2;
        }
        public double getNum2()
        {
            return num2;
        }
        public double modulo()
        {
            return num1 % num2;
        }
    }
}
