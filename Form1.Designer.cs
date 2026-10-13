namespace Avance1_KendallCampos
{
    partial class FrmEstudiantes
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
            lblTitulo = new Label();
            grpEstudiante = new GroupBox();
            cmbBloque = new ComboBox();
            cmbCarrera = new ComboBox();
            lblBloque = new Label();
            lblCarrera = new Label();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            txtEdad = new TextBox();
            lblEdad = new Label();
            txtIdentificacion = new TextBox();
            lblIdentificacion = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            grpEstudiante.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.MidnightBlue;
            lblTitulo.Location = new Point(13, 9);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(584, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "SISTEMA DE GESTION DE ESTUDIANTES";
            // 
            // grpEstudiante
            // 
            grpEstudiante.Controls.Add(cmbBloque);
            grpEstudiante.Controls.Add(cmbCarrera);
            grpEstudiante.Controls.Add(lblBloque);
            grpEstudiante.Controls.Add(lblCarrera);
            grpEstudiante.Controls.Add(txtCorreo);
            grpEstudiante.Controls.Add(lblCorreo);
            grpEstudiante.Controls.Add(txtEdad);
            grpEstudiante.Controls.Add(lblEdad);
            grpEstudiante.Controls.Add(txtIdentificacion);
            grpEstudiante.Controls.Add(lblIdentificacion);
            grpEstudiante.Controls.Add(txtNombre);
            grpEstudiante.Controls.Add(lblNombre);
            grpEstudiante.Location = new Point(13, 54);
            grpEstudiante.Margin = new Padding(4);
            grpEstudiante.Name = "grpEstudiante";
            grpEstudiante.Padding = new Padding(4);
            grpEstudiante.Size = new Size(500, 440);
            grpEstudiante.TabIndex = 1;
            grpEstudiante.TabStop = false;
            grpEstudiante.Text = "Datos del estudiante";
            // 
            // cmbBloque
            // 
            cmbBloque.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBloque.FormattingEnabled = true;
            cmbBloque.Items.AddRange(new object[] { "Bloque 1", "Bloque 2", "Bloque 3", "Bloque 4", "Bloque 5", "Bloque 6", "Bloque 7", "Bloque 8", "Bloque 9" });
            cmbBloque.Location = new Point(125, 343);
            cmbBloque.Name = "cmbBloque";
            cmbBloque.Size = new Size(280, 33);
            cmbBloque.TabIndex = 11;
            // 
            // cmbCarrera
            // 
            cmbCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Items.AddRange(new object[] { "Ingeniería en Sistemas ", "Administración de Empresas", "Ingeniería Industrial", "Ingeniería Civil", "Derecho", "Educación" });
            cmbCarrera.Location = new Point(125, 291);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(280, 33);
            cmbCarrera.TabIndex = 10;
            // 
            // lblBloque
            // 
            lblBloque.AutoSize = true;
            lblBloque.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBloque.Location = new Point(7, 343);
            lblBloque.Name = "lblBloque";
            lblBloque.Size = new Size(67, 23);
            lblBloque.TabIndex = 9;
            lblBloque.Text = "Bloque:";
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCarrera.Location = new Point(7, 296);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(70, 23);
            lblCarrera.TabIndex = 8;
            lblCarrera.Text = "Carrera:";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(179, 214);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(280, 30);
            txtCorreo.TabIndex = 7;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(7, 221);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(160, 23);
            lblCorreo.TabIndex = 6;
            lblCorreo.Text = "Correo electronico: ";
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEdad.Location = new Point(179, 161);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(280, 30);
            txtEdad.TabIndex = 5;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEdad.Location = new Point(7, 168);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(57, 23);
            lblEdad.TabIndex = 4;
            lblEdad.Text = "Edad: ";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdentificacion.Location = new Point(179, 110);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(280, 30);
            txtIdentificacion.TabIndex = 3;
            // 
            // lblIdentificacion
            // 
            lblIdentificacion.AutoSize = true;
            lblIdentificacion.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIdentificacion.Location = new Point(7, 113);
            lblIdentificacion.Name = "lblIdentificacion";
            lblIdentificacion.Size = new Size(121, 23);
            lblIdentificacion.TabIndex = 2;
            lblIdentificacion.Text = "Identificacion: ";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(179, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(280, 30);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(7, 63);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(154, 23);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre completo:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.LightSteelBlue;
            btnGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(520, 64);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 35);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Gainsboro;
            btnLimpiar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(520, 105);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(120, 35);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.LightCoral;
            btnSalir.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(520, 146);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(120, 35);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmEstudiantes
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1488, 816);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(grpEstudiante);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmEstudiantes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestion de Estudiantes";
            grpEstudiante.ResumeLayout(false);
            grpEstudiante.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox grpEstudiante;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private Label lblEdad;
        private TextBox txtIdentificacion;
        private Label lblIdentificacion;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private ComboBox cmbCarrera;
        private Label lblBloque;
        private Label lblCarrera;
        private ComboBox cmbBloque;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
