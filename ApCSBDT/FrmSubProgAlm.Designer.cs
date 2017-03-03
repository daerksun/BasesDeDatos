namespace ApCSBDT {
  partial class FrmSubProgAlm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.btnPA = new System.Windows.Forms.Button();
      this.btCantMaters = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnPA
      // 
      this.btnPA.Location = new System.Drawing.Point(83, 12);
      this.btnPA.Name = "btnPA";
      this.btnPA.Size = new System.Drawing.Size(216, 38);
      this.btnPA.TabIndex = 0;
      this.btnPA.Text = "Procedimiento Almacenado";
      this.btnPA.UseVisualStyleBackColor = true;
      this.btnPA.Click += new System.EventHandler(this.btnPA_Click);
      // 
      // btCantMaters
      // 
      this.btCantMaters.Location = new System.Drawing.Point(83, 56);
      this.btCantMaters.Name = "btCantMaters";
      this.btCantMaters.Size = new System.Drawing.Size(216, 38);
      this.btCantMaters.TabIndex = 1;
      this.btCantMaters.Text = "Cantidad de Materias";
      this.btCantMaters.UseVisualStyleBackColor = true;
      this.btCantMaters.Click += new System.EventHandler(this.btCantMaters_Click);
      // 
      // FrmSubProgAlm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(389, 117);
      this.Controls.Add(this.btCantMaters);
      this.Controls.Add(this.btnPA);
      this.Name = "FrmSubProgAlm";
      this.Text = "Ejecución de subprogramas almacenados";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnPA;
    private System.Windows.Forms.Button btCantMaters;
  }
}