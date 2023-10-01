using System;
using System.Security.Principal;
using System.Windows.Forms;

namespace mluduena.CAI.Ej02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cargaCombobox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowsIdentity identidadUsuario = WindowsIdentity.GetCurrent();

            string nombreUsuario = identidadUsuario.Name;

            string nombreRealUsuario = "Mart�n Ludue�a";

            lblNombreUsuario.Text = $"Usuario: {nombreUsuario}";
            lblNombreReal.Text = $"Nombre real: {nombreRealUsuario}";
            lblFechaHoy.Text = $"Fecha de hoy: {DateTime.Now.ToString("dd/MM/yyyy")}";
        }

        private void cargaCombobox()
        {
            List<string> datosComboBox = new List<string> { "Ford", "Fiat", "Chevrolet", "Audi" };
            cmbMarcas.Items.AddRange(datosComboBox.ToArray());
        }

        private void ingresarDatosClick(object sender, EventArgs e)
        {
            string marca = cmbMarcas.Text; string modelo = txtModelo.Text;
            string a�o = txtA�o.Text; int a�oOut = 0; string precio = txtPrecio.Text;
            float precioOut = 0f; string acumuladorErrores = "";

            acumuladorErrores = acumuladorErrores + validarMarca("MARCA");
            acumuladorErrores = acumuladorErrores + validarModelo(modelo, "MODELO");
            acumuladorErrores = acumuladorErrores + validarA�o(a�o, ref a�oOut, "A�O");
            acumuladorErrores = acumuladorErrores + validarPrecio(precio, ref precioOut, "PRECIO");

            if (string.IsNullOrEmpty(acumuladorErrores))
            {
                AutoModel nuevoAuto = new AutoModel();
                nuevoAuto.Marca = marca;
                nuevoAuto.Modelo = modelo;
                nuevoAuto.A�o = a�oOut;
                nuevoAuto.Precio = precioOut;

                lstDatosAuto.Items.Add(nuevoAuto.Marca);
                lstDatosAuto.Items.Add(nuevoAuto.Modelo);
                lstDatosAuto.Items.Add(nuevoAuto.A�o);
                lstDatosAuto.Items.Add(nuevoAuto.Precio);
            }
            else
            {
                MessageBox.Show(acumuladorErrores);
            }
        }

       private string validarMarca(string parametro2)
        {
            if(cmbMarcas.SelectedItem == null)
            {
                return $"El campo {parametro2} no puede ser vac�o." + Environment.NewLine;
            }
            else
            {
                return "";
            }
        }

       private string validarModelo(string parametro1, string parametro2)
        {
            if(string.IsNullOrEmpty(parametro1))
            {
                return $"El campo {parametro2} no puede ser vac�o." + Environment.NewLine;
            }
            else
            {
                return "";
            }
        }
       
       private string validarA�o(string parametro1, ref int parametro2, string parametro3)
        {
            if (string.IsNullOrEmpty(parametro1))
            {
                return $"El campo {parametro3} no puede ser vac�o." + Environment.NewLine;
            }
            else if (!int.TryParse(parametro1, out parametro2))
            {
                return $"El campo {parametro3} debe ser un n�mero entero." + Environment.NewLine;
            }
            else if (parametro2.ToString().Length != 4)
            {
                return $"El campo {parametro3} debe tener 4 cifras." + Environment.NewLine;
            }
            else if (parametro2 < 2000 || parametro2 > 2021)
            {
                return $"El campo {parametro3} debe ser entre 2000 y 2021." + Environment.NewLine;
            }
            else
            {
                return "";
            }
        }

       private string validarPrecio(string parametro1, ref float parametro2, string parametro3)
        {
            if (string.IsNullOrEmpty(parametro1))
            {
                return $"El campo {parametro3} no puede ser vac�o." + Environment.NewLine;
            }
            else if (!float.TryParse(parametro1, out parametro2))
            {
                return $"El campo {parametro3} debe ser un n�mero." + Environment.NewLine;
            }
            else if (parametro2 < 0)
            {
                return $"El campo {parametro3} debe ser un n�mero positivo." + Environment.NewLine;
            }
            else
            {
                return "";
            }
        }
    }
}