using Entidades;

namespace integrador_ignacio_medici
{
    partial class FrmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LbResultado = new Label();
            txtPrimerOperador = new TextBox();
            lblPrimerOperador = new Label();
            lblSegundoOperador = new Label();
            txtSegundoOperador = new TextBox();
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            grpSistema = new GroupBox();
            rdbBinario = new RadioButton();
            rdbDecimal = new RadioButton();
            cmbOperacion = new ComboBox();
            lblOperacion = new Label();
            lblResultadoOperacion = new Label();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // LbResultado
            // 
            LbResultado.AutoSize = true;
            LbResultado.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            LbResultado.Location = new Point(12, 33);
            LbResultado.Name = "LbResultado";
            LbResultado.Size = new Size(232, 54);
            LbResultado.TabIndex = 0;
            LbResultado.Text = "Resultado: ";
            // 
            // txtPrimerOperador
            // 
            txtPrimerOperador.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrimerOperador.Location = new Point(12, 305);
            txtPrimerOperador.Multiline = true;
            txtPrimerOperador.Name = "txtPrimerOperador";
            txtPrimerOperador.Size = new Size(232, 45);
            txtPrimerOperador.TabIndex = 1;
            txtPrimerOperador.TextChanged += TxtBPrimerOperador_TextChanged;
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrimerOperador.Location = new Point(12, 274);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.Size = new Size(182, 28);
            lblPrimerOperador.TabIndex = 2;
            lblPrimerOperador.Text = "Primer Operador: ";
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblSegundoOperador.Location = new Point(556, 274);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(198, 28);
            lblSegundoOperador.TabIndex = 4;
            lblSegundoOperador.Text = "Segundo operador: ";
            // 
            // txtSegundoOperador
            // 
            txtSegundoOperador.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtSegundoOperador.Location = new Point(556, 305);
            txtSegundoOperador.Multiline = true;
            txtSegundoOperador.Name = "txtSegundoOperador";
            txtSegundoOperador.Size = new Size(232, 45);
            txtSegundoOperador.TabIndex = 3;
            txtSegundoOperador.TextChanged += txtSegundoOperador_TextChanged;
            // 
            // btnOperar
            // 
            btnOperar.Location = new Point(12, 384);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(269, 54);
            btnOperar.TabIndex = 4;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(287, 384);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(243, 54);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(536, 384);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(252, 54);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Location = new Point(287, 129);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(200, 100);
            grpSistema.TabIndex = 1;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en: ";
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rdbBinario.Location = new Point(104, 48);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(69, 23);
            rdbBinario.TabIndex = 0;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.BackgroundImageLayout = ImageLayout.Zoom;
            rdbDecimal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rdbDecimal.Location = new Point(23, 48);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(75, 23);
            rdbDecimal.TabIndex = 1;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // cmbOperacion
            // 
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Items.AddRange(new object[] { "", "+", "-", "/", "*" });
            cmbOperacion.Location = new Point(333, 305);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(114, 45);
            cmbOperacion.TabIndex = 2;
            cmbOperacion.SelectedIndexChanged += cmbOperacion_SelectedIndexChanged;
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblOperacion.Location = new Point(333, 263);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(114, 28);
            lblOperacion.TabIndex = 11;
            lblOperacion.Text = "Operacion:";
            // 
            // lblResultadoOperacion
            // 
            lblResultadoOperacion.AutoSize = true;
            lblResultadoOperacion.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultadoOperacion.Location = new Point(225, 33);
            lblResultadoOperacion.Name = "lblResultadoOperacion";
            lblResultadoOperacion.Size = new Size(0, 54);
            lblResultadoOperacion.TabIndex = 13;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultadoOperacion);
            Controls.Add(lblOperacion);
            Controls.Add(cmbOperacion);
            Controls.Add(grpSistema);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            Controls.Add(lblSegundoOperador);
            Controls.Add(txtSegundoOperador);
            Controls.Add(lblPrimerOperador);
            Controls.Add(txtPrimerOperador);
            Controls.Add(LbResultado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Alumno: Ignacio Medici";
            FormClosing += FrmCalculadora_FormClosing;
            Load += FrmCalculadora_Load;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbResultado;
        private TextBox txtPrimerOperador;
        private Label lblPrimerOperador;
        private Label lblSegundoOperador;
        private TextBox txtSegundoOperador;
        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private GroupBox grpSistema;
        private ComboBox cmbOperacion;
        private Label lblOperacion;
        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;
        private Label lblResultadoOperacion;
    }
}