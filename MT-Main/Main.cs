using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT_Main {
    /// <summary>
    /// Form principal
    /// </summary>
    public partial class Main : Form {



        /// <summary>
        /// Iniciar componentes principales
        /// </summary>
        /// 
        private string alfabeto = "";
        private const char ESPACIO_EN_BLANCO = 'Δ';
        private ListViewItem cabezalDeLaMaquina = null;
        private char[] cadenaEntrada;
        private List<Operacion> operaciones = new List<Operacion>();
        private int delay = 100;

        public Main() {
            InitializeComponent();
            cboMovimientos.DataSource = Enum.GetValues(typeof(Movimientos));
            cboAcciones.DataSource = Enum.GetValues(typeof(Acciones));
            clearMovs();
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

        private void radEliminarTodosElementos_CheckedChanged(object sender, EventArgs e) {
            habilitarTextBoxesAuxiliares(false);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            habilitarTextBoxesAuxiliares(true);
        }

        private void habilitarTextBoxesAuxiliares(bool valor) {
            txtCaracterAuxiliar.Enabled = valor;
        }

        private void btnResetearPrograma_Click(object sender, EventArgs e) {
            cadenaEntrada = null;
            alfabetoEnCeldas.Items.Clear();
        }

        private void btnAgregarAccion_Click(object sender, EventArgs e) {
            Operacion nuevaOperacion = new Operacion((Movimientos) cboMovimientos.SelectedItem, (Acciones) cboAcciones.SelectedItem);
            
            if(string.IsNullOrWhiteSpace(txtCaracterAuxiliar.Text)) {
                MessageBox.Show("Favor de introducir un caracter para detener los movimientos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCaracterAuxiliar.Focus();
                return;
            }
            if(!alfabeto.Contains(txtCaracterAuxiliar.Text)) {
                MessageBox.Show("El elemento que se quiere utilizar en movimientos no se encuentra en el alfabeto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCaracterAuxiliar.Focus();
                return;
            }
            nuevaOperacion.CaracterMovimiento = txtCaracterAuxiliar.Text.ElementAt(0);

            if(nuevaOperacion.Accion == Acciones.REEMPLAZAR_SIMBOLO) {
                if(string.IsNullOrWhiteSpace(txtCaracterReemplazar.Text)) {
                    MessageBox.Show("Favor de introducir un caracter para reemplazar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCaracterReemplazar.Focus();
                    return;
                }
                if(!alfabeto.Contains(txtCaracterReemplazar.Text)) {
                    MessageBox.Show("El elemento que se quiere utilizar en reemplazo no se encuentra en el alfabeto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCaracterReemplazar.Focus();
                    return;
                }

                nuevaOperacion.CaracterAccion = txtCaracterReemplazar.Text.ElementAt(0);
            }

            nuevaOperacion.IsNegacion = chkNegacion.Checked;
            operaciones.Add(nuevaOperacion);

            clearMovs();
            btnGuardarCadenaEntrada.Enabled = false;
            btnEncenderMaquina.Enabled = true;
        }

        private async void btnEncenderMaquina_Click(object sender, EventArgs e) {
            delay = (int) delayControl.Value;
            bool x = await ejecutar();
            if(x) {
                MessageBox.Show("Cadena aceptada.", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("La cadena no fue aceptada.", "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async Task<bool>  ejecutar() {
            ListViewItem cabezal;
            try {
                cabezal = alfabetoEnCeldas.SelectedItems[0];
            } catch { //No deberia ocurrir nunca
                MessageBox.Show("No se encontro una cadena con la cual interactuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return await Task.FromResult(false);
            }
        
            int iterador = cabezal.Index;

            foreach(Operacion operacion in operaciones) {
                switch(operacion.Movimiento) {
                    case Movimientos.MOVER_DERECHA_HASTA:
                        iterador++;
                        while(true) {
                            if(iterador == cadenaEntrada.Length) {
                                MessageBox.Show("Ocurrio un problema en la parada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return await Task.FromResult(false);
                            }

                            if(operacion.IsNegacion ? cadenaEntrada[iterador] != operacion.CaracterMovimiento : cadenaEntrada[iterador] == operacion.CaracterMovimiento) { //Es el elemento que estoy buscando?
                                break;
                            }

                            var item = alfabetoEnCeldas.Items[iterador];
                            try {
                                alfabetoEnCeldas.Items[iterador + 1].Selected = true; //Cambio visual
                            } catch {
                                MessageBox.Show("Ocurrio un problema en la parada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return await Task.FromResult(false);
                            }

                            switch(operacion.Accion) {
                                case Acciones.ELIMINAR_CARACTER:
                                    cadenaEntrada[iterador] = ESPACIO_EN_BLANCO; //Cambia el valor en la cadena real
                                    item.Text = ESPACIO_EN_BLANCO.ToString(); //Cambia el valor visible en las celdas
                                    break;
                                case Acciones.REEMPLAZAR_SIMBOLO:
                                    cadenaEntrada[iterador] = operacion.CaracterAccion; //Cambia el valor en la cadena real
                                    item.Text = operacion.CaracterAccion.ToString(); //Cambia el valor visible en las celdas
                                    break;
                                case Acciones.SOBREESCRIBIR:
                                    break;
                            }
                          
                            await Task.Delay(delay); 
                            iterador++;
                        }

                    break;
                    case Movimientos.MOVER_IZQUIERDA_HASTA:
                        iterador--;
                        while(true) {
                            if(iterador == -1) {
                                MessageBox.Show("Ocurrio una terminacion anormal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return await Task.FromResult(false);
                            }
                            if(operacion.IsNegacion ? cadenaEntrada[iterador] != operacion.CaracterMovimiento : cadenaEntrada[iterador] == operacion.CaracterMovimiento) { //Es el elemento que estoy buscando?
                                break;
                            }

                            var item = alfabetoEnCeldas.Items[iterador];
                            try {
                                alfabetoEnCeldas.Items[iterador - 1].Selected = true; //Cambio visual
                            } catch {
                                MessageBox.Show("Ocurrio una terminacion anormal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return await Task.FromResult(false);
                            }

                            switch(operacion.Accion) {
                                case Acciones.ELIMINAR_CARACTER:
                                    cadenaEntrada[iterador] = ESPACIO_EN_BLANCO; //Cambia el valor en la cadena real
                                    item.Text = ESPACIO_EN_BLANCO.ToString(); //Cambia el valor visible en las celdas
                                    break;
                                case Acciones.REEMPLAZAR_SIMBOLO:
                                    cadenaEntrada[iterador] = operacion.CaracterAccion; //Cambia el valor en la cadena real
                                    item.Text = operacion.CaracterAccion.ToString(); //Cambia el valor visible en las celdas
                                    break;
                                case Acciones.SOBREESCRIBIR:
                                    break;
                            }

                            await Task.Delay(delay);
                            iterador--;
                        }

                     break;                    
                }
            }

            return await Task.FromResult(true);
        }

        private void clearMovs() {
            cboAcciones.SelectedIndex = 0;
            cboMovimientos.SelectedIndex = 0;
            txtCaracterAuxiliar.Text = "";
            txtCaracterReemplazar.Text = "";
            chkNegacion.Checked = false;
        }
    
    }
}
