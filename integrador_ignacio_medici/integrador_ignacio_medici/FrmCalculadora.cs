using Entidades;

namespace integrador_ignacio_medici
{
    public partial class FrmCalculadora : Form
    {
        private Numeracion primerOperando, segundoOperando, resultado;
        private Operacion calculadora;
        private ESistema sistema;

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            rdbDecimal.Checked = true;
            rdbBinario.Checked = false;
        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Desea cerra la calculadora?";
            string caption = "Cierre";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons, icon);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void TxtBPrimerOperador_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {

            this.primerOperando = new Numeracion(this.txtPrimerOperador.Text, this.sistema);
            this.segundoOperando = new Numeracion(this.txtSegundoOperador.Text, this.sistema);

            this.calculadora = new Operacion(this.primerOperando, this.segundoOperando);
            
            this.setResultado();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPrimerOperador.Clear();
            txtSegundoOperador.Clear();
            lblResultadoOperacion.Text = string.Empty;
            cmbOperacion.SelectedIndex = 0;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            this.sistema = ESistema.Decimal;
            
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            this.sistema = ESistema.Binario;
            
        }
        
        private void setResultado()
        {
            if (char.TryParse(cmbOperacion.Text, out char operadorSeleccionado))
            {
                this.resultado = new Numeracion(this.calculadora.Operar(operadorSeleccionado).ValorNumerico, this.sistema);

                if (sistema == ESistema.Decimal)
                {
                    lblResultadoOperacion.Text = this.resultado.ValorNumerico;
                }
                else
                {
                    lblResultadoOperacion.Text = this.resultado.ConvertirA(this.sistema);
                }
            }
            else
            {
                string mensajeError = "Error, operador invalido!";
                string tituloError = "Error operador";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(mensajeError, tituloError, button, icon);
            }
        }
    }
}