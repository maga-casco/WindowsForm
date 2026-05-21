namespace Login_WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnLogin = new Button();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            label1 = new Label();
            label2 = new Label();
            chkMostrarCaracteres = new CheckBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(151, 200);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(153, 29);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnIniciarSesion_Click_1;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(39, 58);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(265, 27);
            txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(39, 127);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(265, 27);
            txtContraseña.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 35);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 3;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 104);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 4;
            label2.Text = "Contraseña:";
            // 
            // chkMostrarCaracteres
            // 
            chkMostrarCaracteres.AutoSize = true;
            chkMostrarCaracteres.Location = new Point(40, 161);
            chkMostrarCaracteres.Name = "chkMostrarCaracteres";
            chkMostrarCaracteres.Size = new Size(158, 24);
            chkMostrarCaracteres.TabIndex = 5;
            chkMostrarCaracteres.Text = "Mostrar contraseña";
            chkMostrarCaracteres.UseVisualStyleBackColor = true;
            chkMostrarCaracteres.CheckedChanged += chkMostrarCaracteres_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 333);
            Controls.Add(chkMostrarCaracteres);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(btnLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Label label1;
        private Label label2;
        private CheckBox chkMostrarCaracteres;
        private Button btnConexion;
    }
}
