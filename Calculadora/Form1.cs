//Nombre: Nakleh Zeidan Silva 
//Fecha: 12--11-2022

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Calculadora XD C#";
        }

//////////////////////////////> variables para guardar resultados
        string CalcularTotal;
        int numeroUNO;
        int numeroDOS;
        string opcion;
        int Resultado;
        List<string> list = new List<string>();








        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textoResultado_TextChanged(object sender, EventArgs e)
        {

        }


//////////////////////////////>  BOTONES NUMERICOS 0-9
        private void button3_Click(object sender, EventArgs e)
        {
            textoResultado.Text = textoResultado.Text + "1"; // BOTON 1
            list.Add(textoResultado.Text);


        }
        private void boton2_Click(object sender, EventArgs e)
        {
            textoResultado.Text= textoResultado.Text + "2"; // BOTON 2
            list.Add(textoResultado.Text);
        }

        private void boton3_Click(object sender, EventArgs e)  
        {
            textoResultado.Text = textoResultado.Text + "3";// BOTON 3
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textoResultado.Text = textoResultado.Text + "4";// BOTON 4
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            textoResultado.Text = textoResultado.Text + "5";// BOTON 5
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            textoResultado.Text = textoResultado.Text + "6";// BOTON 6
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textoResultado.Text = textoResultado.Text + "7";// BOTON 7
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            textoResultado.Text = textoResultado.Text + "8";// BOTON 8
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            textoResultado.Text = textoResultado.Text + "9";// BOTON 9
        }

        private void boton0_Click(object sender, EventArgs e)
        {
            textoResultado.Text = textoResultado.Text + "0";// BOTON 0
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textoResultado.Text = textoResultado.Text + ".";// BOTON .
        }


//////////////////////////////>  FUNCIONES ARITMETICAS + - X / "ELEVADO"

        private void suma_Click(object sender, EventArgs e) //SUMA
        {

           
            opcion = "+";
          
            numeroUNO = int.Parse(textoResultado.Text);

            textoResultado.Clear();
            

        }


        private void resta_Click(object sender, EventArgs e) // restar
        {

            opcion = "-";
            numeroUNO = int.Parse(textoResultado.Text);
            textoResultado.Clear();

        }

        private void mult_Click(object sender, EventArgs e) // multiplicar
        {
            opcion = "*";
            numeroUNO = int.Parse(textoResultado.Text); 

            textoResultado.Clear();

        }

        private void div_Click(object sender, EventArgs e) // dividir
        {
            opcion = "/";
            numeroUNO = int.Parse(textoResultado.Text);

            textoResultado.Clear();
        }


        private void button17_Click(object sender, EventArgs e) // ELEVADO
        {
            opcion = "**";
            numeroUNO = int.Parse(textoResultado.Text);

            textoResultado.Clear();
        }

 //////////////////////////////>   calcular =
        private void button19_Click(object sender, EventArgs e)
        {
            numeroDOS = int.Parse(textoResultado.Text);
            

            if(opcion.Equals("+")) //suma
            {
                
                Resultado = numeroUNO + numeroDOS;

            }


            if (opcion.Equals("-")) // resta
            {
                Resultado = numeroUNO - numeroDOS;

            }


            if (opcion.Equals("*")) // x
            {
                Resultado = numeroUNO * numeroDOS;

            }


            if (opcion.Equals("/")) // div
            {    
                Resultado = numeroUNO / numeroDOS;

            }

            if (opcion.Equals("**")) // elevado
            {
                Resultado = (int)Math.Pow(numeroUNO, numeroDOS);



            }


            textoResultado.Text = Resultado + "";        
        }

//////////////////////////////>   BORRAR todo 
        private void button2_Click(object sender, EventArgs e)
        {
            textoResultado.Text = "";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var text = textoResultado.Text;
            textoResultado.Text = text.Remove(text.Length - 1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

//Funciones graficadas BOTON GRAFCAR

        private void button3_Click_1(object sender, EventArgs e)
        {

            int uno = int.Parse(textBox1.Text);
            int dos = int.Parse(textBox2.Text);

            Series series = new Series();
            chart1.Series.Add(series);
            series.ChartType = SeriesChartType.Line;
            series.Name = "y=mx+b";

          

            for (int x = 0; x <= 10; x++)
            {
               
                int y = uno * x + dos;
                series.Points.AddXY(x, y);
            }

            chart1.Titles.Add("Ecuacion Lineal");
            chart1.Legends[0].Enabled = true;
            chart1.ChartAreas[0].AxisX.Title = "X";
            chart1.ChartAreas[0].AxisY.Title = "Y";



        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
