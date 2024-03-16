namespace final_programación_2_08_05_2023
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExpClient = new System.Windows.Forms.Button();
            this.btnExpPedidos = new System.Windows.Forms.Button();
            this.btnImportProduct = new System.Windows.Forms.Button();
            this.btnVerSaldo = new System.Windows.Forms.Button();
            this.btnAddSelect = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnSelectProd = new System.Windows.Forms.Button();
            this.btnAddPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCUIT = new System.Windows.Forms.TextBox();
            this.tbKilos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbElegidos = new System.Windows.Forms.ListBox();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCUIT);
            this.groupBox1.Controls.Add(this.btnPagar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddSelect);
            this.groupBox1.Controls.Add(this.btnVerSaldo);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 524);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar/Agregar Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbProducto);
            this.groupBox2.Controls.Add(this.lbElegidos);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbKilos);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnSelectProd);
            this.groupBox2.Controls.Add(this.btnAddPedido);
            this.groupBox2.Location = new System.Drawing.Point(6, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 241);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Pedido";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnImportProduct);
            this.groupBox3.Controls.Add(this.btnExpPedidos);
            this.groupBox3.Controls.Add(this.btnExpClient);
            this.groupBox3.Location = new System.Drawing.Point(681, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(418, 524);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sistema";
            // 
            // btnExpClient
            // 
            this.btnExpClient.Location = new System.Drawing.Point(6, 38);
            this.btnExpClient.Name = "btnExpClient";
            this.btnExpClient.Size = new System.Drawing.Size(406, 72);
            this.btnExpClient.TabIndex = 9;
            this.btnExpClient.Text = "Exportar Cliente";
            this.btnExpClient.UseVisualStyleBackColor = true;
            // 
            // btnExpPedidos
            // 
            this.btnExpPedidos.Location = new System.Drawing.Point(6, 116);
            this.btnExpPedidos.Name = "btnExpPedidos";
            this.btnExpPedidos.Size = new System.Drawing.Size(406, 72);
            this.btnExpPedidos.TabIndex = 10;
            this.btnExpPedidos.Text = "Exportar Pedidos";
            this.btnExpPedidos.UseVisualStyleBackColor = true;
            // 
            // btnImportProduct
            // 
            this.btnImportProduct.Location = new System.Drawing.Point(6, 238);
            this.btnImportProduct.Name = "btnImportProduct";
            this.btnImportProduct.Size = new System.Drawing.Size(406, 72);
            this.btnImportProduct.TabIndex = 11;
            this.btnImportProduct.Text = "Importar Productos";
            this.btnImportProduct.UseVisualStyleBackColor = true;
            // 
            // btnVerSaldo
            // 
            this.btnVerSaldo.Location = new System.Drawing.Point(217, 218);
            this.btnVerSaldo.Name = "btnVerSaldo";
            this.btnVerSaldo.Size = new System.Drawing.Size(204, 53);
            this.btnVerSaldo.TabIndex = 3;
            this.btnVerSaldo.Text = "Ver Saldo";
            this.btnVerSaldo.UseVisualStyleBackColor = true;
            // 
            // btnAddSelect
            // 
            this.btnAddSelect.Location = new System.Drawing.Point(7, 218);
            this.btnAddSelect.Name = "btnAddSelect";
            this.btnAddSelect.Size = new System.Drawing.Size(204, 53);
            this.btnAddSelect.TabIndex = 2;
            this.btnAddSelect.Text = "Agregar / Seleccionar";
            this.btnAddSelect.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(427, 218);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(204, 53);
            this.btnPagar.TabIndex = 4;
            this.btnPagar.Text = "Realizar Pago";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // btnSelectProd
            // 
            this.btnSelectProd.Location = new System.Drawing.Point(176, 119);
            this.btnSelectProd.Name = "btnSelectProd";
            this.btnSelectProd.Size = new System.Drawing.Size(102, 55);
            this.btnSelectProd.TabIndex = 7;
            this.btnSelectProd.Text = "Elegir Producto";
            this.btnSelectProd.UseVisualStyleBackColor = true;
            // 
            // btnAddPedido
            // 
            this.btnAddPedido.Location = new System.Drawing.Point(176, 180);
            this.btnAddPedido.Name = "btnAddPedido";
            this.btnAddPedido.Size = new System.Drawing.Size(215, 55);
            this.btnAddPedido.TabIndex = 8;
            this.btnAddPedido.Text = "Agregar Pedido";
            this.btnAddPedido.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "CUIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kg";
            // 
            // tbCUIT
            // 
            this.tbCUIT.Location = new System.Drawing.Point(114, 114);
            this.tbCUIT.Name = "tbCUIT";
            this.tbCUIT.Size = new System.Drawing.Size(100, 22);
            this.tbCUIT.TabIndex = 1;
            // 
            // tbKilos
            // 
            this.tbKilos.Location = new System.Drawing.Point(256, 70);
            this.tbKilos.Name = "tbKilos";
            this.tbKilos.Size = new System.Drawing.Size(100, 22);
            this.tbKilos.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Productos elegidos";
            // 
            // lbElegidos
            // 
            this.lbElegidos.FormattingEnabled = true;
            this.lbElegidos.ItemHeight = 16;
            this.lbElegidos.Location = new System.Drawing.Point(393, 37);
            this.lbElegidos.Name = "lbElegidos";
            this.lbElegidos.Size = new System.Drawing.Size(232, 196);
            this.lbElegidos.TabIndex = 11;
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(42, 21);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(314, 24);
            this.cbProducto.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 548);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnAddSelect;
        private System.Windows.Forms.Button btnVerSaldo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSelectProd;
        private System.Windows.Forms.Button btnAddPedido;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnImportProduct;
        private System.Windows.Forms.Button btnExpPedidos;
        private System.Windows.Forms.Button btnExpClient;
        private System.Windows.Forms.TextBox tbCUIT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.ListBox lbElegidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKilos;
        private System.Windows.Forms.Label label2;
    }
}

