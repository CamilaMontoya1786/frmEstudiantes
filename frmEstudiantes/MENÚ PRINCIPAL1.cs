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

namespace FrmEstudiantes
{

    /// <summary>
    /// Nombres: Jaider Oquendo Zapata - Maria Camila Montoya Zapata
    /// Fecha:25/04/2023
    /// Descripción: Formulario para acceder a otros formularios los cuales guardan datos de estudiante y datos acádemicos 
    /// /// </summary>
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cierra cualquiera de los dos formularios que se estuvieran utilizando 

            Form frmDatosEstudiantes = this.ActiveMdiChild;
            if (frmDatosEstudiantes != null)
            {
                frmDatosEstudiantes.Close();
            }

            Form frmDatosAcademicos = this.ActiveMdiChild;
            if (frmDatosAcademicos != null)
            {
                frmDatosAcademicos.Close();
            }


        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cierra el programa
            this.Close();
        }

        private void datosAcádemicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //crea el formulario de datos académicos y lo muestra
            frmDatosAcademicos formDatosAcademico = new frmDatosAcademicos();
            formDatosAcademico.MdiParent = this;
            formDatosAcademico.Show();
        }

        private void datosEstudiantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //crea el formulario de datos estudiantes y lo muestra
            frmDatosEstudiantes formDatosEstudiantes = new frmDatosEstudiantes();
            formDatosEstudiantes.MdiParent = this;
            formDatosEstudiantes.Show();


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void datosEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
            // MessageBox.Show("Señor usuario para guardar exitosamente su información; presione el botón guardar de la parte inferior del formulario."); MessageBox.Show("Señor usuario para guardar exitosamente su información; presione el botón guardar de la parte inferior del formulario.");
        }
    }


}
