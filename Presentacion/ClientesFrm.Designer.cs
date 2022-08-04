
namespace Presentacion
{
    partial class ClientesFrm
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
            this.grillaclientes = new System.Windows.Forms.DataGridView();
            this.Modificacionbtn = new System.Windows.Forms.Button();
            this.Altabtn = new System.Windows.Forms.Button();
            this.userControlBaja1 = new Presentacion.UserControlBaja();
            ((System.ComponentModel.ISupportInitialize)(this.grillaclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaclientes
            // 
            this.grillaclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaclientes.Location = new System.Drawing.Point(29, 51);
            this.grillaclientes.MultiSelect = false;
            this.grillaclientes.Name = "grillaclientes";
            this.grillaclientes.ReadOnly = true;
            this.grillaclientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaclientes.Size = new System.Drawing.Size(510, 173);
            this.grillaclientes.TabIndex = 0;
            this.grillaclientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaclientes_CellClick);
            this.grillaclientes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaclientes_RowEnter);
            // 
            // Modificacionbtn
            // 
            this.Modificacionbtn.Location = new System.Drawing.Point(579, 133);
            this.Modificacionbtn.Name = "Modificacionbtn";
            this.Modificacionbtn.Size = new System.Drawing.Size(115, 23);
            this.Modificacionbtn.TabIndex = 4;
            this.Modificacionbtn.Text = "Modificar cliente";
            this.Modificacionbtn.UseVisualStyleBackColor = true;
            this.Modificacionbtn.Click += new System.EventHandler(this.Modificacionbtn_Click);
            // 
            // Altabtn
            // 
            this.Altabtn.Location = new System.Drawing.Point(579, 80);
            this.Altabtn.Name = "Altabtn";
            this.Altabtn.Size = new System.Drawing.Size(113, 23);
            this.Altabtn.TabIndex = 5;
            this.Altabtn.Text = "Alta de cliente";
            this.Altabtn.UseVisualStyleBackColor = true;
            this.Altabtn.Click += new System.EventHandler(this.Altabtn_Click_1);
            // 
            // userControlBaja1
            // 
            this.userControlBaja1.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.userControlBaja1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.userControlBaja1.Location = new System.Drawing.Point(579, 180);
            this.userControlBaja1.Name = "userControlBaja1";
            this.userControlBaja1.Size = new System.Drawing.Size(115, 28);
            this.userControlBaja1.TabIndex = 6;
            this.userControlBaja1.Click += new System.EventHandler(this.userControlBaja1_Click);
            // 
            // ClientesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControlBaja1);
            this.Controls.Add(this.Altabtn);
            this.Controls.Add(this.Modificacionbtn);
            this.Controls.Add(this.grillaclientes);
            this.Name = "ClientesFrm";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.Enter += new System.EventHandler(this.ClientesFrm_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.grillaclientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaclientes;
        private System.Windows.Forms.Button Modificacionbtn;
        private System.Windows.Forms.Button Altabtn;
        private UserControlBaja userControlBaja1;
    }
}