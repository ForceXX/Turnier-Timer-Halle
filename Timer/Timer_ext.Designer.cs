/*
 * Erstellt mit SharpDevelop.
 * Benutzer: ForceXX
 * Datum: 20.06.2014
 * Zeit: 14:56
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
namespace Timer
{
	partial class Timer_ext
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timer_ext));
			this.time_show = new System.Windows.Forms.Label();
			this.pictureBox_sponsor = new System.Windows.Forms.PictureBox();
			this.timer_sponsor = new System.Windows.Forms.Timer(this.components);
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_sponsor)).BeginInit();
			this.SuspendLayout();
			// 
			// time_show
			// 
			this.time_show.BackColor = System.Drawing.SystemColors.Control;
			this.time_show.Dock = System.Windows.Forms.DockStyle.Fill;
			this.time_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 200F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.time_show.Location = new System.Drawing.Point(0, 0);
			this.time_show.Name = "time_show";
			this.time_show.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
			this.time_show.Size = new System.Drawing.Size(1264, 682);
			this.time_show.TabIndex = 20;
			this.time_show.Text = "00:00:00";
			this.time_show.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox_sponsor
			// 
			this.pictureBox_sponsor.BackColor = System.Drawing.SystemColors.Control;
			this.pictureBox_sponsor.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pictureBox_sponsor.Location = new System.Drawing.Point(0, 385);
			this.pictureBox_sponsor.Name = "pictureBox_sponsor";
			this.pictureBox_sponsor.Size = new System.Drawing.Size(1264, 297);
			this.pictureBox_sponsor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox_sponsor.TabIndex = 21;
			this.pictureBox_sponsor.TabStop = false;
			// 
			// timer_sponsor
			// 
			this.timer_sponsor.Interval = 1000;
			this.timer_sponsor.Tick += new System.EventHandler(this.Timer_sponsorTick);
			// 
			// webBrowser1
			// 
			this.webBrowser1.AllowNavigation = false;
			this.webBrowser1.AllowWebBrowserDrop = false;
			this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
			this.webBrowser1.Location = new System.Drawing.Point(0, 0);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.ScrollBarsEnabled = false;
			this.webBrowser1.Size = new System.Drawing.Size(1264, 682);
			this.webBrowser1.TabIndex = 22;
			// 
			// Timer_ext
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 682);
			this.ControlBox = false;
			this.Controls.Add(this.pictureBox_sponsor);
			this.Controls.Add(this.webBrowser1);
			this.Controls.Add(this.time_show);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(236, 135);
			this.Name = "Timer_ext";
			this.Text = "Timer";
			this.Resize += new System.EventHandler(this.Timer_extResize);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_sponsor)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.Timer timer_sponsor;
		private System.Windows.Forms.PictureBox pictureBox_sponsor;
        private System.Windows.Forms.Label time_show;
	}
}
