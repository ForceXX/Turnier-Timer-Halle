/*
 * Erstellt mit SharpDevelop.
 * Benutzer: ForceXX
 * Datum: 19.06.2014
 * Zeit: 18:12
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Timer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
	
		public string hours, hours_pause;
		public string minutes, minutes_pause;
		public string seconds, seconds_pause;

		public string begin_song_direc;
        public string mid_song_direc;
        public string last_minute_song_direc;
        public string end_song_direc;

        public string begin_song_folder;
        public string mid_song_folder;
        public string last_minute_song_folder;
        public string end_song_folder;
        public string sponsor_folder;
        public string spielplan_file;
        public string pause_file;
        public string open_settings_path;
        public string save_settings_path;

		
		public Boolean paused = false;
        public Boolean song_paused = false;
        public Boolean begin_song = true;
        public Boolean mid_song = true;
        public Boolean last_minute_song = true;
        public Boolean end_song = true;
        public Boolean is_extern_view = false;
        public Boolean toggle_game_tab = false;
        public Boolean toggle_pause_tab = false;

		public int origtime, origtime_pause;
		public int timeleft, timeleft_pause;
		public int counter_spielplan;
		public int counter_wait;
		
		private Boolean isBrowserOn;
		
		private string[] save_strings;
		private string[] save_names = {"Anfang","Anfang Art", "Anfang Verzeichnis","Halbzeit","Halbzeit Art",
										"Halbzeit Verzeichnise","Letzte zwei Minuten","Letzte zwei Minuten Art",
										"Letzte zwei Minuten Verzeichnis", "Ende","Ende Art","Ende Verzeichnis", "Stunden",
										"Minute","Sekunden","Wartezeit","Sponsoren Verzeichnis","Sponsoren Intervall"};
		private string[] load_strings;

		private System.IO.StreamWriter writer;
		private System.IO.StreamReader reader;
		
        WMPLib.WindowsMediaPlayer sound = new WMPLib.WindowsMediaPlayer();
        

		Timer_ext timer_ext_view = new Timer_ext();
				
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			tab_spielplan.Enabled = false;
			tab_pause.Enabled = false;
            timer_ext_view.Show();
		}


        private void timer_game_tick(object sender, EventArgs e)
        {
            String hours_temp;
            String minutes_temp;
            String seconds_temp;
            
            if (timeleft > 0)
            {
                if (timeleft == (origtime / 2))
                {

                    if (checkBox_mid_song.Checked == true)
                    {
                        btn_sound_stop.Enabled = true;
                        btn_sound_pause.Enabled = true;
                        sound_volume.Enabled = true;

                        if (radioButton_mid_choose.Checked == true)
                        {
                            sound.URL = mid_song_direc;
                            sound.settings.volume = sound_volume.Value;
                            sound.controls.play();
                        }
                        else if (radioButton_mid_random.Checked == true)
                        {
                            var rand = new Random();
                            var files = Directory.GetFiles(begin_song_folder);
                            sound.URL = files[rand.Next(files.Length)];
                            sound.settings.volume = sound_volume.Value;
                            sound.controls.play();
                        }


                    }
                }
				
                
                //Letzte Minute
                if (timeleft == 120)
                {
                    if (checkBox_last_minute_song.Checked == true)
                    {
                        btn_sound_stop.Enabled = true;
                        btn_sound_pause.Enabled = true;
                        sound_volume.Enabled = true;

                        if (radioButton_last_minute_choose.Checked == true)
                        {
                            sound.URL = last_minute_song_direc;
                            sound.settings.volume = sound_volume.Value;
                            sound.controls.play();
                        }
                        else if (radioButton_last_minute_random.Checked == true)
                        {
                            var rand = new Random();
                            var files = Directory.GetFiles(last_minute_song_folder);
                            sound.URL = files[rand.Next(files.Length)];
                            sound.settings.volume = sound_volume.Value;
                            sound.controls.play();
                        }
                    }
                }

                TimeSpan timespan1 = TimeSpan.FromSeconds(timeleft);

                if (timespan1.Hours < 10) hours_temp = "0" + Convert.ToString(timespan1.Hours);
                else hours_temp = Convert.ToString(timespan1.Hours);

                if (timespan1.Minutes < 10) minutes_temp = "0" + Convert.ToString(timespan1.Minutes);
                else minutes_temp = Convert.ToString(timespan1.Minutes);

                if (timespan1.Seconds < 10) seconds_temp = "0" + Convert.ToString(timespan1.Seconds);
                else seconds_temp = Convert.ToString(timespan1.Seconds);

                toolStripProgressBar1.PerformStep();

                time_show_game.Text = hours_temp + ":" + minutes_temp + ":" + seconds_temp;
                timer_ext_view.time_show_text = hours_temp + ":" + minutes_temp + ":" + seconds_temp;

                timeleft = timeleft - 1;
                time_over_game.Text = "";


            }

            else
            {

                time_show_game.Text = "00:00:00";
                timer_ext_view.time_show_text = "00:00:00";
                timer_game.Stop();
                
                btn_stop_game.Enabled = false;
                btn_pause_game.Enabled = false;
                btn_save_game.Enabled = true;
                btn_reset_game.Enabled = true;
                btn_extern_view.Enabled = false;

                checkBox_begin_song.Enabled = true;
                checkBox_mid_song.Enabled = true;
                checkBox_last_minute_song.Enabled = true;
                checkBox_end_song.Enabled = true;
                
                checkBox_begin_song.Checked = true;
                checkBox_mid_song.Checked = true;
                checkBox_last_minute_song.Checked = true;
                checkBox_end_song.Checked = true;

                label4.Enabled = true;
                label5.Enabled = true;
                label9.Enabled = true;
                label13.Enabled = true;

                groupBox_begin.Enabled = true;
                groupBox_mid.Enabled = true;
                groupBox_last_minute.Enabled = true;
                groupBox_end.Enabled = true;

                textBox_begin_song_direc.Enabled = true;
                textBox_mid_song_direc.Enabled = true;
                textBox_last_minute_song_direc.Enabled = true;
                textBox_end_song_direc.Enabled = true;

                btn_open_begin.Enabled = true;
                btn_open_mid.Enabled = true;
                btn_open_last_minute.Enabled = true;
                btn_open_end.Enabled = true;

                toolStripStatusLabel1.Text = "Inaktiv";
                toolStripProgressBar1.Value = 0;
                this.Text = "Timer";
                timer_ext_view.title_text = "Timer";

                //var is_extern_timer = Application.OpenForms["Timer_ext"];												//Suche nach offener Form Timer_ext

                if (checkBox_end_song.Checked == true)
                {
                    btn_sound_pause.Enabled = true;
                    btn_sound_stop.Enabled = true;

                    if (radioButton_end_choose.Checked == true)
                    {
                        sound.URL = end_song_direc;
                        sound.settings.volume = sound_volume.Value;
                        sound.controls.play();

                    }
                    else if (radioButton_end_random.Checked == true)
                    {
                        var rand = new Random();
                        var files = Directory.GetFiles(end_song_folder);
                        sound.URL = files[rand.Next(files.Length)];
                        sound.settings.volume = sound_volume.Value;
                        sound.controls.play();
                    }


                }
                else
                {
                    btn_sound_pause.Enabled = false;
                    btn_sound_stop.Enabled = false;
                }

                //if (is_extern_timer != null)
                //{
                //    is_extern_timer.Hide();																					//Schließe offene Form
                //}

                time_over_game.Text = "Zeit vorbei!";
                timer_ext_view.time_show_text = "Zeit vorbei!";
                
                if(numericUpDown1.Value != 0){
                	counter_wait = (int)numericUpDown1.Value;
                	toolStripStatusLabel1.Text = "Wartend";
                	timer_wait.Start();
                }
            }
        }

		private void timer_pause_tick(object sender, EventArgs e)
		{
			String hours_temp;
            String minutes_temp;
            String seconds_temp;

            if (timeleft_pause > 0)
            {
            	
            	if(isBrowserOn){
            		if(timeleft_pause % numericUpDown_spielplan_intervall.Value == 0){
            			timer_ext_view.setBrowser(true);
            			counter_spielplan = (int)numericUpDown_spielplan_dauer.Value;
            		}
            		else{
            			counter_spielplan--;
            		}
            		
            		if(counter_spielplan == 0){
            			timer_ext_view.setBrowser(false);
            		}
            	}
            	
            	
            
               TimeSpan timespan1 = TimeSpan.FromSeconds(timeleft_pause);

                if (timespan1.Hours < 10) hours_temp = "0" + Convert.ToString(timespan1.Hours);
                else hours_temp = Convert.ToString(timespan1.Hours);

                if (timespan1.Minutes < 10) minutes_temp = "0" + Convert.ToString(timespan1.Minutes);
                else minutes_temp = Convert.ToString(timespan1.Minutes);

                if (timespan1.Seconds < 10) seconds_temp = "0" + Convert.ToString(timespan1.Seconds);
                else seconds_temp = Convert.ToString(timespan1.Seconds);

                toolStripProgressBar1.PerformStep();

                time_show_pause.Text = hours_temp + ":" + minutes_temp + ":" + seconds_temp;
                timer_ext_view.time_show_text = "Pause\n"+hours_temp + ":" + minutes_temp + ":" + seconds_temp;

                timeleft_pause = timeleft_pause - 1;
                time_over_pause.Text = "";


            }

            else
            {

                time_show_pause.Text = "00:00:00";
                timer_ext_view.time_show_text = "00:00:00";
                timer_pause.Stop();

                btn_stop_pause.Enabled = false;
                btn_pause_pause.Enabled = false;
                btn_save_pause.Enabled = true;
                btn_reset_pause.Enabled = true;
                btn_extern_view.Enabled = false;

                checkBox_begin_song.Checked = true;
                checkBox_mid_song.Checked = true;
                checkBox_last_minute_song.Checked = true;
                checkBox_end_song.Checked = true;

                label4.Enabled = true;
                label5.Enabled = true;
                label9.Enabled = true;
                label13.Enabled = true;

                groupBox_begin.Enabled = true;
                groupBox_mid.Enabled = true;
                groupBox_last_minute.Enabled = true;
                groupBox_end.Enabled = true;

                textBox_begin_song_direc.Enabled = true;
                textBox_mid_song_direc.Enabled = true;
                textBox_last_minute_song_direc.Enabled = true;
                textBox_end_song_direc.Enabled = true;

                btn_open_begin.Enabled = true;
                btn_open_mid.Enabled = true;
                btn_open_last_minute.Enabled = true;
                btn_open_end.Enabled = true;

                toolStripStatusLabel1.Text = "Inaktiv";
                toolStripProgressBar1.Value = 0;
                this.Text = "Timer";
                timer_ext_view.title_text = "Timer";

                //var is_extern_timer = Application.OpenForms["Timer_ext"];												//Suche nach offener Form Timer_ext

                time_over_pause.Text = "Pause um!";
                timer_ext_view.time_show_text = "Pause um!";
                
            }
		}      

        private void Btn_saveClick(object sender, EventArgs e)
		{
			
			btn_reset_game.Enabled = true;
			btn_pause_game.Enabled = false;
			btn_stop_game.Enabled = false;
			btn_start_game.Enabled = true;
            time_over_game.Text = "";
            
            togglePauseTab(false);
      
            timer_ext_view.toggle_mode(false);

            origtime = Convert.ToInt32(seconds_input_game.Value)+Convert.ToInt32(minutes_input_game.Value)*60+Convert.ToInt32(hours_input_game.Value)*60*60;											//Zeit zu Zählen in Sekunden umrechnen
			timeleft = origtime;

            if (Convert.ToInt32(hours_input_game.Value) < 10) hours = "0" + Convert.ToString(hours_input_game.Value);
            else hours = Convert.ToString(hours_input_game.Value);

            if (Convert.ToInt32(minutes_input_game.Value) < 10) minutes = "0" + Convert.ToString(minutes_input_game.Value);
            else minutes = Convert.ToString(minutes_input_game.Value);

            if (Convert.ToInt32(seconds_input_game.Value) < 10) seconds = "0" + Convert.ToString(seconds_input_game.Value);
            else seconds = Convert.ToString(seconds_input_game.Value);

            timer_ext_view.time_show_text = hours + ":" + minutes + ":" + seconds;

			time_show_game.Text = hours+":"+minutes+":"+seconds;
			
			toolStripProgressBar1.Maximum = origtime;
			toolStripProgressBar1.Value = 0;
			toolStripProgressBar1.Step = 1;

            if (textBox_begin_song_direc.Text == "")
            {
                begin_song_direc = "";
                begin_song_folder = "";
                checkBox_begin_song.Checked = false;
                btn_open_begin.Enabled = false;
                label4.Enabled = false;
                groupBox_begin.Enabled = false;
                textBox_begin_song_direc.Enabled = false;
                checkBox_begin_song.Enabled = false;
            }
            else
            {
                begin_song_direc = textBox_begin_song_direc.Text;
                begin_song_folder = textBox_begin_song_direc.Text;
            }
            
            if (textBox_mid_song_direc.Text == "")
            {
                mid_song_direc = "";
                mid_song_folder = "";
                checkBox_mid_song.Checked = false;
                btn_open_mid.Enabled = false;
                label9.Enabled = false;
                groupBox_mid.Enabled = false;
                textBox_mid_song_direc.Enabled = false;
                checkBox_mid_song.Enabled = false;
            }
            else
            {
                mid_song_direc = textBox_mid_song_direc.Text;
                mid_song_folder = textBox_mid_song_direc.Text;
            }

            if (textBox_last_minute_song_direc.Text == "")
            {
                last_minute_song_direc = "";
                last_minute_song_folder = "";
                checkBox_last_minute_song.Checked = false;
                btn_open_last_minute.Enabled = false;
                label13.Enabled = false;
                groupBox_last_minute.Enabled = false;
                textBox_last_minute_song_direc.Enabled = false;
                checkBox_last_minute_song.Enabled = false;
            }
            else
            {
                last_minute_song_direc = textBox_last_minute_song_direc.Text;
                last_minute_song_folder = textBox_last_minute_song_direc.Text;
            }
            
            if (textBox_end_song_direc.Text == "")
            {
                end_song_direc = "";
                end_song_folder = "";
                checkBox_end_song.Checked = false;
                btn_open_end.Enabled = false;
                label5.Enabled = false;
                groupBox_end.Enabled = false;
                textBox_end_song_direc.Enabled = false;
                checkBox_end_song.Enabled = false;
            }
            else
            {
                end_song_direc = textBox_end_song_direc.Text;
                end_song_folder = textBox_end_song_direc.Text;
            }
           

			
			//MessageBox.Show(Convert.ToString(timeleft)+begin_song_direc+end_song_direc);										//Prüfung ob timeleft korrekt ist

		}
        
        private void Btn_save_pauseClick(object sender, EventArgs e)
		{
			btn_reset_pause.Enabled = true;
			btn_pause_pause.Enabled = false;
			btn_stop_pause.Enabled = false;
			btn_start_pause.Enabled = true;
            time_over_pause.Text = "";

            toggleGameTab(false);

            origtime_pause = Convert.ToInt32(seconds_input_pause.Value)+Convert.ToInt32(minutes_input_pause.Value)*60+Convert.ToInt32(hours_input_pause.Value)*60*60;											//Zeit zu Zählen in Sekunden umrechnen
			timeleft_pause = origtime_pause;

            if (Convert.ToInt32(hours_input_pause.Value) < 10) hours_pause = "0" + Convert.ToString(hours_input_pause.Value);
            else hours_pause = Convert.ToString(hours_input_pause.Value);

            if (Convert.ToInt32(minutes_input_pause.Value) < 10) minutes_pause = "0" + Convert.ToString(minutes_input_pause.Value);
            else minutes_pause = Convert.ToString(minutes_input_pause.Value);

            if (Convert.ToInt32(seconds_input_pause.Value) < 10) seconds_pause = "0" + Convert.ToString(seconds_input_pause.Value);
            else seconds_pause = Convert.ToString(seconds_input_pause.Value);

            timer_ext_view.time_show_text = "Pause\n"+hours_pause + ":" + minutes_pause + ":" + seconds_pause;

			time_show_pause.Text = hours_pause+":"+minutes_pause+":"+seconds_pause;
			
			toolStripProgressBar1.Maximum = origtime_pause;
			toolStripProgressBar1.Value = 0;
			toolStripProgressBar1.Step = 1;
		}

        private void Btn_startClick(object sender, EventArgs e)														//Button Start Click
		{
			
			
			btn_save_game.Enabled = false;
			btn_start_game.Enabled = false;
			btn_pause_game.Enabled = true;
			btn_stop_game.Enabled = true;
			btn_reset_game.Enabled = false;
            btn_sound_pause.Enabled = true;
            btn_sound_stop.Enabled = true;
            btn_extern_view.Enabled = true;


            checkBox_begin_song.Enabled = false;
            checkBox_mid_song.Enabled = false;
            checkBox_last_minute_song.Enabled = false;
            checkBox_end_song.Enabled = false;

            label4.Enabled = false;
            label5.Enabled = false;
            label9.Enabled = false;
            label13.Enabled = false;

            groupBox_begin.Enabled = false;
            groupBox_mid.Enabled = false;
            groupBox_last_minute.Enabled = false;
            groupBox_end.Enabled = false;

            textBox_begin_song_direc.Enabled = false;
            textBox_mid_song_direc.Enabled = false;
            textBox_last_minute_song_direc.Enabled = false;
            textBox_end_song_direc.Enabled = false;

            btn_open_begin.Enabled = false;
            btn_open_mid.Enabled = false;
            btn_open_last_minute.Enabled = false;
            btn_open_end.Enabled = false;


            time_over_game.Text = "";
            
			toolStripStatusLabel1.Text = "Aktiv";
			this.Text = "Timer (Aktiv)";
            timer_ext_view.title_text = "Timer (Aktiv)";
			
			//timer_ext_view.Show();
            is_extern_view = true;
			
            if (checkBox_begin_song.Checked == true)
            {
                if (radioButton_begin_choose.Checked == true)
                {
                    sound.URL = begin_song_direc;
                    sound.settings.volume = sound_volume.Value;
                    sound.controls.play();
                }
                else if (radioButton_begin_random.Checked == true)
                {
                    var rand = new Random();
                    var files = Directory.GetFiles(begin_song_folder);
                    sound.URL = files[rand.Next(files.Length)];
                    sound.settings.volume = sound_volume.Value;
                    sound.controls.play();
                }
                

            }
            else
            {
                btn_sound_pause.Enabled = false;
                btn_sound_stop.Enabled = false;
            }

			timer_game.Start();
		}

        private void Btn_start_pauseClick(object sender, EventArgs e)
		{
			btn_save_pause.Enabled = false;
			btn_start_pause.Enabled = false;
			btn_pause_pause.Enabled = true;
			btn_stop_pause.Enabled = true;
			btn_reset_pause.Enabled = false;
            btn_sound_pause.Enabled = true;
            btn_sound_stop.Enabled = true;
            btn_extern_view.Enabled = true;
            if(textBox_pause.Text != "") {
            	btn_pause_sound_start.Enabled = true;
            	btn_pause_sound_stop.Enabled = true;
            }
            btn_open_pause.Enabled = false;


            checkBox_begin_song.Checked = false;
            checkBox_mid_song.Checked = false;
            checkBox_last_minute_song.Checked = false;
            checkBox_end_song.Checked = false;
			
            //Deaktiviert Label, etc...
            //Unnötig
//            label4.Enabled = false;
//            label5.Enabled = false;
//            label9.Enabled = false;
//            label13.Enabled = false;
//
//            groupBox_begin.Enabled = false;
//            groupBox_mid.Enabled = false;
//            groupBox_last_minute.Enabled = false;
//            groupBox_end.Enabled = false;
//
//            textBox_begin_song_direc.Enabled = false;
//            textBox_mid_song_direc.Enabled = false;
//            textBox_last_minute_song_direc.Enabled = false;
//            textBox_end_song_direc.Enabled = false;
//
//            btn_open_begin.Enabled = false;
//            btn_open_mid.Enabled = false;
//            btn_open_last_minute.Enabled = false;
//            btn_open_end.Enabled = false;


            time_over_pause.Text = "";
            
			toolStripStatusLabel1.Text = "Aktiv";
			this.Text = "Timer (Pause)";
            timer_ext_view.title_text = "Timer (Pause)";
			
			//timer_ext_view.Show();
            is_extern_view = true;


			timer_pause.Start();
		}
        
        private void Btn_pauseClick(object sender, EventArgs e)
		{
			if (paused == true){
				timer_game.Enabled = true;
                btn_reset_game.Enabled = false;
				btn_pause_game.Text = "Pause";
                toolStripStatusLabel1.Text = "Aktiv";
				this.Text = "Timer (Aktiv)";
				timer_ext_view.Text = "Timer (Aktiv)";
				paused = false;
			}
			else if (paused == false){
				timer_game.Enabled = false;
                btn_reset_game.Enabled = true;
				btn_pause_game.Text = "Weiter";
                toolStripStatusLabel1.Text = "Pausiert";
				this.Text = "Timer (Pausiert)";
				timer_ext_view.Text = "Timer (Pausiert)";
				paused = true;				
			}
		}
        
        private void Btn_pause_pauseClick(object sender, EventArgs e)
		{
			if (paused == true){
				timer_pause.Enabled = true;
                btn_reset_pause.Enabled = false;
				btn_pause_pause.Text = "Pause";
                toolStripStatusLabel1.Text = "Aktiv";
				this.Text = "Timer (Aktiv)";
				timer_ext_view.Text = "Timer (Aktiv)";
				paused = false;
			}
			else if (paused == false){
				timer_pause.Enabled = false;
                btn_reset_pause.Enabled = true;
				btn_pause_pause.Text = "Weiter";
                toolStripStatusLabel1.Text = "Pausiert";
				this.Text = "Timer (Pausiert)";
				timer_ext_view.Text = "Timer (Pausiert)";
				paused = true;				
			}
		}

        private void Btn_stopClick(object sender, EventArgs e)
		{
			timer_game.Stop();
			timer_wait.Stop();
            sound.controls.stop();

			btn_reset_game.Enabled = true;
			btn_save_game.Enabled = true;
			btn_pause_game.Enabled = false;
			btn_stop_game.Enabled = false;
            btn_sound_pause.Enabled = false;
            btn_sound_stop.Enabled = false;
            btn_extern_view.Enabled = false;

			
			toolStripStatusLabel1.Text = "Inaktiv";
			this.Text = "Timer";
            timer_ext_view.title_text = "Timer";

            sound.controls.stop();
            
            //var is_extern_timer = Application.OpenForms["Timer_ext"];												//Suche nach offener Form Timer_ext
			
            //    if (is_extern_timer != null){
            //        is_extern_timer.Hide();																					//Schließe offene Form
            //    }
			
		}
        
        private void Btn_stop_pauseClick(object sender, EventArgs e)
		{
			timer_pause.Stop();
            sound.controls.stop();

			btn_reset_pause.Enabled = true;
			btn_save_pause.Enabled = true;
			btn_pause_pause.Enabled = false;
			btn_stop_pause.Enabled = false;
            btn_sound_pause.Enabled = false;
            btn_sound_stop.Enabled = false;
            btn_extern_view.Enabled = false;
            btn_pause_sound_start.Enabled = false;

            checkBox_begin_song.Checked = true;
            checkBox_mid_song.Checked = true;
            checkBox_last_minute_song.Checked = true;
            checkBox_end_song.Checked = true;

//            label4.Enabled = true;
//            label5.Enabled = true;
//            label9.Enabled = true;
//            label13.Enabled = true;
//
//            groupBox_begin.Enabled = true;
//            groupBox_mid.Enabled = true;
//            groupBox_last_minute.Enabled = true;
//            groupBox_end.Enabled = true;
//
//            textBox_begin_song_direc.Enabled = true;
//            textBox_mid_song_direc.Enabled = true;
//            textBox_last_minute_song_direc.Enabled = true;
//            textBox_end_song_direc.Enabled = true;
//
//            btn_open_begin.Enabled = true;
//            btn_open_mid.Enabled = true;
//            btn_open_last_minute.Enabled = true;
//            btn_open_end.Enabled = true;
			
			toolStripStatusLabel1.Text = "Inaktiv";
			this.Text = "Timer";
            timer_ext_view.title_text = "Timer";

            sound.controls.stop();
            
            //var is_extern_timer = Application.OpenForms["Timer_ext"];												//Suche nach offener Form Timer_ext
			
            //    if (is_extern_timer != null){
            //        is_extern_timer.Hide();																					//Schließe offene Form
            //    }
		}

        private void Btn_resetClick(object sender, EventArgs e)
		{
			btn_start_game.Enabled = false;
			btn_pause_game.Enabled = false;
			btn_stop_game.Enabled = false;
			btn_reset_game.Enabled = false;
			btn_save_game.Enabled = true;
            btn_extern_view.Enabled = false;
            btn_sound_pause.Enabled = false;
            btn_sound_stop.Enabled = false;

            checkBox_begin_song.Checked = true;
            checkBox_mid_song.Checked = true;
            checkBox_last_minute_song.Checked = true;
            checkBox_end_song.Checked = true;
            
            checkBox_begin_song.Enabled = true;
            checkBox_mid_song.Enabled = true;
            checkBox_last_minute_song.Enabled = true;
            checkBox_end_song.Enabled = true;

            togglePauseTab(true);
            
            //Aktiviert alle Label, Button, TextFields etc.
			//Unnötig, da die Checkboxen das schon erledigen
//            label4.Enabled = true;
//            label5.Enabled = true;
//            label9.Enabled = true;
//            label13.Enabled = true;
//
//            groupBox_begin.Enabled = true;
//            groupBox_mid.Enabled = true;
//            groupBox_last_minute.Enabled = true;
//            groupBox_end.Enabled = true;
//
//            textBox_begin_song_direc.Enabled = true;
//            textBox_mid_song_direc.Enabled = true;
//            textBox_last_minute_song_direc.Enabled = true;
//            textBox_end_song_direc.Enabled = true;
//
//            btn_open_begin.Enabled = true;
//            btn_open_mid.Enabled = true;
//            btn_open_last_minute.Enabled = true;
//            btn_open_end.Enabled = true;
//
//            textBox_begin_song_direc.Text = "";
//            textBox_mid_song_direc.Text = "";
//            textBox_last_minute_song_direc.Text = "";
//            textBox_end_song_direc.Text = "";

			btn_pause_game.Text = "Pause";
			hours_input_game.Value = 0;
			minutes_input_game.Value = 0;
			seconds_input_game.Value = 0;
			numericUpDown1.Value = 0;
			
			toolStripProgressBar1.Value = 0;
			toolStripStatusLabel1.Text = "Inaktiv";
            this.Text = "Timer";

			time_show_game.Text = "00:00:00";
            time_over_game.Text = "";

            timer_ext_view.time_show_text = "00:00:00";
            timer_ext_view.title_text = "Timer";

            //var is_extern_timer = Application.OpenForms["Timer_ext"];												//Suche nach offener Form Timer_ext
			
            //    if (is_extern_timer != null){
            //        is_extern_timer.Hide();																					//Schließe offene Form
            //    }
		}

		private void Btn_reset_pauseClick(object sender, EventArgs e)
		{
			toggleGameTab(true);
			
			btn_start_pause.Enabled = false;
			btn_pause_pause.Enabled = false;
			btn_stop_pause.Enabled = false;
			btn_reset_pause.Enabled = false;
			btn_save_pause.Enabled = true;
            btn_extern_view.Enabled = false;
            btn_sound_pause.Enabled = false;
            btn_sound_stop.Enabled = false;

            checkBox_begin_song.Enabled = true;
            checkBox_mid_song.Enabled = true;
            checkBox_last_minute_song.Enabled = true;
            checkBox_end_song.Enabled = true;

            label4.Enabled = true;
            label5.Enabled = true;
            label9.Enabled = true;
            label13.Enabled = true;

            groupBox_begin.Enabled = true;
            groupBox_mid.Enabled = true;
            groupBox_last_minute.Enabled = true;
            groupBox_end.Enabled = true;

            textBox_begin_song_direc.Enabled = true;
            textBox_mid_song_direc.Enabled = true;
            textBox_last_minute_song_direc.Enabled = true;
            textBox_end_song_direc.Enabled = true;

            btn_open_begin.Enabled = true;
            btn_open_mid.Enabled = true;
            btn_open_last_minute.Enabled = true;
            btn_open_end.Enabled = true;

            textBox_begin_song_direc.Text = "";
            textBox_mid_song_direc.Text = "";
            textBox_last_minute_song_direc.Text = "";
            textBox_end_song_direc.Text = "";

			btn_pause_pause.Text = "Pause";
			hours_input_pause.Value = 0;
			minutes_input_pause.Value = 0;
			seconds_input_pause.Value = 0;
			
			toolStripProgressBar1.Value = 0;
			toolStripStatusLabel1.Text = "Inaktiv";
            this.Text = "Timer";

			time_show_pause.Text = "00:00:00";
            time_over_pause.Text = "";

            timer_ext_view.time_show_text = "00:00:00";
            timer_ext_view.title_text = "Timer";

            //var is_extern_timer = Application.OpenForms["Timer_ext"];												//Suche nach offener Form Timer_ext
			
            //    if (is_extern_timer != null){
            //        is_extern_timer.Hide();																					//Schließe offene Form
            //    }	
		}
        
        private void Btn_open_beginClick(object sender, EventArgs e)
		{
            if (radioButton_begin_choose.Checked == true)
            {
                DialogResult result = open_begin_file.ShowDialog(); // Show the dialog.
                if (result == DialogResult.OK)
                {

                    try
                    {
                        textBox_begin_song_direc.Text = open_begin_file.FileName;
                    }
                    catch (IOException)
                    {
                    }
                }
            }
            else if (radioButton_begin_random.Checked == true)
            {

                DialogResult result = open_begin_folder.ShowDialog() ; // Show the dialog.
                if (result == DialogResult.OK)
                {

                    try
                    {
                        textBox_begin_song_direc.Text = open_begin_folder.SelectedPath;
                    }
                    catch (IOException)
                    {
                    }
                }
            }
		}
       
        private void btn_open_mid_Click(object sender, EventArgs e)
        {
            if (radioButton_mid_choose.Checked == true)
            {
                DialogResult result = open_mid_file.ShowDialog(); // Show the dialog.
                if (result == DialogResult.OK)
                {

                    try
                    {
                        textBox_mid_song_direc.Text = open_mid_file.FileName;
                    }
                    catch (IOException)
                    {
                    }
                }
            }
            else if (radioButton_mid_random.Checked == true)
            {

                DialogResult result = open_mid_folder.ShowDialog(); // Show the dialog.
                if (result == DialogResult.OK)
                {

                    try
                    {
                        textBox_mid_song_direc.Text = open_mid_folder.SelectedPath;
                    }
                    catch (IOException)
                    {
                    }
                }
            }
        }
   
        private void btn_open_last_minute_Click(object sender, EventArgs e)
        {
            if (radioButton_last_minute_choose.Checked == true)
            {
                DialogResult result = open_last_minute_file.ShowDialog(); // Show the dialog.
                if (result == DialogResult.OK)
                {

                    try
                    {
                        textBox_last_minute_song_direc.Text = open_last_minute_file.FileName;
                    }
                    catch (IOException)
                    {
                    }
                }
            }
            else if (radioButton_last_minute_random.Checked == true)
            {

                DialogResult result = open_last_minute_folder.ShowDialog(); // Show the dialog.
                if (result == DialogResult.OK)
                {

                    try
                    {
                        textBox_last_minute_song_direc.Text = open_last_minute_folder.SelectedPath;
                    }
                    catch (IOException)
                    {
                    }
                }
            }
        }

        private void Btn_open_endClick(object sender, EventArgs e)
        {
            if (radioButton_end_choose.Checked == true)
            {
                DialogResult result = open_end_file.ShowDialog(); // Show the dialog.
                if (result == DialogResult.OK)
                {

                    try
                    {
                        textBox_end_song_direc.Text = open_end_file.FileName;
                    }
                    catch (IOException)
                    {
                    }
                }
            }
            else if (radioButton_end_random.Checked == true)
            {

                DialogResult result = open_end_folder.ShowDialog(); // Show the dialog.
                if (result == DialogResult.OK)
                {

                    try
                    {
                        textBox_end_song_direc.Text = open_end_folder.SelectedPath;
                    }
                    catch (IOException)
                    {
                    }
                }
            }
        }

        private void Btn_open_sponsorClick(object sender, EventArgs e)
		{
			DialogResult result = open_sponsor_folder.ShowDialog(); // Show the dialog.
			if (result == DialogResult.OK)
            {

                try
                {
                    textBox_sponsor_directory.Text = open_sponsor_folder.SelectedPath;                    
                }
                catch (IOException)
                {
                }
                
                btn_sponsor_start.Enabled = true;
            }
		}
        
        private void Btn_open_spielplanClick(object sender, EventArgs e)
		{
			DialogResult result = open_spielplan_file.ShowDialog(); // Show the dialog.
			if (result == DialogResult.OK)
            {

                try
                {
                    spielplan_file = open_spielplan_file.FileName;
                    textBox_spielplan.Text = spielplan_file;
                    timer_ext_view.setSpielplanLocation(open_spielplan_file.FileName);

                    btn_spielplan_accept.Enabled = true;
                }
                catch (IOException)
                {
                }
               
            }
		}
        
        private void Btn_open_pauseClick(object sender, EventArgs e)
		{
			DialogResult result = open_pause_file.ShowDialog(); // Show the dialog.
			if (result == DialogResult.OK)
            {

                try
                {
                    pause_file = open_pause_file.FileName;
                    textBox_pause.Text = pause_file;                   	
                }
                catch (IOException)
                {
                }
               
            }
		}
        
        private void btn_extern_view_Click(object sender, EventArgs e)
        {
            if (is_extern_view == true)
            {
                btn_extern_view.Text = "Zeige ext. Fenster";
                is_extern_view = false;
                timer_ext_view.Hide();
            }
            else if (is_extern_view == false)
            {
                btn_extern_view.Text = "Verstecke ext. Fenster";
                is_extern_view = true;
                timer_ext_view.Show();
            }
        }
		
		private void btn_sound_pause_Click(object sender, EventArgs e)
        {
            if (song_paused == true){
                btn_sound_pause.Text = "Pause";
                sound.controls.play();
                song_paused = false;
            }
            else if (song_paused == false){
                btn_sound_pause.Text = "Weiter";
                sound.controls.pause();
                song_paused = true;
            }

        }

        private void btn_sound_stop_Click(object sender, EventArgs e)
        {
            btn_sound_pause.Enabled = false;
            btn_sound_stop.Enabled = false;
            sound.controls.stop();
        }
        
        private void Btn_pause_sound_startClick(object sender, EventArgs e)
		{
			sound.URL = textBox_pause.Text;
	        sound.controls.play();
		}
        
        private void Btn_pause_sound_stopClick(object sender, EventArgs e)
		{
        	sound.controls.stop();
		}

        private void sound_volume_Scroll(object sender, EventArgs e)
        {
            sound.settings.volume = sound_volume.Value;
        }

        private void checkBox_begin_song_CheckedChanged(object sender, EventArgs e)
        {
            if (begin_song == false)
            {
                label4.Enabled = true;
                groupBox_begin.Enabled = true;
                textBox_begin_song_direc.Enabled = true;
                btn_open_begin.Enabled = true;
                begin_song = true;
                
            }
            else if (begin_song == true)
            {
                label4.Enabled = false;
                groupBox_begin.Enabled = false;
                textBox_begin_song_direc.Enabled = false;
                btn_open_begin.Enabled = false;
                begin_song = false;
                
            }
        }

        private void checkBox_mid_song_CheckedChanged(object sender, EventArgs e)
        {
            if (mid_song == false)
            {
                label9.Enabled = true;
                groupBox_mid.Enabled = true;
                textBox_mid_song_direc.Enabled = true;
                btn_open_mid.Enabled = true;
                mid_song = true;

            }
            else if (mid_song == true)
            {
                label9.Enabled = false;
                groupBox_mid.Enabled = false;
                textBox_mid_song_direc.Enabled = false;
                btn_open_mid.Enabled = false;
                mid_song = false;

            }
        }
       
        private void checkBox_last_minute_song_CheckedChanged(object sender, EventArgs e)
        {
            if (last_minute_song == false)
            {
                label13.Enabled = true;
                groupBox_last_minute.Enabled = true;
                textBox_last_minute_song_direc.Enabled = true;
                btn_open_last_minute.Enabled = true;
                last_minute_song = true;

            }
            else if (last_minute_song == true)
            {
                label13.Enabled = false;
                groupBox_last_minute.Enabled = false;
                textBox_last_minute_song_direc.Enabled = false;
                btn_open_last_minute.Enabled = false;
                last_minute_song = false;

            }
        }

        private void checkBox_end_song_CheckedChanged(object sender, EventArgs e)
        {
            if (end_song == false)
            {
                label5.Enabled = true;
                groupBox_end.Enabled = true;
                textBox_end_song_direc.Enabled = true;
                btn_open_end.Enabled = true;
                end_song = true;

            }
            else if (end_song == true)
            {
                label5.Enabled = false;
                groupBox_end.Enabled = false;
                textBox_end_song_direc.Enabled = false;
                btn_open_end.Enabled = false;
                end_song = false;

            }
        }

        private void radioButton_begin_choose_CheckedChanged(object sender, EventArgs e)
        {
            textBox_begin_song_direc.Text = "";
            begin_song_direc = "";
            begin_song_folder = "";
        }

        private void radioButton_begin_random_CheckedChanged(object sender, EventArgs e)
        {
            textBox_begin_song_direc.Text = "";
            begin_song_direc = "";
            begin_song_folder = "";
        }

        private void radioButton_mid_choose_CheckedChanged(object sender, EventArgs e)
        {
            textBox_mid_song_direc.Text = "";
            mid_song_direc = "";
            mid_song_folder = "";
        }

        private void radioButton_mid_random_CheckedChanged(object sender, EventArgs e)
        {
            textBox_mid_song_direc.Text = "";
            mid_song_direc = "";
            mid_song_folder = "";
        }

        private void radioButton_last_minute_choose_CheckedChanged(object sender, EventArgs e)
        {
            textBox_last_minute_song_direc.Text = "";
            last_minute_song_direc = "";
            last_minute_song_folder = "";
        }

        private void radioButton_last_minute_random_CheckedChanged(object sender, EventArgs e)
        {
            textBox_last_minute_song_direc.Text = "";
            last_minute_song_direc = "";
            last_minute_song_folder = "";
        }
       
        private void radioButton_end_choose_CheckedChanged(object sender, EventArgs e)
        {
            textBox_end_song_direc.Text = "";
            end_song_direc = "";
            end_song_folder = "";
        }

        private void radioButton_end_random_CheckedChanged(object sender, EventArgs e)
        {
            textBox_end_song_direc.Text = "";
            end_song_direc = "";
            end_song_folder = "";
        }
        
        private void RadioButton_sponsor_randomCheckedChanged(object sender, EventArgs e)
		{
			textBox_sponsor_directory.Text = "";
   			sponsor_folder = "";
   			btn_sponsor_start.Enabled = false;
   			btn_sponsor_stop.Enabled = false;
		}
		
		private void RadioButton_sponsor_orderCheckedChanged(object sender, EventArgs e)
		{
			textBox_sponsor_directory.Text = "";
   			sponsor_folder = "";
   			btn_sponsor_start.Enabled = false;
   			btn_sponsor_stop.Enabled = false;
		}

        private void label_about_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutWindow = new AboutBox1();
            aboutWindow.Show();
        }
	
        private void toggleGameTab(Boolean toggle){
			tab_music.Enabled = toggle;
        	tab_game.Enabled = toggle;
        }
        
        private void togglePauseTab(Boolean toggle){
			tab_pause.Enabled = toggle;
			tab_spielplan.Enabled = toggle;
        }

		private void Btn_sponsor_startClick(object sender, EventArgs e)
		{
			btn_sponsor_start.Enabled = false;
			btn_sponsor_stop.Enabled = true;
			
			label14.Enabled = false;
			textBox_sponsor_directory.Enabled = false;
			label15.Enabled = false;
			btn_open_sponsor.Enabled = false;
			numericUpDown_sponsor_intervall.Enabled = false;
			
			timer_ext_view.sponsor_intervall = Convert.ToInt32(numericUpDown_sponsor_intervall.Value);
			timer_ext_view.setImageLocation(textBox_sponsor_directory.Text);
			timer_ext_view.Timer_sponsor_start();
		}
		
		private void Btn_sponsor_stopClick(object sender, EventArgs e)
		{
			btn_sponsor_start.Enabled = true;
			btn_sponsor_stop
				.Enabled = false;
			
			label14.Enabled = true;
			textBox_sponsor_directory.Enabled = true;
			label15.Enabled = true;
			btn_open_sponsor.Enabled = true;
			numericUpDown_sponsor_intervall.Enabled = true;
			
			timer_ext_view.Timer_sponsor_stop();
		}
		
		private void Btn_spielplan_acceptClick(object sender, EventArgs e)
		{
			//Intervallzeit !muss! größer als Anzeigedauer sein
			if(numericUpDown_spielplan_intervall.Value > numericUpDown_spielplan_dauer.Value){
			
			btn_spielplan_accept.Enabled = false;
			btn_spielplan_reset.Enabled = true;
			btn_open_spielplan.Enabled = false;
			
			label16.Enabled = false;
			label17.Enabled = false;
			label24.Enabled = false;
			
			textBox_spielplan.Enabled = false;
			numericUpDown_spielplan_intervall.Enabled = false;
			numericUpDown_spielplan_dauer.Enabled = false;
			
			this.isBrowserOn = true;
			
			timer_ext_view.setSpielplanLocation(spielplan_file);
			}
			else{
				MessageBox.Show("Das Intervall muss! größer als die Anzeigedauer sein!","Fehler", MessageBoxButtons.OK);
			}
		}
		
		private void Btn_spielplan_resetClick(object sender, EventArgs e)
		{
			btn_spielplan_accept.Enabled = true;
			btn_spielplan_reset.Enabled = false;
			btn_open_spielplan.Enabled = true;
			
			label16.Enabled= true;
			label17.Enabled= true;
			label24.Enabled = true;
			
			textBox_spielplan.Enabled = true;
			numericUpDown_spielplan_intervall.Enabled = true;
			numericUpDown_spielplan_dauer.Enabled = true;
			
			this.isBrowserOn = false;
		}
		
		private void Timer_waitTick(object sender, EventArgs e)
		{
			if(counter_wait == 0){
				timer_wait.Stop();
				toolStripStatusLabel1.Text = "Inaktiv";
				timer_ext_view.toggle_mode(true);
			}
			else{
				counter_wait--;
			}
		}
		
		private void SchließenToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		private void EinstellungenÖffnenToolStripMenuItemClick(object sender, EventArgs e)
		{
			string temp;
			DialogResult result = open_settings.ShowDialog(); // Show the dialog.
			if (result == DialogResult.OK)
            {

                try
                {
                	load_strings = new string[save_names.Length];
          			open_settings_path = open_settings.FileName;
          			reader = new StreamReader(open_settings_path);
          			for(int i = 0; i < save_names.Length; i++){
          				if((temp = reader.ReadLine()) != null){
          					load_strings[i] = temp;
          				}
          			}
          			setInputs(); 
                }
                catch (IOException)
                {
                }
               
            }
		}
		
		private void EinstellungenSpeichernToolStripMenuItemClick(object sender, EventArgs e)
		{
			getInputs();
			
			DialogResult result = save_settings.ShowDialog(); // Show the dialog.
			if (save_settings.FileName != "")
            {

                try
                {
                	save_settings_path = save_settings.FileName;
                	writer = new StreamWriter(save_settings_path);
					
					for(int i = 0; i < save_names.Length; i++){
						writer.WriteLine(save_names[i] + "|" + save_strings[i]);
					}
					writer.Close();
                }
                catch (IOException)
                {
                }
               
            }
		}
		
		private void getInputs(){
			save_strings = new string[save_names.Length];
			for(int i = 0; i < save_names.Length; i++){
				switch(i){
					case 0:
						save_strings[i] = checkBox_begin_song.Checked.ToString();
						break;
					case 1:
						save_strings[i] = radioButton_begin_choose.Checked.ToString();
						break;							
					case 2:
						save_strings[i] = textBox_begin_song_direc.Text;
						break;
					case 3:
						save_strings[i] = checkBox_mid_song.Checked.ToString();	
						break;
					case 4:
						save_strings[i] = radioButton_mid_choose.Checked.ToString();
						break;
					case 5:
						save_strings[i] = textBox_mid_song_direc.Text;
						break;
					case 6:
						save_strings[i] = checkBox_last_minute_song.Checked.ToString();
						break;
					case 7:
						save_strings[i] = radioButton_last_minute_choose.Checked.ToString();
						break;
					case 8:
						save_strings[i] = textBox_last_minute_song_direc.Text;
						break;
					case 9:
						save_strings[i] = checkBox_end_song.Checked.ToString();
						break;
					case 10:
						save_strings[i] = radioButton_end_choose.Checked.ToString();
						break;
					case 11:
						save_strings[i] = textBox_end_song_direc.Text;
						break;
					case 12:
						save_strings[i] = hours_input_game.Value.ToString();
						break;
					case 13:
						save_strings[i] = minutes_input_game.Value.ToString();
						break;
					case 14:
						save_strings[i] = seconds_input_game.Value.ToString();
						break;
					case 15:
						save_strings[i] = numericUpDown1.Value.ToString();
						break;
					case 16:
						save_strings[i] = textBox_sponsor_directory.Text;
						break;
					case 17:
						save_strings[i] = numericUpDown_sponsor_intervall.Value.ToString();
						break;
				}
			}
		}
		
		private void setInputs(){
				int temp_pos;
				string temp_input;
				//clean read strings
				for(int i = 0; i < save_names.Length; i++){
					temp_pos = load_strings[i].IndexOf('|');
					temp_input = load_strings[i].Remove(0,temp_pos+1);
					load_strings[i] = temp_input;
				}
				
				for(int i = 0; i < save_names.Length; i++){
					switch(i){
							//begin_song
						case 0:
							if(load_strings[i] == "True"){
								checkBox_begin_song.Checked = true;
							}
							else{
								checkBox_begin_song.Checked = false;
							}
							break;
						case 1:
							if(load_strings[i] == "True"){
								radioButton_begin_choose.Checked = true;
								radioButton_begin_random.Checked = false;
							}
							else{
								radioButton_begin_choose.Checked = false;
								radioButton_begin_random.Checked = true;
							}
							break;
						case 2:
							if(load_strings[i] != ""){
								textBox_begin_song_direc.Text = load_strings[i];
							}
							break;
							//mid_song
						case 3:
							if(load_strings[i] == "True"){
								checkBox_mid_song.Checked = true;
							}
							else{
								checkBox_mid_song.Checked = false;
							}
							break;
						case 4:
							if(load_strings[i] == "True"){
								radioButton_mid_choose.Checked = true;
								radioButton_mid_random.Checked = false;
							}
							else{
								radioButton_mid_choose.Checked = false;
								radioButton_mid_random.Checked = true;
							}
							break;
						case 5:
							if(load_strings[i] != ""){
								textBox_mid_song_direc.Text = load_strings[i];
							}
							break;
							//last_minute_song
						case 6:
							if(load_strings[i] == "True"){
								checkBox_last_minute_song.Checked = true;
							}
							else{
								checkBox_last_minute_song.Checked = false;
							}
							break;
						case 7:
							if(load_strings[i] == "True"){
								radioButton_last_minute_choose.Checked = true;
								radioButton_last_minute_random.Checked = false;
							}
							else{
								radioButton_last_minute_choose.Checked = false;
								radioButton_last_minute_random.Checked = true;
							}
							break;
						case 8:
							if(load_strings[i] != ""){
								textBox_last_minute_song_direc.Text = load_strings[i];
							}
							break;
							//end_song
						case 9:
							if(load_strings[i] == "True"){
								checkBox_end_song.Checked = true;
							}
							else{
								checkBox_end_song.Checked = false;
							}
							break;
						case 10:
							if(load_strings[i] == "True"){
								radioButton_end_choose.Checked = true;
								radioButton_end_random.Checked = false;
							}
							else{
								radioButton_end_choose.Checked = false;
								radioButton_end_random.Checked = true;
							}
							break;
						case 11:
							if(load_strings[i] != ""){
								textBox_end_song_direc.Text = load_strings[i];
							}
							break;
							//game_time
						case 12:
							if(Convert.ToInt32(load_strings[i]) != 0){
								hours_input_game.Value = Convert.ToInt32(load_strings[i]);
							}
							break;
						case 13:
							if(Convert.ToInt32(load_strings[i]) != 0){
								minutes_input_game.Value = Convert.ToInt32(load_strings[i]);
							}
							break;
						case 14:
							if(Convert.ToInt32(load_strings[i]) != 0){
								seconds_input_game.Value = Convert.ToInt32(load_strings[i]);
							}
							break;
							//waiting_time
						case 15:
							if(Convert.ToInt32(load_strings[i]) != 0){
								numericUpDown1.Value = Convert.ToInt32(load_strings[i]);
							}
							break;
							//sponsor_directory
						case 16:
							if(load_strings[i] != ""){
								textBox_sponsor_directory.Text = load_strings[i];
								btn_sponsor_start.Enabled = true;
							}
							break;
						case 17:
							if(Convert.ToInt32(load_strings[i]) != 0){
								numericUpDown_sponsor_intervall.Value = Convert.ToInt32(load_strings[i]);
							}
							break;
					}
				}
				
			}
	}
	
	
}
