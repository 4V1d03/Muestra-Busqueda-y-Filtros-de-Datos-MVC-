namespace Muestra__Busqueda_y_Filtro_de_Datos.Vista
{
    partial class Cliente
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
            dgvclientes = new DataGridView();
            txtbuscar = new TextBox();
            btnbuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvclientes).BeginInit();
            SuspendLayout();
            // 
            // dgvclientes
            // 
            dgvclientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvclientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvclientes.Location = new Point(22, 95);
            dgvclientes.Name = "dgvclientes";
            dgvclientes.RowHeadersWidth = 51;
            dgvclientes.RowTemplate.Height = 29;
            dgvclientes.Size = new Size(904, 312);
            dgvclientes.TabIndex = 0;
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(22, 62);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(401, 27);
            txtbuscar.TabIndex = 1;
            // 
            // btnbuscar
            // 
            btnbuscar.Location = new Point(429, 59);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(84, 30);
            btnbuscar.TabIndex = 2;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 450);
            Controls.Add(btnbuscar);
            Controls.Add(txtbuscar);
            Controls.Add(dgvclientes);
            Name = "Cliente";
            Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)dgvclientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dgvclientes;
        public TextBox txtbuscar;
        public Button btnbuscar;
    }
}