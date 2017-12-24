using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apagados_Programados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Apagado_Click(object sender, EventArgs e)
        {
            int valorNumerico = 0;

            String h = horas.Text;
            String m = minutos.Text;
            String s = segundos.Text;         

            if (int.TryParse(h, out valorNumerico) || int.TryParse(m, out valorNumerico) || int.TryParse(s, out valorNumerico))
            {
                //Métodos de funcionamiento normales REVISAR

                //System.FormatException
                try
                {
                    int numHoras = Int32.Parse(h);
                    int numMin = Int32.Parse(m);
                    int numSegun = Int32.Parse(s);

                    int hTotal = numHoras * 3600;
                    int mTotal = numMin * 60;

                    int total = hTotal + mTotal + numSegun;

                    //MessageBox.Show(total.ToString());

                    //LANZAMOS EL COMANDO PARA QUE LA CMD LO EJECUTE
                    String apagado = "shutdown -s -t " + total;
                    System.Diagnostics.ProcessStartInfo processStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c " + apagado);

                    //Indicamos que no se muestre la pantalla de cmd
                    processStartInfo.UseShellExecute = false;
                    processStartInfo.CreateNoWindow = false;

                    //Inicializamos el proceso
                    System.Diagnostics.Process proc = new System.Diagnostics.Process();
                    proc.StartInfo = processStartInfo;
                    proc.Start();

                }catch (System.FormatException) //Control de errores
                {
                    MessageBox.Show("ERROR: Debes escribir números, no letras");
                }

            }
            else
            {
                MessageBox.Show("ERROR: Debes escribir números, no letras");
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            //Cancela tanto reinicios como apagados
            String cancelar = "shutdown /a";

            //Creamos proceso para lanzar el comando a la cmd del sistema
            System.Diagnostics.ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd", "/c" + cancelar);

            //Indicamos que no se muestre la pantalla de cmd
            processStartInfo.UseShellExecute = false;
            processStartInfo.CreateNoWindow = false;

            //Inicializamos el proceso
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = processStartInfo;
            proc.Start();


        }

        private void Reinicio_Click(object sender, EventArgs e)
        {
            //Reinicios programados del sistema

            int valorNumerico = 0;

            String h = horas.Text;
            String m = minutos.Text;
            String s = segundos.Text;

            try
            {
                int numHoras = Int32.Parse(h);
                int numMin = Int32.Parse(m);
                int numSegun = Int32.Parse(s);

                int hTotal = numHoras * 3600;
                int mTotal = numMin * 60;

                int total = hTotal + mTotal + numSegun;

                //MessageBox.Show(total.ToString());

                //LANZAMOS EL COMANDO PARA QUE LA CMD LO EJECUTE
                String reinicio = "shutdown -r -t " + total;
                System.Diagnostics.ProcessStartInfo processStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c " + reinicio);

                //Indicamos que no se muestre la pantalla de cmd
                processStartInfo.UseShellExecute = false;
                processStartInfo.CreateNoWindow = false;

                //Inicializamos el proceso
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = processStartInfo;
                proc.Start();

            }
            catch (System.FormatException) //Control de errores
            {
                MessageBox.Show("ERROR: Debes escribir números, no letras");
            }

        }
    }
}
