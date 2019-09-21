namespace Capa_Presentacion
{
    partial class Form_Tablero
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_Tablero_1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tablero_1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Tablero_1
            // 
            this.dataGridView_Tablero_1.AllowUserToAddRows = false;
            this.dataGridView_Tablero_1.AllowUserToDeleteRows = false;
            this.dataGridView_Tablero_1.AllowUserToResizeColumns = false;
            this.dataGridView_Tablero_1.AllowUserToResizeRows = false;
            this.dataGridView_Tablero_1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Tablero_1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Tablero_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Tablero_1.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Tablero_1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Tablero_1.Location = new System.Drawing.Point(36, 41);
            this.dataGridView_Tablero_1.MultiSelect = false;
            this.dataGridView_Tablero_1.Name = "dataGridView_Tablero_1";
            this.dataGridView_Tablero_1.ReadOnly = true;
            this.dataGridView_Tablero_1.RowHeadersVisible = false;
            this.dataGridView_Tablero_1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_Tablero_1.Size = new System.Drawing.Size(1191, 465);
            this.dataGridView_Tablero_1.TabIndex = 0;
            // 
            // Form_Tablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1264, 661);
            this.Controls.Add(this.dataGridView_Tablero_1);
            this.Name = "Form_Tablero";
            this.Text = "Batalla Naval";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tablero_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Tablero_1;


       
    }
}

