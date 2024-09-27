namespace EFDemo
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnObtenerTodo = new System.Windows.Forms.Button();
            this.txtObtenerPorId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObtenerPorId = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(30, 34);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(732, 286);
            this.dgvCustomers.TabIndex = 0;
            // 
            // btnObtenerTodo
            // 
            this.btnObtenerTodo.Location = new System.Drawing.Point(361, 360);
            this.btnObtenerTodo.Name = "btnObtenerTodo";
            this.btnObtenerTodo.Size = new System.Drawing.Size(95, 24);
            this.btnObtenerTodo.TabIndex = 1;
            this.btnObtenerTodo.Text = "Cargar todo";
            this.btnObtenerTodo.UseVisualStyleBackColor = true;
            this.btnObtenerTodo.Click += new System.EventHandler(this.btnObtenerTodo_Click);
            // 
            // txtObtenerPorId
            // 
            this.txtObtenerPorId.Location = new System.Drawing.Point(99, 363);
            this.txtObtenerPorId.Name = "txtObtenerPorId";
            this.txtObtenerPorId.Size = new System.Drawing.Size(100, 20);
            this.txtObtenerPorId.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "IDCustomer";
            // 
            // btnObtenerPorId
            // 
            this.btnObtenerPorId.Location = new System.Drawing.Point(218, 360);
            this.btnObtenerPorId.Name = "btnObtenerPorId";
            this.btnObtenerPorId.Size = new System.Drawing.Size(95, 24);
            this.btnObtenerPorId.TabIndex = 5;
            this.btnObtenerPorId.Text = "Obtener";
            this.btnObtenerPorId.UseVisualStyleBackColor = true;
            this.btnObtenerPorId.Click += new System.EventHandler(this.btnObtenerPorId_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.txtObtenerPorId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObtenerPorId);
            this.Controls.Add(this.btnObtenerTodo);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnObtenerTodo;
        private System.Windows.Forms.TextBox txtObtenerPorId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObtenerPorId;
    }
}

