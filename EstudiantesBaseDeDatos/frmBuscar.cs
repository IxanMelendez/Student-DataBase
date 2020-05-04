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
    public partial class frmBuscar : Form
    {
        public frmBuscar()
        {
            InitializeComponent();
        }

        private void estudianteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estudianteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBEstudiantesDataSet);

        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBEstudiantesDataSet.Estudiante' table. You can move, or remove it, as needed.
            this.estudianteTableAdapter.Fill(this.dBEstudiantesDataSet.Estudiante);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.estudianteTableAdapter.FillBy(this.dBEstudiantesDataSet.Estudiante, nombreDepartamentoToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


    }
}
