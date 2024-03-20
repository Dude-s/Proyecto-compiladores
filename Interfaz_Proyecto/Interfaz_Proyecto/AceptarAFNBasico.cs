using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Interfaz_Proyecto
{
    public partial class AceptarAFNBasico : Form
    {

        private AFN_Basico cerrar;
        public AceptarAFNBasico()
        {
            InitializeComponent();
            cerrar = new AFN_Basico();
        }

        private void OK1_Click(object sender, EventArgs e)
        {
            this.Close();

            if (cerrar != null)
            {
                cerrar.Close();
            }
        }
    }
}
