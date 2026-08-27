namespace PryPosseReg1
{
    partial class frmGestión
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
            menuStrip1 = new MenuStrip();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            agregarNuevosClientesToolStripMenuItem = new ToolStripMenuItem();
            listadoDeClientesToolStripMenuItem = new ToolStripMenuItem();
            clientesDeudoresToolStripMenuItem = new ToolStripMenuItem();
            clientesOrdPorToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sistemaToolStripMenuItem, clientesToolStripMenuItem, ventasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(561, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem, salirToolStripMenuItem });
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(60, 20);
            sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(180, 22);
            acercaDeToolStripMenuItem.Text = "Acerca de ";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(180, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += this.salirToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarNuevosClientesToolStripMenuItem, listadoDeClientesToolStripMenuItem, clientesDeudoresToolStripMenuItem, clientesOrdPorToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(61, 20);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // agregarNuevosClientesToolStripMenuItem
            // 
            agregarNuevosClientesToolStripMenuItem.Name = "agregarNuevosClientesToolStripMenuItem";
            agregarNuevosClientesToolStripMenuItem.Size = new Size(200, 22);
            agregarNuevosClientesToolStripMenuItem.Text = "Agregar nuevos clientes";
            agregarNuevosClientesToolStripMenuItem.Click += agregarNuevosClientesToolStripMenuItem_Click;
            // 
            // listadoDeClientesToolStripMenuItem
            // 
            listadoDeClientesToolStripMenuItem.Name = "listadoDeClientesToolStripMenuItem";
            listadoDeClientesToolStripMenuItem.Size = new Size(200, 22);
            listadoDeClientesToolStripMenuItem.Text = "Listado de clientes";
            // 
            // clientesDeudoresToolStripMenuItem
            // 
            clientesDeudoresToolStripMenuItem.Name = "clientesDeudoresToolStripMenuItem";
            clientesDeudoresToolStripMenuItem.Size = new Size(200, 22);
            clientesDeudoresToolStripMenuItem.Text = "Clientes deudores";
            // 
            // clientesOrdPorToolStripMenuItem
            // 
            clientesOrdPorToolStripMenuItem.Name = "clientesOrdPorToolStripMenuItem";
            clientesOrdPorToolStripMenuItem.Size = new Size(200, 22);
            clientesOrdPorToolStripMenuItem.Text = "Clientes ord por..";
            clientesOrdPorToolStripMenuItem.Click += clientesOrdPorToolStripMenuItem_Click;
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(53, 20);
            ventasToolStripMenuItem.Text = "Ventas";
            // 
            // frmGestión
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(561, 313);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmGestión";
            Text = "Gestión";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem agregarNuevosClientesToolStripMenuItem;
        private ToolStripMenuItem listadoDeClientesToolStripMenuItem;
        private ToolStripMenuItem clientesDeudoresToolStripMenuItem;
        private ToolStripMenuItem clientesOrdPorToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
    }
}
