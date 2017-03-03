namespace ApCSBDT {
  partial class FrmConsulta {
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
      this.components = new System.ComponentModel.Container();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.nOMALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nOMMATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cALIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.aLUMCALIFSBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dataSetAlumCalifs = new ApCSBDT.DataSetAlumCalifs();
      this.aLUMCALIFSTableAdapter = new ApCSBDT.DataSetAlumCalifsTableAdapters.ALUMCALIFSTableAdapter();
      this.btnEj1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.aLUMCALIFSBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSetAlumCalifs)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nOMALDataGridViewTextBoxColumn,
            this.nOMMATDataGridViewTextBoxColumn,
            this.cALIFDataGridViewTextBoxColumn,
            this.fECHADataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.aLUMCALIFSBindingSource;
      this.dataGridView1.Location = new System.Drawing.Point(12, 12);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(445, 237);
      this.dataGridView1.TabIndex = 0;
      // 
      // nOMALDataGridViewTextBoxColumn
      // 
      this.nOMALDataGridViewTextBoxColumn.DataPropertyName = "NOMAL";
      this.nOMALDataGridViewTextBoxColumn.HeaderText = "NOMAL";
      this.nOMALDataGridViewTextBoxColumn.Name = "nOMALDataGridViewTextBoxColumn";
      // 
      // nOMMATDataGridViewTextBoxColumn
      // 
      this.nOMMATDataGridViewTextBoxColumn.DataPropertyName = "NOMMAT";
      this.nOMMATDataGridViewTextBoxColumn.HeaderText = "NOMMAT";
      this.nOMMATDataGridViewTextBoxColumn.Name = "nOMMATDataGridViewTextBoxColumn";
      // 
      // cALIFDataGridViewTextBoxColumn
      // 
      this.cALIFDataGridViewTextBoxColumn.DataPropertyName = "CALIF";
      this.cALIFDataGridViewTextBoxColumn.HeaderText = "CALIF";
      this.cALIFDataGridViewTextBoxColumn.Name = "cALIFDataGridViewTextBoxColumn";
      // 
      // fECHADataGridViewTextBoxColumn
      // 
      this.fECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA";
      this.fECHADataGridViewTextBoxColumn.HeaderText = "FECHA";
      this.fECHADataGridViewTextBoxColumn.Name = "fECHADataGridViewTextBoxColumn";
      // 
      // aLUMCALIFSBindingSource
      // 
      this.aLUMCALIFSBindingSource.DataMember = "ALUMCALIFS";
      this.aLUMCALIFSBindingSource.DataSource = this.dataSetAlumCalifs;
      // 
      // dataSetAlumCalifs
      // 
      this.dataSetAlumCalifs.DataSetName = "DataSetAlumCalifs";
      this.dataSetAlumCalifs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // aLUMCALIFSTableAdapter
      // 
      this.aLUMCALIFSTableAdapter.ClearBeforeFill = true;
      // 
      // btnEj1
      // 
      this.btnEj1.Location = new System.Drawing.Point(360, 255);
      this.btnEj1.Name = "btnEj1";
      this.btnEj1.Size = new System.Drawing.Size(97, 37);
      this.btnEj1.TabIndex = 1;
      this.btnEj1.Text = "Califs  >=  8";
      this.btnEj1.UseVisualStyleBackColor = true;
      this.btnEj1.Click += new System.EventHandler(this.btnEj1_Click);
      // 
      // FrmConsulta
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(476, 330);
      this.Controls.Add(this.btnEj1);
      this.Controls.Add(this.dataGridView1);
      this.Name = "FrmConsulta";
      this.Text = "Calificaciones de los alumnos";
      this.Load += new System.EventHandler(this.FrmConsulta_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.aLUMCALIFSBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSetAlumCalifs)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private DataSetAlumCalifs dataSetAlumCalifs;
    private System.Windows.Forms.BindingSource aLUMCALIFSBindingSource;
    private DataSetAlumCalifsTableAdapters.ALUMCALIFSTableAdapter aLUMCALIFSTableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn nOMALDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nOMMATDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn cALIFDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn fECHADataGridViewTextBoxColumn;
    private System.Windows.Forms.Button btnEj1;


  }
}