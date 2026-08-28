namespace PryPosseReg1
{
    partial class frmClientesDeudores
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
            grbDeudores = new GroupBox();
            dgvListaDeu = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            lblTotalDeuda = new Label();
            lblCantClientes = new Label();
            lblProm = new Label();
            txtTotalDeuda = new TextBox();
            txtCantClientes = new TextBox();
            txtPromedio = new TextBox();
            btnListaDeu = new Button();
            grbDeudores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaDeu).BeginInit();
            SuspendLayout();
            // 
            // grbDeudores
            // 
            grbDeudores.BackColor = Color.RosyBrown;
            grbDeudores.Controls.Add(btnListaDeu);
            grbDeudores.Controls.Add(txtPromedio);
            grbDeudores.Controls.Add(txtCantClientes);
            grbDeudores.Controls.Add(txtTotalDeuda);
            grbDeudores.Controls.Add(lblProm);
            grbDeudores.Controls.Add(lblCantClientes);
            grbDeudores.Controls.Add(lblTotalDeuda);
            grbDeudores.Controls.Add(dgvListaDeu);
            grbDeudores.Location = new Point(11, 11);
            grbDeudores.Name = "grbDeudores";
            grbDeudores.Size = new Size(533, 482);
            grbDeudores.TabIndex = 0;
            grbDeudores.TabStop = false;
            grbDeudores.Text = "Consulta de datos";
            // 
            // dgvListaDeu
            // 
            dgvListaDeu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaDeu.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvListaDeu.Location = new Point(8, 22);
            dgvListaDeu.Name = "dgvListaDeu";
            dgvListaDeu.Size = new Size(519, 224);
            dgvListaDeu.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Código";
            Column1.Name = "Column1";
            Column1.Width = 120;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre y Apellido ";
            Column2.Name = "Column2";
            Column2.Width = 120;
            // 
            // Column3
            // 
            Column3.HeaderText = "Límite de crédito";
            Column3.Name = "Column3";
            Column3.Width = 120;
            // 
            // Column4
            // 
            Column4.HeaderText = "Deuda";
            Column4.Name = "Column4";
            Column4.Width = 120;
            // 
            // lblTotalDeuda
            // 
            lblTotalDeuda.AutoSize = true;
            lblTotalDeuda.Font = new Font("Segoe UI", 9.75F);
            lblTotalDeuda.Location = new Point(223, 291);
            lblTotalDeuda.Name = "lblTotalDeuda";
            lblTotalDeuda.Size = new Size(99, 17);
            lblTotalDeuda.TabIndex = 1;
            lblTotalDeuda.Text = "Total de deuda:";
            // 
            // lblCantClientes
            // 
            lblCantClientes.AutoSize = true;
            lblCantClientes.Font = new Font("Segoe UI", 9.75F);
            lblCantClientes.Location = new Point(223, 326);
            lblCantClientes.Name = "lblCantClientes";
            lblCantClientes.Size = new Size(131, 17);
            lblCantClientes.TabIndex = 2;
            lblCantClientes.Text = "Cantidad de Clientes:";
            // 
            // lblProm
            // 
            lblProm.AutoSize = true;
            lblProm.Font = new Font("Segoe UI", 9.75F);
            lblProm.Location = new Point(223, 361);
            lblProm.Name = "lblProm";
            lblProm.Size = new Size(128, 17);
            lblProm.TabIndex = 3;
            lblProm.Text = "Promedio de deuda:";
            // 
            // txtTotalDeuda
            // 
            txtTotalDeuda.Location = new Point(373, 289);
            txtTotalDeuda.Name = "txtTotalDeuda";
            txtTotalDeuda.Size = new Size(130, 23);
            txtTotalDeuda.TabIndex = 4;
            // 
            // txtCantClientes
            // 
            txtCantClientes.Location = new Point(373, 325);
            txtCantClientes.Name = "txtCantClientes";
            txtCantClientes.Size = new Size(130, 23);
            txtCantClientes.TabIndex = 5;
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(373, 361);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(130, 23);
            txtPromedio.TabIndex = 6;
            // 
            // btnListaDeu
            // 
            btnListaDeu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnListaDeu.Location = new Point(266, 420);
            btnListaDeu.Name = "btnListaDeu";
            btnListaDeu.Size = new Size(220, 24);
            btnListaDeu.TabIndex = 7;
            btnListaDeu.Text = "Listar Deudores";
            btnListaDeu.UseVisualStyleBackColor = true;
            btnListaDeu.Click += btnListaDeu_Click;
            // 
            // frmClientesDeudores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(556, 505);
            Controls.Add(grbDeudores);
            Name = "frmClientesDeudores";
            Text = "frmClientesDeudores";
            grbDeudores.ResumeLayout(false);
            grbDeudores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaDeu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbDeudores;
        private DataGridView dgvListaDeu;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox txtPromedio;
        private TextBox txtCantClientes;
        private TextBox txtTotalDeuda;
        private Label lblProm;
        private Label lblCantClientes;
        private Label lblTotalDeuda;
        private Button btnListaDeu;
    }
}