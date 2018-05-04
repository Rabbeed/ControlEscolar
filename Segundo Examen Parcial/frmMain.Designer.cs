namespace Segundo_Examen_Parcial
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRed = new System.Windows.Forms.Label();
            this.lvwNodos = new System.Windows.Forms.ListView();
            this.coIiP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPuertos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSaltos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nodos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCrear = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // lblRed
            // 
            this.lblRed.BackColor = System.Drawing.Color.White;
            this.lblRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.Location = new System.Drawing.Point(12, 51);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(249, 260);
            this.lblRed.TabIndex = 2;
            this.lblRed.Text = "[Datos Red]";
            this.lblRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRed.DoubleClick += new System.EventHandler(this.lblRed_DoubleClick);
            this.lblRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblRed_MouseDown);
            // 
            // lvwNodos
            // 
            this.lvwNodos.BackColor = System.Drawing.Color.White;
            this.lvwNodos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coIiP,
            this.columnTipo,
            this.columnPuertos,
            this.columnSaltos,
            this.columnSO});
            this.lvwNodos.Location = new System.Drawing.Point(271, 51);
            this.lvwNodos.Name = "lvwNodos";
            this.lvwNodos.Size = new System.Drawing.Size(561, 260);
            this.lvwNodos.TabIndex = 4;
            this.lvwNodos.UseCompatibleStateImageBehavior = false;
            this.lvwNodos.View = System.Windows.Forms.View.Details;
            this.lvwNodos.DoubleClick += new System.EventHandler(this.lvwNodos_DoubleClick);
            // 
            // coIiP
            // 
            this.coIiP.Text = "IP";
            this.coIiP.Width = 136;
            // 
            // columnTipo
            // 
            this.columnTipo.Text = "Tipo";
            this.columnTipo.Width = 99;
            // 
            // columnPuertos
            // 
            this.columnPuertos.Text = "Puertos abiertos";
            this.columnPuertos.Width = 108;
            // 
            // columnSaltos
            // 
            this.columnSaltos.Text = "Saltos objetivo";
            this.columnSaltos.Width = 100;
            // 
            // columnSO
            // 
            this.columnSO.Text = "Sistema Operativo";
            this.columnSO.Width = 113;
            // 
            // Nodos
            // 
            this.Nodos.AutoSize = true;
            this.Nodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nodos.Location = new System.Drawing.Point(268, 32);
            this.Nodos.Name = "Nodos";
            this.Nodos.Size = new System.Drawing.Size(58, 16);
            this.Nodos.TabIndex = 5;
            this.Nodos.Text = "Nodos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Red:";
            // 
            // lblCrear
            // 
            this.lblCrear.BackColor = System.Drawing.Color.White;
            this.lblCrear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrear.Location = new System.Drawing.Point(12, 317);
            this.lblCrear.Name = "lblCrear";
            this.lblCrear.Size = new System.Drawing.Size(249, 34);
            this.lblCrear.TabIndex = 7;
            this.lblCrear.Text = "Doble click [Crear o Modificar Red] -- Click derecho [Agregar Nodo]";
            this.lblCrear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(564, 34);
            this.label2.TabIndex = 8;
            this.label2.Text = "Doble click [Modificar Nodo]";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 354);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCrear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nodos);
            this.Controls.Add(this.lvwNodos);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Ethical Hackers";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.ListView lvwNodos;
        private System.Windows.Forms.Label Nodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCrear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader coIiP;
        private System.Windows.Forms.ColumnHeader columnTipo;
        private System.Windows.Forms.ColumnHeader columnPuertos;
        private System.Windows.Forms.ColumnHeader columnSaltos;
        private System.Windows.Forms.ColumnHeader columnSO;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

