using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;



namespace WindowsFormsApplication2
{
    public partial class promedio : Form
    {

       
        double nn, nn2, nn3, nn4, nn5, nt, pr;

     

        private void btnc_Click(object sender, EventArgs e)
        {
            
            StreamReader leer = File.OpenText("C:\\Users\\JAR\\Desktop\\proyect\\guardar\\text.txt");
            
            StreamReader leer2 = File.OpenText("C:\\Users\\JAR\\Desktop\\proyect\\guardar\\text2.txt");
            StreamReader leer3 = File.OpenText("C:\\Users\\JAR\\Desktop\\proyect\\guardar\\text3.txt");
            StreamReader leer4 = File.OpenText("C:\\Users\\JAR\\Desktop\\proyect\\guardar\\text4.txt");
            StreamReader leer5 = File.OpenText("C:\\Users\\JAR\\Desktop\\proyect\\guardar\\text5.txt");
            StreamReader leer6 = File.OpenText("C:\\Users\\JAR\\Desktop\\proyect\\guardar\\text6.txt");
            StreamReader leer7 = File.OpenText("C:\\Users\\JAR\\Desktop\\proyect\\guardar\\text7.txt");
            StreamReader leer8 = File.OpenText("C:\\Users\\JAR\\Desktop\\proyect\\guardar\\text8.txt");
            StreamReader leer9 = File.OpenText("C:\\Users\\JAR\\Desktop\\proyect\\guardar\\text9.txt");
            StreamReader leer10 = File.OpenText("C:\\Users\\JAR\\Desktop\\proyect\\guardar\\text10.txt");
            StreamReader leer11 = File.OpenText("C:\\Users\\JAR\\Desktop\\proyect\\guardar\\text11.txt");
            StreamReader leer1 = File.OpenText("C:\\Users\\JAR\\Desktop\\proyect\\guardar\\text1.txt");
            StreamReader leer12 = File.OpenText("C:\\Users\\JAR\\Desktop\\proyect\\guardar\\text12.txt");
            string contenido = null;
            string contenido1 = null;
            string contenido2 = null;
            string contenido3 = null;
            string contenido4 = null;
            string contenido5 = null;
            string contenido6 = null;
            string contenido7 = null;
            string contenido8 = null;
            string contenido9 = null;
            string contenido10 = null;
            string contenido11 = null;
            string contenido12 = null;
            while ((contenido = leer.ReadLine()) != null)
            {
                pantalla.Text = contenido.ToString();
               
            }


            while ((contenido1 = leer1.ReadLine()) != null)
            {

                n1.Text = contenido1.ToString();
            }
            while ((contenido2 = leer2.ReadLine()) != null)
            {

                n2.Text = contenido2.ToString();
            }
            while ((contenido3 = leer3.ReadLine()) != null)
            {

                n3.Text = contenido3.ToString();
            }
            while ((contenido4 = leer4.ReadLine()) != null)
            {

                n4.Text = contenido4.ToString();
            }
            while ((contenido5 = leer5.ReadLine()) != null)
            {

                n5.Text = contenido5.ToString();
            }
            while ((contenido6 = leer6.ReadLine()) != null)
            {

                pantalla2.Text = contenido6.ToString();
            }
            while((contenido7 = leer7.ReadLine()) != null)
            {
               
                    checkBox1.CheckState = CheckState.Checked;
                

                

            }

            while ((contenido8 = leer8.ReadLine()) != null)
            {

                na.Text = contenido8.ToString();
            }
            while ((contenido9 = leer9.ReadLine()) != null)
            {

                es.Text = contenido9.ToString();
            }
            while ((contenido10 = leer10.ReadLine()) != null)
            {

                nl.Text = contenido10.ToString();
            }
            while ((contenido11 = leer11.ReadLine()) != null)
            {

                sc.Text = contenido11.ToString();
            }

            while ((contenido12 = leer12.ReadLine()) != null)
            {
                porcentage.Text = contenido12.ToString();
            }
                 

        }
         
