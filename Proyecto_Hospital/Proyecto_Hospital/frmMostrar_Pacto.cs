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
    public partial class frmMostrar_Pacto : Form
    {
        public frmMostrar_Pacto()
        {
            InitializeComponent();
        }

        private void CargarUnidades()
        {
            try
            {
                string query = "";
                DataTable dt = null;

                query = @"SELECT
                      idunidad, tipounidad as unidad_medida
                      FROM
                      Unidad";

                if (auxiliar.conn.SQLSelectDataTable(query, ref dt))
                {
                    unidad_medida.DisplayMember = "unidad_medida";
                    unidad_medida.ValueMember = "unidad_medida";
                    unidad_medida.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo de Unidad: " +
                                 ex.ToString());
            }



        }
        private void CargarFrecuencia()
        {
            try
            {
                string query = "";
                DataTable dt = null;

                query = @"SELECT
                      id, nombre as frecuencia
                      FROM
                      Frecuencia";

                if (auxiliar.conn.SQLSelectDataTable(query, ref dt))
                {
                    frecuencia.DisplayMember = "frecuencia";
                    frecuencia.ValueMember = "frecuencia";
                    frecuencia.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo de Frecuencia: " +
                                 ex.ToString());
            }



        }

        private void mostrar()
        {
            try
            {
                string query = "";
                DataTable dt = null;

                query = @"SELECT 
                      codigo_stock,descripcion,unidad_medida,pacto_stocks
                       ,frecuencia,costo_unitario,costo_total,fecha,codigopacto
                      FROM
                      pacto_stock
                     ";

                if (auxiliar.conn.SQLSelectDataTable(query, ref dt))
                {
                    dgpacto.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Mostrar: " +
                                 ex.ToString());
            }
        }
        private void frmMostrar_Pacto_Load(object sender, EventArgs e)
        {
            CargarFrecuencia();
            CargarUnidades();
            mostrar();
        }

        private void BuscarPorFecha()
        {
            try
            {
                string query = "";
                DataTable dt = null;

                query = @"SELECT 
                      codigo_stock,descripcion,unidad_medida,pacto_stocks
                       ,frecuencia,costo_unitario,costo_total,fecha,codigopacto
                      FROM
                      pacto_stock
                      where
                      fecha = '{0}'
                     ";
                query = string.Format(query, dtfecha.Text);
                if (auxiliar.conn.SQLSelectDataTable(query, ref dt))
                {
                    dgpacto.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Mostrar: " +
                                 ex.ToString());
            }
        }

        private void btnBuscarPorFecha_Click(object sender, EventArgs e)
        {
            CargarFrecuencia();
            CargarUnidades();
            BuscarPorFecha();
        }
    }
}
