namespace CamelUp.Forms.Views
{
    partial class FrmMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainWindow));
            this.TlpContenedor = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.FlpBotonesArriba = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.BtnMax = new FontAwesome.Sharp.IconButton();
            this.BtnMin = new FontAwesome.Sharp.IconButton();
            this.TlpContenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.FlpBotonesArriba.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpContenedor
            // 
            this.TlpContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.TlpContenedor.ColumnCount = 3;
            this.TlpContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.5283F));
            this.TlpContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.73585F));
            this.TlpContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.73585F));
            this.TlpContenedor.Controls.Add(this.panel1, 0, 0);
            this.TlpContenedor.Controls.Add(this.FlpBotonesArriba, 1, 0);
            this.TlpContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpContenedor.Location = new System.Drawing.Point(0, 0);
            this.TlpContenedor.Margin = new System.Windows.Forms.Padding(0);
            this.TlpContenedor.Name = "TlpContenedor";
            this.TlpContenedor.RowCount = 4;
            this.TlpContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.TlpContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.TlpContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.38095F));
            this.TlpContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.61905F));
            this.TlpContenedor.Size = new System.Drawing.Size(1097, 593);
            this.TlpContenedor.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.LblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 41);
            this.panel1.TabIndex = 0;
            // 
            // LblTitulo
            // 
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitulo.Font = new System.Drawing.Font("Source Sans Pro Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(0, 0);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.LblTitulo.Size = new System.Drawing.Size(269, 41);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Camel Up";
            this.LblTitulo.DoubleClick += new System.EventHandler(this.TituloDocleClik);
            // 
            // FlpBotonesArriba
            // 
            this.FlpBotonesArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(66)))));
            this.TlpContenedor.SetColumnSpan(this.FlpBotonesArriba, 2);
            this.FlpBotonesArriba.Controls.Add(this.BtnClose);
            this.FlpBotonesArriba.Controls.Add(this.BtnMax);
            this.FlpBotonesArriba.Controls.Add(this.BtnMin);
            this.FlpBotonesArriba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpBotonesArriba.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlpBotonesArriba.Location = new System.Drawing.Point(269, 0);
            this.FlpBotonesArriba.Margin = new System.Windows.Forms.Padding(0);
            this.FlpBotonesArriba.Name = "FlpBotonesArriba";
            this.FlpBotonesArriba.Size = new System.Drawing.Size(828, 41);
            this.FlpBotonesArriba.TabIndex = 1;
            this.FlpBotonesArriba.DoubleClick += new System.EventHandler(this.TituloDocleClik);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnClose.IconColor = System.Drawing.Color.Black;
            this.BtnClose.IconSize = 32;
            this.BtnClose.Location = new System.Drawing.Point(785, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Rotation = 0D;
            this.BtnClose.Size = new System.Drawing.Size(43, 41);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnMax
            // 
            this.BtnMax.BackColor = System.Drawing.Color.Transparent;
            this.BtnMax.FlatAppearance.BorderSize = 0;
            this.BtnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.BtnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMax.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.BtnMax.IconColor = System.Drawing.Color.Black;
            this.BtnMax.IconSize = 32;
            this.BtnMax.Location = new System.Drawing.Point(742, 0);
            this.BtnMax.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Rotation = 0D;
            this.BtnMax.Size = new System.Drawing.Size(43, 41);
            this.BtnMax.TabIndex = 1;
            this.BtnMax.UseVisualStyleBackColor = false;
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // BtnMin
            // 
            this.BtnMin.BackColor = System.Drawing.Color.Transparent;
            this.BtnMin.FlatAppearance.BorderSize = 0;
            this.BtnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.BtnMin.IconColor = System.Drawing.Color.Black;
            this.BtnMin.IconSize = 32;
            this.BtnMin.Location = new System.Drawing.Point(699, 0);
            this.BtnMin.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Rotation = 0D;
            this.BtnMin.Size = new System.Drawing.Size(43, 41);
            this.BtnMin.TabIndex = 2;
            this.BtnMin.UseVisualStyleBackColor = false;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // FrmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 593);
            this.ControlBox = false;
            this.Controls.Add(this.TlpContenedor);
            this.Font = new System.Drawing.Font("Source Sans Pro Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMainWindow";
            this.TlpContenedor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.FlpBotonesArriba.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpContenedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel FlpBotonesArriba;
        private FontAwesome.Sharp.IconButton BtnClose;
        private FontAwesome.Sharp.IconButton BtnMin;
        private System.Windows.Forms.Label LblTitulo;
        private FontAwesome.Sharp.IconButton BtnMax;
    }
}