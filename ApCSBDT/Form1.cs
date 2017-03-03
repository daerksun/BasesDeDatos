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
  public partial class FrmMenú : Form {
    public FrmMenú() {
      InitializeComponent();
    }

    private void MnuSalir_Click(object sender, EventArgs e) {
      this.Close();

    }

    private void MnuAlumnos_Click(object sender, EventArgs e) {
      FrmAlumnos fa = new FrmAlumnos();
      fa.Show();
    }

    private void materiaToolStripMenuItem_Click(object sender, EventArgs e) {
      FrmMaterias fm = new FrmMaterias();
      fm.ShowDialog();
    }

    private void MnuConsulta_Click(object sender, EventArgs e) {
      FrmConsulta fc = new FrmConsulta();
      fc.Show();
    }

    private void mnuProgs_Click(object sender, EventArgs e) {
      FrmSubProgAlm fs = new FrmSubProgAlm();
      fs.Show();
    }
  }
}
