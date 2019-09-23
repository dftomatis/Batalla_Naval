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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_Tablero_1 = new System.Windows.Forms.DataGridView();
            this.dataGridView_Tablero_2 = new System.Windows.Forms.DataGridView();
            this.btnP1SelectEstrategia = new System.Windows.Forms.Button();
            this.btn_P1Disparar = new System.Windows.Forms.Button();
            this.btnP2SelectEstrategia = new System.Windows.Forms.Button();
            this.btn_P2Disparar = new System.Windows.Forms.Button();
            this.btn_Terminar = new System.Windows.Forms.Button();
            this.btn_NuevaPartida = new System.Windows.Forms.Button();
            this.rb_Estrategia_Aleatoria = new System.Windows.Forms.RadioButton();
            this.rb_estrategiaCaza = new System.Windows.Forms.RadioButton();
            this.groupBox_Estrategias1 = new System.Windows.Forms.GroupBox();
            this.rb_EstrategiaAleatoria2 = new System.Windows.Forms.RadioButton();
            this.rb_EstrategiaCaza2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tablero_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tablero_2)).BeginInit();
            this.groupBox_Estrategias1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.dataGridView_Tablero_1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Tablero_1.MultiSelect = false;
            this.dataGridView_Tablero_1.Name = "dataGridView_Tablero_1";
            this.dataGridView_Tablero_1.ReadOnly = true;
            this.dataGridView_Tablero_1.RowHeadersVisible = false;
            this.dataGridView_Tablero_1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_Tablero_1.Size = new System.Drawing.Size(650, 500);
            this.dataGridView_Tablero_1.TabIndex = 0;
            this.dataGridView_Tablero_1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Tablero_1_CellContentClick);
            // 
            // dataGridView_Tablero_2
            // 
            this.dataGridView_Tablero_2.AllowUserToAddRows = false;
            this.dataGridView_Tablero_2.AllowUserToDeleteRows = false;
            this.dataGridView_Tablero_2.AllowUserToResizeColumns = false;
            this.dataGridView_Tablero_2.AllowUserToResizeRows = false;
            this.dataGridView_Tablero_2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Tablero_2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Tablero_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Tablero_2.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Tablero_2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Tablero_2.Location = new System.Drawing.Point(708, 12);
            this.dataGridView_Tablero_2.MultiSelect = false;
            this.dataGridView_Tablero_2.Name = "dataGridView_Tablero_2";
            this.dataGridView_Tablero_2.ReadOnly = true;
            this.dataGridView_Tablero_2.RowHeadersVisible = false;
            this.dataGridView_Tablero_2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_Tablero_2.Size = new System.Drawing.Size(650, 500);
            this.dataGridView_Tablero_2.TabIndex = 1;
            // 
            // btnP1SelectEstrategia
            // 
            this.btnP1SelectEstrategia.Location = new System.Drawing.Point(119, 40);
            this.btnP1SelectEstrategia.Name = "btnP1SelectEstrategia";
            this.btnP1SelectEstrategia.Size = new System.Drawing.Size(146, 23);
            this.btnP1SelectEstrategia.TabIndex = 3;
            this.btnP1SelectEstrategia.Text = "Seleccionar Estrategia";
            this.btnP1SelectEstrategia.UseVisualStyleBackColor = true;
            this.btnP1SelectEstrategia.Click += new System.EventHandler(this.BtnSelectEstrategia_Click);
            // 
            // btn_P1Disparar
            // 
            this.btn_P1Disparar.Location = new System.Drawing.Point(12, 624);
            this.btn_P1Disparar.Name = "btn_P1Disparar";
            this.btn_P1Disparar.Size = new System.Drawing.Size(146, 23);
            this.btn_P1Disparar.TabIndex = 4;
            this.btn_P1Disparar.Text = "Disparar";
            this.btn_P1Disparar.UseVisualStyleBackColor = true;
            this.btn_P1Disparar.Click += new System.EventHandler(this.Btn_P1Disparar_Click);
            // 
            // btnP2SelectEstrategia
            // 
            this.btnP2SelectEstrategia.Location = new System.Drawing.Point(120, 40);
            this.btnP2SelectEstrategia.Name = "btnP2SelectEstrategia";
            this.btnP2SelectEstrategia.Size = new System.Drawing.Size(146, 23);
            this.btnP2SelectEstrategia.TabIndex = 5;
            this.btnP2SelectEstrategia.Text = "Seleccionar Estrategia";
            this.btnP2SelectEstrategia.UseVisualStyleBackColor = true;
            this.btnP2SelectEstrategia.Click += new System.EventHandler(this.BtnP2SelectEstrategia_Click);
            // 
            // btn_P2Disparar
            // 
            this.btn_P2Disparar.Location = new System.Drawing.Point(708, 624);
            this.btn_P2Disparar.Name = "btn_P2Disparar";
            this.btn_P2Disparar.Size = new System.Drawing.Size(146, 23);
            this.btn_P2Disparar.TabIndex = 6;
            this.btn_P2Disparar.Text = "Disparar";
            this.btn_P2Disparar.UseVisualStyleBackColor = true;
            this.btn_P2Disparar.Click += new System.EventHandler(this.Btn_P2Disparar_Click);
            // 
            // btn_Terminar
            // 
            this.btn_Terminar.Location = new System.Drawing.Point(12, 666);
            this.btn_Terminar.Name = "btn_Terminar";
            this.btn_Terminar.Size = new System.Drawing.Size(146, 23);
            this.btn_Terminar.TabIndex = 7;
            this.btn_Terminar.Text = "Terminar Partida";
            this.btn_Terminar.UseVisualStyleBackColor = true;
            this.btn_Terminar.Click += new System.EventHandler(this.Btn_Terminar_Click);
            // 
            // btn_NuevaPartida
            // 
            this.btn_NuevaPartida.Location = new System.Drawing.Point(182, 666);
            this.btn_NuevaPartida.Name = "btn_NuevaPartida";
            this.btn_NuevaPartida.Size = new System.Drawing.Size(146, 23);
            this.btn_NuevaPartida.TabIndex = 8;
            this.btn_NuevaPartida.Text = "Nueva Partida";
            this.btn_NuevaPartida.UseVisualStyleBackColor = true;
            this.btn_NuevaPartida.Click += new System.EventHandler(this.Btn_NuevaPartida_Click);
            // 
            // rb_Estrategia_Aleatoria
            // 
            this.rb_Estrategia_Aleatoria.AutoSize = true;
            this.rb_Estrategia_Aleatoria.Location = new System.Drawing.Point(6, 23);
            this.rb_Estrategia_Aleatoria.Name = "rb_Estrategia_Aleatoria";
            this.rb_Estrategia_Aleatoria.Size = new System.Drawing.Size(66, 17);
            this.rb_Estrategia_Aleatoria.TabIndex = 9;
            this.rb_Estrategia_Aleatoria.TabStop = true;
            this.rb_Estrategia_Aleatoria.Text = "Aleatoria";
            this.rb_Estrategia_Aleatoria.UseVisualStyleBackColor = true;
            // 
            // rb_estrategiaCaza
            // 
            this.rb_estrategiaCaza.AutoSize = true;
            this.rb_estrategiaCaza.Location = new System.Drawing.Point(5, 46);
            this.rb_estrategiaCaza.Name = "rb_estrategiaCaza";
            this.rb_estrategiaCaza.Size = new System.Drawing.Size(108, 17);
            this.rb_estrategiaCaza.TabIndex = 10;
            this.rb_estrategiaCaza.TabStop = true;
            this.rb_estrategiaCaza.Text = "Busqueda y Caza";
            this.rb_estrategiaCaza.UseVisualStyleBackColor = true;
            // 
            // groupBox_Estrategias1
            // 
            this.groupBox_Estrategias1.Controls.Add(this.rb_estrategiaCaza);
            this.groupBox_Estrategias1.Controls.Add(this.rb_Estrategia_Aleatoria);
            this.groupBox_Estrategias1.Controls.Add(this.btnP1SelectEstrategia);
            this.groupBox_Estrategias1.Location = new System.Drawing.Point(7, 525);
            this.groupBox_Estrategias1.Name = "groupBox_Estrategias1";
            this.groupBox_Estrategias1.Size = new System.Drawing.Size(279, 93);
            this.groupBox_Estrategias1.TabIndex = 11;
            this.groupBox_Estrategias1.TabStop = false;
            this.groupBox_Estrategias1.Text = "Estrategias Jugador 1";
            this.groupBox_Estrategias1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // rb_EstrategiaAleatoria2
            // 
            this.rb_EstrategiaAleatoria2.AutoSize = true;
            this.rb_EstrategiaAleatoria2.Location = new System.Drawing.Point(6, 23);
            this.rb_EstrategiaAleatoria2.Name = "rb_EstrategiaAleatoria2";
            this.rb_EstrategiaAleatoria2.Size = new System.Drawing.Size(66, 17);
            this.rb_EstrategiaAleatoria2.TabIndex = 12;
            this.rb_EstrategiaAleatoria2.TabStop = true;
            this.rb_EstrategiaAleatoria2.Text = "Aleatoria";
            this.rb_EstrategiaAleatoria2.UseVisualStyleBackColor = true;
            // 
            // rb_EstrategiaCaza2
            // 
            this.rb_EstrategiaCaza2.AutoSize = true;
            this.rb_EstrategiaCaza2.Location = new System.Drawing.Point(6, 46);
            this.rb_EstrategiaCaza2.Name = "rb_EstrategiaCaza2";
            this.rb_EstrategiaCaza2.Size = new System.Drawing.Size(108, 17);
            this.rb_EstrategiaCaza2.TabIndex = 13;
            this.rb_EstrategiaCaza2.TabStop = true;
            this.rb_EstrategiaCaza2.Text = "Busqueda y Caza";
            this.rb_EstrategiaCaza2.UseVisualStyleBackColor = true;
            this.rb_EstrategiaCaza2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_EstrategiaAleatoria2);
            this.groupBox1.Controls.Add(this.rb_EstrategiaCaza2);
            this.groupBox1.Controls.Add(this.btnP2SelectEstrategia);
            this.groupBox1.Location = new System.Drawing.Point(708, 525);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 93);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estrategias Jugador 2";
            // 
            // Form_Tablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_Estrategias1);
            this.Controls.Add(this.btn_NuevaPartida);
            this.Controls.Add(this.btn_Terminar);
            this.Controls.Add(this.btn_P2Disparar);
            this.Controls.Add(this.btn_P1Disparar);
            this.Controls.Add(this.dataGridView_Tablero_2);
            this.Controls.Add(this.dataGridView_Tablero_1);
            this.Name = "Form_Tablero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batalla Naval";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Tablero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tablero_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tablero_2)).EndInit();
            this.groupBox_Estrategias1.ResumeLayout(false);
            this.groupBox_Estrategias1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Tablero_1;
        private System.Windows.Forms.DataGridView dataGridView_Tablero_2;
        private System.Windows.Forms.Button btnP1SelectEstrategia;
        private System.Windows.Forms.Button btn_P1Disparar;
        private System.Windows.Forms.Button btnP2SelectEstrategia;
        private System.Windows.Forms.Button btn_P2Disparar;
        private System.Windows.Forms.Button btn_Terminar;
        private System.Windows.Forms.Button btn_NuevaPartida;
        private System.Windows.Forms.RadioButton rb_Estrategia_Aleatoria;
        private System.Windows.Forms.RadioButton rb_estrategiaCaza;
        private System.Windows.Forms.GroupBox groupBox_Estrategias1;
        private System.Windows.Forms.RadioButton rb_EstrategiaAleatoria2;
        private System.Windows.Forms.RadioButton rb_EstrategiaCaza2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

