
namespace Presentacion
{
    partial class Lote_detalleFRM
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
            this.grilla_lotes = new System.Windows.Forms.DataGridView();
            this.grilla_detalle = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.modstockbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.borrarprodbtn = new System.Windows.Forms.Button();
            this.agregaprodbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_lotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_detalle)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla_lotes
            // 
            this.grilla_lotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_lotes.Location = new System.Drawing.Point(23, 110);
            this.grilla_lotes.MultiSelect = false;
            this.grilla_lotes.Name = "grilla_lotes";
            this.grilla_lotes.ReadOnly = true;
            this.grilla_lotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_lotes.Size = new System.Drawing.Size(270, 165);
            this.grilla_lotes.TabIndex = 0;
            this.grilla_lotes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_lotes_CellClick);
            // 
            // grilla_detalle
            // 
            this.grilla_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_detalle.Location = new System.Drawing.Point(345, 110);
            this.grilla_detalle.MultiSelect = false;
            this.grilla_detalle.Name = "grilla_detalle";
            this.grilla_detalle.ReadOnly = true;
            this.grilla_detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla_detalle.Size = new System.Drawing.Size(600, 165);
            this.grilla_detalle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Detalle de stock del lote";
            // 
            // modstockbtn
            // 
            this.modstockbtn.Location = new System.Drawing.Point(754, 314);
            this.modstockbtn.Name = "modstockbtn";
            this.modstockbtn.Size = new System.Drawing.Size(175, 71);
            this.modstockbtn.TabIndex = 4;
            this.modstockbtn.Text = "Modificar stock de lote seleccionado";
            this.modstockbtn.UseVisualStyleBackColor = true;
            this.modstockbtn.Click += new System.EventHandler(this.modstockbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seleccione lote para ver stock";
            // 
            // borrarprodbtn
            // 
            this.borrarprodbtn.Location = new System.Drawing.Point(545, 314);
            this.borrarprodbtn.Name = "borrarprodbtn";
            this.borrarprodbtn.Size = new System.Drawing.Size(175, 71);
            this.borrarprodbtn.TabIndex = 6;
            this.borrarprodbtn.Text = "Borrar producto seleccionado  de lote";
            this.borrarprodbtn.UseVisualStyleBackColor = true;
            this.borrarprodbtn.Click += new System.EventHandler(this.borrarprodbtn_Click);
            // 
            // agregaprodbtn
            // 
            this.agregaprodbtn.Location = new System.Drawing.Point(345, 314);
            this.agregaprodbtn.Name = "agregaprodbtn";
            this.agregaprodbtn.Size = new System.Drawing.Size(175, 71);
            this.agregaprodbtn.TabIndex = 7;
            this.agregaprodbtn.Text = "Agregar productos a lote";
            this.agregaprodbtn.UseVisualStyleBackColor = true;
            this.agregaprodbtn.Click += new System.EventHandler(this.agregaprodbtn_Click);
            // 
            // Lote_detalleFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 452);
            this.Controls.Add(this.agregaprodbtn);
            this.Controls.Add(this.borrarprodbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modstockbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grilla_detalle);
            this.Controls.Add(this.grilla_lotes);
            this.Name = "Lote_detalleFRM";
            this.Text = "Lotes";
            this.Load += new System.EventHandler(this.LoteModFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_lotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_detalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grilla_lotes;
        private System.Windows.Forms.DataGridView grilla_detalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button modstockbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button borrarprodbtn;
        private System.Windows.Forms.Button agregaprodbtn;
    }
}