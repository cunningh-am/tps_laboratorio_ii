
namespace Formularios
{
    partial class FormVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_cliente = new System.Windows.Forms.ComboBox();
            this.cb_producto = new System.Windows.Forms.ComboBox();
            this.btn_vender = new System.Windows.Forms.Button();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.lbl_producto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_cliente
            // 
            this.cb_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cliente.FormattingEnabled = true;
            this.cb_cliente.Location = new System.Drawing.Point(12, 44);
            this.cb_cliente.Name = "cb_cliente";
            this.cb_cliente.Size = new System.Drawing.Size(847, 23);
            this.cb_cliente.TabIndex = 0;
            // 
            // cb_producto
            // 
            this.cb_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_producto.FormattingEnabled = true;
            this.cb_producto.Location = new System.Drawing.Point(12, 143);
            this.cb_producto.Name = "cb_producto";
            this.cb_producto.Size = new System.Drawing.Size(847, 23);
            this.cb_producto.TabIndex = 1;
            // 
            // btn_vender
            // 
            this.btn_vender.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_vender.Location = new System.Drawing.Point(239, 258);
            this.btn_vender.Name = "btn_vender";
            this.btn_vender.Size = new System.Drawing.Size(357, 81);
            this.btn_vender.TabIndex = 2;
            this.btn_vender.Text = "Vender";
            this.btn_vender.UseVisualStyleBackColor = true;
            this.btn_vender.Click += new System.EventHandler(this.btn_vender_Click);
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Location = new System.Drawing.Point(13, 13);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(47, 15);
            this.lbl_cliente.TabIndex = 3;
            this.lbl_cliente.Text = "Cliente:";
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.Location = new System.Drawing.Point(12, 113);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(59, 15);
            this.lbl_producto.TabIndex = 4;
            this.lbl_producto.Text = "Producto:";
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 385);
            this.Controls.Add(this.lbl_producto);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.btn_vender);
            this.Controls.Add(this.cb_producto);
            this.Controls.Add(this.cb_cliente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVenta";
            this.Text = "Vender";
            this.Load += new System.EventHandler(this.FormVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_cliente;
        private System.Windows.Forms.ComboBox cb_producto;
        private System.Windows.Forms.Button btn_vender;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Label lbl_producto;
    }
}