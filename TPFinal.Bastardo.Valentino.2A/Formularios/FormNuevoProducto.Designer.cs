
namespace Formularios
{
    partial class FormNuevoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevoProducto));
            this.txt_nombreProd = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_unidadesVendidas = new System.Windows.Forms.TextBox();
            this.rb_videojuego = new System.Windows.Forms.RadioButton();
            this.rb_consola = new System.Windows.Forms.RadioButton();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.cb_genero = new System.Windows.Forms.ComboBox();
            this.cb_color = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_cash = new System.Windows.Forms.Label();
            this.lbl_unidades = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombreProd
            // 
            this.txt_nombreProd.BackColor = System.Drawing.SystemColors.Window;
            this.txt_nombreProd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nombreProd.Location = new System.Drawing.Point(215, 43);
            this.txt_nombreProd.MaxLength = 50;
            this.txt_nombreProd.Name = "txt_nombreProd";
            this.txt_nombreProd.Size = new System.Drawing.Size(252, 32);
            this.txt_nombreProd.TabIndex = 0;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(215, 108);
            this.txt_precio.MaxLength = 9;
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(100, 23);
            this.txt_precio.TabIndex = 1;
            this.txt_precio.TextChanged += new System.EventHandler(this.txt_precio_TextChanged);
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            // 
            // txt_unidadesVendidas
            // 
            this.txt_unidadesVendidas.Location = new System.Drawing.Point(367, 108);
            this.txt_unidadesVendidas.MaxLength = 9;
            this.txt_unidadesVendidas.Name = "txt_unidadesVendidas";
            this.txt_unidadesVendidas.Size = new System.Drawing.Size(100, 23);
            this.txt_unidadesVendidas.TabIndex = 2;
            this.txt_unidadesVendidas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_unidadesVendidas_KeyPress);
            // 
            // rb_videojuego
            // 
            this.rb_videojuego.AutoSize = true;
            this.rb_videojuego.Location = new System.Drawing.Point(12, 427);
            this.rb_videojuego.Name = "rb_videojuego";
            this.rb_videojuego.Size = new System.Drawing.Size(85, 19);
            this.rb_videojuego.TabIndex = 3;
            this.rb_videojuego.TabStop = true;
            this.rb_videojuego.Text = "Videojuego";
            this.rb_videojuego.UseVisualStyleBackColor = true;
            this.rb_videojuego.CheckedChanged += new System.EventHandler(this.rb_videojuego_CheckedChanged);
            // 
            // rb_consola
            // 
            this.rb_consola.AutoSize = true;
            this.rb_consola.Location = new System.Drawing.Point(411, 430);
            this.rb_consola.Name = "rb_consola";
            this.rb_consola.Size = new System.Drawing.Size(68, 19);
            this.rb_consola.TabIndex = 4;
            this.rb_consola.TabStop = true;
            this.rb_consola.Text = "Consola";
            this.rb_consola.UseVisualStyleBackColor = true;
            this.rb_consola.CheckedChanged += new System.EventHandler(this.rb_consola_CheckedChanged);
            // 
            // cb_tipo
            // 
            this.cb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Location = new System.Drawing.Point(287, 177);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(104, 23);
            this.cb_tipo.TabIndex = 5;
            // 
            // cb_genero
            // 
            this.cb_genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_genero.FormattingEnabled = true;
            this.cb_genero.Location = new System.Drawing.Point(137, 426);
            this.cb_genero.Name = "cb_genero";
            this.cb_genero.Size = new System.Drawing.Size(130, 23);
            this.cb_genero.TabIndex = 6;
            this.cb_genero.SelectedIndexChanged += new System.EventHandler(this.cb_genero_SelectedIndexChanged);
            // 
            // cb_color
            // 
            this.cb_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_color.FormattingEnabled = true;
            this.cb_color.Location = new System.Drawing.Point(530, 426);
            this.cb_color.Name = "cb_color";
            this.cb_color.Size = new System.Drawing.Size(130, 23);
            this.cb_color.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(411, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 219);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 177);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(255, 219);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Location = new System.Drawing.Point(215, 25);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(122, 15);
            this.lbl_titulo.TabIndex = 10;
            this.lbl_titulo.Text = "Nombre del producto";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Location = new System.Drawing.Point(215, 90);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(40, 15);
            this.lbl_precio.TabIndex = 11;
            this.lbl_precio.Text = "Precio";
            // 
            // lbl_cash
            // 
            this.lbl_cash.AutoSize = true;
            this.lbl_cash.Location = new System.Drawing.Point(201, 112);
            this.lbl_cash.Name = "lbl_cash";
            this.lbl_cash.Size = new System.Drawing.Size(13, 15);
            this.lbl_cash.TabIndex = 12;
            this.lbl_cash.Text = "$";
            // 
            // lbl_unidades
            // 
            this.lbl_unidades.AutoSize = true;
            this.lbl_unidades.Location = new System.Drawing.Point(367, 90);
            this.lbl_unidades.Name = "lbl_unidades";
            this.lbl_unidades.Size = new System.Drawing.Size(106, 15);
            this.lbl_unidades.TabIndex = 13;
            this.lbl_unidades.Text = "Unidades vendidas";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_aceptar.Location = new System.Drawing.Point(245, 517);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(176, 52);
            this.btn_aceptar.TabIndex = 14;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // FormNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(672, 630);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lbl_unidades);
            this.Controls.Add(this.lbl_cash);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cb_color);
            this.Controls.Add(this.cb_genero);
            this.Controls.Add(this.cb_tipo);
            this.Controls.Add(this.rb_consola);
            this.Controls.Add(this.rb_videojuego);
            this.Controls.Add(this.txt_unidadesVendidas);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_nombreProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNuevoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar Producto";
            this.Load += new System.EventHandler(this.FormNuevoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombreProd;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_unidadesVendidas;
        private System.Windows.Forms.RadioButton rb_videojuego;
        private System.Windows.Forms.RadioButton rb_consola;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.ComboBox cb_genero;
        private System.Windows.Forms.ComboBox cb_color;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label lbl_cash;
        private System.Windows.Forms.Label lbl_unidades;
        private System.Windows.Forms.Button btn_aceptar;
    }
}