
namespace wPedidosApp
{
    partial class FrmHistorial
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
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.cmbFiltroEntrega = new System.Windows.Forms.ComboBox();
            this.lblTipoEntrega = new System.Windows.Forms.Label();
            this.lblTituloForm2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(38, 102);
            this.dgvHistorial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.RowHeadersWidth = 82;
            this.dgvHistorial.RowTemplate.Height = 33;
            this.dgvHistorial.Size = new System.Drawing.Size(633, 141);
            this.dgvHistorial.TabIndex = 0;
            // 
            // cmbFiltroEntrega
            // 
            this.cmbFiltroEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroEntrega.FormattingEnabled = true;
            this.cmbFiltroEntrega.Items.AddRange(new object[] {
            "Todos",
            "Dron",
            "Motocicleta",
            "Camión",
            "Bicicleta"});
            this.cmbFiltroEntrega.Location = new System.Drawing.Point(133, 65);
            this.cmbFiltroEntrega.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFiltroEntrega.Name = "cmbFiltroEntrega";
            this.cmbFiltroEntrega.Size = new System.Drawing.Size(98, 23);
            this.cmbFiltroEntrega.TabIndex = 1;
            this.cmbFiltroEntrega.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroEntrega_SelectedIndexChanged);
            // 
            // lblTipoEntrega
            // 
            this.lblTipoEntrega.AutoSize = true;
            this.lblTipoEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEntrega.Location = new System.Drawing.Point(35, 68);
            this.lblTipoEntrega.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoEntrega.Name = "lblTipoEntrega";
            this.lblTipoEntrega.Size = new System.Drawing.Size(94, 15);
            this.lblTipoEntrega.TabIndex = 2;
            this.lblTipoEntrega.Text = "Tipo de Entrega";
            // 
            // lblTituloForm2
            // 
            this.lblTituloForm2.AutoSize = true;
            this.lblTituloForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloForm2.Location = new System.Drawing.Point(279, 23);
            this.lblTituloForm2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloForm2.Name = "lblTituloForm2";
            this.lblTituloForm2.Size = new System.Drawing.Size(177, 24);
            this.lblTituloForm2.TabIndex = 3;
            this.lblTituloForm2.Text = "Historial de Pedidos";
            // 
            // FrmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 319);
            this.Controls.Add(this.lblTituloForm2);
            this.Controls.Add(this.lblTipoEntrega);
            this.Controls.Add(this.cmbFiltroEntrega);
            this.Controls.Add(this.dgvHistorial);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmHistorial";
            this.Text = "Historial Pedidos";
            this.Load += new System.EventHandler(this.FormHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.ComboBox cmbFiltroEntrega;
        private System.Windows.Forms.Label lblTipoEntrega;
        private System.Windows.Forms.Label lblTituloForm2;
    }
}