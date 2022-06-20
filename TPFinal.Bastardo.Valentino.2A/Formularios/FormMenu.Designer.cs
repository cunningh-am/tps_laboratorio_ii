
namespace Formularios
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.btn_AgregarProducto = new System.Windows.Forms.Button();
            this.btn_VerProducto = new System.Windows.Forms.Button();
            this.btn_AgregarCliente = new System.Windows.Forms.Button();
            this.btn_VerClientes = new System.Windows.Forms.Button();
            this.btn_toTxt = new System.Windows.Forms.Button();
            this.btn_toJson = new System.Windows.Forms.Button();
            this.btn_toXML = new System.Windows.Forms.Button();
            this.btn_fromJson = new System.Windows.Forms.Button();
            this.btn_fromXML = new System.Windows.Forms.Button();
            this.gb_Productos = new System.Windows.Forms.GroupBox();
            this.btn_sortPrecio = new System.Windows.Forms.Button();
            this.btn_sortNombre = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.gb_clientes = new System.Windows.Forms.GroupBox();
            this.gb_Ventas = new System.Windows.Forms.GroupBox();
            this.btn_Ganancias = new System.Windows.Forms.Button();
            this.btn_ConcretarVenta = new System.Windows.Forms.Button();
            this.gb_Productos.SuspendLayout();
            this.gb_clientes.SuspendLayout();
            this.gb_Ventas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AgregarProducto
            // 
            this.btn_AgregarProducto.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AgregarProducto.Location = new System.Drawing.Point(108, 40);
            this.btn_AgregarProducto.Name = "btn_AgregarProducto";
            this.btn_AgregarProducto.Size = new System.Drawing.Size(300, 73);
            this.btn_AgregarProducto.TabIndex = 0;
            this.btn_AgregarProducto.Text = "Agregar Producto";
            this.btn_AgregarProducto.UseVisualStyleBackColor = true;
            this.btn_AgregarProducto.Click += new System.EventHandler(this.btn_AgregarProducto_Click);
            // 
            // btn_VerProducto
            // 
            this.btn_VerProducto.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_VerProducto.Location = new System.Drawing.Point(108, 119);
            this.btn_VerProducto.Name = "btn_VerProducto";
            this.btn_VerProducto.Size = new System.Drawing.Size(300, 73);
            this.btn_VerProducto.TabIndex = 1;
            this.btn_VerProducto.Text = "Ver Productos";
            this.btn_VerProducto.UseVisualStyleBackColor = true;
            this.btn_VerProducto.Click += new System.EventHandler(this.btn_VerProducto_Click);
            // 
            // btn_AgregarCliente
            // 
            this.btn_AgregarCliente.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AgregarCliente.Location = new System.Drawing.Point(108, 33);
            this.btn_AgregarCliente.Name = "btn_AgregarCliente";
            this.btn_AgregarCliente.Size = new System.Drawing.Size(300, 73);
            this.btn_AgregarCliente.TabIndex = 2;
            this.btn_AgregarCliente.Text = "Agregar Cliente";
            this.btn_AgregarCliente.UseVisualStyleBackColor = true;
            this.btn_AgregarCliente.Click += new System.EventHandler(this.btn_AgregarCliente_Click);
            // 
            // btn_VerClientes
            // 
            this.btn_VerClientes.BackColor = System.Drawing.Color.Red;
            this.btn_VerClientes.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_VerClientes.Location = new System.Drawing.Point(108, 112);
            this.btn_VerClientes.Name = "btn_VerClientes";
            this.btn_VerClientes.Size = new System.Drawing.Size(300, 73);
            this.btn_VerClientes.TabIndex = 3;
            this.btn_VerClientes.Text = "Ver Clientes";
            this.btn_VerClientes.UseVisualStyleBackColor = false;
            this.btn_VerClientes.Click += new System.EventHandler(this.btn_VerClientes_Click);
            // 
            // btn_toTxt
            // 
            this.btn_toTxt.Location = new System.Drawing.Point(500, 81);
            this.btn_toTxt.Name = "btn_toTxt";
            this.btn_toTxt.Size = new System.Drawing.Size(73, 73);
            this.btn_toTxt.TabIndex = 4;
            this.btn_toTxt.Text = "Guardar en texto (.txt)";
            this.btn_toTxt.UseVisualStyleBackColor = true;
            this.btn_toTxt.Click += new System.EventHandler(this.btn_toTxt_Click);
            // 
            // btn_toJson
            // 
            this.btn_toJson.Location = new System.Drawing.Point(414, 71);
            this.btn_toJson.Name = "btn_toJson";
            this.btn_toJson.Size = new System.Drawing.Size(75, 73);
            this.btn_toJson.TabIndex = 5;
            this.btn_toJson.Text = "Guardar en Json";
            this.btn_toJson.UseVisualStyleBackColor = true;
            this.btn_toJson.Click += new System.EventHandler(this.btn_toJson_Click);
            // 
            // btn_toXML
            // 
            this.btn_toXML.Location = new System.Drawing.Point(414, 81);
            this.btn_toXML.Name = "btn_toXML";
            this.btn_toXML.Size = new System.Drawing.Size(75, 73);
            this.btn_toXML.TabIndex = 6;
            this.btn_toXML.Text = "Guardar en XML";
            this.btn_toXML.UseVisualStyleBackColor = true;
            this.btn_toXML.Click += new System.EventHandler(this.btn_toXML_Click);
            // 
            // btn_fromJson
            // 
            this.btn_fromJson.Location = new System.Drawing.Point(29, 71);
            this.btn_fromJson.Name = "btn_fromJson";
            this.btn_fromJson.Size = new System.Drawing.Size(73, 73);
            this.btn_fromJson.TabIndex = 7;
            this.btn_fromJson.Text = "Leer Json";
            this.btn_fromJson.UseVisualStyleBackColor = true;
            this.btn_fromJson.Click += new System.EventHandler(this.btn_fromJson_Click);
            // 
            // btn_fromXML
            // 
            this.btn_fromXML.Location = new System.Drawing.Point(29, 43);
            this.btn_fromXML.Name = "btn_fromXML";
            this.btn_fromXML.Size = new System.Drawing.Size(73, 73);
            this.btn_fromXML.TabIndex = 8;
            this.btn_fromXML.Text = "Leer XML";
            this.btn_fromXML.UseVisualStyleBackColor = true;
            this.btn_fromXML.Click += new System.EventHandler(this.btn_fromXML_Click);
            // 
            // gb_Productos
            // 
            this.gb_Productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gb_Productos.Controls.Add(this.btn_sortPrecio);
            this.gb_Productos.Controls.Add(this.btn_sortNombre);
            this.gb_Productos.Controls.Add(this.btn_eliminar);
            this.gb_Productos.Controls.Add(this.btn_fromXML);
            this.gb_Productos.Controls.Add(this.btn_AgregarProducto);
            this.gb_Productos.Controls.Add(this.btn_toXML);
            this.gb_Productos.Controls.Add(this.btn_toTxt);
            this.gb_Productos.Controls.Add(this.btn_VerProducto);
            this.gb_Productos.Location = new System.Drawing.Point(241, 174);
            this.gb_Productos.Name = "gb_Productos";
            this.gb_Productos.Size = new System.Drawing.Size(579, 221);
            this.gb_Productos.TabIndex = 9;
            this.gb_Productos.TabStop = false;
            this.gb_Productos.Text = "Productos";
            // 
            // btn_sortPrecio
            // 
            this.btn_sortPrecio.Location = new System.Drawing.Point(6, 170);
            this.btn_sortPrecio.Name = "btn_sortPrecio";
            this.btn_sortPrecio.Size = new System.Drawing.Size(96, 42);
            this.btn_sortPrecio.TabIndex = 11;
            this.btn_sortPrecio.Text = "Ordenar Por Precio";
            this.btn_sortPrecio.UseVisualStyleBackColor = true;
            this.btn_sortPrecio.Click += new System.EventHandler(this.btn_sortPrecio_Click);
            // 
            // btn_sortNombre
            // 
            this.btn_sortNombre.Location = new System.Drawing.Point(6, 122);
            this.btn_sortNombre.Name = "btn_sortNombre";
            this.btn_sortNombre.Size = new System.Drawing.Size(96, 42);
            this.btn_sortNombre.TabIndex = 10;
            this.btn_sortNombre.Text = "Ordenar Por Nombre";
            this.btn_sortNombre.UseVisualStyleBackColor = true;
            this.btn_sortNombre.Click += new System.EventHandler(this.btn_sortNombre_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_eliminar.Location = new System.Drawing.Point(414, 40);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(159, 35);
            this.btn_eliminar.TabIndex = 9;
            this.btn_eliminar.Text = "Eliminar Producto";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // gb_clientes
            // 
            this.gb_clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gb_clientes.Controls.Add(this.btn_VerClientes);
            this.gb_clientes.Controls.Add(this.btn_AgregarCliente);
            this.gb_clientes.Controls.Add(this.btn_toJson);
            this.gb_clientes.Controls.Add(this.btn_fromJson);
            this.gb_clientes.Location = new System.Drawing.Point(241, 408);
            this.gb_clientes.Name = "gb_clientes";
            this.gb_clientes.Size = new System.Drawing.Size(579, 208);
            this.gb_clientes.TabIndex = 10;
            this.gb_clientes.TabStop = false;
            this.gb_clientes.Text = "Clientes";
            // 
            // gb_Ventas
            // 
            this.gb_Ventas.Controls.Add(this.btn_Ganancias);
            this.gb_Ventas.Controls.Add(this.btn_ConcretarVenta);
            this.gb_Ventas.Location = new System.Drawing.Point(235, 642);
            this.gb_Ventas.Name = "gb_Ventas";
            this.gb_Ventas.Size = new System.Drawing.Size(579, 208);
            this.gb_Ventas.TabIndex = 11;
            this.gb_Ventas.TabStop = false;
            this.gb_Ventas.Text = "Ventas";
            // 
            // btn_Ganancias
            // 
            this.btn_Ganancias.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Ganancias.Location = new System.Drawing.Point(290, 43);
            this.btn_Ganancias.Name = "btn_Ganancias";
            this.btn_Ganancias.Size = new System.Drawing.Size(272, 103);
            this.btn_Ganancias.TabIndex = 1;
            this.btn_Ganancias.Text = "Ver Ganancias";
            this.btn_Ganancias.UseVisualStyleBackColor = true;
            this.btn_Ganancias.Click += new System.EventHandler(this.btn_Ganancias_Click_1);
            // 
            // btn_ConcretarVenta
            // 
            this.btn_ConcretarVenta.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ConcretarVenta.Location = new System.Drawing.Point(12, 43);
            this.btn_ConcretarVenta.Name = "btn_ConcretarVenta";
            this.btn_ConcretarVenta.Size = new System.Drawing.Size(272, 103);
            this.btn_ConcretarVenta.TabIndex = 0;
            this.btn_ConcretarVenta.Text = "Vender";
            this.btn_ConcretarVenta.UseVisualStyleBackColor = true;
            this.btn_ConcretarVenta.Click += new System.EventHandler(this.btn_ConcretarVenta_Click_1);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1052, 827);
            this.Controls.Add(this.gb_Ventas);
            this.Controls.Add(this.gb_clientes);
            this.Controls.Add(this.gb_Productos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenu_FormClosing);
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.gb_Productos.ResumeLayout(false);
            this.gb_clientes.ResumeLayout(false);
            this.gb_Ventas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AgregarProducto;
        private System.Windows.Forms.Button btn_VerProducto;
        private System.Windows.Forms.Button btn_AgregarCliente;
        private System.Windows.Forms.Button btn_VerClientes;
        private System.Windows.Forms.Button btn_toTxt;
        private System.Windows.Forms.Button btn_toJson;
        private System.Windows.Forms.Button btn_toXML;
        private System.Windows.Forms.Button btn_fromJson;
        private System.Windows.Forms.Button btn_fromXML;
        private System.Windows.Forms.GroupBox gb_Productos;
        private System.Windows.Forms.GroupBox gb_clientes;
        private System.Windows.Forms.GroupBox gb_Ventas;
        private System.Windows.Forms.Button btn_Ganancias;
        private System.Windows.Forms.Button btn_ConcretarVenta;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_sortPrecio;
        private System.Windows.Forms.Button btn_sortNombre;
    }
}

