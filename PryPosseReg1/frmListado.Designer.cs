namespace PryPosseReg1
{
    partial class frmListado
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
            grbLista = new GroupBox();
            dgvLista = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            cmbModo = new ComboBox();
            cmbCampo = new ComboBox();
            btnListar = new Button();
            lblModo = new Label();
            lblCampo = new Label();
            grbLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // grbLista
            // 
            grbLista.BackColor = Color.RosyBrown;
            grbLista.Controls.Add(dgvLista);
            grbLista.Controls.Add(cmbModo);
            grbLista.Controls.Add(cmbCampo);
            grbLista.Controls.Add(btnListar);
            grbLista.Controls.Add(lblModo);
            grbLista.Controls.Add(lblCampo);
            grbLista.Location = new Point(11, 12);
            grbLista.Name = "grbLista";
            grbLista.Size = new Size(681, 276);
            grbLista.TabIndex = 0;
            grbLista.TabStop = false;
            // 
            // dgvLista
            // 
            dgvLista.BackgroundColor = Color.WhiteSmoke;
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvLista.GridColor = Color.Black;
            dgvLista.Location = new Point(45, 74);
            dgvLista.Name = "dgvLista";
            dgvLista.Size = new Size(604, 161);
            dgvLista.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.HeaderText = "Código";
            Column1.Name = "Column1";
            Column1.Width = 140;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.Name = "Column2";
            Column2.Width = 140;
            // 
            // Column3
            // 
            Column3.HeaderText = "Límite de Crédito";
            Column3.Name = "Column3";
            Column3.Width = 140;
            // 
            // Column4
            // 
            Column4.HeaderText = "Deuda";
            Column4.Name = "Column4";
            Column4.Width = 140;
            // 
            // cmbModo
            // 
            cmbModo.FormattingEnabled = true;
            cmbModo.Items.AddRange(new object[] { "Ascendente", "Descendente" });
            cmbModo.Location = new Point(458, 40);
            cmbModo.Name = "cmbModo";
            cmbModo.Size = new Size(121, 23);
            cmbModo.TabIndex = 4;
            // 
            // cmbCampo
            // 
            cmbCampo.FormattingEnabled = true;
            cmbCampo.Items.AddRange(new object[] { "Código", "Nombre", "Límite", "Deuda" });
            cmbCampo.Location = new Point(161, 40);
            cmbCampo.Name = "cmbCampo";
            cmbCampo.Size = new Size(121, 23);
            cmbCampo.TabIndex = 3;
            // 
            // btnListar
            // 
            btnListar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnListar.Location = new Point(511, 241);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(164, 29);
            btnListar.TabIndex = 2;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // lblModo
            // 
            lblModo.AutoSize = true;
            lblModo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModo.Location = new Point(399, 43);
            lblModo.Name = "lblModo";
            lblModo.Size = new Size(44, 17);
            lblModo.TabIndex = 1;
            lblModo.Text = "Modo";
            // 
            // lblCampo
            // 
            lblCampo.AutoSize = true;
            lblCampo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCampo.Location = new Point(101, 43);
            lblCampo.Name = "lblCampo";
            lblCampo.Size = new Size(50, 17);
            lblCampo.TabIndex = 0;
            lblCampo.Text = "Campo";
            // 
            // frmListado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(704, 300);
            Controls.Add(grbLista);
            Name = "frmListado";
            Text = "frmListado";
            Load += frmListado_Load;
            grbLista.ResumeLayout(false);
            grbLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbLista;
        private Label lblModo;
        private Label lblCampo;
        private ComboBox cmbModo;
        private ComboBox cmbCampo;
        private Button btnListar;
        private DataGridView dgvLista;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}