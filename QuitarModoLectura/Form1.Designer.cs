namespace QuitarModoLectura
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
            this.btEjecutar = new System.Windows.Forms.Button();
            this.btConvertir = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btRuta = new System.Windows.Forms.Button();
            this.chkSoloLectura = new System.Windows.Forms.CheckBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // btEjecutar
            // 
            this.btEjecutar.Location = new System.Drawing.Point(456, 129);
            this.btEjecutar.Name = "btEjecutar";
            this.btEjecutar.Size = new System.Drawing.Size(133, 23);
            this.btEjecutar.TabIndex = 0;
            this.btEjecutar.Text = "Ver Archivos";
            this.btEjecutar.UseVisualStyleBackColor = true;
            this.btEjecutar.Click += new System.EventHandler(this.btEjecutar_Click);
            // 
            // btConvertir
            // 
            this.btConvertir.Location = new System.Drawing.Point(595, 129);
            this.btConvertir.Name = "btConvertir";
            this.btConvertir.Size = new System.Drawing.Size(161, 23);
            this.btConvertir.TabIndex = 2;
            this.btConvertir.Text = "Cambiar Archivos Solo Lectura";
            this.btConvertir.UseVisualStyleBackColor = true;
            this.btConvertir.Click += new System.EventHandler(this.btConvertir_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(12, 29);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(691, 20);
            this.txtRuta.TabIndex = 3;
            this.txtRuta.TextChanged += new System.EventHandler(this.txtRuta_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ruta";
            // 
            // btRuta
            // 
            this.btRuta.Location = new System.Drawing.Point(709, 26);
            this.btRuta.Name = "btRuta";
            this.btRuta.Size = new System.Drawing.Size(25, 23);
            this.btRuta.TabIndex = 5;
            this.btRuta.Text = "...";
            this.btRuta.UseVisualStyleBackColor = true;
            this.btRuta.Click += new System.EventHandler(this.btRuta_Click);
            // 
            // chkSoloLectura
            // 
            this.chkSoloLectura.AutoSize = true;
            this.chkSoloLectura.Checked = true;
            this.chkSoloLectura.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSoloLectura.Location = new System.Drawing.Point(271, 129);
            this.chkSoloLectura.Name = "chkSoloLectura";
            this.chkSoloLectura.Size = new System.Drawing.Size(122, 17);
            this.chkSoloLectura.TabIndex = 6;
            this.chkSoloLectura.Text = "Mostrar solo Lectura";
            this.chkSoloLectura.UseVisualStyleBackColor = true;
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView.Location = new System.Drawing.Point(16, 173);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(772, 265);
            this.treeView.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.chkSoloLectura);
            this.Controls.Add(this.btRuta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.btConvertir);
            this.Controls.Add(this.btEjecutar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEjecutar;
        private System.Windows.Forms.Button btConvertir;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRuta;
        private System.Windows.Forms.CheckBox chkSoloLectura;
        private System.Windows.Forms.TreeView treeView;
    }
}

