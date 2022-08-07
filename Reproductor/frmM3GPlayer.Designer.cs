namespace Reproductor
{
    partial class frmM3GPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmM3GPlayer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdAnterior = new System.Windows.Forms.Button();
            this.cmdProximo = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.cmdPausar = new System.Windows.Forms.Button();
            this.cmdDetener = new System.Windows.Forms.Button();
            this.cmdReproducir = new System.Windows.Forms.Button();
            this.cmdSeleccion = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdAnterior);
            this.panel1.Controls.Add(this.cmdProximo);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.cmdPausar);
            this.panel1.Controls.Add(this.cmdDetener);
            this.panel1.Controls.Add(this.cmdReproducir);
            this.panel1.Controls.Add(this.cmdSeleccion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 271);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 71);
            this.panel1.TabIndex = 0;
            // 
            // cmdAnterior
            // 
            this.cmdAnterior.Image = ((System.Drawing.Image)(resources.GetObject("cmdAnterior.Image")));
            this.cmdAnterior.Location = new System.Drawing.Point(155, 10);
            this.cmdAnterior.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAnterior.Name = "cmdAnterior";
            this.cmdAnterior.Size = new System.Drawing.Size(55, 46);
            this.cmdAnterior.TabIndex = 7;
            this.cmdAnterior.UseVisualStyleBackColor = true;
            this.cmdAnterior.Click += new System.EventHandler(this.cmdAnterior_Click);
            // 
            // cmdProximo
            // 
            this.cmdProximo.Image = ((System.Drawing.Image)(resources.GetObject("cmdProximo.Image")));
            this.cmdProximo.Location = new System.Drawing.Point(280, 10);
            this.cmdProximo.Margin = new System.Windows.Forms.Padding(4);
            this.cmdProximo.Name = "cmdProximo";
            this.cmdProximo.Size = new System.Drawing.Size(55, 46);
            this.cmdProximo.TabIndex = 6;
            this.cmdProximo.UseVisualStyleBackColor = true;
            this.cmdProximo.Click += new System.EventHandler(this.cmdProximo_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.Menu;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(475, 7);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(253, 56);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // cmdPausar
            // 
            this.cmdPausar.Image = ((System.Drawing.Image)(resources.GetObject("cmdPausar.Image")));
            this.cmdPausar.Location = new System.Drawing.Point(67, 10);
            this.cmdPausar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdPausar.Name = "cmdPausar";
            this.cmdPausar.Size = new System.Drawing.Size(55, 46);
            this.cmdPausar.TabIndex = 4;
            this.cmdPausar.UseVisualStyleBackColor = true;
            this.cmdPausar.Click += new System.EventHandler(this.cmdPausar_Click);
            // 
            // cmdDetener
            // 
            this.cmdDetener.Image = ((System.Drawing.Image)(resources.GetObject("cmdDetener.Image")));
            this.cmdDetener.Location = new System.Drawing.Point(217, 10);
            this.cmdDetener.Margin = new System.Windows.Forms.Padding(4);
            this.cmdDetener.Name = "cmdDetener";
            this.cmdDetener.Size = new System.Drawing.Size(55, 46);
            this.cmdDetener.TabIndex = 3;
            this.cmdDetener.UseVisualStyleBackColor = true;
            this.cmdDetener.Click += new System.EventHandler(this.cmdDetener_Click);
            // 
            // cmdReproducir
            // 
            this.cmdReproducir.Image = ((System.Drawing.Image)(resources.GetObject("cmdReproducir.Image")));
            this.cmdReproducir.Location = new System.Drawing.Point(4, 10);
            this.cmdReproducir.Margin = new System.Windows.Forms.Padding(4);
            this.cmdReproducir.Name = "cmdReproducir";
            this.cmdReproducir.Size = new System.Drawing.Size(55, 46);
            this.cmdReproducir.TabIndex = 2;
            this.cmdReproducir.UseVisualStyleBackColor = true;
            this.cmdReproducir.Click += new System.EventHandler(this.cmdReproducir_Click);
            // 
            // cmdSeleccion
            // 
            this.cmdSeleccion.Image = ((System.Drawing.Image)(resources.GetObject("cmdSeleccion.Image")));
            this.cmdSeleccion.Location = new System.Drawing.Point(375, 10);
            this.cmdSeleccion.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSeleccion.Name = "cmdSeleccion";
            this.cmdSeleccion.Size = new System.Drawing.Size(80, 46);
            this.cmdSeleccion.TabIndex = 0;
            this.cmdSeleccion.UseVisualStyleBackColor = true;
            this.cmdSeleccion.Click += new System.EventHandler(this.cmdSeleccion_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(732, 271);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // YoniPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(732, 342);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "YoniPlayer";
            this.Text = "M3GPlayer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button cmdSeleccion;
        private System.Windows.Forms.Button cmdReproducir;
        private System.Windows.Forms.Button cmdPausar;
        private System.Windows.Forms.Button cmdDetener;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button cmdProximo;
        private System.Windows.Forms.Button cmdAnterior;
    }
}

