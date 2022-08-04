
namespace Presentacion
{
    partial class UsuariosFRM
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
            this.Modificacionbtn = new System.Windows.Forms.Button();
            this.Bajabtn = new System.Windows.Forms.Button();
            this.Altabtn = new System.Windows.Forms.Button();
            this.grilla_usuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // Modificacionbtn
            // 
            this.Modificacionbtn.Location = new System.Drawing.Point(390, 131);
            this.Modificacionbtn.Name = "Modificacionbtn";
            this.Modificacionbtn.Size = new System.Drawing.Size(115, 23);
            this.Modificacionbtn.TabIndex = 8;
            this.Modificacionbtn.Text = "Modificar usuario";
            this.Modificacionbtn.UseVisualStyleBackColor = true;
            this.Modificacionbtn.Click += new System.EventHandler(this.Modificacionbtn_Click);
            // 
            // Bajabtn
            // 
            this.Bajabtn.Location = new System.Drawing.Point(390, 181);
            this.Bajabtn.Name = "Bajabtn";
            this.Bajabtn.Size = new System.Drawing.Size(115, 23);
            this.Bajabtn.TabIndex = 7;
            this.Bajabtn.Text = "Eliminar usuario";
            this.Bajabtn.UseVisualStyleBackColor = true;
            this.Bajabtn.Click += new System.EventHandler(this.Bajabtn_Click);
            // 
            // Altabtn
            // 
            this.Altabtn.Location = new System.Drawing.Point(390, 86);
            this.Altabtn.Name = "Altabtn";
            this.Altabtn.Size = new System.Drawing.Size(115, 23);
            this.Altabtn.TabIndex = 6;
            this.Altabtn.Text = "Nuevo usuario";
            this.Altabtn.UseVisualStyleBackColor = true;
            this.Altabtn.Click += new System.EventHandler(this.Altabtn_Click);
            // 
            // grilla_usuarios
            // 
            this.grilla_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_usuarios.Location = new System.Drawing.Point(65, 72);
            this.grilla_usuarios.MultiSelect = false;
            this.grilla_usuarios.Name = "grilla_usuarios";
            this.grilla_usuarios.ReadOnly = true;
            this.grilla_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_usuarios.Size = new System.Drawing.Size(297, 173);
            this.grilla_usuarios.TabIndex = 5;
            // 
            // UsuariosFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 291);
            this.Controls.Add(this.Modificacionbtn);
            this.Controls.Add(this.Bajabtn);
            this.Controls.Add(this.Altabtn);
            this.Controls.Add(this.grilla_usuarios);
            this.Name = "UsuariosFRM";
            this.Text = "Usuarios del sistema";
            this.Load += new System.EventHandler(this.UsuariosFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Modificacionbtn;
        private System.Windows.Forms.Button Bajabtn;
        private System.Windows.Forms.Button Altabtn;
        private System.Windows.Forms.DataGridView grilla_usuarios;
    }
}