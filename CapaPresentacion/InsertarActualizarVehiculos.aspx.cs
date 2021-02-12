using System;
using System.Web.UI;
using CapaNegocio;
using CapaEntidad;
using static System.Collections.Specialized.BitVector32;

namespace CapaPresentacion
{
    public partial class InsertarActualizarClientes : System.Web.UI.Page
    {
        VehiculoNegocio ClientNego = new VehiculoNegocio();
        VehiculosEntidad ClientEnti = new VehiculosEntidad();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                MostrarDatos();
            }         
        }
        private void MostrarDatos()
        {
            try
            {
              
                string strCD = Session["NumeroSerie"].ToString();
                ClientEnti = ClientNego.ConsultarCliente(strCD);
                {
                    txtCodigo.Text = ClientEnti.numeroSerieVehiculo;
                    txtNombres.Text = ClientEnti.CilindrosVehiculos;
                    txtApellidos.Text = ClientEnti.colorVehiculo;
                    txtCorreo.Text = ClientEnti.numeroEjesVehiculo;
                    txtEstatus.Text = ClientEnti.estatusVehiculo;
                    btnGrabar.Enabled = false;
                    btnActualizar.Enabled=true;
                    btnCancelar.Enabled = true;
                }
            }
            catch (Exception)
            {
            }
        }
        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            if (this.txtCodigo.Text.Trim() != "" && this.txtApellidos.Text.Trim() != ""
               && this.txtNombres.Text.Trim() != "" && this.txtCorreo.Text.Trim() != "")
            {
                try
                {
                    ClientEnti.numeroSerieVehiculo = txtCodigo.Text;
                    ClientEnti.CilindrosVehiculos = txtNombres.Text;
                    ClientEnti.colorVehiculo = txtApellidos.Text;
                    ClientEnti.numeroEjesVehiculo = txtCorreo.Text;
                    ClientEnti.estatusVehiculo = "1";
                    if (ClientNego.InsertarCliente(ClientEnti) == true)
                    {
                        lblMensaje.Text = "Registro Guardado Correctamente";
                        Response.Redirect("~/ListarVehiculos.aspx");
                    }
                    else
                    {
                        lblMensaje.Text = "Error de grabación de datos";
                    }
                }
                catch (Exception exc)
                {
                    lblMensaje.Text = exc.Message.ToString();
                }
            }
            else {
                lblMensaje.Text = "Todo los Campos son Obligatorios.";
            }                
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (this.txtCodigo.Text.Trim() != "" && this.txtApellidos.Text.Trim() != ""
              && this.txtNombres.Text.Trim() != "" && this.txtCorreo.Text.Trim() != "")
            {
                try
                {

                    ClientEnti.numeroSerieVehiculo = txtCodigo.Text;
                    ClientEnti.CilindrosVehiculos = txtNombres.Text;
                    ClientEnti.colorVehiculo = txtApellidos.Text;
                    ClientEnti.numeroEjesVehiculo = txtCorreo.Text;
                    ClientEnti.estatusVehiculo = txtEstatus.Text;
                    if (ClientNego.ActualizarCliente(ClientEnti) == true)
                    {
                        lblMensaje.Text = "Registro Actualizado Correctamente";
                        Session.RemoveAll();
                        Response.Redirect("~/ListarVehiculos.aspx");
                    }
                    else
                    {
                        lblMensaje.Text = "Error de Actualización de datos";
                    }

                }
                catch (Exception exc)
                {
                    lblMensaje.Text = exc.Message.ToString();
                }
            }
            else {
                lblMensaje.Text = "Todo los Campos son Obligatorios.";
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("~/ListarVehiculos.aspx");
            
        }
    }
}