
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
            this.alfabetoEnCeldas = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGuardarCadenaEntrada = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCadenaEntrada = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCaracterAlfabeto = new System.Windows.Forms.TextBox();
            this.btnAgregarCaracterAlfabeto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxAlfabeto = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            // alfabetoEnCeldas
            // 
            this.alfabetoEnCeldas.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.alfabetoEnCeldas.HideSelection = false;
            this.alfabetoEnCeldas.Location = new System.Drawing.Point(6, 141);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mi alfabeto:";
            // 
            // listBoxAlfabeto
            // 
            this.listBoxAlfabeto.FormattingEnabled = true;
            this.listBoxAlfabeto.ItemHeight = 20;
            this.listBoxAlfabeto.Location = new System.Drawing.Point(12, 284);
            this.listBoxAlfabeto.Name = "listBoxAlfabeto";
            this.listBoxAlfabeto.Size = new System.Drawing.Size(108, 404);
            this.listBoxAlfabeto.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxAlfabeto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maquina de Turing";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarCaracterAlfabeto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCaracterAlfabeto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxAlfabeto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGuardarCadenaEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCadenaEntrada;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView alfabetoEnCeldas;
        private System.Windows.Forms.Button button1;
    }
}