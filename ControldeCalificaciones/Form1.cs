using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControldeCalificaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void txtAlumno_TextChanged(object sender, EventArgs e)
        {

        }
        private void btmCalcular_Click(object sender, EventArgs e)
        {
            #region Validar controles
            //Validar campo Alumnos
            if (txtAlumno.Text == String.Empty)
            {
                epError.SetError(txtAlumno, "El campo ALUMNO es obligatorio");
                return;
            }
            if (Information.IsNumeric(txtAlumno.Text))
            {
                epError.SetError(txtAlumno, "El campo ALUMNO no acepta caracteres numericos");
                return;
            }
            else 
            {
                epError.Clear();
            }

            //Validar campo Nota 1
            if (txtCalf1.Text == String.Empty)
            {
                epError.SetError(txtCalf1, "El campo CALIFICACION 1 es obligatorio");
                return;
            }
            if (!Information.IsNumeric(txtCalf1.Text))
            {
                epError.SetError(txtCalf1, "El campo CALIFICACION 1 no acepta caracteres alfabeticos");
                return;
            }
            double calf1 = double.Parse(txtCalf1.Text);
            if (calf1 > 100)
            {
                epError.SetError(txtCalf1, "El campo CALIFICACION 1 no acepta valores mayores a 100");
                return;
            }
            else
            {
                epError.Clear();
            }

            //Validar campo Nota 2
            if (txtCalf2.Text == String.Empty)
            {
                epError.SetError(txtCalf2, "El campo CALIFICACION 2 es obligatorio");
                return;
            }
            if (!Information.IsNumeric(txtCalf2.Text))
            {
                epError.SetError(txtCalf2, "El campo CALIFICACION 2 no acepta caracteres alfabeticos");
                return;
            }
            double calf2 = double.Parse(txtCalf2.Text);
            if (calf2 > 100)
            {
                epError.SetError(txtCalf2, "El campo CALIFICACION 2 no acepta valores mayores a 100");
                return;
            }
            else
            {
                epError.Clear();
            }

            //Validar campo Nota 3
            if (txtCalf3.Text == String.Empty)
            {
                epError.SetError(txtCalf3, "El campo CALIFICACION 3 es obligatorio");
                return;
            }
            if (!Information.IsNumeric(txtCalf3.Text))
            {
                epError.SetError(txtCalf3, "El campo CALIFICACION 3 no acepta caracteres alfabeticos");
                return;
            }
            double calf3 = double.Parse(txtCalf3.Text);
            if (calf3 > 100)
            {
                epError.SetError(txtCalf3, "El campo CALIFICACION 3 no acepta valores mayores a 100");
                return;
            }
            else
            {
                epError.Clear();
            }

            //Validar campo Nota 4
            if (txtCalf4.Text == String.Empty)
            {
                epError.SetError(txtCalf4, "El campo CALIFICACION 4 es obligatorio");
                return;
            }
            if (!Information.IsNumeric(txtCalf4.Text))
            {
                epError.SetError(txtCalf4, "El campo CALIFICACION 4 no acepta caracteres alfabeticos");
                return;
            }
            double calf4 = double.Parse(txtCalf4.Text);
            if (calf4 > 100)
            {
                epError.SetError(txtCalf4, "El campo CALIFICACION 4 no acepta valores mayores a 100");
                return;
            }
            else
            {
                epError.Clear();
            }
            #endregion
        }
        private void LimpiarControles() 
        { 
            txtAlumno.Clear();
            txtCalf1.Clear();
            txtCalf2.Clear();
            txtCalf3.Clear();
            txtCalf4.Clear();
            epError.Clear();
            txtAlumno.Focus();
        }

    }
}
