using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIA05_DSP
{
    class clsPlanilla
    {
        private int Estado;
        private String Empresa;
        private DateTime FechaPlanilla;
        private Dictionary<int, clsEmpleado> Listaempleados = new Dictionary<int, clsEmpleado>();
        private int TotalEmpleados;        public clsPlanilla()
        {
            Estado = 1;
            Empresa = "";
            FechaPlanilla = DateTime.Now;
            TotalEmpleados = 0;
        }
        public void AbrirPlanilla(DateTime fechaInicio, string nombreempresa = "(Sin nombre)")
        {
            nombreempresa = nombreempresa.Trim();
            switch (Estado)
            {
                case 1:
                    FechaPlanilla = fechaInicio;
                    if (nombreempresa.Length > 0) Empresa = nombreempresa;                    Estado = 2;                    MessageBox.Show("Planilla Abierta, inicie registro empleados",
                    "Planilla de " + Empresa + ",APERTURA: " + FechaPlanilla.ToString());
                    break;
                case 2:
                    MessageBox.Show("Planilla ya esta abierta desde el:" + FechaPlanilla.ToString(),
                    "Planilla de " + Empresa);
                    break;
                case 3:
                    //La planilla ya finalizo
                    MessageBox.Show("Planilla creada el" + FechaPlanilla.ToString() +
                    " ya se cerro", "Planilla de" + Empresa);
                    break;
            }
        }

        public void RecibirEmpleado(clsEmpleado nuevoEmpleado)
        {
            if (Estado == 2)
            {
                if (nuevoEmpleado.datospersonales_aceptados == false)
                {
                    MessageBox.Show("Error, datos personales estan incompletos",
                    "Control planilla");
                    return;
                }
                if (nuevoEmpleado.datoslaborales_aceptados == false)
                {
                    MessageBox.Show("Error, datos laborales estan incompletos",
                    "Control planilla");
                    return;
                }
                TotalEmpleados += 1;
                Listaempleados.Add(TotalEmpleados, nuevoEmpleado);
            }
            else
            {
                MessageBox.Show("Planilla aun no esta abierta", "Planilla de" + Empresa);
                return;
            }
        }

        public void GenerarListado(ref DataGridView cuadro)
        {
            int i = 1;
            string sb = "0";
            string sn = "0";

            switch (Estado)
            {
                case 1:
                    MessageBox.Show("Planilla aun no ha sido abierta", "Planilla" + Empresa);
                    return;
                    break;
                case 2:
                    if (TotalEmpleados == 0)
                    {
                        MessageBox.Show("Planilla no tiene aun empleados registrados",
                        "Planilla de " + Empresa);
                        return;
                    }
                    Estado = 3;
                    MessageBox.Show("Planilla cerrada con " + TotalEmpleados + " empleados",
                    "Planilla de " + Empresa);
                    MessageBox.Show("Planilla abierta el " + FechaPlanilla.ToString() + " se muestra ahora!!",
                    "Planilla de " + Empresa);
                    break;
            }

            cuadro.Rows.Clear();
            cuadro.Columns.Clear();
            cuadro.Columns.Add("id", "num");
            cuadro.Columns.Add("nom", "nombre completo");
            cuadro.Columns.Add("sb", "sueldo base");
            cuadro.Columns.Add("sf", "sueldo neto final");
            cuadro.RowsDefaultCellStyle.BackColor = System.Drawing.Color.Bisque;
            cuadro.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Beige;

            foreach (var result in Listaempleados)
            {
                cuadro.Rows.Add();
                cuadro.Rows[i - 1].Cells[0].Value = result.Key;
                cuadro.Rows[i - 1].Cells[1].Value = result.Value.nombreCompleto;
                result.Value.VerSueldos(ref sb, ref sn);
                cuadro.Rows[i - 1].Cells[2].Value = sb;
                cuadro.Rows[i - 1].Cells[3].Value = sn;
                i++;
            }
            MessageBox.Show("Planilla de pago final completa generada en pantalla!!");
        }
        public string TotaldeEmpleado
        {
            get
            {
                return TotalEmpleados.ToString();
            }
        }


    }
        }
