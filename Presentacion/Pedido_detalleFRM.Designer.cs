
namespace Presentacion
{
    partial class Pedido_detalleFRM
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
            this.grabarpedidobtn = new System.Windows.Forms.Button();
            this.grilla_lote = new System.Windows.Forms.DataGridView();
            this.combolotes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unitxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grilla_pedido = new System.Windows.Forms.DataGridView();
            this.agregarbtn = new System.Windows.Forms.Button();
            this.modbtn = new System.Windows.Forms.Button();
            this.borrartxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_lote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_pedido)).BeginInit();
            this.SuspendLayout();
            // 
            // grabarpedidobtn
            // 
            this.grabarpedidobtn.Location = new System.Drawing.Point(1074, 289);
            this.grabarpedidobtn.Name = "grabarpedidobtn";
            this.grabarpedidobtn.Size = new System.Drawing.Size(199, 61);
            this.grabarpedidobtn.TabIndex = 0;
            this.grabarpedidobtn.Text = "guardar pedido";
            this.grabarpedidobtn.UseVisualStyleBackColor = true;
            this.grabarpedidobtn.Click += new System.EventHandler(this.grabarpedidobtn_Click);
            // 
            // grilla_lote
            // 
            this.grilla_lote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_lote.Location = new System.Drawing.Point(272, 80);
            this.grilla_lote.MultiSelect = false;
            this.grilla_lote.Name = "grilla_lote";
            this.grilla_lote.ReadOnly = true;
            this.grilla_lote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_lote.Size = new System.Drawing.Size(573, 223);
            this.grilla_lote.TabIndex = 1;
            // 
            // combolotes
            // 
            this.combolotes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combolotes.FormattingEnabled = true;
            this.combolotes.Location = new System.Drawing.Point(65, 72);
            this.combolotes.Name = "combolotes";
            this.combolotes.Size = new System.Drawing.Size(121, 21);
            this.combolotes.TabIndex = 6;
            this.combolotes.SelectionChangeCommitted += new System.EventHandler(this.combolotes_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lote Nro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Productos del lote";
            // 
            // unitxt
            // 
            this.unitxt.Location = new System.Drawing.Point(1074, 126);
            this.unitxt.Name = "unitxt";
            this.unitxt.Size = new System.Drawing.Size(108, 20);
            this.unitxt.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1101, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Unidades";
            // 
            // grilla_pedido
            // 
            this.grilla_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_pedido.Location = new System.Drawing.Point(272, 367);
            this.grilla_pedido.MultiSelect = false;
            this.grilla_pedido.Name = "grilla_pedido";
            this.grilla_pedido.ReadOnly = true;
            this.grilla_pedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_pedido.Size = new System.Drawing.Size(573, 223);
            this.grilla_pedido.TabIndex = 14;
            // 
            // agregarbtn
            // 
            this.agregarbtn.Location = new System.Drawing.Point(884, 105);
            this.agregarbtn.Name = "agregarbtn";
            this.agregarbtn.Size = new System.Drawing.Size(158, 41);
            this.agregarbtn.TabIndex = 15;
            this.agregarbtn.Text = "Agregar producto";
            this.agregarbtn.UseVisualStyleBackColor = true;
            this.agregarbtn.Click += new System.EventHandler(this.agregarbtn_Click);
            // 
            // modbtn
            // 
            this.modbtn.Location = new System.Drawing.Point(884, 503);
            this.modbtn.Name = "modbtn";
            this.modbtn.Size = new System.Drawing.Size(199, 54);
            this.modbtn.TabIndex = 16;
            this.modbtn.Text = "Eliminar unidades";
            this.modbtn.UseVisualStyleBackColor = true;
            this.modbtn.Click += new System.EventHandler(this.modbtn_Click);
            // 
            // borrartxt
            // 
            this.borrartxt.Location = new System.Drawing.Point(1123, 521);
            this.borrartxt.Name = "borrartxt";
            this.borrartxt.Size = new System.Drawing.Size(108, 20);
            this.borrartxt.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Pedido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1146, 503);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Unidades";
            // 
            // Pedido_detalleFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 655);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.borrartxt);
            this.Controls.Add(this.modbtn);
            this.Controls.Add(this.agregarbtn);
            this.Controls.Add(this.grilla_pedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.unitxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combolotes);
            this.Controls.Add(this.grilla_lote);
            this.Controls.Add(this.grabarpedidobtn);
            this.Name = "Pedido_detalleFRM";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedido_detalleFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_lote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_pedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button grabarpedidobtn;
        private System.Windows.Forms.DataGridView grilla_lote;
        private System.Windows.Forms.ComboBox combolotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox unitxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grilla_pedido;
        private System.Windows.Forms.Button agregarbtn;
        private System.Windows.Forms.Button modbtn;
        private System.Windows.Forms.TextBox borrartxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}