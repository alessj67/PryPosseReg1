namespace PryPosseReg1
{
    partial class frmAgregarClientes
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
            grbAgregar = new GroupBox();
            txtLimite = new TextBox();
            txtUsuario = new TextBox();
            txtDeuda = new TextBox();
            txtCodigo = new TextBox();
            lblLimite = new Label();
            lblUsuario = new Label();
            lblDeuda = new Label();
            lblCodigo = new Label();
            btnCargar = new Button();
            grbAgregar.SuspendLayout();
            SuspendLayout();
            // 
            // grbAgregar
            // 
            grbAgregar.BackColor = Color.RosyBrown;
            grbAgregar.Controls.Add(txtLimite);
            grbAgregar.Controls.Add(txtUsuario);
            grbAgregar.Controls.Add(txtDeuda);
            grbAgregar.Controls.Add(txtCodigo);
            grbAgregar.Controls.Add(lblLimite);
            grbAgregar.Controls.Add(lblUsuario);
            grbAgregar.Controls.Add(lblDeuda);
            grbAgregar.Controls.Add(lblCodigo);
            grbAgregar.Controls.Add(btnCargar);
            grbAgregar.Location = new Point(12, 12);
            grbAgregar.Name = "grbAgregar";
            grbAgregar.Size = new Size(556, 223);
            grbAgregar.TabIndex = 0;
            grbAgregar.TabStop = false;
            grbAgregar.Text = "Carga de datos";
            // 
            // txtLimite
            // 
            txtLimite.Location = new Point(412, 100);
            txtLimite.Name = "txtLimite";
            txtLimite.Size = new Size(100, 23);
            txtLimite.TabIndex = 8;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(370, 25);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(142, 23);
            txtUsuario.TabIndex = 7;
            // 
            // txtDeuda
            // 
            txtDeuda.Location = new Point(143, 97);
            txtDeuda.Name = "txtDeuda";
            txtDeuda.Size = new Size(124, 23);
            txtDeuda.TabIndex = 6;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(143, 27);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(124, 23);
            txtCodigo.TabIndex = 5;
            // 
            // lblLimite
            // 
            lblLimite.AutoSize = true;
            lblLimite.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblLimite.Location = new Point(292, 104);
            lblLimite.Name = "lblLimite";
            lblLimite.Size = new Size(105, 16);
            lblLimite.TabIndex = 4;
            lblLimite.Text = "Límite de crédito";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblUsuario.Location = new Point(292, 32);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(54, 16);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario";
            // 
            // lblDeuda
            // 
            lblDeuda.AutoSize = true;
            lblDeuda.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblDeuda.Location = new Point(66, 104);
            lblDeuda.Name = "lblDeuda";
            lblDeuda.Size = new Size(48, 16);
            lblDeuda.TabIndex = 2;
            lblDeuda.Text = "Deuda";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblCodigo.Location = new Point(66, 34);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(51, 16);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código";
            // 
            // btnCargar
            // 
            btnCargar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCargar.Location = new Point(437, 169);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(97, 32);
            btnCargar.TabIndex = 0;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // frmAgregarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(593, 247);
            Controls.Add(grbAgregar);
            Name = "frmAgregarClientes";
            Text = "Agregar Clientes";
            grbAgregar.ResumeLayout(false);
            grbAgregar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbAgregar;
        private Label lblLimite;
        private Label lblUsuario;
        private Label lblDeuda;
        private Label lblCodigo;
        private Button btnCargar;
        private TextBox txtLimite;
        private TextBox txtUsuario;
        private TextBox txtDeuda;
        private TextBox txtCodigo;
    }
}