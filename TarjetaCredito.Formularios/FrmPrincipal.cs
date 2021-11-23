using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarjetaCredito.Entidades;
using TarjetaCredito.Entidades.Excepciones;
using TarjetaCredito.Entidades.Modelo;
using TarjetaCredito.Negocio;

namespace TarjetaCredito.Formularios
{
    public partial class FrmPrincipal : Form
    {

        private TarjetaNegocio _Tarjeta;
        public FrmPrincipal()
        {
            this._Tarjeta = new TarjetaNegocio();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipoTarjeta.Items.Add("--seleccione--");
            cmbPeriodoCierre.Items.Add("--seleccione--");
            Limpiar();
            lstTarjetas_Load();
          
           
        }

        private void Limpiar()
        {

            cmbTipoTarjeta.SelectedIndex = -1;
            cmbPeriodoCierre.SelectedIndex = -1;
            cmbCliente.SelectedIndex = -1;
            txtNroPlastico.Text = string.Empty;
            txtLimite.Text = string.Empty;
            
        }

        private void cmbtipoTarjeta_Click(object sender, EventArgs e)
        {
            cmbTipoTarjeta.DataSource = null;
            cmbTipoTarjeta.DataSource = Enum.GetValues(typeof(TipoTarjeta));
        }
        private void cmbPerCierre_Click(object sender, EventArgs e)
        {
            cmbPeriodoCierre.DataSource = null;
            cmbPeriodoCierre.DataSource = Enum.GetValues(typeof(PeriodoCierre));
        }

        private void cmbtipoTarjeta_Select(object sender, EventArgs e)
        {
            txtNroPlastico.Text = string.Empty;
        }

        private void cmbCliente_Click(object sender, EventArgs e)
        {
            cmbCliente.DataSource = null;
            cmbCliente.DataSource = _Tarjeta.ListarClientes();
            cmbCliente.DisplayMember = "DisplayparaCombo";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (_Tarjeta.ComprobarLimit(txtLimite.Text))
            {
                Tarjeta TarjNueva = CrearTarjeta();
                txtNroPlastico.Text = _Tarjeta.GenerarNro(TarjNueva);
               
            }
            else
            {
                MessageBox.Show("El límite debe ser entre $1000 y $50000");
                txtLimite.Clear();
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Resultado Operacion = _Tarjeta.AltaTarjeta(CrearTarjeta());
                Limpiar();
                if (Operacion.IsOk)
                {
                    MessageBox.Show("Se ha registrado la Tarjeta");
                    lstTarjetas_Load();
                   
                }
                else
                {
                    MessageBox.Show(Operacion.Error);
                }
            }
            catch (ClienteSinLimite ex)
            {

            }
            catch (ClienteSinCuenta ex)
            {
            }
            catch (Exception ex)
            {

            }
        }

        private Tarjeta CrearTarjeta()
        {
            Tarjeta TarjNueva = new Tarjeta();
            Cliente ClienteSeleccionado = (Cliente)cmbCliente.SelectedItem;
            TarjNueva.IdCliente = ClienteSeleccionado.Id;
            TipoTarjeta TipoSelec = (TipoTarjeta)cmbTipoTarjeta.SelectedItem;
            TarjNueva.Tipo = (int)TipoSelec;
            TarjNueva.PeriodoVencimiento = (int)(PeriodoCierre)cmbPeriodoCierre.SelectedItem;
            TarjNueva.LimiteCompra = double.Parse(txtLimite.Text);
            TarjNueva.NroPlastico = txtNroPlastico.Text;
            return TarjNueva;

        }

        private void lstTarjetas_Load()
        {
            lstTarjetas.DataSource = null;
            lstTarjetas.DataSource = _Tarjeta.TraerTarjetas();
            lstTarjetas.DisplayMember = "DisplayTarjeta";
            txtEmitidos.Text = _Tarjeta.CantidadPlastico().ToString();
            txtPromedio.Text = _Tarjeta.LimitePromedio().ToString();

        }
    }
}
