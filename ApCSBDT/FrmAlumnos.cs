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

    private void FrmAlumnos_Load(object sender, EventArgs e) {
      // TODO: esta línea de código carga datos en la tabla 'dSAlumnos.ALUM' Puede moverla o quitarla según sea necesario.
      this.aLUMTableAdapter.Fill(this.dSAlumnos.ALUM);

    }
  }
}
