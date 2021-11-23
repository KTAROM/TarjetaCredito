
namespace TarjetaCredito.Formularios
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTipoTarjeta = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.lblNroPlastico = new System.Windows.Forms.Label();
            this.cmbPeriodoCierre = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbTipoTarjeta = new System.Windows.Forms.ComboBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNroPlastico = new System.Windows.Forms.TextBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.lblReporte = new System.Windows.Forms.Label();
            this.lstTarjetas = new System.Windows.Forms.ListBox();
            this.lblEmitidos = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.txtEmitidos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(76, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(142, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Formulario Tarjeta de Crédito";
            // 
            // lblTipoTarjeta
            // 
            this.lblTipoTarjeta.AutoSize = true;
            this.lblTipoTarjeta.Location = new System.Drawing.Point(24, 67);
            this.lblTipoTarjeta.Name = "lblTipoTarjeta";
            this.lblTipoTarjeta.Size = new System.Drawing.Size(64, 13);
            this.lblTipoTarjeta.TabIndex = 1;
            this.lblTipoTarjeta.Text = "Tipo Tarjeta";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(24, 107);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(90, 13);
            this.lblPeriodo.TabIndex = 2;
            this.lblPeriodo.Text = "Período de Cierre";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(28, 141);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente";
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(24, 175);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(90, 13);
            this.lblLimite.TabIndex = 4;
            this.lblLimite.Text = "Límite de Compra";
            // 
            // lblNroPlastico
            // 
            this.lblNroPlastico.AutoSize = true;
            this.lblNroPlastico.Location = new System.Drawing.Point(32, 288);
            this.lblNroPlastico.Name = "lblNroPlastico";
            this.lblNroPlastico.Size = new System.Drawing.Size(99, 13);
            this.lblNroPlastico.TabIndex = 5;
            this.lblNroPlastico.Text = "Número de Plástico";
            // 
            // cmbPeriodoCierre
            // 
            this.cmbPeriodoCierre.FormattingEnabled = true;
            this.cmbPeriodoCierre.Location = new System.Drawing.Point(144, 104);
            this.cmbPeriodoCierre.Name = "cmbPeriodoCierre";
            this.cmbPeriodoCierre.Size = new System.Drawing.Size(121, 21);
            this.cmbPeriodoCierre.TabIndex = 6;
            this.cmbPeriodoCierre.Click += new System.EventHandler(this.cmbPerCierre_Click);
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(144, 141);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(121, 21);
            this.cmbCliente.TabIndex = 7;
            this.cmbCliente.Click += new System.EventHandler(this.cmbCliente_Click);
            // 
            // cmbTipoTarjeta
            // 
            this.cmbTipoTarjeta.FormattingEnabled = true;
            this.cmbTipoTarjeta.Location = new System.Drawing.Point(144, 59);
            this.cmbTipoTarjeta.Name = "cmbTipoTarjeta";
            this.cmbTipoTarjeta.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoTarjeta.TabIndex = 8;
            this.cmbTipoTarjeta.SelectedIndexChanged += new System.EventHandler(this.cmbtipoTarjeta_Select);
            this.cmbTipoTarjeta.Click += new System.EventHandler(this.cmbtipoTarjeta_Click);
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(144, 175);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(121, 20);
            this.txtLimite.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(35, 237);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(230, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNroPlastico
            // 
            this.txtNroPlastico.Location = new System.Drawing.Point(153, 281);
            this.txtNroPlastico.Name = "txtNroPlastico";
            this.txtNroPlastico.Size = new System.Drawing.Size(135, 20);
            this.txtNroPlastico.TabIndex = 11;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(31, 323);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(234, 23);
            this.btnAlta.TabIndex = 12;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // lblReporte
            // 
            this.lblReporte.AutoSize = true;
            this.lblReporte.Location = new System.Drawing.Point(511, 19);
            this.lblReporte.Name = "lblReporte";
            this.lblReporte.Size = new System.Drawing.Size(86, 13);
            this.lblReporte.TabIndex = 13;
            this.lblReporte.Text = "Reporte Tarjetas";
            // 
            // lstTarjetas
            // 
            this.lstTarjetas.FormattingEnabled = true;
            this.lstTarjetas.Location = new System.Drawing.Point(395, 61);
            this.lstTarjetas.Name = "lstTarjetas";
            this.lstTarjetas.Size = new System.Drawing.Size(342, 134);
            this.lstTarjetas.TabIndex = 14;
            // 
            // lblEmitidos
            // 
            this.lblEmitidos.AutoSize = true;
            this.lblEmitidos.Location = new System.Drawing.Point(392, 247);
            this.lblEmitidos.Name = "lblEmitidos";
            this.lblEmitidos.Size = new System.Drawing.Size(135, 13);
            this.lblEmitidos.TabIndex = 15;
            this.lblEmitidos.Text = "Cantidad Plásticos emitidos";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(392, 284);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(82, 13);
            this.lblPromedio.TabIndex = 16;
            this.lblPromedio.Text = "Límite promedio";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Enabled = false;
            this.txtPromedio.Location = new System.Drawing.Point(551, 281);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(100, 20);
            this.txtPromedio.TabIndex = 17;
            // 
            // txtEmitidos
            // 
            this.txtEmitidos.Enabled = false;
            this.txtEmitidos.Location = new System.Drawing.Point(551, 237);
            this.txtEmitidos.Name = "txtEmitidos";
            this.txtEmitidos.Size = new System.Drawing.Size(100, 20);
            this.txtEmitidos.TabIndex = 18;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEmitidos);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblEmitidos);
            this.Controls.Add(this.lstTarjetas);
            this.Controls.Add(this.lblReporte);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.txtNroPlastico);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtLimite);
            this.Controls.Add(this.cmbTipoTarjeta);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.cmbPeriodoCierre);
            this.Controls.Add(this.lblNroPlastico);
            this.Controls.Add(this.lblLimite);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lblTipoTarjeta);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmPrincipal";
            this.Text = "Cantidad Plásticos emitidos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTipoTarjeta;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label lblNroPlastico;
        private System.Windows.Forms.ComboBox cmbPeriodoCierre;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbTipoTarjeta;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNroPlastico;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Label lblReporte;
        private System.Windows.Forms.ListBox lstTarjetas;
        private System.Windows.Forms.Label lblEmitidos;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.TextBox txtEmitidos;
    }
}

