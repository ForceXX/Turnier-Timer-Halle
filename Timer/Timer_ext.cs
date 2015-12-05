/*
 * Erstellt mit SharpDevelop.
 * Benutzer: ForceXX
 * Datum: 20.06.2014
 * Zeit: 14:56
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Timer
{
	/// <summary>
	/// Description of Timer_ext.
	/// </summary>
	public partial class Timer_ext : Form
	{
		private int timer_sponsor_intervall;
		private int timer_spielplan_intervall;
		private int timer_sponsor_counter;
		private int timer_image_counter;
		private string imageSponsorSource;
		private string[] sponsor_pictures;
		private double fontsize;
		
		public Timer_ext()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//Detect if second monitor is connected
			//Moves Timer_ext-Form to second Monitor
			if(Screen.AllScreens.Length > 1){
				Rectangle bounds = Screen.AllScreens[1].Bounds;
				this.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
				this.StartPosition = FormStartPosition.Manual;
			}
			//Maximizes Timer_ext-Form
			this.WindowState = FormWindowState.Maximized;
			
			this.webBrowser1.Visible = false;
			
			time_show.Width = this.Width;
			time_show.Height = this.Height;
			fontsize = this.Width/6;
			this.time_show.Font = new System.Drawing.Font("Microsoft Sans Serif", Convert.ToInt32(fontsize), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
		}
		
	
		public string time_show_text{
			get{
				return this.time_show.Text;
			}
			set{
				this.time_show.Text = value;
			}
		}
	
		public string title_text{
			get{
				return this.Text;
			}
			set{
				this.Text = value;
			}
		}
		
		public int sponsor_intervall{
			get{
				return this.timer_sponsor_intervall;
			}
			set{
				this.timer_sponsor_intervall = value;
			}
		}
		
		public int spielplan_intervall{
			get{
				return this.timer_spielplan_intervall;
			}
			set{
				this.timer_spielplan_intervall = value;
			}
		}

        private void Timer_extResize(object sender, EventArgs e)
		{
        	time_show.Width = this.Width;
			time_show.Height = this.Height;
			fontsize = this.Width/6;
			this.time_show.Font = new System.Drawing.Font("Microsoft Sans Serif", Convert.ToInt32(fontsize), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
        }
		
        public void setImageLocation(String source){
        	this.imageSponsorSource = source;
        	//this.sponsor_pictures = Directory.GetFiles(this.imageSponsorSource);
        	
        }
        
        public void setSpielplanLocation(String source){
        	this.webBrowser1.Navigate(source);
        }
        
		private void Timer_sponsorTick(object sender, EventArgs e)
		{
			
			this.sponsor_pictures = Directory.GetFiles(this.imageSponsorSource);
			
			if(timer_sponsor_counter == 0) this.pictureBox_sponsor.ImageLocation = this.sponsor_pictures[0];
			
			//wenn counter mod Intervall = 0 -> Bildwechsel
			if(this.timer_sponsor_counter % this.timer_sponsor_intervall == 0){
				this.pictureBox_sponsor.ImageLocation = this.sponsor_pictures[timer_image_counter];
				
				if(timer_image_counter == sponsor_pictures.Length-1){
					timer_image_counter = 0;
				}
				else{
					timer_image_counter++;
				}
				
			}
			timer_sponsor_counter++;
		
		}
		
		public void Timer_sponsor_start(){
			this.timer_sponsor_counter = 0;
			this.timer_image_counter = 0;
			this.timer_sponsor.Start();
		}
		
		public void Timer_sponsor_stop(){
			this.timer_sponsor.Stop();
			this.pictureBox_sponsor.Image = null;
		}
		
		public void setBrowser(Boolean set){
			if(set == true)this.webBrowser1.Visible = true;
			else this.webBrowser1.Visible = false;
		}
		
		public void toggle_mode(Boolean toggle){
			//MessageBox.Show("ToggleMode: "+toggle);
			if(toggle){
				this.time_show.Visible = false;
				this.pictureBox_sponsor.Dock = DockStyle.Fill;
			}
			else{
				this.pictureBox_sponsor.Dock = DockStyle.Bottom;
				this.time_show.Visible = true;
			}
		}
	}
}
