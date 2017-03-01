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
  public partial class FrmMaterias : Form {
    public FrmMaterias() {
      InitializeComponent();
    }

    private void FrmMaterias_Load(object sender, EventArgs e) {
      // TODO: esta línea de código carga datos en la tabla 'dsMaterias.MATER' Puede moverla o quitarla según sea necesario.
      this.mATERTableAdapter.Fill(this.dsMaterias.MATER);

    }
  }
}
