
namespace Presentacion
{
    partial class Usuarios_detalleFRM
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
            this.modbtn = new System.Windows.Forms.Button();
            this.altabtn = new System.Windows.Forms.Button();
            this.contxt = new System.Windows.Forms.TextBox();
            this.usuariotxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // modbtn
            // 
            this.modbtn.Location = new System.Drawing.Point(114, 105);
            this.modbtn.Name = "modbtn";
            this.modbtn.Size = new System.Drawing.Size(178, 23);
            this.modbtn.TabIndex = 0;
            this.modbtn.Text = "Modificacion de usuario";
            this.modbtn.UseVisualStyleBackColor = true;
            this.modbtn.Click += new System.EventHandler(this.modbtn_Click);
            // 
            // altabtn
            // 
            this.altabtn.Location = new System.Drawing.Point(146, 105);
            this.altabtn.Name = "altabtn";
            this.altabtn.Size = new System.Drawing.Size(106, 23);
            this.altabtn.TabIndex = 1;
            this.altabtn.Text = "Alta de usuario";
            this.altabtn.UseVisualStyleBackColor = true;
            this.altabtn.Click += new System.EventHandler(this.altabtn_Click);
            // 
            // contxt
            // 
            this.contxt.Location = new System.Drawing.Point(214, 79);
            this.contxt.Name = "contxt";
            this.contxt.Size = new System.Drawing.Size(100, 20);
            this.contxt.TabIndex = 2;
            // 
            // usuariotxt
            // 
            this.usuariotxt.Location = new System.Drawing.Point(69, 79);
            this.usuariotxt.Name = "usuariotxt";
            this.usuariotxt.Size = new System.Drawing.Size(100, 20);
            this.usuariotxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // Usuarios_detalleFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 206);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usuariotxt);
            this.Controls.Add(this.contxt);
            this.Controls.Add(this.altabtn);
            this.Controls.Add(this.modbtn);
            this.Name = "Usuarios_detalleFRM";
            this.Text = "Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modbtn;
        private System.Windows.Forms.Button altabtn;
        private System.Windows.Forms.TextBox contxt;
        private System.Windows.Forms.TextBox usuariotxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}