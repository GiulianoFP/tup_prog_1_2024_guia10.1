using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1
{
    public partial class Form1 : Form
    {

        #region dominio
        double distBici = 0;        
        double distMoto = 0;
        

        int Automovil = 0;
        int TransporteP = 0;
        int Bicicleta = 0;
        int Moto = 0;

        #region promedios
        double CalcularPromMoto()
        {
            double promedio = 0;
            if (Moto > 0)
                promedio = distMoto / Moto;

            return promedio;
        }
        double CalcularPromBici()
        {
            double promedio = 0;
            if (Bicicleta > 0)
                promedio = distBici / Bicicleta;

            return promedio;
        }
        #endregion
        int CalcularPersonas()
        {
            return Bicicleta+Moto+Automovil+TransporteP;
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double distancia = Convert.ToDouble(txtDistancia.Text);
            if(rbBici.Checked)
            {
                Bicicleta ++;
                distBici += distancia;
     
            }
            else if (rbMoto.Checked)
            {
                Moto++;
                distMoto += distancia;

            }
            else if (rbAuto.Checked)
            {
                Automovil++;
    
            }
            else
            {
                TransporteP++;
       
            }


            #region clear
            rbBici.Checked = false;
            rbMoto.Checked = false;
            rbAuto.Checked = false;
            rbTPublico.Checked = false;
            txtDistancia.Clear();
            #endregion
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int poblacion = CalcularPersonas();
            double promBici = CalcularPromBici();
            double promMoto = CalcularPromMoto();
            listBox1.Items.Add($"Poblacion: {poblacion}");
            listBox1.Items.Add($"Promedio de distancia recorrida por usuarios de bicicleta:{promBici}");
            listBox1.Items.Add($"Promedio de distancia recorrida por usuarios de motocicleta:{promMoto}");


        }
    }
}
