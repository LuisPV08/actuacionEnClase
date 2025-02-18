using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form1 : Form
    {

        Matematica mat;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2;

            if (!double.TryParse(tbnum1.Text, out num1))
            {
                MessageBox.Show("Por favor, ingrese un número válido en el primer campo.");
                return;
            }
            if (!double.TryParse(tbnum2.Text, out num2))
            {
                MessageBox.Show("Por favor, ingrese un número válido en el segundo campo.");
                return;
            }
            mat = new Matematica(num1, num2);
            calcularOperacion();
        }

        private void calcularOperacion()
        {
            double resultado = 0;
            
            if (sumar.Checked)
            {
                mat.sumar();
                MessageBox.Show("La suma es: " + mat.sumar());
                result.Text = mat.sumar().ToString();
            }
            if (restar.Checked)
            {
                mat.restar();
                MessageBox.Show("La resta es: " + mat.restar());
                result.Text = mat.restar().ToString();
            }
            if (multiplicar.Checked)
            {
                mat.multiplicar();
                MessageBox.Show("La multiplicación es: " + mat.multiplicar());
                result.Text = mat.multiplicar().ToString();
            }
            if (dividir.Checked)
            {
                if (mat.getNum2() == 0)
                {
                    MessageBox.Show("No se puede dividir por cero");
                    result.Text = "Error";
                    return;
                }
                resultado = mat.dividir();
                MessageBox.Show("La división es: " + resultado);
                result.Text = resultado.ToString();
            }
            if (modulo.Checked)
            {
                if (mat.getNum2() == 0)
                {
                    MessageBox.Show("No se puede calcular el módulo cuando el divisor es cero");
                    result.Text = "Error";
                    return;
                }
                resultado = mat.modulo();
                MessageBox.Show("El módulo es: " + resultado);
                result.Text = resultado.ToString();
            }
        }
    }
}
