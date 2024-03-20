namespace Interfaz_Proyecto
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void basicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AFN_Basico form = new AFN_Basico();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
