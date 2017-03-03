  using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApCSBDT {
  public partial class FrmAlumnos : Form {
    public FrmAlumnos() {
      InitializeComponent();
    }

    //Lee la tabla de alumnos 
    private void FrmAlumnos_Load(object sender, EventArgs e) {
      this.aLUMTableAdapter.Fill(this.dSAlumnos.ALUM);

    }

    //Actualiza la tabla de alumno en la BD
    private void BtnACT_Click(object sender, EventArgs e) {
      this.aLUMTableAdapter.Update(this.dSAlumnos.ALUM);
    }
  }
}
