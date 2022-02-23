
namespace MT_Main {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSelectedItemList = new System.Windows.Forms.Label();
            this.alfabetoEnCeldas = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnResetearPrograma = new System.Windows.Forms.Button();
            this.btnGuardarCadenaEntrada = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCadenaEntrada = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCaracterAlfabeto = new System.Windows.Forms.TextBox();
            this.btnAgregarCaracterAlfabeto = new System.Windows.Forms.Button();
            this.listBoxAlfabeto = new System.Windows.Forms.ListBox();
            this.btnEncenderMaquina = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAgregarAccion = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMovimientos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCaracterAuxiliar = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbxMovimientosPorPasos = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvAcciones = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cboAcciones = new System.Windows.Forms.ComboBox();
            this.chkNegacion = new System.Windows.Forms.CheckBox();
            this.txtCaracterReemplazar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.delayControl = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayControl)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSelectedItemList);
            this.groupBox1.Controls.Add(this.alfabetoEnCeldas);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1309, 246);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de entrada";
            // 
            // lblSelectedItemList
            // 
            this.lblSelectedItemList.AutoSize = true;
            this.lblSelectedItemList.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedItemList.Location = new System.Drawing.Point(1084, 132);
            this.lblSelectedItemList.Name = "lblSelectedItemList";
            this.lblSelectedItemList.Size = new System.Drawing.Size(213, 20);
            this.lblSelectedItemList.TabIndex = 8;
            this.lblSelectedItemList.Text = "Cabezal seleccionado:";
            // 
            // alfabetoEnCeldas
            // 
            this.alfabetoEnCeldas.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.alfabetoEnCeldas.HideSelection = false;
            this.alfabetoEnCeldas.Location = new System.Drawing.Point(6, 155);
            this.alfabetoEnCeldas.MultiSelect = false;
            this.alfabetoEnCeldas.Name = "alfabetoEnCeldas";
            this.alfabetoEnCeldas.OwnerDraw = true;
            this.alfabetoEnCeldas.Size = new System.Drawing.Size(1297, 85);
            this.alfabetoEnCeldas.TabIndex = 7;
            this.alfabetoEnCeldas.TileSize = new System.Drawing.Size(60, 60);
            this.alfabetoEnCeldas.UseCompatibleStateImageBehavior = false;
            this.alfabetoEnCeldas.View = System.Windows.Forms.View.Tile;
            this.alfabetoEnCeldas.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.alfabetoEnCeldas_DrawItem);
            this.alfabetoEnCeldas.Click += new System.EventHandler(this.alfabetoEnCeldas_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnResetearPrograma);
            this.groupBox3.Controls.Add(this.btnGuardarCadenaEntrada);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtCadenaEntrada);
            this.groupBox3.Location = new System.Drawing.Point(285, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1018, 90);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cadena de entrada";
            // 
            // btnResetearPrograma
            // 
            this.btnResetearPrograma.Location = new System.Drawing.Point(600, 56);
            this.btnResetearPrograma.Name = "btnResetearPrograma";
            this.btnResetearPrograma.Size = new System.Drawing.Size(250, 28);
            this.btnResetearPrograma.TabIndex = 7;
            this.btnResetearPrograma.Text = "Resetear cadena";
            this.btnResetearPrograma.UseVisualStyleBackColor = true;
            this.btnResetearPrograma.Click += new System.EventHandler(this.btnResetearPrograma_Click);
            // 
            // btnGuardarCadenaEntrada
            // 
            this.btnGuardarCadenaEntrada.Location = new System.Drawing.Point(856, 56);
            this.btnGuardarCadenaEntrada.Name = "btnGuardarCadenaEntrada";
            this.btnGuardarCadenaEntrada.Size = new System.Drawing.Size(156, 28);
            this.btnGuardarCadenaEntrada.TabIndex = 6;
            this.btnGuardarCadenaEntrada.Text = "Guardar";
            this.btnGuardarCadenaEntrada.UseVisualStyleBackColor = true;
            this.btnGuardarCadenaEntrada.Click += new System.EventHandler(this.btnGuardarCadenaEntrada_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Introduce la cadena de entrada:";
            // 
            // txtCadenaEntrada
            // 
            this.txtCadenaEntrada.Location = new System.Drawing.Point(286, 23);
            this.txtCadenaEntrada.Name = "txtCadenaEntrada";
            this.txtCadenaEntrada.Size = new System.Drawing.Size(726, 27);
            this.txtCadenaEntrada.TabIndex = 4;
            this.txtCadenaEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCadenaEntrada_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtCaracterAlfabeto);
            this.groupBox2.Controls.Add(this.btnAgregarCaracterAlfabeto);
            this.groupBox2.Location = new System.Drawing.Point(6, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 90);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alfabeto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Introduce un caracter:";
            // 
            // txtCaracterAlfabeto
            // 
            this.txtCaracterAlfabeto.Location = new System.Drawing.Point(203, 20);
            this.txtCaracterAlfabeto.MaxLength = 1;
            this.txtCaracterAlfabeto.Name = "txtCaracterAlfabeto";
            this.txtCaracterAlfabeto.Size = new System.Drawing.Size(64, 27);
            this.txtCaracterAlfabeto.TabIndex = 1;
            this.txtCaracterAlfabeto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracterAlfabeto_KeyPress);
            // 
            // btnAgregarCaracterAlfabeto
            // 
            this.btnAgregarCaracterAlfabeto.Location = new System.Drawing.Point(6, 53);
            this.btnAgregarCaracterAlfabeto.Name = "btnAgregarCaracterAlfabeto";
            this.btnAgregarCaracterAlfabeto.Size = new System.Drawing.Size(261, 27);
            this.btnAgregarCaracterAlfabeto.TabIndex = 3;
            this.btnAgregarCaracterAlfabeto.Text = "Agregar al alfabeto";
            this.btnAgregarCaracterAlfabeto.UseVisualStyleBackColor = true;
            this.btnAgregarCaracterAlfabeto.Click += new System.EventHandler(this.btnAgregarCaracterAlfabeto_Click);
            // 
            // listBoxAlfabeto
            // 
            this.listBoxAlfabeto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBoxAlfabeto.FormattingEnabled = true;
            this.listBoxAlfabeto.ItemHeight = 20;
            this.listBoxAlfabeto.Location = new System.Drawing.Point(34, 26);
            this.listBoxAlfabeto.Name = "listBoxAlfabeto";
            this.listBoxAlfabeto.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxAlfabeto.Size = new System.Drawing.Size(23, 384);
            this.listBoxAlfabeto.TabIndex = 2;
            // 
            // btnEncenderMaquina
            // 
            this.btnEncenderMaquina.Enabled = false;
            this.btnEncenderMaquina.Location = new System.Drawing.Point(0, 262);
            this.btnEncenderMaquina.Name = "btnEncenderMaquina";
            this.btnEncenderMaquina.Size = new System.Drawing.Size(331, 54);
            this.btnEncenderMaquina.TabIndex = 3;
            this.btnEncenderMaquina.Text = "Encender maquina";
            this.btnEncenderMaquina.UseVisualStyleBackColor = true;
            this.btnEncenderMaquina.Click += new System.EventHandler(this.btnEncenderMaquina_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtCaracterReemplazar);
            this.groupBox4.Controls.Add(this.chkNegacion);
            this.groupBox4.Controls.Add(this.cboAcciones);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.btnAgregarAccion);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cboMovimientos);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtCaracterAuxiliar);
            this.groupBox4.Controls.Add(this.btnEncenderMaquina);
            this.groupBox4.Location = new System.Drawing.Point(121, 264);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(343, 333);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Procesos";
            // 
            // btnAgregarAccion
            // 
            this.btnAgregarAccion.Location = new System.Drawing.Point(0, 225);
            this.btnAgregarAccion.Name = "btnAgregarAccion";
            this.btnAgregarAccion.Size = new System.Drawing.Size(331, 31);
            this.btnAgregarAccion.TabIndex = 13;
            this.btnAgregarAccion.Text = "Agregar";
            this.btnAgregarAccion.UseVisualStyleBackColor = true;
            this.btnAgregarAccion.Click += new System.EventHandler(this.btnAgregarAccion_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Movimiento:";
            // 
            // cboMovimientos
            // 
            this.cboMovimientos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMovimientos.FormattingEnabled = true;
            this.cboMovimientos.Location = new System.Drawing.Point(122, 26);
            this.cboMovimientos.Name = "cboMovimientos";
            this.cboMovimientos.Size = new System.Drawing.Size(215, 28);
            this.cboMovimientos.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hasta que encuentres:";
            // 
            // txtCaracterAuxiliar
            // 
            this.txtCaracterAuxiliar.Location = new System.Drawing.Point(208, 60);
            this.txtCaracterAuxiliar.MaxLength = 1;
            this.txtCaracterAuxiliar.Name = "txtCaracterAuxiliar";
            this.txtCaracterAuxiliar.Size = new System.Drawing.Size(129, 27);
            this.txtCaracterAuxiliar.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listBoxAlfabeto);
            this.groupBox5.Location = new System.Drawing.Point(12, 264);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(94, 416);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Alfabeto";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvAcciones);
            this.groupBox6.Location = new System.Drawing.Point(562, 414);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(343, 141);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Acciones";
            // 
            // lbxMovimientosPorPasos
            // 
            this.lbxMovimientosPorPasos.FormattingEnabled = true;
            this.lbxMovimientosPorPasos.ItemHeight = 20;
            this.lbxMovimientosPorPasos.Location = new System.Drawing.Point(931, 313);
            this.lbxMovimientosPorPasos.Name = "lbxMovimientosPorPasos";
            this.lbxMovimientosPorPasos.Size = new System.Drawing.Size(390, 364);
            this.lbxMovimientosPorPasos.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Movimientos por pasos.";
            // 
            // dgvAcciones
            // 
            this.dgvAcciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcciones.Location = new System.Drawing.Point(0, 54);
            this.dgvAcciones.Name = "dgvAcciones";
            this.dgvAcciones.Size = new System.Drawing.Size(331, 129);
            this.dgvAcciones.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Accion:";
            // 
            // cboAcciones
            // 
            this.cboAcciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAcciones.FormattingEnabled = true;
            this.cboAcciones.Location = new System.Drawing.Point(96, 96);
            this.cboAcciones.Name = "cboAcciones";
            this.cboAcciones.Size = new System.Drawing.Size(241, 28);
            this.cboAcciones.TabIndex = 15;
            // 
            // chkNegacion
            // 
            this.chkNegacion.AutoSize = true;
            this.chkNegacion.Location = new System.Drawing.Point(26, 181);
            this.chkNegacion.Name = "chkNegacion";
            this.chkNegacion.Size = new System.Drawing.Size(103, 24);
            this.chkNegacion.TabIndex = 16;
            this.chkNegacion.Text = "Negacion";
            this.chkNegacion.UseVisualStyleBackColor = true;
            // 
            // txtCaracterReemplazar
            // 
            this.txtCaracterReemplazar.Location = new System.Drawing.Point(208, 130);
            this.txtCaracterReemplazar.MaxLength = 1;
            this.txtCaracterReemplazar.Name = "txtCaracterReemplazar";
            this.txtCaracterReemplazar.Size = new System.Drawing.Size(129, 27);
            this.txtCaracterReemplazar.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Reemplazalo por:";
            // 
            // delayControl
            // 
            this.delayControl.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.delayControl.Location = new System.Drawing.Point(488, 630);
            this.delayControl.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.delayControl.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.delayControl.Name = "delayControl";
            this.delayControl.Size = new System.Drawing.Size(120, 27);
            this.delayControl.TabIndex = 10;
            this.delayControl.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 692);
            this.Controls.Add(this.delayControl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbxMovimientosPorPasos);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maquina de Turing";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarCaracterAlfabeto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCaracterAlfabeto;
        private System.Windows.Forms.ListBox listBoxAlfabeto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGuardarCadenaEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCadenaEntrada;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView alfabetoEnCeldas;
        private System.Windows.Forms.Button btnEncenderMaquina;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblSelectedItemList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCaracterAuxiliar;
        private System.Windows.Forms.Button btnResetearPrograma;
        private System.Windows.Forms.Button btnAgregarAccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMovimientos;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvAcciones;
        private System.Windows.Forms.ListBox lbxMovimientosPorPasos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboAcciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkNegacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCaracterReemplazar;
        private System.Windows.Forms.NumericUpDown delayControl;
    }
}