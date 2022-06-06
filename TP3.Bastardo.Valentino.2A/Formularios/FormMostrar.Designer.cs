
namespace Formularios
{
    partial class FormMostrar<T>
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
            this.lb_1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lb_1
            // 
            this.lb_1.FormattingEnabled = true;
            this.lb_1.ItemHeight = 15;
            this.lb_1.Location = new System.Drawing.Point(12, 12);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(776, 409);
            this.lb_1.TabIndex = 0;
            this.lb_1.SelectedIndexChanged += new System.EventHandler(this.lb_1_SelectedIndexChanged);
            // 
            // FormMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMostrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar";
            this.Load += new System.EventHandler(this.FormMostrar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_1;
    }
}