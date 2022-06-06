
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
            this.gb_clientes = new System.Windows.Forms.GroupBox();
            this.gb_Productos.SuspendLayout();
            this.gb_clientes.SuspendLayout();
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
            this.btn_VerClientes.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_VerClientes.Location = new System.Drawing.Point(108, 112);
            this.btn_VerClientes.Name = "btn_VerClientes";
            this.btn_VerClientes.Size = new System.Drawing.Size(300, 73);
            this.btn_VerClientes.TabIndex = 3;
            this.btn_VerClientes.Text = "Ver Clientes";
            this.btn_VerClientes.UseVisualStyleBackColor = true;
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
            this.btn_fromXML.Location = new System.Drawing.Point(6, 81);
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
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1052, 634);
            this.Controls.Add(this.gb_clientes);
            this.Controls.Add(this.gb_Productos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.gb_Productos.ResumeLayout(false);
            this.gb_clientes.ResumeLayout(false);
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
    }
}

