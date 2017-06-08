using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEUTEC;

namespace Proyecto_Hospital
{
    public partial class frmMenu : Form
    {
        public static bool validacion = false;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (auxiliar.conn.Conectar(".", "Hospital", "sa", "holamundo"))
            {
                MessageBox.Show("Conectado exitosamente a la base de datos");
            }
            else
            {
                MessageBox.Show("Error al conectarse.! " + auxiliar.conn.SQLError());
            }
        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.ShowDialog(this);

            if (validacion)
            {
                pactoDeStockToolStripMenuItem.Enabled = true;
                reposicionDeStockToolStripMenuItem.Enabled = true;
            }
            else
            {
                pactoDeStockToolStripMenuItem.Enabled = false;
                reposicionDeStockToolStripMenuItem.Enabled = false;
            }
            validacion = false;
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pacto frm = new Pacto();
            frm.Show();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrar_Pacto frm = new frmMostrar_Pacto();
            frm.Show();
        }
    }
}
