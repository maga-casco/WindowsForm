namespace Login_WinForm
{
    partial class MenuPrincipal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            Formulario = new TabControl();
            tabUsuarios = new TabPage();
            btnExportarExcel = new Button();
            lblBuscar = new Label();
            lblListaDeUsuarios = new Label();
            txtBuscar = new TextBox();
            btnEditarUsuario = new Button();
            btnEliminarUsuario = new Button();
            dataGridView1 = new DataGridView();
            btnAgregarUsuario = new Button();
            tabFormulario = new TabPage();
            lblRol = new Label();
            cmbRol = new ComboBox();
            lblTitulo = new Label();
            btnCancelar = new Button();
            lblConfirmar = new Label();
            txtConfirmar = new TextBox();
            btnGuardarCambios = new Button();
            txtUsuarios = new TextBox();
            lblUsuario = new Label();
            lblContraseña = new Label();
            txtContraseñas = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Formulario.SuspendLayout();
            tabUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabFormulario.SuspendLayout();
            SuspendLayout();
            // 
            // Formulario
            // 
            Formulario.Controls.Add(tabUsuarios);
            Formulario.Controls.Add(tabFormulario);
            Formulario.Location = new Point(23, 27);
            Formulario.Name = "Formulario";
            Formulario.SelectedIndex = 0;
            Formulario.Size = new Size(766, 526);
            Formulario.TabIndex = 0;
            // 
            // tabUsuarios
            // 
            tabUsuarios.Controls.Add(btnExportarExcel);
            tabUsuarios.Controls.Add(lblBuscar);
            tabUsuarios.Controls.Add(lblListaDeUsuarios);
            tabUsuarios.Controls.Add(txtBuscar);
            tabUsuarios.Controls.Add(btnEditarUsuario);
            tabUsuarios.Controls.Add(btnEliminarUsuario);
            tabUsuarios.Controls.Add(dataGridView1);
            tabUsuarios.Controls.Add(btnAgregarUsuario);
            tabUsuarios.Location = new Point(4, 29);
            tabUsuarios.Name = "tabUsuarios";
            tabUsuarios.Padding = new Padding(3);
            tabUsuarios.Size = new Size(758, 493);
            tabUsuarios.TabIndex = 0;
            tabUsuarios.Text = "Usuarios";
            tabUsuarios.UseVisualStyleBackColor = true;
            tabUsuarios.Click += tabUsuarios_Click;
            // 
            // btnExportarExcel
            // 
            btnExportarExcel.BackColor = Color.SandyBrown;
            btnExportarExcel.ForeColor = SystemColors.ButtonHighlight;
            btnExportarExcel.Location = new Point(574, 230);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.Size = new Size(141, 39);
            btnExportarExcel.TabIndex = 12;
            btnExportarExcel.Text = "Exportar";
            btnExportarExcel.UseVisualStyleBackColor = false;
            btnExportarExcel.Click += btnExportarExcel_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(28, 65);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(55, 20);
            lblBuscar.TabIndex = 11;
            lblBuscar.Text = "Buscar:";
            // 
            // lblListaDeUsuarios
            // 
            lblListaDeUsuarios.AutoSize = true;
            lblListaDeUsuarios.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListaDeUsuarios.Location = new Point(28, 17);
            lblListaDeUsuarios.Name = "lblListaDeUsuarios";
            lblListaDeUsuarios.Size = new Size(195, 31);
            lblListaDeUsuarios.TabIndex = 10;
            lblListaDeUsuarios.Text = "Lista de Usuarios";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(89, 58);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(460, 27);
            txtBuscar.TabIndex = 9;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.BackColor = Color.CornflowerBlue;
            btnEditarUsuario.ForeColor = SystemColors.ButtonHighlight;
            btnEditarUsuario.Location = new Point(574, 140);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(141, 39);
            btnEditarUsuario.TabIndex = 8;
            btnEditarUsuario.Text = "Editar";
            btnEditarUsuario.UseVisualStyleBackColor = false;
            btnEditarUsuario.Click += btnEditarUsuario_Click;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.BackColor = Color.IndianRed;
            btnEliminarUsuario.ForeColor = SystemColors.ButtonHighlight;
            btnEliminarUsuario.Location = new Point(574, 185);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(141, 39);
            btnEliminarUsuario.TabIndex = 7;
            btnEliminarUsuario.Text = "Eliminar";
            btnEliminarUsuario.UseVisualStyleBackColor = false;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 95);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(521, 332);
            dataGridView1.TabIndex = 1;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.BackColor = Color.MediumSeaGreen;
            btnAgregarUsuario.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarUsuario.Location = new Point(574, 95);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(141, 39);
            btnAgregarUsuario.TabIndex = 4;
            btnAgregarUsuario.Text = "Agregar usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = false;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // tabFormulario
            // 
            tabFormulario.Controls.Add(lblRol);
            tabFormulario.Controls.Add(cmbRol);
            tabFormulario.Controls.Add(lblTitulo);
            tabFormulario.Controls.Add(btnCancelar);
            tabFormulario.Controls.Add(lblConfirmar);
            tabFormulario.Controls.Add(txtConfirmar);
            tabFormulario.Controls.Add(btnGuardarCambios);
            tabFormulario.Controls.Add(txtUsuarios);
            tabFormulario.Controls.Add(lblUsuario);
            tabFormulario.Controls.Add(lblContraseña);
            tabFormulario.Controls.Add(txtContraseñas);
            tabFormulario.Location = new Point(4, 29);
            tabFormulario.Name = "tabFormulario";
            tabFormulario.Size = new Size(758, 493);
            tabFormulario.TabIndex = 1;
            tabFormulario.Text = "Formulario";
            tabFormulario.UseVisualStyleBackColor = true;
            tabFormulario.Click += tabPage1_Click;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(37, 254);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(121, 20);
            lblRol.TabIndex = 46;
            lblRol.Text = "Seleccione el rol:";
            lblRol.TextAlign = ContentAlignment.TopCenter;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(37, 277);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(170, 28);
            cmbRol.TabIndex = 45;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(27, 17);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(258, 31);
            lblTitulo.TabIndex = 44;
            lblTitulo.Text = "Agregar nuevo usuario";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkGray;
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(184, 323);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(141, 39);
            btnCancelar.TabIndex = 43;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblConfirmar
            // 
            lblConfirmar.AutoSize = true;
            lblConfirmar.Location = new Point(37, 189);
            lblConfirmar.Name = "lblConfirmar";
            lblConfirmar.Size = new Size(170, 20);
            lblConfirmar.TabIndex = 42;
            lblConfirmar.Text = "Confirmar la contraseña:";
            lblConfirmar.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtConfirmar
            // 
            txtConfirmar.Location = new Point(37, 215);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.Size = new Size(288, 27);
            txtConfirmar.TabIndex = 41;
            txtConfirmar.UseSystemPasswordChar = true;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.BackColor = Color.MediumSeaGreen;
            btnGuardarCambios.ForeColor = SystemColors.ButtonHighlight;
            btnGuardarCambios.Location = new Point(37, 323);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(141, 39);
            btnGuardarCambios.TabIndex = 40;
            btnGuardarCambios.Text = "Guardar";
            btnGuardarCambios.UseVisualStyleBackColor = false;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // txtUsuarios
            // 
            txtUsuarios.Location = new Point(37, 87);
            txtUsuarios.Name = "txtUsuarios";
            txtUsuarios.Size = new Size(288, 27);
            txtUsuarios.TabIndex = 36;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(37, 64);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(107, 20);
            lblUsuario.TabIndex = 38;
            lblUsuario.Text = "Nuevo usuario:";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(37, 126);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(86, 20);
            lblContraseña.TabIndex = 39;
            lblContraseña.Text = "Contraseña:";
            // 
            // txtContraseñas
            // 
            txtContraseñas.Location = new Point(37, 149);
            txtContraseñas.Name = "txtContraseñas";
            txtContraseñas.Size = new Size(288, 27);
            txtContraseñas.TabIndex = 37;
            txtContraseñas.UseSystemPasswordChar = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 565);
            Controls.Add(Formulario);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuPrincipal";
            Load += MenuPrincipal_Load;
            Formulario.ResumeLayout(false);
            tabUsuarios.ResumeLayout(false);
            tabUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabFormulario.ResumeLayout(false);
            tabFormulario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Formulario;
        private TabPage tabUsuarios;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnAgregarUsuario;
        private DataGridView dataGridView1;
        private Button btnEliminarUsuario;
        private Button btnEditarUsuario;
        private TabPage tabFormulario;
        private TextBox txtBuscar;
        private Label label1;
        private TextBox txtUsuarios;
        private Label lblUsuario;
        private Label lblContraseña;
        private TextBox txtContraseñas;
        private Label lblConfirmar;
        private TextBox txtConfirmar;
        private Button btnGuardarCambios;
        private Button btnCancelar;
        private Label lblBuscar;
        private Label lblListaDeUsuarios;
        private Label lblTitulo;
        private Label lblRol;
        private ComboBox cmbRol;
        private Button btnExportarExcel;
    }
}