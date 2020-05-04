namespace EstudiantesBaseDeDatos
{
    partial class frmAnadirEstudiantes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label numero_de_EstudianteLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label departamentoLabel;
            System.Windows.Forms.Label fecha_de_IngresoLabel;
            System.Windows.Forms.Label paisLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnadirEstudiantes));
            this.dBEstudiantesDataSet = new EstudiantesBaseDeDatos.DBEstudiantesDataSet();
            this.estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudianteTableAdapter = new EstudiantesBaseDeDatos.DBEstudiantesDataSetTableAdapters.EstudianteTableAdapter();
            this.tableAdapterManager = new EstudiantesBaseDeDatos.DBEstudiantesDataSetTableAdapters.TableAdapterManager();
            this.estudianteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.estudianteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.numero_de_EstudianteLabel1 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.departamentoTextBox = new System.Windows.Forms.TextBox();
            this.fecha_de_IngresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.paisTextBox = new System.Windows.Forms.TextBox();
            this.dbEstudiantesDataSet1 = new EstudiantesBaseDeDatos.DBEstudiantesDataSet();
            numero_de_EstudianteLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            departamentoLabel = new System.Windows.Forms.Label();
            fecha_de_IngresoLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBEstudiantesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingNavigator)).BeginInit();
            this.estudianteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbEstudiantesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // numero_de_EstudianteLabel
            // 
            numero_de_EstudianteLabel.AutoSize = true;
            numero_de_EstudianteLabel.Location = new System.Drawing.Point(12, 61);
            numero_de_EstudianteLabel.Name = "numero_de_EstudianteLabel";
            numero_de_EstudianteLabel.Size = new System.Drawing.Size(115, 13);
            numero_de_EstudianteLabel.TabIndex = 1;
            numero_de_EstudianteLabel.Text = "Numero de Estudiante:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(12, 90);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(12, 116);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 5;
            apellidoLabel.Text = "Apellido:";
            // 
            // departamentoLabel
            // 
            departamentoLabel.AutoSize = true;
            departamentoLabel.Location = new System.Drawing.Point(12, 142);
            departamentoLabel.Name = "departamentoLabel";
            departamentoLabel.Size = new System.Drawing.Size(77, 13);
            departamentoLabel.TabIndex = 7;
            departamentoLabel.Text = "Departamento:";
            // 
            // fecha_de_IngresoLabel
            // 
            fecha_de_IngresoLabel.AutoSize = true;
            fecha_de_IngresoLabel.Location = new System.Drawing.Point(12, 169);
            fecha_de_IngresoLabel.Name = "fecha_de_IngresoLabel";
            fecha_de_IngresoLabel.Size = new System.Drawing.Size(93, 13);
            fecha_de_IngresoLabel.TabIndex = 9;
            fecha_de_IngresoLabel.Text = "Fecha de Ingreso:";
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.Location = new System.Drawing.Point(12, 194);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(30, 13);
            paisLabel.TabIndex = 11;
            paisLabel.Text = "Pais:";
            // 
            // dBEstudiantesDataSet
            // 
            this.dBEstudiantesDataSet.DataSetName = "DBEstudiantesDataSet";
            this.dBEstudiantesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estudianteBindingSource
            // 
            this.estudianteBindingSource.DataMember = "Estudiante";
            this.estudianteBindingSource.DataSource = this.dBEstudiantesDataSet;
            // 
            // estudianteTableAdapter
            // 
            this.estudianteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EstudianteTableAdapter = this.estudianteTableAdapter;
            this.tableAdapterManager.UpdateOrder = EstudiantesBaseDeDatos.DBEstudiantesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // estudianteBindingNavigator
            // 
            this.estudianteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.estudianteBindingNavigator.BindingSource = this.estudianteBindingSource;
            this.estudianteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.estudianteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.estudianteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.estudianteBindingNavigatorSaveItem});
            this.estudianteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.estudianteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.estudianteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.estudianteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.estudianteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.estudianteBindingNavigator.Name = "estudianteBindingNavigator";
            this.estudianteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.estudianteBindingNavigator.Size = new System.Drawing.Size(359, 25);
            this.estudianteBindingNavigator.TabIndex = 0;
            this.estudianteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // estudianteBindingNavigatorSaveItem
            // 
            this.estudianteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.estudianteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("estudianteBindingNavigatorSaveItem.Image")));
            this.estudianteBindingNavigatorSaveItem.Name = "estudianteBindingNavigatorSaveItem";
            this.estudianteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.estudianteBindingNavigatorSaveItem.Text = "Save Data";
            this.estudianteBindingNavigatorSaveItem.Click += new System.EventHandler(this.estudianteBindingNavigatorSaveItem_Click_2);
            // 
            // numero_de_EstudianteLabel1
            // 
            this.numero_de_EstudianteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "Numero de Estudiante", true));
            this.numero_de_EstudianteLabel1.Location = new System.Drawing.Point(133, 61);
            this.numero_de_EstudianteLabel1.Name = "numero_de_EstudianteLabel1";
            this.numero_de_EstudianteLabel1.Size = new System.Drawing.Size(200, 23);
            this.numero_de_EstudianteLabel1.TabIndex = 2;
            this.numero_de_EstudianteLabel1.Text = "label1";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(133, 87);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "Apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(133, 113);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(200, 20);
            this.apellidoTextBox.TabIndex = 6;
            // 
            // departamentoTextBox
            // 
            this.departamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "Departamento", true));
            this.departamentoTextBox.Location = new System.Drawing.Point(133, 139);
            this.departamentoTextBox.Name = "departamentoTextBox";
            this.departamentoTextBox.Size = new System.Drawing.Size(200, 20);
            this.departamentoTextBox.TabIndex = 8;
            // 
            // fecha_de_IngresoDateTimePicker
            // 
            this.fecha_de_IngresoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.estudianteBindingSource, "Fecha de Ingreso", true));
            this.fecha_de_IngresoDateTimePicker.Location = new System.Drawing.Point(133, 165);
            this.fecha_de_IngresoDateTimePicker.Name = "fecha_de_IngresoDateTimePicker";
            this.fecha_de_IngresoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_de_IngresoDateTimePicker.TabIndex = 10;
            // 
            // paisTextBox
            // 
            this.paisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "Pais", true));
            this.paisTextBox.Location = new System.Drawing.Point(133, 191);
            this.paisTextBox.Name = "paisTextBox";
            this.paisTextBox.Size = new System.Drawing.Size(200, 20);
            this.paisTextBox.TabIndex = 12;
            // 
            // dbEstudiantesDataSet1
            // 
            this.dbEstudiantesDataSet1.DataSetName = "DBEstudiantesDataSet";
            this.dbEstudiantesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmAnadirEstudiantes
            // 
            this.ClientSize = new System.Drawing.Size(359, 233);
            this.Controls.Add(numero_de_EstudianteLabel);
            this.Controls.Add(this.numero_de_EstudianteLabel1);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(departamentoLabel);
            this.Controls.Add(this.departamentoTextBox);
            this.Controls.Add(fecha_de_IngresoLabel);
            this.Controls.Add(this.fecha_de_IngresoDateTimePicker);
            this.Controls.Add(paisLabel);
            this.Controls.Add(this.paisTextBox);
            this.Controls.Add(this.estudianteBindingNavigator);
            this.Name = "frmAnadirEstudiantes";
            this.Text = "Añadir Estudiantes";
            this.Load += new System.EventHandler(this.frmEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBEstudiantesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingNavigator)).EndInit();
            this.estudianteBindingNavigator.ResumeLayout(false);
            this.estudianteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbEstudiantesDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBEstudiantesDataSet dBEstudiantesDataSet;
        private System.Windows.Forms.BindingSource estudianteBindingSource;
        private DBEstudiantesDataSetTableAdapters.EstudianteTableAdapter estudianteTableAdapter;
        private DBEstudiantesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator estudianteBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton estudianteBindingNavigatorSaveItem;
        private System.Windows.Forms.Label numero_de_EstudianteLabel1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox departamentoTextBox;
        private System.Windows.Forms.DateTimePicker fecha_de_IngresoDateTimePicker;
        private System.Windows.Forms.TextBox paisTextBox;
        private DBEstudiantesDataSet dbEstudiantesDataSet1;
    }
}

