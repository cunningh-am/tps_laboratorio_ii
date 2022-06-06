
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
            this.btn_AgregarProducto = new System.Windows.Forms.Button();
            this.btn_VerProducto = new System.Windows.Forms.Button();
            this.btn_AgregarCliente = new System.Windows.Forms.Button();
            this.btn_VerClientes = new System.Windows.Forms.Button();
            this.btn_toTxt = new System.Windows.Forms.Button();
            this.btn_toJson = new System.Windows.Forms.Button();
            this.btn_toXML = new System.Windows.Forms.Button();
            this.btn_fromJson = new System.Windows.Forms.Button();
            this.btn_fromXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AgregarProducto
            // 
            this.btn_AgregarProducto.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AgregarProducto.Location = new System.Drawing.Point(246, 12);
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
            this.btn_VerProducto.Location = new System.Drawing.Point(246, 91);
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
            this.btn_AgregarCliente.Location = new System.Drawing.Point(246, 170);
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
            this.btn_VerClientes.Location = new System.Drawing.Point(246, 249);
            this.btn_VerClientes.Name = "btn_VerClientes";
            this.btn_VerClientes.Size = new System.Drawing.Size(300, 73);
            this.btn_VerClientes.TabIndex = 3;
            this.btn_VerClientes.Text = "Ver Clientes";
            this.btn_VerClientes.UseVisualStyleBackColor = true;
            this.btn_VerClientes.Click += new System.EventHandler(this.btn_VerClientes_Click);
            // 
            // btn_toTxt
            // 
            this.btn_toTxt.Location = new System.Drawing.Point(552, 91);
            this.btn_toTxt.Name = "btn_toTxt";
            this.btn_toTxt.Size = new System.Drawing.Size(73, 73);
            this.btn_toTxt.TabIndex = 4;
            this.btn_toTxt.Text = "Guardar en texto (.txt)";
            this.btn_toTxt.UseVisualStyleBackColor = true;
            this.btn_toTxt.Click += new System.EventHandler(this.btn_toTxt_Click);
            // 
            // btn_toJson
            // 
            this.btn_toJson.Location = new System.Drawing.Point(550, 249);
            this.btn_toJson.Name = "btn_toJson";
            this.btn_toJson.Size = new System.Drawing.Size(75, 73);
            this.btn_toJson.TabIndex = 5;
            this.btn_toJson.Text = "Guardar en Json";
            this.btn_toJson.UseVisualStyleBackColor = true;
            this.btn_toJson.Click += new System.EventHandler(this.btn_toJson_Click);
            // 
            // btn_toXML
            // 
            this.btn_toXML.Location = new System.Drawing.Point(631, 91);
            this.btn_toXML.Name = "btn_toXML";
            this.btn_toXML.Size = new System.Drawing.Size(75, 73);
            this.btn_toXML.TabIndex = 6;
            this.btn_toXML.Text = "Guardar en XML";
            this.btn_toXML.UseVisualStyleBackColor = true;
            this.btn_toXML.Click += new System.EventHandler(this.btn_toXML_Click);
            // 
            // btn_fromJson
            // 
            this.btn_fromJson.Location = new System.Drawing.Point(167, 249);
            this.btn_fromJson.Name = "btn_fromJson";
            this.btn_fromJson.Size = new System.Drawing.Size(73, 73);
            this.btn_fromJson.TabIndex = 7;
            this.btn_fromJson.Text = "Leer Json";
            this.btn_fromJson.UseVisualStyleBackColor = true;
            this.btn_fromJson.Click += new System.EventHandler(this.btn_fromJson_Click);
            // 
            // btn_fromXML
            // 
            this.btn_fromXML.Location = new System.Drawing.Point(167, 91);
            this.btn_fromXML.Name = "btn_fromXML";
            this.btn_fromXML.Size = new System.Drawing.Size(73, 73);
            this.btn_fromXML.TabIndex = 8;
            this.btn_fromXML.Text = "Leer XML";
            this.btn_fromXML.UseVisualStyleBackColor = true;
            this.btn_fromXML.Click += new System.EventHandler(this.btn_fromXML_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_fromXML);
            this.Controls.Add(this.btn_fromJson);
            this.Controls.Add(this.btn_toXML);
            this.Controls.Add(this.btn_toJson);
            this.Controls.Add(this.btn_toTxt);
            this.Controls.Add(this.btn_VerClientes);
            this.Controls.Add(this.btn_AgregarCliente);
            this.Controls.Add(this.btn_VerProducto);
            this.Controls.Add(this.btn_AgregarProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
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
    }
}

