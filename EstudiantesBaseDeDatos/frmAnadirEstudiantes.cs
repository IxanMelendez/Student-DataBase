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
    public partial class frmAnadirEstudiantes : Form
    {
        public frmAnadirEstudiantes()
        {
            InitializeComponent();
        }

        private void estudianteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estudianteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBEstudiantesDataSet);

        }

        private void estudianteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.estudianteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBEstudiantesDataSet);

        }

        private void estudianteBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.estudianteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBEstudiantesDataSet);

        }

        private void frmEstudiantes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBEstudiantesDataSet.Estudiante' table. You can move, or remove it, as needed.
            this.estudianteTableAdapter.Fill(this.dBEstudiantesDataSet.Estudiante);

        }
    }
}
