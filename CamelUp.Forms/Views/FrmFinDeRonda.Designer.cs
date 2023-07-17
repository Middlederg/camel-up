namespace CamelUp.Forms.Views
{
    partial class FrmFinDeRonda
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
            this.pGeneral = new System.Windows.Forms.Panel();
            this.BtnOk = new FontAwesome.Sharp.IconButton();
            this.LblJugador = new System.Windows.Forms.Label();
            this.LbxJugadores = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pGeneral
            // 
            this.pGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.pGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pGeneral.Controls.Add(this.label1);
            this.pGeneral.Controls.Add(this.LbxJugadores);
            this.pGeneral.Controls.Add(this.LblJugador);
            this.pGeneral.Controls.Add(this.BtnOk);
            this.pGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGeneral.Location = new System.Drawing.Point(0, 0);
            this.pGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.pGeneral.Name = "pGeneral";
            this.pGeneral.Size = new System.Drawing.Size(320, 200);
            this.pGeneral.TabIndex = 0;
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.Color.Transparent;
            this.BtnOk.FlatAppearance.BorderSize = 0;
            this.BtnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnOk.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnOk.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(66)))));
            this.BtnOk.IconSize = 32;
            this.BtnOk.Location = new System.Drawing.Point(258, 138);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Rotation = 0D;
            this.BtnOk.Size = new System.Drawing.Size(50, 50);
            this.BtnOk.TabIndex = 2;
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // LblJugador
            // 
            this.LblJugador.AutoSize = true;
            this.LblJugador.Location = new System.Drawing.Point(138, 31);
            this.LblJugador.Name = "LblJugador";
            this.LblJugador.Size = new System.Drawing.Size(40, 17);
            this.LblJugador.TabIndex = 3;
            this.LblJugador.Text = "label1";
            // 
            // LbxJugadores
            // 
            this.LbxJugadores.FormattingEnabled = true;
            this.LbxJugadores.ItemHeight = 17;
            this.LbxJugadores.Location = new System.Drawing.Point(12, 31);
            this.LbxJugadores.Name = "LbxJugadores";
            this.LbxJugadores.Size = new System.Drawing.Size(120, 157);
            this.LbxJugadores.TabIndex = 4;
            this.LbxJugadores.SelectedIndexChanged += new System.EventHandler(this.LbxJugadores_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(66)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(320, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Final de ronda, recogan sus ganancias";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmFinDeRonda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 200);
            this.ControlBox = false;
            this.Controls.Add(this.pGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFinDeRonda";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fin de ronda";
            this.pGeneral.ResumeLayout(false);
            this.pGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pGeneral;
        private FontAwesome.Sharp.IconButton BtnOk;
        private System.Windows.Forms.Label LblJugador;
        private System.Windows.Forms.ListBox LbxJugadores;
        private System.Windows.Forms.Label label1;
    }
}