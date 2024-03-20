using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Interfaz_Proyecto
{
    public partial class AFN_Basico : Form
    {
        public AFN_Basico()
        {
            InitializeComponent();
        }
        private void AFN_Basico_Load(object sender, EventArgs e)
        {
            aceptar.Enabled = true;
        }

        private void Rango1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().Length > 1)
            {
                e.Handled = true;
            }
        }

        private void Rango2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().Length > 1)
            {
                e.Handled = true;
            }
        }

        private void IdAFN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public string ObtenerPrimerosCaracteres(string texto)
        {
            // Separar las palabras en un array
            string[] palabras = texto.Split(' ');

            // Obtener el primer caracter de cada palabra
            string[] primerosCaracteres = new string[palabras.Length];
            for (int i = 0; i < palabras.Length; i++)
            {
                primerosCaracteres[i] = palabras[i].Substring(0, 1);
            }

            // Unir los caracteres en una sola cadena
            string resultado = string.Join("", primerosCaracteres);

            return resultado;
        }

        private void aceptar_Click(object sender, EventArgs e)
        {

            AceptarAFNBasico aceptar = new AceptarAFNBasico();

            char R1 = Rango1.Text[0];
            char R2 = Rango2.Text[0];
            string id = IdAFN.Text;


            // Crear una instancia de AFN
            AFN automata = new AFN(null, null,null);

            // Llamar al método CrearAFNBasico con los parámetros necesarios
            automata.CrearAFNBasico(R1,R2,id);

            aceptar.Show();


        }

    }
}
