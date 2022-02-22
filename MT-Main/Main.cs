using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT_Main {
    /// <summary>
    /// Form principal
    /// </summary>
    public partial class Main : Form {

        enum Operacion {
            RECORRER_DERECHA,
            RECORRER_IZQUIERDA
        }

        /// <summary>
        /// Iniciar componentes principales
        /// </summary>
        /// 
        private string alfabeto = "";
        private const char ESPACIO_EN_BLANCO = 'Δ';

        private object cabezalDeLaMaquina = null;

        public Main() {
            InitializeComponent();
        }

        private void btnAgregarCaracterAlfabeto_Click(object sender, EventArgs e) {
            onAgregarCaracterAlfabeto();
        }

        /// <summary>
        /// Metodo que controla la adicion de nuevos caracteres al alfabeto
        /// </summary>
        private void onAgregarCaracterAlfabeto() {
            string caracterIngresado = txtCaracterAlfabeto.Text;
            if (string.IsNullOrWhiteSpace(caracterIngresado)) {
                MessageBox.Show("Favor de introducir un caracter", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (alfabeto.Contains(caracterIngresado)) {
                MessageBox.Show("El caracter introducido ya se encuentra en el alfabeto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            agregarCaracterAlfabeto(caracterIngresado);
        }

        private void agregarCaracterAlfabeto(string caracterIngresado) {
            alfabeto += caracterIngresado;

            listBoxAlfabeto.Items.Add(caracterIngresado);
       
            txtCaracterAlfabeto.Clear();
            txtCaracterAlfabeto.Focus();
            MessageBox.Show("El caracter <" + caracterIngresado + "> fue ingresado al alfabeto.", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardarCadenaEntrada_Click(object sender, EventArgs e) {
            if(string.IsNullOrEmpty(alfabeto)) {
                MessageBox.Show("No hay elementos en el alfabeto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cadenaEntrada = txtCadenaEntrada.Text;
            //no permitir modificar alfabeto
            //guardar cadena, no modificarla
            //mostrar cadena por espacios, en cuadricula
            //
            guardarCadenaEntradaEnCeldas(cadenaEntrada);
        }

        /// <summary>
        /// Guarda la cadena de entrada en el listView
        /// Lo divide x celdas
        /// </summary>
        /// <param name="cadenaEntrada">Cadena de entrada a dividr en el listView</param>
        private void guardarCadenaEntradaEnCeldas(string cadenaEntrada) {
            foreach(char caracter in cadenaEntrada) {
                alfabetoEnCeldas.Items.Add(caracter.ToString());
            }
            alfabetoEnCeldas.Items[0].Selected = true;
            cabezalDeLaMaquina = alfabetoEnCeldas.SelectedItems[0];
        }

        /// <summary>
        /// Evento que provoca cuando se ingresa un caracter en la cadena de entrada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCadenaEntrada_KeyPress(object sender, KeyPressEventArgs e) {
            if(e.KeyChar == ' ')
                e.KeyChar = ESPACIO_EN_BLANCO;
            else if(e.KeyChar != '\b' && !alfabeto.Contains(e.KeyChar)) {
                if(MessageBox.Show("El caracter ingresado <" + e.KeyChar + "> no se encuentra en el alfabeto. ¿Desea reemplazarlo por un <" + ESPACIO_EN_BLANCO + ">?.", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    e.KeyChar = ESPACIO_EN_BLANCO;
                else
                    e.Handled = true;
            }

        }

        /// <summary>
        /// Dibujar los elementos de la lista en el listView, separando la cadena en celdas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void alfabetoEnCeldas_DrawItem(object sender, DrawListViewItemEventArgs e)
        {

            SolidBrush colorNormalDeFondo = new SolidBrush(Color.FromArgb(255, 90, 51));
            SolidBrush colorCuandoCabezalSeSelecciona = new SolidBrush(Color.FromArgb(36,255,109));
            if (e.Item.Selected) {
                e.Graphics.FillRectangle(colorCuandoCabezalSeSelecciona, e.Bounds);
            } else e.Graphics.FillRectangle(colorNormalDeFondo, e.Bounds); 
            e.Graphics.DrawRectangle(Pens.Red, e.Bounds);
            TextRenderer.DrawText(e.Graphics, e.Item.Text, alfabetoEnCeldas.Font, e.Bounds,
                                   SystemColors.HighlightText, Color.Empty,
                                  TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        /// <summary>
        /// Al momento de hacer enter en el input de un nuevo caracter en el alfabeto, guardarlo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCaracterAlfabeto_KeyPress(object sender, KeyPressEventArgs e) {
            if(e.KeyChar == '\r') {
                onAgregarCaracterAlfabeto();
            }
        }

        /// <summary>
        /// Seleccionar cabezal de la cadena
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void alfabetoEnCeldas_Click(object sender, EventArgs e) {
            var cabezalSeleccionado = alfabetoEnCeldas.SelectedItems[0];
            cabezalDeLaMaquina = cabezalSeleccionado;
        }

        /// <summary>
        /// Realizar una operacion en la cadena
        /// </summary>
        /// <param name="operacion"></param>
        private async void operacionEnCadena(Operacion operacion) {
            if(operacion == Operacion.RECORRER_DERECHA) {
                var cabezal = alfabetoEnCeldas.SelectedItems[0];
               for(int i=cabezal.Index; i < alfabetoEnCeldas.Items.Count; i++) {
                    var item = alfabetoEnCeldas.Items[i];
                    item.Selected = true;
                    await Task.Delay(400);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            operacionEnCadena(Operacion.RECORRER_DERECHA);
        }
    }
}
