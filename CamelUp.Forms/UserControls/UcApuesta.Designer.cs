namespace CamelUp.Forms.UserControls
{
    partial class UcApuesta
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
            this.pGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.PbxColor = new System.Windows.Forms.PictureBox();
            this.pBoxSegundo = new System.Windows.Forms.PictureBox();
            this.pBoxResto = new System.Windows.Forms.PictureBox();
            this.pBoxPrimero = new System.Windows.Forms.PictureBox();
            this.LblPuntos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSegundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxResto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPrimero)).BeginInit();
            this.SuspendLayout();
            // 
            // pGeneral
            // 
            this.pGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.pGeneral.ColumnCount = 3;
            this.pGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.pGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.pGeneral.Controls.Add(this.label3, 0, 2);
            this.pGeneral.Controls.Add(this.label2, 0, 2);
            this.pGeneral.Controls.Add(this.PbxColor, 0, 0);
            this.pGeneral.Controls.Add(this.pBoxSegundo, 1, 1);
            this.pGeneral.Controls.Add(this.pBoxResto, 2, 1);
            this.pGeneral.Controls.Add(this.pBoxPrimero, 0, 1);
            this.pGeneral.Controls.Add(this.LblPuntos, 0, 2);
            this.pGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGeneral.Location = new System.Drawing.Point(0, 0);
            this.pGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.pGeneral.Name = "pGeneral";
            this.pGeneral.RowCount = 3;
            this.pGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.pGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.pGeneral.Size = new System.Drawing.Size(150, 180);
            this.pGeneral.TabIndex = 0;
            // 
            // PbxColor
            // 
            this.pGeneral.SetColumnSpan(this.PbxColor, 3);
            this.PbxColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbxColor.Image = global::CamelUp.Forms.Properties.Resources.azul;
            this.PbxColor.Location = new System.Drawing.Point(10, 10);
            this.PbxColor.Margin = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.PbxColor.Name = "PbxColor";
            this.PbxColor.Size = new System.Drawing.Size(130, 45);
            this.PbxColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxColor.TabIndex = 0;
            this.PbxColor.TabStop = false;
            // 
            // pBoxSegundo
            // 
            this.pBoxSegundo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxSegundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBoxSegundo.Location = new System.Drawing.Point(49, 60);
            this.pBoxSegundo.Margin = new System.Windows.Forms.Padding(0);
            this.pBoxSegundo.Name = "pBoxSegundo";
            this.pBoxSegundo.Size = new System.Drawing.Size(50, 70);
            this.pBoxSegundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxSegundo.TabIndex = 3;
            this.pBoxSegundo.TabStop = false;
            // 
            // pBoxResto
            // 
            this.pBoxResto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxResto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBoxResto.Location = new System.Drawing.Point(99, 60);
            this.pBoxResto.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pBoxResto.Name = "pBoxResto";
            this.pBoxResto.Size = new System.Drawing.Size(41, 70);
            this.pBoxResto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxResto.TabIndex = 4;
            this.pBoxResto.TabStop = false;
            // 
            // pBoxPrimero
            // 
            this.pBoxPrimero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxPrimero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBoxPrimero.Location = new System.Drawing.Point(10, 60);
            this.pBoxPrimero.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pBoxPrimero.Name = "pBoxPrimero";
            this.pBoxPrimero.Size = new System.Drawing.Size(39, 70);
            this.pBoxPrimero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxPrimero.TabIndex = 5;
            this.pBoxPrimero.TabStop = false;
            // 
            // LblPuntos
            // 
            this.LblPuntos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblPuntos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblPuntos.Font = new System.Drawing.Font("Source Sans Pro", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPuntos.Location = new System.Drawing.Point(10, 130);
            this.LblPuntos.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.LblPuntos.Name = "LblPuntos";
            this.LblPuntos.Size = new System.Drawing.Size(39, 40);
            this.LblPuntos.TabIndex = 6;
            this.LblPuntos.Text = "3";
            this.LblPuntos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(49, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(99, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "-1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UcApuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pGeneral);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcApuesta";
            this.Size = new System.Drawing.Size(150, 180);
            this.pGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSegundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxResto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPrimero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pGeneral;
        private System.Windows.Forms.PictureBox PbxColor;
        private System.Windows.Forms.PictureBox pBoxSegundo;
        private System.Windows.Forms.PictureBox pBoxResto;
        private System.Windows.Forms.PictureBox pBoxPrimero;
        private System.Windows.Forms.Label LblPuntos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
