using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudiantesBaseDeDatos
{
    public partial class frmDataGrid : Form
    {
        public frmDataGrid()
        {
            InitializeComponent();
        }

        private void estudianteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estudianteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBEstudiantesDataSet);

        }

        private void DataGrid_Load(object sender, EventArgs e)
        {
            
            Update();

        }
        private void Update()
        {
            //Actualiza la tabla prmaria 
            this.estudianteTableAdapter.Fill(this.dBEstudiantesDataSet.Estudiante);
        }

        private void estudianteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void añadirEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void añadirEstudianteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAnadirEstudiantes frm = new frmAnadirEstudiantes();
            frm.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fillByDepartmentToolStripButton_Click(object sender, EventArgs e)
        {
           
      

        }

        private void buscarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Llama a la forma de Buscar el cual funciona para buscar estudiantes por departamento.
            frmBuscar Buscar = new frmBuscar();
            Buscar.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
