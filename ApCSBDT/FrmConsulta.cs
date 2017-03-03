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
  public partial class FrmConsulta : Form {
    public FrmConsulta() {
      InitializeComponent();
    }

    private void FrmConsulta_Load(object sender, EventArgs e) {
      // TODO: esta línea de código carga datos en la tabla 'dataSetAlumCalifs.ALUMCALIFS' Puede moverla o quitarla según sea necesario.
      this.aLUMCALIFSTableAdapter.Fill(this.dataSetAlumCalifs.ALUMCALIFS);

    }

    private void btnEj1_Click(object sender, EventArgs e) {
      DataTable tabla;
      int cant = 0, calif;

      //Recupera la única tabla del dataset
      tabla = dataSetAlumCalifs.Tables["AlumCalifs"];

      //Obtiene cada calificación de cada fila
      foreach (DataRow fila in tabla.Rows) {
        //calif = int.Parse(fila["Calif"].ToString());
        calif = Convert.ToInt16(fila["Calif"]);
        if (calif >= 8)
          cant++;
      }

      MessageBox.Show("Cantidad de calificaciones: " + cant);
    }

  }
}
