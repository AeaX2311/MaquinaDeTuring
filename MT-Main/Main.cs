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
            ELIMINAR_TODOS,
            ELIMINAR_ELEMENTO
        }

        /// <summary>
        /// Iniciar componentes principales
        /// </summary>
        /// 
        private string alfabeto = "";
        private const char ESPACIO_EN_BLANCO = 'Δ';
        private ListViewItem cabezalDeLaMaquina = null;
        private char[] cadenaEntrada;


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

            cadenaEntrada = txtCadenaEntrada.Text.ToCharArray();
            //no permitir modificar alfabeto
            //guardar cadena, no modificarla
            guardarCadenaEntradaEnCeldas();
            btnEncenderMaquina.Enabled = true;
            btnAgregarCaracterAlfabeto.Enabled = false;
        }

        /// <summary>
        /// Guarda la cadena de entrada en el listView
        /// Lo divide x celdas
        /// </summary>
        /// <param name="cadenaEntrada">Cadena de entrada a dividr en el listView</param>
        private void guardarCadenaEntradaEnCeldas() {
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
            lblSelectedItemList.Text = "Cabezal seleccionado: " + cabezalDeLaMaquina.Index;
        }

        /// <summary>
        /// Realizar una operacion en la cadena
        /// </summary>
        /// <param name="operacion"></param>
        private async void operacionEnCadena(Operacion operacion) {
            ListViewItem cabezal;
            try {
                cabezal = alfabetoEnCeldas.SelectedItems[0];
            }catch { //No deberia ocurrir nunca
                MessageBox.Show("No se encontro una cadena con la cual interactuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(operacion == Operacion.ELIMINAR_TODOS) {
                //Recorre los elementos de la posicion seleccionada hasta el ultimo
                for(int i = cabezal.Index; i < alfabetoEnCeldas.Items.Count; i++) {
                    cadenaEntrada[i] = ESPACIO_EN_BLANCO; //Cambia el valor en la cadena real
                    var item = alfabetoEnCeldas.Items[i];
                    item.Text = ESPACIO_EN_BLANCO.ToString(); //Cambia el valor visible en las celdas
                    item.Selected = true; //Cambio de color  
                    await Task.Delay(800); //Delay
                }
            } else if (operacion == Operacion.ELIMINAR_ELEMENTO) {
                int i;
                for(i = cabezal.Index; i < alfabetoEnCeldas.Items.Count; i++) {
                    var item = alfabetoEnCeldas.Items[i];
                    item.Selected = true;
                    await Task.Delay(800);
                    
                    if(cadenaEntrada[i] == txtAuxiliar.Text.ElementAt(0)) { //Es el elemento que estoy buscando?
                        cadenaEntrada[i] = ESPACIO_EN_BLANCO; //Cambia el valor en la cadena real
                        item.Text = ESPACIO_EN_BLANCO.ToString(); //Cambia el valor visible en las celdas
                        i--; //Decrementa en uno para que aparezca en la posicion anterior
                        break;
                    }
                }

                for(; i >= 0; i--) {
                    var item = alfabetoEnCeldas.Items[i];
                    item.Selected = true;
                    await Task.Delay(800);
                    
                    if(i == int.Parse(nudCabezaFinal.Text)) break;//Llegue a la posicion que quiero terminar?
                }
            }
        }

        private void btnEncenderMaquina_Click(object sender, EventArgs e) {
            if(radEliminarTodosElementos.Checked) {
                operacionEnCadena(Operacion.ELIMINAR_TODOS);
            } else if(radEliminarElemento.Checked) {
                if(string.IsNullOrWhiteSpace(txtAuxiliar.Text)) {
                    MessageBox.Show("Favor de introducir un elemento para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAuxiliar.Focus();
                    return;
                }
                if(string.IsNullOrWhiteSpace(nudCabezaFinal.Text)) {
                    MessageBox.Show("Favor de introducir el cabezal en el que terminara la maquina.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nudCabezaFinal.Focus();
                    return;
                }
                if(!alfabeto.Contains(txtAuxiliar.Text)) {
                    MessageBox.Show("El elemento que se quiere eliminar no se encuentra en el alfabeto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAuxiliar.Focus();
                    return;
                }

                operacionEnCadena(Operacion.ELIMINAR_ELEMENTO);
            }

            //Imprimir diagrama
           // MessageBox.Show("Operacion realizada correctamente.", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radEliminarTodosElementos_CheckedChanged(object sender, EventArgs e) {
            habilitarTextBoxesAuxiliares(false);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            habilitarTextBoxesAuxiliares(true);
        }

        private void habilitarTextBoxesAuxiliares(bool valor) {
            txtAuxiliar.Enabled = valor;
            nudCabezaFinal.Enabled = valor;
        }

        private void btnResetearPrograma_Click(object sender, EventArgs e) {
            cadenaEntrada = null;
            alfabetoEnCeldas.Items.Clear();
        }
    }
}
