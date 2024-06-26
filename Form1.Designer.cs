namespace crudDapper
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.TXTName = new System.Windows.Forms.TextBox();
            this.TXTPosition = new System.Windows.Forms.TextBox();
            this.TXTId = new System.Windows.Forms.TextBox();
            this.BTNAgregar = new System.Windows.Forms.Button();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.BTNEditar = new System.Windows.Forms.Button();
            this.DGVData = new System.Windows.Forms.DataGridView();
            this.TXTSalaray = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Position";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(24, 83);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(51, 20);
            this.Name.TabIndex = 2;
            this.Name.Text = "Name";
            // 
            // TXTName
            // 
            this.TXTName.Location = new System.Drawing.Point(108, 77);
            this.TXTName.Name = "TXTName";
            this.TXTName.Size = new System.Drawing.Size(279, 26);
            this.TXTName.TabIndex = 3;
            // 
            // TXTPosition
            // 
            this.TXTPosition.Location = new System.Drawing.Point(108, 131);
            this.TXTPosition.Name = "TXTPosition";
            this.TXTPosition.Size = new System.Drawing.Size(279, 26);
            this.TXTPosition.TabIndex = 4;
            // 
            // TXTId
            // 
            this.TXTId.Location = new System.Drawing.Point(108, 32);
            this.TXTId.Name = "TXTId";
            this.TXTId.Size = new System.Drawing.Size(279, 26);
            this.TXTId.TabIndex = 5;
            // 
            // BTNAgregar
            // 
            this.BTNAgregar.Location = new System.Drawing.Point(108, 240);
            this.BTNAgregar.Name = "BTNAgregar";
            this.BTNAgregar.Size = new System.Drawing.Size(98, 29);
            this.BTNAgregar.TabIndex = 6;
            this.BTNAgregar.Text = "Agregar";
            this.BTNAgregar.UseVisualStyleBackColor = true;
            this.BTNAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNEliminar.Location = new System.Drawing.Point(329, 240);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(98, 29);
            this.BTNEliminar.TabIndex = 7;
            this.BTNEliminar.Text = "Eliminar";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            // 
            // BTNEditar
            // 
            this.BTNEditar.Location = new System.Drawing.Point(220, 240);
            this.BTNEditar.Name = "BTNEditar";
            this.BTNEditar.Size = new System.Drawing.Size(98, 29);
            this.BTNEditar.TabIndex = 8;
            this.BTNEditar.Text = "Editar";
            this.BTNEditar.UseVisualStyleBackColor = true;
            // 
            // DGVData
            // 
            this.DGVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVData.Location = new System.Drawing.Point(28, 306);
            this.DGVData.Name = "DGVData";
            this.DGVData.RowHeadersWidth = 62;
            this.DGVData.RowTemplate.Height = 28;
            this.DGVData.Size = new System.Drawing.Size(844, 150);
            this.DGVData.TabIndex = 9;
            // 
            // TXTSalaray
            // 
            this.TXTSalaray.Location = new System.Drawing.Point(108, 189);
            this.TXTSalaray.Name = "TXTSalaray";
            this.TXTSalaray.Size = new System.Drawing.Size(279, 26);
            this.TXTSalaray.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Salary";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 479);
            this.Controls.Add(this.TXTSalaray);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DGVData);
            this.Controls.Add(this.BTNEditar);
            this.Controls.Add(this.BTNEliminar);
            this.Controls.Add(this.BTNAgregar);
            this.Controls.Add(this.TXTId);
            this.Controls.Add(this.TXTPosition);
            this.Controls.Add(this.TXTName);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGVData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox TXTName;
        private System.Windows.Forms.TextBox TXTPosition;
        private System.Windows.Forms.TextBox TXTId;
        private System.Windows.Forms.Button BTNAgregar;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.Button BTNEditar;
        private System.Windows.Forms.DataGridView DGVData;
        private System.Windows.Forms.TextBox TXTSalaray;
        private System.Windows.Forms.Label label4;
    }
}

