using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            Color textColor = SystemColors.HighlightText;
            Color backGroundDeLaCelda = Color.FromArgb(255,90,51);
            SolidBrush sb = new SolidBrush(backGroundDeLaCelda);
            e.Graphics.FillRectangle(sb, e.Bounds); //Hacer el rectangulo
            e.Graphics.DrawRectangle(Pens.DarkGray, e.Bounds);
            TextRenderer.DrawText(e.Graphics, e.Item.Text, alfabetoEnCeldas.Font, e.Bounds,
                                  textColor, Color.Empty,
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
            var cabezalSeleccionodo = alfabetoEnCeldas.SelectedItems[0];
           // cabezalSeleccionodo.Bounds = Bounds. TODO
           // cabezalSeleccionodo.BackColor = Color.Red;
        }
    }
}
