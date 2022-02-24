
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
            this.btnGuardarCadenaEntrada = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCadenaEntrada = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCaracterAlfabeto = new System.Windows.Forms.TextBox();
            this.btnAgregarCaracterAlfabeto = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.delayControl = new System.Windows.Forms.NumericUpDown();
            this.btnResetearPrograma = new System.Windows.Forms.Button();
            this.listBoxAlfabeto = new System.Windows.Forms.ListBox();
            this.btnEncenderMaquina = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCaracterReemplazar = new System.Windows.Forms.TextBox();
            this.chkNegacion = new System.Windows.Forms.CheckBox();
            this.cboAcciones = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregarAccion = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMovimientos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCaracterAuxiliar = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvAcciones = new System.Windows.Forms.DataGridView();
            this.Iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnResetearMovimientos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayControl)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcciones)).BeginInit();
            this.groupBox7.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(1309, 228);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de entrada";
            // 
            // lblSelectedItemList
            // 
            this.lblSelectedItemList.AutoSize = true;
            this.lblSelectedItemList.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedItemList.Location = new System.Drawing.Point(309, 96);
            this.lblSelectedItemList.Name = "lblSelectedItemList";
            this.lblSelectedItemList.Size = new System.Drawing.Size(213, 20);
            this.lblSelectedItemList.TabIndex = 8;
            this.lblSelectedItemList.Text = "Cabezal seleccionado:";
            // 
            // alfabetoEnCeldas
            // 
            this.alfabetoEnCeldas.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.alfabetoEnCeldas.HideSelection = false;
            this.alfabetoEnCeldas.Location = new System.Drawing.Point(6, 122);
            this.alfabetoEnCeldas.MultiSelect = false;
            this.alfabetoEnCeldas.Name = "alfabetoEnCeldas";
            this.alfabetoEnCeldas.OwnerDraw = true;
            this.alfabetoEnCeldas.Size = new System.Drawing.Size(1297, 86);
            this.alfabetoEnCeldas.TabIndex = 7;
            this.alfabetoEnCeldas.TileSize = new System.Drawing.Size(60, 60);
            this.alfabetoEnCeldas.UseCompatibleStateImageBehavior = false;
            this.alfabetoEnCeldas.View = System.Windows.Forms.View.Tile;
            this.alfabetoEnCeldas.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.alfabetoEnCeldas_DrawItem);
            this.alfabetoEnCeldas.Click += new System.EventHandler(this.alfabetoEnCeldas_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGuardarCadenaEntrada);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtCadenaEntrada);
            this.groupBox3.Location = new System.Drawing.Point(285, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1018, 61);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cadena de entrada";
            // 
            // btnGuardarCadenaEntrada
            // 
            this.btnGuardarCadenaEntrada.BackColor = System.Drawing.Color.PowderBlue;
            this.btnGuardarCadenaEntrada.Location = new System.Drawing.Point(856, 23);
            this.btnGuardarCadenaEntrada.Name = "btnGuardarCadenaEntrada";
            this.btnGuardarCadenaEntrada.Size = new System.Drawing.Size(156, 28);
            this.btnGuardarCadenaEntrada.TabIndex = 6;
            this.btnGuardarCadenaEntrada.Text = "Guardar";
            this.btnGuardarCadenaEntrada.UseVisualStyleBackColor = false;
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
            this.txtCadenaEntrada.Size = new System.Drawing.Size(566, 27);
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
            this.btnAgregarCaracterAlfabeto.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAgregarCaracterAlfabeto.Location = new System.Drawing.Point(6, 53);
            this.btnAgregarCaracterAlfabeto.Name = "btnAgregarCaracterAlfabeto";
            this.btnAgregarCaracterAlfabeto.Size = new System.Drawing.Size(261, 27);
            this.btnAgregarCaracterAlfabeto.TabIndex = 3;
            this.btnAgregarCaracterAlfabeto.Text = "Agregar al alfabeto";
            this.btnAgregarCaracterAlfabeto.UseVisualStyleBackColor = false;
            this.btnAgregarCaracterAlfabeto.Click += new System.EventHandler(this.btnAgregarCaracterAlfabeto_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(663, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Retraso/Delay:";
            // 
            // delayControl
            // 
            this.delayControl.BackColor = System.Drawing.Color.Azure;
            this.delayControl.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.delayControl.Location = new System.Drawing.Point(815, 266);
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
            this.delayControl.Size = new System.Drawing.Size(85, 27);
            this.delayControl.TabIndex = 10;
            this.delayControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.delayControl.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnResetearPrograma
            // 
            this.btnResetearPrograma.BackColor = System.Drawing.Color.Firebrick;
            this.btnResetearPrograma.ForeColor = System.Drawing.Color.Snow;
            this.btnResetearPrograma.Location = new System.Drawing.Point(211, 31);
            this.btnResetearPrograma.Name = "btnResetearPrograma";
            this.btnResetearPrograma.Size = new System.Drawing.Size(196, 28);
            this.btnResetearPrograma.TabIndex = 7;
            this.btnResetearPrograma.Text = "Resetear Maquina";
            this.btnResetearPrograma.UseVisualStyleBackColor = false;
            this.btnResetearPrograma.Click += new System.EventHandler(this.btnResetearPrograma_Click);
            // 
            // listBoxAlfabeto
            // 
            this.listBoxAlfabeto.BackColor = System.Drawing.Color.White;
            this.listBoxAlfabeto.FormattingEnabled = true;
            this.listBoxAlfabeto.ItemHeight = 20;
            this.listBoxAlfabeto.Location = new System.Drawing.Point(34, 26);
            this.listBoxAlfabeto.Name = "listBoxAlfabeto";
            this.listBoxAlfabeto.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxAlfabeto.Size = new System.Drawing.Size(23, 364);
            this.listBoxAlfabeto.TabIndex = 2;
            this.listBoxAlfabeto.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxAlfabeto_DrawItem);
            // 
            // btnEncenderMaquina
            // 
            this.btnEncenderMaquina.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEncenderMaquina.Enabled = false;
            this.btnEncenderMaquina.ForeColor = System.Drawing.Color.Snow;
            this.btnEncenderMaquina.Location = new System.Drawing.Point(1038, 246);
            this.btnEncenderMaquina.Name = "btnEncenderMaquina";
            this.btnEncenderMaquina.Size = new System.Drawing.Size(250, 65);
            this.btnEncenderMaquina.TabIndex = 3;
            this.btnEncenderMaquina.Text = "Encender maquina";
            this.btnEncenderMaquina.UseVisualStyleBackColor = false;
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
            this.groupBox4.Location = new System.Drawing.Point(112, 317);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(413, 333);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Estados";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Reemplazalo por:";
            // 
            // txtCaracterReemplazar
            // 
            this.txtCaracterReemplazar.Location = new System.Drawing.Point(318, 231);
            this.txtCaracterReemplazar.MaxLength = 1;
            this.txtCaracterReemplazar.Name = "txtCaracterReemplazar";
            this.txtCaracterReemplazar.Size = new System.Drawing.Size(89, 27);
            this.txtCaracterReemplazar.TabIndex = 17;
            // 
            // chkNegacion
            // 
            this.chkNegacion.AutoSize = true;
            this.chkNegacion.Location = new System.Drawing.Point(304, 130);
            this.chkNegacion.Name = "chkNegacion";
            this.chkNegacion.Size = new System.Drawing.Size(103, 24);
            this.chkNegacion.TabIndex = 16;
            this.chkNegacion.Text = "Negacion";
            this.chkNegacion.UseVisualStyleBackColor = true;
            // 
            // cboAcciones
            // 
            this.cboAcciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAcciones.FormattingEnabled = true;
            this.cboAcciones.Location = new System.Drawing.Point(122, 178);
            this.cboAcciones.Name = "cboAcciones";
            this.cboAcciones.Size = new System.Drawing.Size(285, 28);
            this.cboAcciones.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Accion:";
            // 
            // btnAgregarAccion
            // 
            this.btnAgregarAccion.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAgregarAccion.Location = new System.Drawing.Point(6, 286);
            this.btnAgregarAccion.Name = "btnAgregarAccion";
            this.btnAgregarAccion.Size = new System.Drawing.Size(401, 33);
            this.btnAgregarAccion.TabIndex = 13;
            this.btnAgregarAccion.Text = "Agregar";
            this.btnAgregarAccion.UseVisualStyleBackColor = false;
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
            this.cboMovimientos.Size = new System.Drawing.Size(285, 28);
            this.cboMovimientos.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hasta que encuentres:";
            // 
            // txtCaracterAuxiliar
            // 
            this.txtCaracterAuxiliar.Location = new System.Drawing.Point(318, 77);
            this.txtCaracterAuxiliar.MaxLength = 1;
            this.txtCaracterAuxiliar.Name = "txtCaracterAuxiliar";
            this.txtCaracterAuxiliar.Size = new System.Drawing.Size(89, 27);
            this.txtCaracterAuxiliar.TabIndex = 5;
            this.txtCaracterAuxiliar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracterAuxiliar_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listBoxAlfabeto);
            this.groupBox5.Location = new System.Drawing.Point(12, 246);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(94, 404);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Alfabeto";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvAcciones);
            this.groupBox6.Location = new System.Drawing.Point(540, 317);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(781, 333);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Movimientos por pasos";
            // 
            // dgvAcciones
            // 
            this.dgvAcciones.AllowUserToAddRows = false;
            this.dgvAcciones.AllowUserToDeleteRows = false;
            this.dgvAcciones.AllowUserToResizeRows = false;
            this.dgvAcciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAcciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvAcciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Iteracion,
            this.Descripcion});
            this.dgvAcciones.Location = new System.Drawing.Point(6, 26);
            this.dgvAcciones.MultiSelect = false;
            this.dgvAcciones.Name = "dgvAcciones";
            this.dgvAcciones.ReadOnly = true;
            this.dgvAcciones.RowHeadersVisible = false;
            this.dgvAcciones.Size = new System.Drawing.Size(769, 301);
            this.dgvAcciones.TabIndex = 0;
            // 
            // Iteracion
            // 
            this.Iteracion.FillWeight = 40.60914F;
            this.Iteracion.HeaderText = "Estados";
            this.Iteracion.Name = "Iteracion";
            this.Iteracion.ReadOnly = true;
            this.Iteracion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Descripcion
            // 
            this.Descripcion.FillWeight = 159.3909F;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnResetearMovimientos);
            this.groupBox7.Controls.Add(this.btnResetearPrograma);
            this.groupBox7.Location = new System.Drawing.Point(112, 246);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(413, 65);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Acciones de reseteo";
            // 
            // btnResetearMovimientos
            // 
            this.btnResetearMovimientos.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnResetearMovimientos.Enabled = false;
            this.btnResetearMovimientos.ForeColor = System.Drawing.Color.Snow;
            this.btnResetearMovimientos.Location = new System.Drawing.Point(6, 31);
            this.btnResetearMovimientos.Name = "btnResetearMovimientos";
            this.btnResetearMovimientos.Size = new System.Drawing.Size(199, 28);
            this.btnResetearMovimientos.TabIndex = 8;
            this.btnResetearMovimientos.Text = "Resetear Estados";
            this.btnResetearMovimientos.UseVisualStyleBackColor = false;
            this.btnResetearMovimientos.Click += new System.EventHandler(this.btnResetearMovimientos_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1333, 664);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.delayControl);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEncenderMaquina);
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
            ((System.ComponentModel.ISupportInitialize)(this.delayControl)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcciones)).EndInit();
            this.groupBox7.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox cboAcciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkNegacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCaracterReemplazar;
        private System.Windows.Forms.NumericUpDown delayControl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnResetearMovimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}