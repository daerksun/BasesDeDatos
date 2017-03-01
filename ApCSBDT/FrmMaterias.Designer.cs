namespace ApCSBDT {
  partial class FrmMaterias {
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
      this.dsMaterias = new ApCSBDT.DsMaterias();
      this.mATERBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.mATERTableAdapter = new ApCSBDT.DsMateriasTableAdapters.MATERTableAdapter();
      this.cLAVEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nOMMATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cREDSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsMaterias)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.mATERBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLAVEMDataGridViewTextBoxColumn,
            this.nOMMATDataGridViewTextBoxColumn,
            this.cREDSDataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.mATERBindingSource;
      this.dataGridView1.Location = new System.Drawing.Point(12, 12);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(451, 220);
      this.dataGridView1.TabIndex = 0;
      // 
      // dsMaterias
      // 
      this.dsMaterias.DataSetName = "DsMaterias";
      this.dsMaterias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // mATERBindingSource
      // 
      this.mATERBindingSource.DataMember = "MATER";
      this.mATERBindingSource.DataSource = this.dsMaterias;
      // 
      // mATERTableAdapter
      // 
      this.mATERTableAdapter.ClearBeforeFill = true;
      // 
      // cLAVEMDataGridViewTextBoxColumn
      // 
      this.cLAVEMDataGridViewTextBoxColumn.DataPropertyName = "CLAVEM";
      this.cLAVEMDataGridViewTextBoxColumn.HeaderText = "CLAVEM";
      this.cLAVEMDataGridViewTextBoxColumn.Name = "cLAVEMDataGridViewTextBoxColumn";
      // 
      // nOMMATDataGridViewTextBoxColumn
      // 
      this.nOMMATDataGridViewTextBoxColumn.DataPropertyName = "NOMMAT";
      this.nOMMATDataGridViewTextBoxColumn.HeaderText = "NOMMAT";
      this.nOMMATDataGridViewTextBoxColumn.Name = "nOMMATDataGridViewTextBoxColumn";
      // 
      // cREDSDataGridViewTextBoxColumn
      // 
      this.cREDSDataGridViewTextBoxColumn.DataPropertyName = "CREDS";
      this.cREDSDataGridViewTextBoxColumn.HeaderText = "CREDS";
      this.cREDSDataGridViewTextBoxColumn.Name = "cREDSDataGridViewTextBoxColumn";
      // 
      // FrmMaterias
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(475, 246);
      this.Controls.Add(this.dataGridView1);
      this.Name = "FrmMaterias";
      this.Text = "FrmMaterias";
      this.Load += new System.EventHandler(this.FrmMaterias_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsMaterias)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.mATERBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private DsMaterias dsMaterias;
    private System.Windows.Forms.BindingSource mATERBindingSource;
    private DsMateriasTableAdapters.MATERTableAdapter mATERTableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn cLAVEMDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nOMMATDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn cREDSDataGridViewTextBoxColumn;
  }
}