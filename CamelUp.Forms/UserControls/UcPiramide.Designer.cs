namespace CamelUp.Forms.UserControls
{
    partial class UcPiramide
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.LblAzul = new System.Windows.Forms.Label();
            this.LblVerde = new System.Windows.Forms.Label();
            this.LblNaranja = new System.Windows.Forms.Label();
            this.LblAmarillo = new System.Windows.Forms.Label();
            this.LblBlanco = new System.Windows.Forms.Label();
            this.PbxPiramide = new System.Windows.Forms.PictureBox();
            this.TlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPiramide)).BeginInit();
            this.SuspendLayout();
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.ColumnCount = 5;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpPrincipal.Controls.Add(this.LblAzul, 0, 1);
            this.TlpPrincipal.Controls.Add(this.LblVerde, 1, 1);
            this.TlpPrincipal.Controls.Add(this.LblNaranja, 2, 1);
            this.TlpPrincipal.Controls.Add(this.LblAmarillo, 3, 1);
            this.TlpPrincipal.Controls.Add(this.LblBlanco, 4, 1);
            this.TlpPrincipal.Controls.Add(this.PbxPiramide, 0, 0);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.RowCount = 2;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpPrincipal.Size = new System.Drawing.Size(300, 320);
            this.TlpPrincipal.TabIndex = 0;
            // 
            // LblAzul
            // 
            this.LblAzul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblAzul.Font = new System.Drawing.Font("Source Sans Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAzul.Image = global::CamelUp.Forms.Properties.Resources.DadoAzul;
            this.LblAzul.Location = new System.Drawing.Point(0, 256);
            this.LblAzul.Margin = new System.Windows.Forms.Padding(0);
            this.LblAzul.Name = "LblAzul";
            this.LblAzul.Size = new System.Drawing.Size(60, 64);
            this.LblAzul.TabIndex = 0;
            this.LblAzul.Tag = "1";
            this.LblAzul.Text = "1";
            this.LblAzul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblVerde
            // 
            this.LblVerde.Font = new System.Drawing.Font("Source Sans Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVerde.Image = global::CamelUp.Forms.Properties.Resources.DadoVerde;
            this.LblVerde.Location = new System.Drawing.Point(60, 256);
            this.LblVerde.Margin = new System.Windows.Forms.Padding(0);
            this.LblVerde.Name = "LblVerde";
            this.LblVerde.Size = new System.Drawing.Size(60, 64);
            this.LblVerde.TabIndex = 1;
            this.LblVerde.Tag = "2";
            this.LblVerde.Text = "1";
            this.LblVerde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblNaranja
            // 
            this.LblNaranja.Font = new System.Drawing.Font("Source Sans Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNaranja.Image = global::CamelUp.Forms.Properties.Resources.DadoNaranja;
            this.LblNaranja.Location = new System.Drawing.Point(120, 256);
            this.LblNaranja.Margin = new System.Windows.Forms.Padding(0);
            this.LblNaranja.Name = "LblNaranja";
            this.LblNaranja.Size = new System.Drawing.Size(60, 64);
            this.LblNaranja.TabIndex = 2;
            this.LblNaranja.Tag = "3";
            this.LblNaranja.Text = "1";
            this.LblNaranja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblAmarillo
            // 
            this.LblAmarillo.Font = new System.Drawing.Font("Source Sans Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAmarillo.Image = global::CamelUp.Forms.Properties.Resources.DadoAmarillo;
            this.LblAmarillo.Location = new System.Drawing.Point(180, 256);
            this.LblAmarillo.Margin = new System.Windows.Forms.Padding(0);
            this.LblAmarillo.Name = "LblAmarillo";
            this.LblAmarillo.Size = new System.Drawing.Size(60, 64);
            this.LblAmarillo.TabIndex = 3;
            this.LblAmarillo.Tag = "4";
            this.LblAmarillo.Text = "1";
            this.LblAmarillo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblBlanco
            // 
            this.LblBlanco.Font = new System.Drawing.Font("Source Sans Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBlanco.Image = global::CamelUp.Forms.Properties.Resources.DadoBlanco;
            this.LblBlanco.Location = new System.Drawing.Point(240, 256);
            this.LblBlanco.Margin = new System.Windows.Forms.Padding(0);
            this.LblBlanco.Name = "LblBlanco";
            this.LblBlanco.Size = new System.Drawing.Size(60, 64);
            this.LblBlanco.TabIndex = 4;
            this.LblBlanco.Tag = "5";
            this.LblBlanco.Text = "1";
            this.LblBlanco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PbxPiramide
            // 
            this.TlpPrincipal.SetColumnSpan(this.PbxPiramide, 5);
            this.PbxPiramide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbxPiramide.Image = global::CamelUp.Forms.Properties.Resources.piramide;
            this.PbxPiramide.Location = new System.Drawing.Point(0, 0);
            this.PbxPiramide.Margin = new System.Windows.Forms.Padding(0);
            this.PbxPiramide.Name = "PbxPiramide";
            this.PbxPiramide.Size = new System.Drawing.Size(300, 256);
            this.PbxPiramide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxPiramide.TabIndex = 5;
            this.PbxPiramide.TabStop = false;
            // 
            // UcPiramide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TlpPrincipal);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcPiramide";
            this.Size = new System.Drawing.Size(300, 320);
            this.TlpPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxPiramide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private System.Windows.Forms.Label LblAzul;
        private System.Windows.Forms.Label LblVerde;
        private System.Windows.Forms.Label LblNaranja;
        private System.Windows.Forms.Label LblAmarillo;
        private System.Windows.Forms.Label LblBlanco;
        private System.Windows.Forms.PictureBox PbxPiramide;
    }
}
