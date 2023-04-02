namespace App_Reutilizacion
{
    partial class Windows_Media_Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Windows_Media_Player));
            this.btn_cargar_video = new System.Windows.Forms.Button();
            this.txtBox_ruta = new System.Windows.Forms.TextBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cargar_video
            // 
            this.btn_cargar_video.Location = new System.Drawing.Point(517, 18);
            this.btn_cargar_video.Name = "btn_cargar_video";
            this.btn_cargar_video.Size = new System.Drawing.Size(99, 32);
            this.btn_cargar_video.TabIndex = 1;
            this.btn_cargar_video.Text = "Cargar video";
            this.btn_cargar_video.UseVisualStyleBackColor = true;
            this.btn_cargar_video.Click += new System.EventHandler(this.btn_cargar_video_Click);
            // 
            // txtBox_ruta
            // 
            this.txtBox_ruta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_ruta.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBox_ruta.Location = new System.Drawing.Point(12, 26);
            this.txtBox_ruta.Name = "txtBox_ruta";
            this.txtBox_ruta.ReadOnly = true;
            this.txtBox_ruta.Size = new System.Drawing.Size(475, 20);
            this.txtBox_ruta.TabIndex = 2;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 64);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(604, 407);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(677, 105);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(75, 23);
            this.btn_play.TabIndex = 3;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(677, 159);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 4;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(677, 212);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(75, 23);
            this.btn_pause.TabIndex = 5;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // Windows_Media_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.txtBox_ruta);
            this.Controls.Add(this.btn_cargar_video);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Windows_Media_Player";
            this.Text = "Windows_Media_Player";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btn_cargar_video;
        private System.Windows.Forms.TextBox txtBox_ruta;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_pause;
    }
}