        private void btnguardar_Click(object sender, EventArgs e)
        {
            StreamWriter escrito = File.CreateText("C:\\Users\\JAR\\Desktop\\proyect\\guardar\\text.txt");
            StreamWriter escrito1 = File.CreateText("C:\\Users\\JAR\\Desktop\\proyect\\guardar\\text1.txt");
            StreamWriter escrito2 = File.CreateText("C:\\Users\\JAR\\Desktop\\proyect\\guardar\\text2.txt");
            StreamWriter escrito3 = File.CreateText("C:\\Users\\JAR\\Desktop\\proyect\\guardar\\text3.txt");
            StreamWriter escrito4 = File.CreateText("C:\\Users\\JAR\\Desktop\\proyect\\guardar\\text4.txt");
            StreamWriter escrito5 = File.CreateText("C:\\Users\\JAR\\Desktop\\proyect\\guardar\\text5.txt");
            StreamWriter escrito6 = File.CreateText("C:\\Users\\JAR\\Desktop\\proyect\\guardar\\text6.txt");
            StreamWriter escrito7 = File.CreateText("C:\\Users\\JAR\\Desktop\\proyect\\guardar\\text7.txt");
            StreamWriter escrito8 = File.CreateText("C:\\Users\\JAR\\Desktop\\proyect\\guardar\\text8.txt");
            StreamWriter escrito9 = File.CreateText("C:\\Users\\JAR\\Desktop\\proyect\\guardar\\text9.txt");
            StreamWriter escrito10 = File.CreateText("C:\\Users\\JAR\\Desktop\\proyect\\guardar\\text10.txt");
            StreamWriter escrito11 = File.CreateText("C:\\Users\\JAR\\Desktop\\proyect\\guardar\\text11.txt");
            StreamWriter escrito12 = File.CreateText("C:\\Users\\JAR\\Desktop\\proyect\\guardar\\text12.txt");

            string contenido = pantalla.Text;
            string contenido1 = n1.Text;
            string contenido2 = n2.Text;
            string contenido3 = n3.Text;
            string contenido4 = n4.Text;
            string contenido5 = n5.Text;
            string contenido6 = pantalla2.Text;
            bool contenido7 = checkBox1.Checked;
            string contenido8 = na.Text;
            string contenido9 = es.Text;
            string contenido10 = nl.Text;
            string contenido11 = sc.Text;
            string contenido12 = porcentage.Text;

            escrito.Write(contenido);
            escrito1.Write(contenido1);
            escrito2.Write(contenido2);
            escrito3.Write(contenido3);
            escrito4.Write(contenido4);
            escrito5.Write(contenido5);
            escrito6.Write(contenido6);
            escrito7.Write(contenido7);
            escrito8.Write(contenido8);
            escrito9.Write(contenido9);
            escrito10.Write(contenido10);
            escrito11.Write(contenido11);
            escrito12.Write(contenido12);
            escrito.Flush();
            escrito.Close();
            escrito1.Flush();
            escrito2.Close();
            escrito3.Flush();
            escrito3.Close();
            escrito4.Flush();
            escrito4.Close();
            escrito5.Flush();
            escrito5.Close();
            escrito6.Flush();
            escrito6.Close();
            escrito7.Flush();
            escrito7.Close();
            escrito8.Flush();
            escrito8.Close();
            escrito9.Flush();
            escrito9.Close();
            escrito10.Flush();
            escrito10.Close();
            escrito11.Flush();
            escrito11.Close();
            escrito12.Flush();
            escrito12.Close();
            pantalla.Text = "";
            pantalla2.Text = "";
            n1.Text = "";
            n2.Text = "";
            n3.Text = "";
            n4.Text = "";
            n5.Text = "";
            na.Text = "";
            sc.Text = "";
            es.Text = "";
            nl.Text = "";
            porcentage.Text = "";
            checkBox1.Checked = false;



            MessageBox.Show("guardado correctamente","Guardar");


        }

        public promedio()
        {
            InitializeComponent();
        }

        private void btnr_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(n1.Text);
            double numero2 = Convert.ToDouble(n2.Text);
            double numero3 = Convert.ToDouble(n3.Text);
            double numero4 = Convert.ToDouble(n4.Text);
            double numero5 = Convert.ToDouble(n5.Text);
            


           

            nn = Convert.ToDouble(numero1) * 0.35;
            nn2 = Convert.ToDouble(numero2) * 0.10;
            nn3 = Convert.ToDouble(numero3) * 0.25;
            nn4 = Convert.ToDouble(numero4) * 0.05;
            nn5 = Convert.ToDouble(numero5) * 0.40;

            nt = nn + nn2 + nn3 + nn4 + nn5 / 4;

            pr = (35 * nt)/100 ;


            porcentage.Text = pr.ToString();
           

            pantalla.Text = nt.ToString();

            if (nt <= 6.49 )
            {
                if (nt == 5)
                {
                    string b = "Bueno";
                    pantalla2.Text = b;

                }

                if (nt == 4)
                {
                    string r = "Regular";
                    pantalla2.Text = r;

                }

                if (nt == 3)
                {
                    string r = "Regular";
                    pantalla2.Text = r;

                }
                if (nt == 2)
                {
                    string nb = "No Tan Bueno";
                    pantalla2.Text = nb;

                }
                if (nt == 1)
                {
                    string nb = "No Tan Bueno";
                    pantalla2.Text = nb;

                }

                checkBox2.CheckState = CheckState.Checked; 
            }


            if (nt >= 6.50)
            {
                if (nt == 10)
                {
                    string exelente = "exelente";

                    pantalla2.Text = exelente;


                }
                if (nt == 9)
                {
                    string  exelente = "exelente";
                    
                    pantalla2.Text = exelente;
                    
                    
                }
                if (nt == 7)
                {
                    string mb = "Muy Bueno";
                    pantalla2.Text = mb;

                }
                if (nt == 8)
                {
                    string mb = "Muy Bueno";
                    pantalla2.Text = mb;

                }
                if (nt == 6)
                {
                    string b = "Bueno";
                    pantalla2.Text = b;

                }
               


                checkBox1.CheckState = CheckState.Checked;
            }

            


        }

       

    }
}
