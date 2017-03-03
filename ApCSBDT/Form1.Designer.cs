namespace ApCSBDT {
  partial class FrmMenú {
    /// <summary>
    /// Variable del diseñador requerida.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén utilizando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido del método con el editor de código.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenú));
      this.menuStrip3 = new System.Windows.Forms.MenuStrip();
      this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.MnuSalir = new System.Windows.Forms.ToolStripMenuItem();
      this.tablasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.MnuAlumnos = new System.Windows.Forms.ToolStripMenuItem();
      this.materiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.MnuConsulta = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuProgs = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip3.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip3
      // 
      this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.tablasToolStripMenuItem,
            this.procesosToolStripMenuItem});
      this.menuStrip3.Location = new System.Drawing.Point(0, 0);
      this.menuStrip3.Name = "menuStrip3";
      this.menuStrip3.Size = new System.Drawing.Size(439, 24);
      this.menuStrip3.TabIndex = 2;
      this.menuStrip3.Text = "menuStrip3";
      // 
      // salirToolStripMenuItem
      // 
      this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuSalir});
      this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
      this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
      this.salirToolStripMenuItem.Text = "Salir";
      // 
      // MnuSalir
      // 
      this.MnuSalir.Name = "MnuSalir";
      this.MnuSalir.Size = new System.Drawing.Size(96, 22);
      this.MnuSalir.Text = "Salir";
      this.MnuSalir.Click += new System.EventHandler(this.MnuSalir_Click);
      // 
      // tablasToolStripMenuItem
      // 
      this.tablasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAlumnos,
            this.materiaToolStripMenuItem});
      this.tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
      this.tablasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
      this.tablasToolStripMenuItem.Text = "Tablas";
      // 
      // MnuAlumnos
      // 
      this.MnuAlumnos.Name = "MnuAlumnos";
      this.MnuAlumnos.Size = new System.Drawing.Size(122, 22);
      this.MnuAlumnos.Text = "Alumnos";
      this.MnuAlumnos.Click += new System.EventHandler(this.MnuAlumnos_Click);
      // 
      // materiaToolStripMenuItem
      // 
      this.materiaToolStripMenuItem.Name = "materiaToolStripMenuItem";
      this.materiaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
      this.materiaToolStripMenuItem.Text = "Materia";
      this.materiaToolStripMenuItem.Click += new System.EventHandler(this.materiaToolStripMenuItem_Click);
      // 
      // procesosToolStripMenuItem
      // 
      this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuConsulta,
            this.mnuProgs});
      this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
      this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
      this.procesosToolStripMenuItem.Text = "Procesos";
      // 
      // MnuConsulta
      // 
      this.MnuConsulta.Name = "MnuConsulta";
      this.MnuConsulta.Size = new System.Drawing.Size(226, 22);
      this.MnuConsulta.Text = "Consulta";
      this.MnuConsulta.Click += new System.EventHandler(this.MnuConsulta_Click);
      // 
      // mnuProgs
      // 
      this.mnuProgs.Name = "mnuProgs";
      this.mnuProgs.Size = new System.Drawing.Size(226, 22);
      this.mnuProgs.Text = "Subprogramas Almacenados";
      this.mnuProgs.Click += new System.EventHandler(this.mnuProgs_Click);
      // 
      // FrmMenú
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(439, 262);
      this.Controls.Add(this.menuStrip3);
      this.Name = "FrmMenú";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.menuStrip3.ResumeLayout(false);
      this.menuStrip3.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip3;
    private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem MnuSalir;
    private System.Windows.Forms.ToolStripMenuItem tablasToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem MnuAlumnos;
    private System.Windows.Forms.ToolStripMenuItem materiaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem MnuConsulta;
    private System.Windows.Forms.ToolStripMenuItem mnuProgs;
  }
}

