﻿namespace Presentacion
{
    partial class fMenu
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
          this.components = new System.ComponentModel.Container();
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMenu));
          this.visualStyler1 = new SkinSoft.VisualStyler.VisualStyler(this.components);
          this.btnDistrito = new System.Windows.Forms.Button();
          this.btnAmigo = new System.Windows.Forms.Button();
          this.label1 = new System.Windows.Forms.Label();
          ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).BeginInit();
          this.SuspendLayout();
          // 
          // visualStyler1
          // 
          this.visualStyler1.License = ((SkinSoft.VisualStyler.Licensing.VisualStylerLicense)(resources.GetObject("visualStyler1.License")));
          this.visualStyler1.ShowFocusCues = false;
          this.visualStyler1.LoadVisualStyle(null, "Sustenance (Blue).vssf");
          // 
          // btnDistrito
          // 
          this.btnDistrito.Location = new System.Drawing.Point(54, 25);
          this.btnDistrito.Name = "btnDistrito";
          this.btnDistrito.Size = new System.Drawing.Size(75, 23);
          this.btnDistrito.TabIndex = 1;
          this.btnDistrito.Text = "DISTRITOS";
          this.btnDistrito.UseVisualStyleBackColor = true;
          this.btnDistrito.Click += new System.EventHandler(this.btnDistrito_Click);
          // 
          // btnAmigo
          // 
          this.btnAmigo.Location = new System.Drawing.Point(154, 25);
          this.btnAmigo.Name = "btnAmigo";
          this.btnAmigo.Size = new System.Drawing.Size(75, 23);
          this.btnAmigo.TabIndex = 2;
          this.btnAmigo.Text = "AMIGOS";
          this.btnAmigo.UseVisualStyleBackColor = true;
          this.btnAmigo.Click += new System.EventHandler(this.btnAmigo_Click);
          // 
          // label1
          // 
          this.label1.AutoSize = true;
          this.label1.Location = new System.Drawing.Point(64, 65);
          this.label1.Name = "label1";
          this.label1.Size = new System.Drawing.Size(154, 13);
          this.label1.TabIndex = 0;
          this.label1.Text = "..:: Powered by: J4ckware™ ::..";
          // 
          // fMenu
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(283, 86);
          this.Controls.Add(this.label1);
          this.Controls.Add(this.btnAmigo);
          this.Controls.Add(this.btnDistrito);
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
          this.MaximizeBox = false;
          this.Name = "fMenu";
          this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
          this.Text = "Programacion en N capas";
          ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).EndInit();
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

        private SkinSoft.VisualStyler.VisualStyler visualStyler1;
        private System.Windows.Forms.Button btnDistrito;
        private System.Windows.Forms.Button btnAmigo;
        private System.Windows.Forms.Label label1;
    }
}

