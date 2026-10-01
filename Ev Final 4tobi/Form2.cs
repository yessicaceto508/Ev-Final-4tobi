using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_Final_4tobi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextVar1.Text);
            int num2 = int.Parse(TextVar2.Text);
            int num3 = 1;
            int potencia = 1;

            while (num1 != num2) ;
            {
                potencia = potencia * num1;
                num3++;
            }
            MessageBox.Show("el resultado es" + potencia);
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextVar1.Text);
            int num2 = int.Parse(TextVar2.Text);
            int suma = num1 + num2;
            MessageBox.Show("El resultado es" + suma);

        }

        private void BtnPotencia_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextVar1.Text);
            int num2 = int.Parse(TextVar2.Text);
            int num3 = 1;
            
            
            while (num3 != num2)
            {
                BtnPotencia = BtnPotencia * num1;
                num3 = num3 + 1;

            }
        }

        private void BtnDivision_Click(object sender, EventArgs e)

        {
            float n1 = float.Parse(TextVar1.Text);// aqui obtenemos el primer numero y se guarda en la variabkle num1
            float n2 = float.Parse(TextVar2.Text);// aqui obtenemos el segundo numero y se guarda en la variabkle num2

            if (n2 > 0)// es el inicio de la condiccion tomando en cuenta que todo nunero que mayor 
            {//inicio del if
                float division = n1 / n2;
                MessageBox.Show("el resultado es" + division);
            }// fin del if
            else// condision else siempre afinidad al if y es lo que ocurre si no se cumple la primera condiccion 
            {// inicio del else 
                MessageBox.Show("la division es indifinida");// resultado si no se cimple la condiccion 
            }//fin del eslse 
        }
    }
}