/*
 * Erstellt mit SharpDevelop.
 * Benutzer: ForceXX
 * Datum: 19.06.2014
 * Zeit: 18:12
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
namespace Timer
{
	partial class MainForm
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
		public void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btn_start_game = new System.Windows.Forms.Button();
			this.hours_input_game = new System.Windows.Forms.NumericUpDown();
			this.minutes_input_game = new System.Windows.Forms.NumericUpDown();
			this.seconds_input_game = new System.Windows.Forms.NumericUpDown();
			this.btn_pause_game = new System.Windows.Forms.Button();
			this.btn_stop_game = new System.Windows.Forms.Button();
			this.btn_save_game = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.timer_game = new System.Windows.Forms.Timer(this.components);
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.time_show_game = new System.Windows.Forms.Label();
			this.btn_reset_game = new System.Windows.Forms.Button();
			this.separator3 = new System.Windows.Forms.Label();
			this.separator2 = new System.Windows.Forms.Label();
			this.separator1 = new System.Windows.Forms.Label();
			this.textBox_begin_song_direc = new System.Windows.Forms.TextBox();
			this.textBox_end_song_direc = new System.Windows.Forms.TextBox();
			this.btn_open_begin = new System.Windows.Forms.Button();
			this.btn_open_end = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.open_begin_file = new System.Windows.Forms.OpenFileDialog();
			this.open_end_file = new System.Windows.Forms.OpenFileDialog();
			this.sound_volume = new System.Windows.Forms.TrackBar();
			this.btn_sound_pause = new System.Windows.Forms.Button();
			this.btn_sound_stop = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.time_over_game = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.btn_open_mid = new System.Windows.Forms.Button();
			this.textBox_mid_song_direc = new System.Windows.Forms.TextBox();
			this.checkBox_begin_song = new System.Windows.Forms.CheckBox();
			this.checkBox_mid_song = new System.Windows.Forms.CheckBox();
			this.checkBox_end_song = new System.Windows.Forms.CheckBox();
			this.open_mid_file = new System.Windows.Forms.OpenFileDialog();
			this.radioButton_begin_choose = new System.Windows.Forms.RadioButton();
			this.radioButton_begin_random = new System.Windows.Forms.RadioButton();
			this.open_begin_folder = new System.Windows.Forms.FolderBrowserDialog();
			this.open_mid_folder = new System.Windows.Forms.FolderBrowserDialog();
			this.open_end_folder = new System.Windows.Forms.FolderBrowserDialog();
			this.groupBox_begin = new System.Windows.Forms.GroupBox();
			this.groupBox_mid = new System.Windows.Forms.GroupBox();
			this.radioButton_mid_choose = new System.Windows.Forms.RadioButton();
			this.radioButton_mid_random = new System.Windows.Forms.RadioButton();
			this.groupBox_end = new System.Windows.Forms.GroupBox();
			this.radioButton_end_choose = new System.Windows.Forms.RadioButton();
			this.radioButton_end_random = new System.Windows.Forms.RadioButton();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.btn_extern_view = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.groupBox_last_minute = new System.Windows.Forms.GroupBox();
			this.radioButton_last_minute_choose = new System.Windows.Forms.RadioButton();
			this.radioButton_last_minute_random = new System.Windows.Forms.RadioButton();
			this.textBox_last_minute_song_direc = new System.Windows.Forms.TextBox();
			this.btn_open_last_minute = new System.Windows.Forms.Button();
			this.checkBox_last_minute_song = new System.Windows.Forms.CheckBox();
			this.open_last_minute_folder = new System.Windows.Forms.FolderBrowserDialog();
			this.open_last_minute_file = new System.Windows.Forms.OpenFileDialog();
			this.label_about = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.btn_save_pause = new System.Windows.Forms.Button();
			this.seconds_input_pause = new System.Windows.Forms.NumericUpDown();
			this.minutes_input_pause = new System.Windows.Forms.NumericUpDown();
			this.hours_input_pause = new System.Windows.Forms.NumericUpDown();
			this.time_over_pause = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.time_show_pause = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.btn_stop_pause = new System.Windows.Forms.Button();
			this.btn_pause_pause = new System.Windows.Forms.Button();
			this.btn_start_pause = new System.Windows.Forms.Button();
			this.btn_reset_pause = new System.Windows.Forms.Button();
			this.timer_pause = new System.Windows.Forms.Timer(this.components);
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tab_music = new System.Windows.Forms.TabPage();
			this.tab_game = new System.Windows.Forms.TabPage();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label27 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.tab_sponsor = new System.Windows.Forms.TabPage();
			this.btn_sponsor_stop = new System.Windows.Forms.Button();
			this.btn_sponsor_start = new System.Windows.Forms.Button();
			this.numericUpDown_sponsor_intervall = new System.Windows.Forms.NumericUpDown();
			this.btn_open_sponsor = new System.Windows.Forms.Button();
			this.textBox_sponsor_directory = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.tab_pause = new System.Windows.Forms.TabPage();
			this.label6 = new System.Windows.Forms.Label();
			this.btn_pause_sound_start = new System.Windows.Forms.Button();
			this.btn_pause_sound_stop = new System.Windows.Forms.Button();
			this.textBox_pause = new System.Windows.Forms.TextBox();
			this.btn_open_pause = new System.Windows.Forms.Button();
			this.tab_spielplan = new System.Windows.Forms.TabPage();
			this.numericUpDown_spielplan_dauer = new System.Windows.Forms.NumericUpDown();
			this.label24 = new System.Windows.Forms.Label();
			this.btn_spielplan_reset = new System.Windows.Forms.Button();
			this.btn_spielplan_accept = new System.Windows.Forms.Button();
			this.numericUpDown_spielplan_intervall = new System.Windows.Forms.NumericUpDown();
			this.label17 = new System.Windows.Forms.Label();
			this.btn_open_spielplan = new System.Windows.Forms.Button();
			this.textBox_spielplan = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.open_sponsor_folder = new System.Windows.Forms.FolderBrowserDialog();
			this.open_spielplan_file = new System.Windows.Forms.OpenFileDialog();
			this.open_pause_file = new System.Windows.Forms.OpenFileDialog();
			this.timer_wait = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.einstellungenÖffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.einstellungenSpeichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.open_settings = new System.Windows.Forms.OpenFileDialog();
			this.save_settings = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.hours_input_game)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minutes_input_game)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.seconds_input_game)).BeginInit();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sound_volume)).BeginInit();
			this.groupBox_begin.SuspendLayout();
			this.groupBox_mid.SuspendLayout();
			this.groupBox_end.SuspendLayout();
			this.groupBox_last_minute.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.seconds_input_pause)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minutes_input_pause)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hours_input_pause)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tab_music.SuspendLayout();
			this.tab_game.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.tab_sponsor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sponsor_intervall)).BeginInit();
			this.tab_pause.SuspendLayout();
			this.tab_spielplan.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_spielplan_dauer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_spielplan_intervall)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_start_game
			// 
			this.btn_start_game.Enabled = false;
			this.btn_start_game.Location = new System.Drawing.Point(26, 336);
			this.btn_start_game.Name = "btn_start_game";
			this.btn_start_game.Size = new System.Drawing.Size(75, 23);
			this.btn_start_game.TabIndex = 0;
			this.btn_start_game.Text = "Start";
			this.btn_start_game.UseVisualStyleBackColor = true;
			this.btn_start_game.Click += new System.EventHandler(this.Btn_startClick);
			// 
			// hours_input_game
			// 
			this.hours_input_game.Location = new System.Drawing.Point(69, 59);
			this.hours_input_game.Maximum = new decimal(new int[] {
									24,
									0,
									0,
									0});
			this.hours_input_game.Name = "hours_input_game";
			this.hours_input_game.Size = new System.Drawing.Size(46, 20);
			this.hours_input_game.TabIndex = 1;
			// 
			// minutes_input_game
			// 
			this.minutes_input_game.Location = new System.Drawing.Point(121, 59);
			this.minutes_input_game.Maximum = new decimal(new int[] {
									59,
									0,
									0,
									0});
			this.minutes_input_game.Name = "minutes_input_game";
			this.minutes_input_game.Size = new System.Drawing.Size(46, 20);
			this.minutes_input_game.TabIndex = 2;
			// 
			// seconds_input_game
			// 
			this.seconds_input_game.Location = new System.Drawing.Point(173, 59);
			this.seconds_input_game.Maximum = new decimal(new int[] {
									59,
									0,
									0,
									0});
			this.seconds_input_game.Name = "seconds_input_game";
			this.seconds_input_game.Size = new System.Drawing.Size(46, 20);
			this.seconds_input_game.TabIndex = 3;
			// 
			// btn_pause_game
			// 
			this.btn_pause_game.Enabled = false;
			this.btn_pause_game.Location = new System.Drawing.Point(119, 336);
			this.btn_pause_game.Name = "btn_pause_game";
			this.btn_pause_game.Size = new System.Drawing.Size(75, 23);
			this.btn_pause_game.TabIndex = 5;
			this.btn_pause_game.Text = "Pause";
			this.btn_pause_game.UseVisualStyleBackColor = true;
			this.btn_pause_game.Click += new System.EventHandler(this.Btn_pauseClick);
			// 
			// btn_stop_game
			// 
			this.btn_stop_game.Enabled = false;
			this.btn_stop_game.Location = new System.Drawing.Point(211, 336);
			this.btn_stop_game.Name = "btn_stop_game";
			this.btn_stop_game.Size = new System.Drawing.Size(75, 23);
			this.btn_stop_game.TabIndex = 6;
			this.btn_stop_game.Text = "Stop";
			this.btn_stop_game.UseVisualStyleBackColor = true;
			this.btn_stop_game.Click += new System.EventHandler(this.Btn_stopClick);
			// 
			// btn_save_game
			// 
			this.btn_save_game.Location = new System.Drawing.Point(108, 168);
			this.btn_save_game.Name = "btn_save_game";
			this.btn_save_game.Size = new System.Drawing.Size(86, 23);
			this.btn_save_game.TabIndex = 7;
			this.btn_save_game.Text = "Übernehmen";
			this.btn_save_game.UseVisualStyleBackColor = true;
			this.btn_save_game.Click += new System.EventHandler(this.Btn_saveClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(68, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 16);
			this.label1.TabIndex = 13;
			this.label1.Text = "Stunden";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(120, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 16);
			this.label2.TabIndex = 14;
			this.label2.Text = "Minuten";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(171, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.TabIndex = 15;
			this.label3.Text = "Sekunden";
			// 
			// timer_game
			// 
			this.timer_game.Interval = 1000;
			this.timer_game.Tick += new System.EventHandler(this.timer_game_tick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel1,
									this.toolStripProgressBar1});
			this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.statusStrip1.Location = new System.Drawing.Point(0, 492);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(310, 22);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.Stretch = false;
			this.statusStrip1.TabIndex = 16;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.AutoSize = false;
			this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 14);
			this.toolStripStatusLabel1.Text = "Inaktiv";
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.Margin = new System.Windows.Forms.Padding(7, 3, 1, 3);
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
			this.toolStripProgressBar1.Size = new System.Drawing.Size(225, 16);
			// 
			// time_show_game
			// 
			this.time_show_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.time_show_game.Location = new System.Drawing.Point(17, 204);
			this.time_show_game.Name = "time_show_game";
			this.time_show_game.Size = new System.Drawing.Size(262, 78);
			this.time_show_game.TabIndex = 17;
			this.time_show_game.Text = "00:00:00";
			this.time_show_game.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_reset_game
			// 
			this.btn_reset_game.Enabled = false;
			this.btn_reset_game.Location = new System.Drawing.Point(211, 397);
			this.btn_reset_game.Name = "btn_reset_game";
			this.btn_reset_game.Size = new System.Drawing.Size(75, 23);
			this.btn_reset_game.TabIndex = 18;
			this.btn_reset_game.Text = "Reset";
			this.btn_reset_game.UseVisualStyleBackColor = true;
			this.btn_reset_game.Click += new System.EventHandler(this.Btn_resetClick);
			// 
			// separator3
			// 
			this.separator3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.separator3.Location = new System.Drawing.Point(17, 380);
			this.separator3.Name = "separator3";
			this.separator3.Size = new System.Drawing.Size(264, 2);
			this.separator3.TabIndex = 19;
			this.separator3.Text = "label4";
			// 
			// separator2
			// 
			this.separator2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.separator2.Location = new System.Drawing.Point(17, 303);
			this.separator2.Name = "separator2";
			this.separator2.Size = new System.Drawing.Size(264, 2);
			this.separator2.TabIndex = 20;
			this.separator2.Text = "label5";
			// 
			// separator1
			// 
			this.separator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.separator1.Location = new System.Drawing.Point(17, 195);
			this.separator1.Name = "separator1";
			this.separator1.Size = new System.Drawing.Size(264, 2);
			this.separator1.TabIndex = 21;
			this.separator1.Text = "label6";
			// 
			// textBox_begin_song_direc
			// 
			this.textBox_begin_song_direc.Location = new System.Drawing.Point(39, 59);
			this.textBox_begin_song_direc.Name = "textBox_begin_song_direc";
			this.textBox_begin_song_direc.ReadOnly = true;
			this.textBox_begin_song_direc.Size = new System.Drawing.Size(199, 20);
			this.textBox_begin_song_direc.TabIndex = 22;
			// 
			// textBox_end_song_direc
			// 
			this.textBox_end_song_direc.Location = new System.Drawing.Point(38, 330);
			this.textBox_end_song_direc.Name = "textBox_end_song_direc";
			this.textBox_end_song_direc.ReadOnly = true;
			this.textBox_end_song_direc.Size = new System.Drawing.Size(199, 20);
			this.textBox_end_song_direc.TabIndex = 23;
			// 
			// btn_open_begin
			// 
			this.btn_open_begin.Location = new System.Drawing.Point(252, 59);
			this.btn_open_begin.Name = "btn_open_begin";
			this.btn_open_begin.Size = new System.Drawing.Size(37, 23);
			this.btn_open_begin.TabIndex = 24;
			this.btn_open_begin.Text = "...";
			this.btn_open_begin.UseVisualStyleBackColor = true;
			this.btn_open_begin.Click += new System.EventHandler(this.Btn_open_beginClick);
			// 
			// btn_open_end
			// 
			this.btn_open_end.Location = new System.Drawing.Point(251, 330);
			this.btn_open_end.Name = "btn_open_end";
			this.btn_open_end.Size = new System.Drawing.Size(37, 23);
			this.btn_open_end.TabIndex = 25;
			this.btn_open_end.Text = "...";
			this.btn_open_end.UseVisualStyleBackColor = true;
			this.btn_open_end.Click += new System.EventHandler(this.Btn_open_endClick);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(126, 1);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 13);
			this.label4.TabIndex = 26;
			this.label4.Text = "Anfang";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.Control;
			this.label5.Location = new System.Drawing.Point(125, 272);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 13);
			this.label5.TabIndex = 27;
			this.label5.Text = "Ende";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// open_begin_file
			// 
			this.open_begin_file.Filter = "Alle Dateien| *.*|mp3-Dateien|*.mp3|WAV-Dateien|*.wav";
			this.open_begin_file.InitialDirectory = "C:\\Program Files (x86)\\Microsoft Visual Studio 10.0\\Common7\\IDE\\VCSExpress.exe";
			this.open_begin_file.SupportMultiDottedExtensions = true;
			// 
			// open_end_file
			// 
			this.open_end_file.Filter = "Alle Dateien| *.*|mp3-Dateien|*.mp3|WAV-Dateien|*.wav";
			this.open_end_file.InitialDirectory = "C:\\Program Files (x86)\\Microsoft Visual Studio 10.0\\Common7\\IDE\\VCSExpress.exe";
			this.open_end_file.SupportMultiDottedExtensions = true;
			// 
			// sound_volume
			// 
			this.sound_volume.Location = new System.Drawing.Point(351, 338);
			this.sound_volume.Maximum = 100;
			this.sound_volume.Name = "sound_volume";
			this.sound_volume.Size = new System.Drawing.Size(262, 45);
			this.sound_volume.TabIndex = 30;
			this.sound_volume.TickFrequency = 5;
			this.sound_volume.Value = 50;
			this.sound_volume.Scroll += new System.EventHandler(this.sound_volume_Scroll);
			// 
			// btn_sound_pause
			// 
			this.btn_sound_pause.Enabled = false;
			this.btn_sound_pause.Location = new System.Drawing.Point(384, 310);
			this.btn_sound_pause.Name = "btn_sound_pause";
			this.btn_sound_pause.Size = new System.Drawing.Size(75, 23);
			this.btn_sound_pause.TabIndex = 31;
			this.btn_sound_pause.Text = "Pause";
			this.btn_sound_pause.UseVisualStyleBackColor = true;
			this.btn_sound_pause.Click += new System.EventHandler(this.btn_sound_pause_Click);
			// 
			// btn_sound_stop
			// 
			this.btn_sound_stop.Enabled = false;
			this.btn_sound_stop.Location = new System.Drawing.Point(492, 309);
			this.btn_sound_stop.Name = "btn_sound_stop";
			this.btn_sound_stop.Size = new System.Drawing.Size(75, 23);
			this.btn_sound_stop.TabIndex = 32;
			this.btn_sound_stop.Text = "Stop";
			this.btn_sound_stop.UseVisualStyleBackColor = true;
			this.btn_sound_stop.Click += new System.EventHandler(this.btn_sound_stop_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(114, 315);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 13);
			this.label7.TabIndex = 33;
			this.label7.Text = "Timersteuerung";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(434, 288);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(85, 13);
			this.label8.TabIndex = 34;
			this.label8.Text = "Soundsteuerung";
			// 
			// time_over_game
			// 
			this.time_over_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.time_over_game.Location = new System.Drawing.Point(53, 272);
			this.time_over_game.Name = "time_over_game";
			this.time_over_game.Size = new System.Drawing.Size(190, 30);
			this.time_over_game.TabIndex = 35;
			this.time_over_game.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(126, 90);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(45, 13);
			this.label9.TabIndex = 36;
			this.label9.Text = "Halbzeit";
			// 
			// btn_open_mid
			// 
			this.btn_open_mid.Location = new System.Drawing.Point(251, 148);
			this.btn_open_mid.Name = "btn_open_mid";
			this.btn_open_mid.Size = new System.Drawing.Size(37, 23);
			this.btn_open_mid.TabIndex = 37;
			this.btn_open_mid.Text = "...";
			this.btn_open_mid.UseVisualStyleBackColor = true;
			this.btn_open_mid.Click += new System.EventHandler(this.btn_open_mid_Click);
			// 
			// textBox_mid_song_direc
			// 
			this.textBox_mid_song_direc.Location = new System.Drawing.Point(39, 148);
			this.textBox_mid_song_direc.Name = "textBox_mid_song_direc";
			this.textBox_mid_song_direc.ReadOnly = true;
			this.textBox_mid_song_direc.Size = new System.Drawing.Size(199, 20);
			this.textBox_mid_song_direc.TabIndex = 38;
			// 
			// checkBox_begin_song
			// 
			this.checkBox_begin_song.AutoSize = true;
			this.checkBox_begin_song.Checked = true;
			this.checkBox_begin_song.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_begin_song.Location = new System.Drawing.Point(14, 28);
			this.checkBox_begin_song.Name = "checkBox_begin_song";
			this.checkBox_begin_song.Size = new System.Drawing.Size(15, 14);
			this.checkBox_begin_song.TabIndex = 39;
			this.checkBox_begin_song.UseVisualStyleBackColor = true;
			this.checkBox_begin_song.CheckedChanged += new System.EventHandler(this.checkBox_begin_song_CheckedChanged);
			// 
			// checkBox_mid_song
			// 
			this.checkBox_mid_song.AutoSize = true;
			this.checkBox_mid_song.Checked = true;
			this.checkBox_mid_song.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_mid_song.Location = new System.Drawing.Point(14, 119);
			this.checkBox_mid_song.Name = "checkBox_mid_song";
			this.checkBox_mid_song.Size = new System.Drawing.Size(15, 14);
			this.checkBox_mid_song.TabIndex = 40;
			this.checkBox_mid_song.UseVisualStyleBackColor = true;
			this.checkBox_mid_song.CheckedChanged += new System.EventHandler(this.checkBox_mid_song_CheckedChanged);
			// 
			// checkBox_end_song
			// 
			this.checkBox_end_song.AutoSize = true;
			this.checkBox_end_song.Checked = true;
			this.checkBox_end_song.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_end_song.Location = new System.Drawing.Point(13, 301);
			this.checkBox_end_song.Name = "checkBox_end_song";
			this.checkBox_end_song.Size = new System.Drawing.Size(15, 14);
			this.checkBox_end_song.TabIndex = 41;
			this.checkBox_end_song.UseVisualStyleBackColor = true;
			this.checkBox_end_song.CheckedChanged += new System.EventHandler(this.checkBox_end_song_CheckedChanged);
			// 
			// open_mid_file
			// 
			this.open_mid_file.Filter = "Alle Dateien| *.*|mp3-Dateien|*.mp3|WAV-Dateien|*.wav";
			this.open_mid_file.SupportMultiDottedExtensions = true;
			// 
			// radioButton_begin_choose
			// 
			this.radioButton_begin_choose.Checked = true;
			this.radioButton_begin_choose.Location = new System.Drawing.Point(8, 14);
			this.radioButton_begin_choose.Name = "radioButton_begin_choose";
			this.radioButton_begin_choose.Size = new System.Drawing.Size(65, 24);
			this.radioButton_begin_choose.TabIndex = 42;
			this.radioButton_begin_choose.TabStop = true;
			this.radioButton_begin_choose.Text = "Auswahl";
			this.radioButton_begin_choose.UseVisualStyleBackColor = true;
			this.radioButton_begin_choose.CheckedChanged += new System.EventHandler(this.radioButton_begin_choose_CheckedChanged);
			// 
			// radioButton_begin_random
			// 
			this.radioButton_begin_random.Location = new System.Drawing.Point(84, 14);
			this.radioButton_begin_random.Name = "radioButton_begin_random";
			this.radioButton_begin_random.Size = new System.Drawing.Size(65, 24);
			this.radioButton_begin_random.TabIndex = 43;
			this.radioButton_begin_random.Text = "Zufällig";
			this.radioButton_begin_random.UseVisualStyleBackColor = true;
			this.radioButton_begin_random.CheckedChanged += new System.EventHandler(this.radioButton_begin_random_CheckedChanged);
			// 
			// groupBox_begin
			// 
			this.groupBox_begin.Controls.Add(this.radioButton_begin_choose);
			this.groupBox_begin.Controls.Add(this.radioButton_begin_random);
			this.groupBox_begin.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox_begin.Location = new System.Drawing.Point(64, 10);
			this.groupBox_begin.Name = "groupBox_begin";
			this.groupBox_begin.Size = new System.Drawing.Size(158, 46);
			this.groupBox_begin.TabIndex = 51;
			this.groupBox_begin.TabStop = false;
			// 
			// groupBox_mid
			// 
			this.groupBox_mid.Controls.Add(this.radioButton_mid_choose);
			this.groupBox_mid.Controls.Add(this.radioButton_mid_random);
			this.groupBox_mid.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox_mid.Location = new System.Drawing.Point(64, 99);
			this.groupBox_mid.Name = "groupBox_mid";
			this.groupBox_mid.Size = new System.Drawing.Size(159, 46);
			this.groupBox_mid.TabIndex = 52;
			this.groupBox_mid.TabStop = false;
			// 
			// radioButton_mid_choose
			// 
			this.radioButton_mid_choose.Checked = true;
			this.radioButton_mid_choose.Location = new System.Drawing.Point(8, 14);
			this.radioButton_mid_choose.Name = "radioButton_mid_choose";
			this.radioButton_mid_choose.Size = new System.Drawing.Size(65, 24);
			this.radioButton_mid_choose.TabIndex = 42;
			this.radioButton_mid_choose.TabStop = true;
			this.radioButton_mid_choose.Text = "Auswahl";
			this.radioButton_mid_choose.UseVisualStyleBackColor = true;
			this.radioButton_mid_choose.CheckedChanged += new System.EventHandler(this.radioButton_mid_choose_CheckedChanged);
			// 
			// radioButton_mid_random
			// 
			this.radioButton_mid_random.Location = new System.Drawing.Point(84, 14);
			this.radioButton_mid_random.Name = "radioButton_mid_random";
			this.radioButton_mid_random.Size = new System.Drawing.Size(65, 24);
			this.radioButton_mid_random.TabIndex = 43;
			this.radioButton_mid_random.Text = "Zufällig";
			this.radioButton_mid_random.UseVisualStyleBackColor = true;
			this.radioButton_mid_random.CheckedChanged += new System.EventHandler(this.radioButton_mid_random_CheckedChanged);
			// 
			// groupBox_end
			// 
			this.groupBox_end.Controls.Add(this.radioButton_end_choose);
			this.groupBox_end.Controls.Add(this.radioButton_end_random);
			this.groupBox_end.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox_end.Location = new System.Drawing.Point(64, 281);
			this.groupBox_end.Name = "groupBox_end";
			this.groupBox_end.Size = new System.Drawing.Size(159, 46);
			this.groupBox_end.TabIndex = 53;
			this.groupBox_end.TabStop = false;
			// 
			// radioButton_end_choose
			// 
			this.radioButton_end_choose.Checked = true;
			this.radioButton_end_choose.Location = new System.Drawing.Point(8, 14);
			this.radioButton_end_choose.Name = "radioButton_end_choose";
			this.radioButton_end_choose.Size = new System.Drawing.Size(65, 24);
			this.radioButton_end_choose.TabIndex = 42;
			this.radioButton_end_choose.TabStop = true;
			this.radioButton_end_choose.Text = "Auswahl";
			this.radioButton_end_choose.UseVisualStyleBackColor = true;
			this.radioButton_end_choose.CheckedChanged += new System.EventHandler(this.radioButton_end_choose_CheckedChanged);
			// 
			// radioButton_end_random
			// 
			this.radioButton_end_random.Location = new System.Drawing.Point(84, 14);
			this.radioButton_end_random.Name = "radioButton_end_random";
			this.radioButton_end_random.Size = new System.Drawing.Size(69, 24);
			this.radioButton_end_random.TabIndex = 43;
			this.radioButton_end_random.Text = "Zufällig";
			this.radioButton_end_random.UseVisualStyleBackColor = true;
			this.radioButton_end_random.CheckedChanged += new System.EventHandler(this.radioButton_end_random_CheckedChanged);
			// 
			// label10
			// 
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label10.Location = new System.Drawing.Point(20, 85);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(264, 2);
			this.label10.TabIndex = 54;
			this.label10.Text = "label10";
			// 
			// label11
			// 
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label11.Location = new System.Drawing.Point(20, 174);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(264, 2);
			this.label11.TabIndex = 55;
			this.label11.Text = "label11";
			// 
			// btn_extern_view
			// 
			this.btn_extern_view.Enabled = false;
			this.btn_extern_view.Location = new System.Drawing.Point(379, 397);
			this.btn_extern_view.Name = "btn_extern_view";
			this.btn_extern_view.Size = new System.Drawing.Size(140, 23);
			this.btn_extern_view.TabIndex = 56;
			this.btn_extern_view.Text = "Verstecke ext. Fenster";
			this.btn_extern_view.UseVisualStyleBackColor = true;
			this.btn_extern_view.Click += new System.EventHandler(this.btn_extern_view_Click);
			// 
			// label12
			// 
			this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label12.Location = new System.Drawing.Point(20, 265);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(264, 2);
			this.label12.TabIndex = 57;
			this.label12.Text = "label12";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.SystemColors.Control;
			this.label13.Location = new System.Drawing.Point(101, 178);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(92, 13);
			this.label13.TabIndex = 58;
			this.label13.Text = "Letzten 2 Minuten";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox_last_minute
			// 
			this.groupBox_last_minute.Controls.Add(this.radioButton_last_minute_choose);
			this.groupBox_last_minute.Controls.Add(this.radioButton_last_minute_random);
			this.groupBox_last_minute.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox_last_minute.Location = new System.Drawing.Point(64, 189);
			this.groupBox_last_minute.Name = "groupBox_last_minute";
			this.groupBox_last_minute.Size = new System.Drawing.Size(158, 46);
			this.groupBox_last_minute.TabIndex = 52;
			this.groupBox_last_minute.TabStop = false;
			// 
			// radioButton_last_minute_choose
			// 
			this.radioButton_last_minute_choose.Checked = true;
			this.radioButton_last_minute_choose.Location = new System.Drawing.Point(8, 14);
			this.radioButton_last_minute_choose.Name = "radioButton_last_minute_choose";
			this.radioButton_last_minute_choose.Size = new System.Drawing.Size(65, 24);
			this.radioButton_last_minute_choose.TabIndex = 42;
			this.radioButton_last_minute_choose.TabStop = true;
			this.radioButton_last_minute_choose.Text = "Auswahl";
			this.radioButton_last_minute_choose.UseVisualStyleBackColor = true;
			this.radioButton_last_minute_choose.CheckedChanged += new System.EventHandler(this.radioButton_last_minute_choose_CheckedChanged);
			// 
			// radioButton_last_minute_random
			// 
			this.radioButton_last_minute_random.Location = new System.Drawing.Point(84, 14);
			this.radioButton_last_minute_random.Name = "radioButton_last_minute_random";
			this.radioButton_last_minute_random.Size = new System.Drawing.Size(65, 24);
			this.radioButton_last_minute_random.TabIndex = 43;
			this.radioButton_last_minute_random.Text = "Zufällig";
			this.radioButton_last_minute_random.UseVisualStyleBackColor = true;
			this.radioButton_last_minute_random.CheckedChanged += new System.EventHandler(this.radioButton_last_minute_random_CheckedChanged);
			// 
			// textBox_last_minute_song_direc
			// 
			this.textBox_last_minute_song_direc.Location = new System.Drawing.Point(39, 238);
			this.textBox_last_minute_song_direc.Name = "textBox_last_minute_song_direc";
			this.textBox_last_minute_song_direc.ReadOnly = true;
			this.textBox_last_minute_song_direc.Size = new System.Drawing.Size(199, 20);
			this.textBox_last_minute_song_direc.TabIndex = 60;
			// 
			// btn_open_last_minute
			// 
			this.btn_open_last_minute.Location = new System.Drawing.Point(251, 238);
			this.btn_open_last_minute.Name = "btn_open_last_minute";
			this.btn_open_last_minute.Size = new System.Drawing.Size(37, 23);
			this.btn_open_last_minute.TabIndex = 59;
			this.btn_open_last_minute.Text = "...";
			this.btn_open_last_minute.UseVisualStyleBackColor = true;
			this.btn_open_last_minute.Click += new System.EventHandler(this.btn_open_last_minute_Click);
			// 
			// checkBox_last_minute_song
			// 
			this.checkBox_last_minute_song.AutoSize = true;
			this.checkBox_last_minute_song.Checked = true;
			this.checkBox_last_minute_song.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_last_minute_song.Location = new System.Drawing.Point(14, 207);
			this.checkBox_last_minute_song.Name = "checkBox_last_minute_song";
			this.checkBox_last_minute_song.Size = new System.Drawing.Size(15, 14);
			this.checkBox_last_minute_song.TabIndex = 61;
			this.checkBox_last_minute_song.UseVisualStyleBackColor = true;
			this.checkBox_last_minute_song.CheckedChanged += new System.EventHandler(this.checkBox_last_minute_song_CheckedChanged);
			// 
			// open_last_minute_file
			// 
			this.open_last_minute_file.Filter = "Alle Dateien| *.*|mp3-Dateien|*.mp3|WAV-Dateien|*.wav";
			this.open_last_minute_file.SupportMultiDottedExtensions = true;
			// 
			// label_about
			// 
			this.label_about.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_about.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_about.Location = new System.Drawing.Point(289, 494);
			this.label_about.Name = "label_about";
			this.label_about.Size = new System.Drawing.Size(18, 17);
			this.label_about.TabIndex = 63;
			this.label_about.Text = "?";
			this.label_about.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label_about.Click += new System.EventHandler(this.label_about_Click);
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(171, 31);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(64, 16);
			this.label18.TabIndex = 73;
			this.label18.Text = "Sekunden";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(120, 31);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(55, 16);
			this.label19.TabIndex = 72;
			this.label19.Text = "Minuten";
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(68, 31);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(55, 16);
			this.label20.TabIndex = 71;
			this.label20.Text = "Stunden";
			// 
			// btn_save_pause
			// 
			this.btn_save_pause.Location = new System.Drawing.Point(108, 76);
			this.btn_save_pause.Name = "btn_save_pause";
			this.btn_save_pause.Size = new System.Drawing.Size(86, 23);
			this.btn_save_pause.TabIndex = 70;
			this.btn_save_pause.Text = "Übernehmen";
			this.btn_save_pause.UseVisualStyleBackColor = true;
			this.btn_save_pause.Click += new System.EventHandler(this.Btn_save_pauseClick);
			// 
			// seconds_input_pause
			// 
			this.seconds_input_pause.Location = new System.Drawing.Point(173, 50);
			this.seconds_input_pause.Maximum = new decimal(new int[] {
									59,
									0,
									0,
									0});
			this.seconds_input_pause.Name = "seconds_input_pause";
			this.seconds_input_pause.Size = new System.Drawing.Size(46, 20);
			this.seconds_input_pause.TabIndex = 69;
			// 
			// minutes_input_pause
			// 
			this.minutes_input_pause.Location = new System.Drawing.Point(121, 50);
			this.minutes_input_pause.Maximum = new decimal(new int[] {
									59,
									0,
									0,
									0});
			this.minutes_input_pause.Name = "minutes_input_pause";
			this.minutes_input_pause.Size = new System.Drawing.Size(46, 20);
			this.minutes_input_pause.TabIndex = 68;
			// 
			// hours_input_pause
			// 
			this.hours_input_pause.Location = new System.Drawing.Point(69, 50);
			this.hours_input_pause.Maximum = new decimal(new int[] {
									24,
									0,
									0,
									0});
			this.hours_input_pause.Name = "hours_input_pause";
			this.hours_input_pause.Size = new System.Drawing.Size(46, 20);
			this.hours_input_pause.TabIndex = 67;
			// 
			// time_over_pause
			// 
			this.time_over_pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.time_over_pause.Location = new System.Drawing.Point(53, 180);
			this.time_over_pause.Name = "time_over_pause";
			this.time_over_pause.Size = new System.Drawing.Size(190, 30);
			this.time_over_pause.TabIndex = 77;
			this.time_over_pause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label22
			// 
			this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label22.Location = new System.Drawing.Point(17, 103);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(264, 2);
			this.label22.TabIndex = 76;
			this.label22.Text = "label6";
			// 
			// label23
			// 
			this.label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label23.Location = new System.Drawing.Point(17, 211);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(264, 2);
			this.label23.TabIndex = 75;
			this.label23.Text = "label5";
			// 
			// time_show_pause
			// 
			this.time_show_pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.time_show_pause.Location = new System.Drawing.Point(17, 112);
			this.time_show_pause.Name = "time_show_pause";
			this.time_show_pause.Size = new System.Drawing.Size(262, 78);
			this.time_show_pause.TabIndex = 74;
			this.time_show_pause.Text = "00:00:00";
			this.time_show_pause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(114, 223);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(80, 13);
			this.label25.TabIndex = 82;
			this.label25.Text = "Timersteuerung";
			// 
			// label26
			// 
			this.label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label26.Location = new System.Drawing.Point(16, 288);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(264, 2);
			this.label26.TabIndex = 81;
			this.label26.Text = "label4";
			// 
			// btn_stop_pause
			// 
			this.btn_stop_pause.Enabled = false;
			this.btn_stop_pause.Location = new System.Drawing.Point(211, 244);
			this.btn_stop_pause.Name = "btn_stop_pause";
			this.btn_stop_pause.Size = new System.Drawing.Size(75, 23);
			this.btn_stop_pause.TabIndex = 80;
			this.btn_stop_pause.Text = "Stop";
			this.btn_stop_pause.UseVisualStyleBackColor = true;
			this.btn_stop_pause.Click += new System.EventHandler(this.Btn_stop_pauseClick);
			// 
			// btn_pause_pause
			// 
			this.btn_pause_pause.Enabled = false;
			this.btn_pause_pause.Location = new System.Drawing.Point(119, 244);
			this.btn_pause_pause.Name = "btn_pause_pause";
			this.btn_pause_pause.Size = new System.Drawing.Size(75, 23);
			this.btn_pause_pause.TabIndex = 79;
			this.btn_pause_pause.Text = "Pause";
			this.btn_pause_pause.UseVisualStyleBackColor = true;
			this.btn_pause_pause.Click += new System.EventHandler(this.Btn_pause_pauseClick);
			// 
			// btn_start_pause
			// 
			this.btn_start_pause.Enabled = false;
			this.btn_start_pause.Location = new System.Drawing.Point(26, 244);
			this.btn_start_pause.Name = "btn_start_pause";
			this.btn_start_pause.Size = new System.Drawing.Size(75, 23);
			this.btn_start_pause.TabIndex = 78;
			this.btn_start_pause.Text = "Start";
			this.btn_start_pause.UseVisualStyleBackColor = true;
			this.btn_start_pause.Click += new System.EventHandler(this.Btn_start_pauseClick);
			// 
			// btn_reset_pause
			// 
			this.btn_reset_pause.Enabled = false;
			this.btn_reset_pause.Location = new System.Drawing.Point(211, 410);
			this.btn_reset_pause.Name = "btn_reset_pause";
			this.btn_reset_pause.Size = new System.Drawing.Size(75, 23);
			this.btn_reset_pause.TabIndex = 83;
			this.btn_reset_pause.Text = "Reset";
			this.btn_reset_pause.UseVisualStyleBackColor = true;
			this.btn_reset_pause.Click += new System.EventHandler(this.Btn_reset_pauseClick);
			// 
			// timer_pause
			// 
			this.timer_pause.Interval = 1000;
			this.timer_pause.Tick += new System.EventHandler(this.timer_pause_tick);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tab_music);
			this.tabControl1.Controls.Add(this.tab_game);
			this.tabControl1.Controls.Add(this.tab_sponsor);
			this.tabControl1.Controls.Add(this.tab_pause);
			this.tabControl1.Controls.Add(this.tab_spielplan);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tabControl1.Location = new System.Drawing.Point(0, 24);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(310, 465);
			this.tabControl1.TabIndex = 84;
			// 
			// tab_music
			// 
			this.tab_music.BackColor = System.Drawing.SystemColors.Control;
			this.tab_music.Controls.Add(this.label5);
			this.tab_music.Controls.Add(this.label13);
			this.tab_music.Controls.Add(this.label9);
			this.tab_music.Controls.Add(this.label4);
			this.tab_music.Controls.Add(this.groupBox_begin);
			this.tab_music.Controls.Add(this.groupBox_last_minute);
			this.tab_music.Controls.Add(this.groupBox_end);
			this.tab_music.Controls.Add(this.checkBox_last_minute_song);
			this.tab_music.Controls.Add(this.groupBox_mid);
			this.tab_music.Controls.Add(this.textBox_last_minute_song_direc);
			this.tab_music.Controls.Add(this.textBox_begin_song_direc);
			this.tab_music.Controls.Add(this.btn_open_last_minute);
			this.tab_music.Controls.Add(this.textBox_end_song_direc);
			this.tab_music.Controls.Add(this.btn_open_begin);
			this.tab_music.Controls.Add(this.label12);
			this.tab_music.Controls.Add(this.btn_open_end);
			this.tab_music.Controls.Add(this.label11);
			this.tab_music.Controls.Add(this.label10);
			this.tab_music.Controls.Add(this.checkBox_end_song);
			this.tab_music.Controls.Add(this.checkBox_mid_song);
			this.tab_music.Controls.Add(this.checkBox_begin_song);
			this.tab_music.Controls.Add(this.btn_open_mid);
			this.tab_music.Controls.Add(this.textBox_mid_song_direc);
			this.tab_music.Location = new System.Drawing.Point(4, 22);
			this.tab_music.Name = "tab_music";
			this.tab_music.Size = new System.Drawing.Size(302, 439);
			this.tab_music.TabIndex = 3;
			this.tab_music.Text = "Musik";
			// 
			// tab_game
			// 
			this.tab_game.BackColor = System.Drawing.SystemColors.Control;
			this.tab_game.Controls.Add(this.numericUpDown1);
			this.tab_game.Controls.Add(this.label27);
			this.tab_game.Controls.Add(this.label21);
			this.tab_game.Controls.Add(this.time_over_game);
			this.tab_game.Controls.Add(this.time_show_game);
			this.tab_game.Controls.Add(this.sound_volume);
			this.tab_game.Controls.Add(this.btn_start_game);
			this.tab_game.Controls.Add(this.hours_input_game);
			this.tab_game.Controls.Add(this.minutes_input_game);
			this.tab_game.Controls.Add(this.seconds_input_game);
			this.tab_game.Controls.Add(this.btn_pause_game);
			this.tab_game.Controls.Add(this.btn_stop_game);
			this.tab_game.Controls.Add(this.btn_save_game);
			this.tab_game.Controls.Add(this.label1);
			this.tab_game.Controls.Add(this.btn_extern_view);
			this.tab_game.Controls.Add(this.label2);
			this.tab_game.Controls.Add(this.label3);
			this.tab_game.Controls.Add(this.btn_reset_game);
			this.tab_game.Controls.Add(this.separator3);
			this.tab_game.Controls.Add(this.separator2);
			this.tab_game.Controls.Add(this.separator1);
			this.tab_game.Controls.Add(this.btn_sound_pause);
			this.tab_game.Controls.Add(this.btn_sound_stop);
			this.tab_game.Controls.Add(this.label7);
			this.tab_game.Controls.Add(this.label8);
			this.tab_game.Location = new System.Drawing.Point(4, 22);
			this.tab_game.Name = "tab_game";
			this.tab_game.Padding = new System.Windows.Forms.Padding(3);
			this.tab_game.Size = new System.Drawing.Size(302, 439);
			this.tab_game.TabIndex = 0;
			this.tab_game.Text = "Spiel";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(83, 129);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(131, 20);
			this.numericUpDown1.TabIndex = 59;
			// 
			// label27
			// 
			this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label27.Location = new System.Drawing.Point(86, 91);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(131, 23);
			this.label27.TabIndex = 58;
			this.label27.Text = "Zeit bis Wechsel";
			// 
			// label21
			// 
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(94, 9);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(100, 23);
			this.label21.TabIndex = 57;
			this.label21.Text = "Zeit";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tab_sponsor
			// 
			this.tab_sponsor.BackColor = System.Drawing.SystemColors.Control;
			this.tab_sponsor.Controls.Add(this.btn_sponsor_stop);
			this.tab_sponsor.Controls.Add(this.btn_sponsor_start);
			this.tab_sponsor.Controls.Add(this.numericUpDown_sponsor_intervall);
			this.tab_sponsor.Controls.Add(this.btn_open_sponsor);
			this.tab_sponsor.Controls.Add(this.textBox_sponsor_directory);
			this.tab_sponsor.Controls.Add(this.label14);
			this.tab_sponsor.Controls.Add(this.label15);
			this.tab_sponsor.Location = new System.Drawing.Point(4, 22);
			this.tab_sponsor.Name = "tab_sponsor";
			this.tab_sponsor.Size = new System.Drawing.Size(302, 439);
			this.tab_sponsor.TabIndex = 2;
			this.tab_sponsor.Text = "Sponsoren";
			// 
			// btn_sponsor_stop
			// 
			this.btn_sponsor_stop.Enabled = false;
			this.btn_sponsor_stop.Location = new System.Drawing.Point(143, 128);
			this.btn_sponsor_stop.Name = "btn_sponsor_stop";
			this.btn_sponsor_stop.Size = new System.Drawing.Size(75, 23);
			this.btn_sponsor_stop.TabIndex = 58;
			this.btn_sponsor_stop.Text = "Stop";
			this.btn_sponsor_stop.UseVisualStyleBackColor = true;
			this.btn_sponsor_stop.Click += new System.EventHandler(this.Btn_sponsor_stopClick);
			// 
			// btn_sponsor_start
			// 
			this.btn_sponsor_start.Enabled = false;
			this.btn_sponsor_start.Location = new System.Drawing.Point(44, 128);
			this.btn_sponsor_start.Name = "btn_sponsor_start";
			this.btn_sponsor_start.Size = new System.Drawing.Size(75, 23);
			this.btn_sponsor_start.TabIndex = 57;
			this.btn_sponsor_start.Text = "Start";
			this.btn_sponsor_start.UseVisualStyleBackColor = true;
			this.btn_sponsor_start.Click += new System.EventHandler(this.Btn_sponsor_startClick);
			// 
			// numericUpDown_sponsor_intervall
			// 
			this.numericUpDown_sponsor_intervall.Location = new System.Drawing.Point(19, 84);
			this.numericUpDown_sponsor_intervall.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.numericUpDown_sponsor_intervall.Name = "numericUpDown_sponsor_intervall";
			this.numericUpDown_sponsor_intervall.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown_sponsor_intervall.TabIndex = 56;
			this.numericUpDown_sponsor_intervall.Value = new decimal(new int[] {
									5,
									0,
									0,
									0});
			// 
			// btn_open_sponsor
			// 
			this.btn_open_sponsor.Location = new System.Drawing.Point(232, 28);
			this.btn_open_sponsor.Name = "btn_open_sponsor";
			this.btn_open_sponsor.Size = new System.Drawing.Size(37, 23);
			this.btn_open_sponsor.TabIndex = 53;
			this.btn_open_sponsor.Text = "...";
			this.btn_open_sponsor.UseVisualStyleBackColor = true;
			this.btn_open_sponsor.Click += new System.EventHandler(this.Btn_open_sponsorClick);
			// 
			// textBox_sponsor_directory
			// 
			this.textBox_sponsor_directory.Location = new System.Drawing.Point(19, 28);
			this.textBox_sponsor_directory.Name = "textBox_sponsor_directory";
			this.textBox_sponsor_directory.ReadOnly = true;
			this.textBox_sponsor_directory.Size = new System.Drawing.Size(199, 20);
			this.textBox_sponsor_directory.TabIndex = 52;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(19, 13);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(100, 23);
			this.label14.TabIndex = 59;
			this.label14.Text = "Sponsoren-Logos";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(19, 69);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(120, 23);
			this.label15.TabIndex = 60;
			this.label15.Text = "Intervall in Sekunden";
			// 
			// tab_pause
			// 
			this.tab_pause.BackColor = System.Drawing.SystemColors.Control;
			this.tab_pause.Controls.Add(this.label6);
			this.tab_pause.Controls.Add(this.btn_pause_sound_start);
			this.tab_pause.Controls.Add(this.btn_pause_sound_stop);
			this.tab_pause.Controls.Add(this.textBox_pause);
			this.tab_pause.Controls.Add(this.btn_open_pause);
			this.tab_pause.Controls.Add(this.btn_reset_pause);
			this.tab_pause.Controls.Add(this.hours_input_pause);
			this.tab_pause.Controls.Add(this.label25);
			this.tab_pause.Controls.Add(this.minutes_input_pause);
			this.tab_pause.Controls.Add(this.label26);
			this.tab_pause.Controls.Add(this.seconds_input_pause);
			this.tab_pause.Controls.Add(this.btn_stop_pause);
			this.tab_pause.Controls.Add(this.btn_save_pause);
			this.tab_pause.Controls.Add(this.btn_pause_pause);
			this.tab_pause.Controls.Add(this.label20);
			this.tab_pause.Controls.Add(this.btn_start_pause);
			this.tab_pause.Controls.Add(this.label19);
			this.tab_pause.Controls.Add(this.time_over_pause);
			this.tab_pause.Controls.Add(this.label18);
			this.tab_pause.Controls.Add(this.label22);
			this.tab_pause.Controls.Add(this.time_show_pause);
			this.tab_pause.Controls.Add(this.label23);
			this.tab_pause.Location = new System.Drawing.Point(4, 22);
			this.tab_pause.Name = "tab_pause";
			this.tab_pause.Padding = new System.Windows.Forms.Padding(3);
			this.tab_pause.Size = new System.Drawing.Size(302, 439);
			this.tab_pause.TabIndex = 1;
			this.tab_pause.Text = "Pause";
			// 
			// label6
			// 
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label6.Location = new System.Drawing.Point(19, 397);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(264, 2);
			this.label6.TabIndex = 88;
			this.label6.Text = "label4";
			// 
			// btn_pause_sound_start
			// 
			this.btn_pause_sound_start.Enabled = false;
			this.btn_pause_sound_start.Location = new System.Drawing.Point(60, 361);
			this.btn_pause_sound_start.Name = "btn_pause_sound_start";
			this.btn_pause_sound_start.Size = new System.Drawing.Size(75, 23);
			this.btn_pause_sound_start.TabIndex = 86;
			this.btn_pause_sound_start.Text = "Start";
			this.btn_pause_sound_start.UseVisualStyleBackColor = true;
			this.btn_pause_sound_start.Click += new System.EventHandler(this.Btn_pause_sound_startClick);
			// 
			// btn_pause_sound_stop
			// 
			this.btn_pause_sound_stop.Enabled = false;
			this.btn_pause_sound_stop.Location = new System.Drawing.Point(168, 360);
			this.btn_pause_sound_stop.Name = "btn_pause_sound_stop";
			this.btn_pause_sound_stop.Size = new System.Drawing.Size(75, 23);
			this.btn_pause_sound_stop.TabIndex = 87;
			this.btn_pause_sound_stop.Text = "Stop";
			this.btn_pause_sound_stop.UseVisualStyleBackColor = true;
			this.btn_pause_sound_stop.Click += new System.EventHandler(this.Btn_pause_sound_stopClick);
			// 
			// textBox_pause
			// 
			this.textBox_pause.Location = new System.Drawing.Point(26, 326);
			this.textBox_pause.Name = "textBox_pause";
			this.textBox_pause.ReadOnly = true;
			this.textBox_pause.Size = new System.Drawing.Size(199, 20);
			this.textBox_pause.TabIndex = 84;
			// 
			// btn_open_pause
			// 
			this.btn_open_pause.Location = new System.Drawing.Point(239, 326);
			this.btn_open_pause.Name = "btn_open_pause";
			this.btn_open_pause.Size = new System.Drawing.Size(37, 23);
			this.btn_open_pause.TabIndex = 85;
			this.btn_open_pause.Text = "...";
			this.btn_open_pause.UseVisualStyleBackColor = true;
			this.btn_open_pause.Click += new System.EventHandler(this.Btn_open_pauseClick);
			// 
			// tab_spielplan
			// 
			this.tab_spielplan.BackColor = System.Drawing.SystemColors.Control;
			this.tab_spielplan.Controls.Add(this.numericUpDown_spielplan_dauer);
			this.tab_spielplan.Controls.Add(this.label24);
			this.tab_spielplan.Controls.Add(this.btn_spielplan_reset);
			this.tab_spielplan.Controls.Add(this.btn_spielplan_accept);
			this.tab_spielplan.Controls.Add(this.numericUpDown_spielplan_intervall);
			this.tab_spielplan.Controls.Add(this.label17);
			this.tab_spielplan.Controls.Add(this.btn_open_spielplan);
			this.tab_spielplan.Controls.Add(this.textBox_spielplan);
			this.tab_spielplan.Controls.Add(this.label16);
			this.tab_spielplan.Location = new System.Drawing.Point(4, 22);
			this.tab_spielplan.Name = "tab_spielplan";
			this.tab_spielplan.Size = new System.Drawing.Size(302, 439);
			this.tab_spielplan.TabIndex = 4;
			this.tab_spielplan.Text = "Spielplan";
			// 
			// numericUpDown_spielplan_dauer
			// 
			this.numericUpDown_spielplan_dauer.Location = new System.Drawing.Point(149, 84);
			this.numericUpDown_spielplan_dauer.Maximum = new decimal(new int[] {
									99,
									0,
									0,
									0});
			this.numericUpDown_spielplan_dauer.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.numericUpDown_spielplan_dauer.Name = "numericUpDown_spielplan_dauer";
			this.numericUpDown_spielplan_dauer.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown_spielplan_dauer.TabIndex = 67;
			this.numericUpDown_spielplan_dauer.Value = new decimal(new int[] {
									20,
									0,
									0,
									0});
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(149, 69);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(120, 23);
			this.label24.TabIndex = 68;
			this.label24.Text = "Dauer in Sekunden";
			// 
			// btn_spielplan_reset
			// 
			this.btn_spielplan_reset.Enabled = false;
			this.btn_spielplan_reset.Location = new System.Drawing.Point(102, 160);
			this.btn_spielplan_reset.Name = "btn_spielplan_reset";
			this.btn_spielplan_reset.Size = new System.Drawing.Size(86, 23);
			this.btn_spielplan_reset.TabIndex = 66;
			this.btn_spielplan_reset.Text = "Reset";
			this.btn_spielplan_reset.UseVisualStyleBackColor = true;
			this.btn_spielplan_reset.Click += new System.EventHandler(this.Btn_spielplan_resetClick);
			// 
			// btn_spielplan_accept
			// 
			this.btn_spielplan_accept.Enabled = false;
			this.btn_spielplan_accept.Location = new System.Drawing.Point(102, 122);
			this.btn_spielplan_accept.Name = "btn_spielplan_accept";
			this.btn_spielplan_accept.Size = new System.Drawing.Size(86, 23);
			this.btn_spielplan_accept.TabIndex = 65;
			this.btn_spielplan_accept.Text = "Übernehmen";
			this.btn_spielplan_accept.UseVisualStyleBackColor = true;
			this.btn_spielplan_accept.Click += new System.EventHandler(this.Btn_spielplan_acceptClick);
			// 
			// numericUpDown_spielplan_intervall
			// 
			this.numericUpDown_spielplan_intervall.Location = new System.Drawing.Point(19, 84);
			this.numericUpDown_spielplan_intervall.Minimum = new decimal(new int[] {
									2,
									0,
									0,
									0});
			this.numericUpDown_spielplan_intervall.Name = "numericUpDown_spielplan_intervall";
			this.numericUpDown_spielplan_intervall.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown_spielplan_intervall.TabIndex = 63;
			this.numericUpDown_spielplan_intervall.Value = new decimal(new int[] {
									20,
									0,
									0,
									0});
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(19, 69);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(120, 23);
			this.label17.TabIndex = 64;
			this.label17.Text = "Intervall in Sekunden";
			// 
			// btn_open_spielplan
			// 
			this.btn_open_spielplan.Location = new System.Drawing.Point(232, 28);
			this.btn_open_spielplan.Name = "btn_open_spielplan";
			this.btn_open_spielplan.Size = new System.Drawing.Size(37, 23);
			this.btn_open_spielplan.TabIndex = 61;
			this.btn_open_spielplan.Text = "...";
			this.btn_open_spielplan.UseVisualStyleBackColor = true;
			this.btn_open_spielplan.Click += new System.EventHandler(this.Btn_open_spielplanClick);
			// 
			// textBox_spielplan
			// 
			this.textBox_spielplan.Location = new System.Drawing.Point(19, 28);
			this.textBox_spielplan.Name = "textBox_spielplan";
			this.textBox_spielplan.ReadOnly = true;
			this.textBox_spielplan.Size = new System.Drawing.Size(199, 20);
			this.textBox_spielplan.TabIndex = 60;
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(19, 13);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(100, 23);
			this.label16.TabIndex = 62;
			this.label16.Text = "Spielplan (html)";
			// 
			// open_spielplan_file
			// 
			this.open_spielplan_file.FileName = "openFileDialog1";
			this.open_spielplan_file.Filter = "HTML-Dateien|*.htm*";
			// 
			// open_pause_file
			// 
			this.open_pause_file.FileName = "openFileDialog1";
			// 
			// timer_wait
			// 
			this.timer_wait.Interval = 1000;
			this.timer_wait.Tick += new System.EventHandler(this.Timer_waitTick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.dateiToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.menuStrip1.Size = new System.Drawing.Size(310, 24);
			this.menuStrip1.TabIndex = 44;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// dateiToolStripMenuItem
			// 
			this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.einstellungenÖffnenToolStripMenuItem,
									this.einstellungenSpeichernToolStripMenuItem,
									this.schließenToolStripMenuItem});
			this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
			this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.dateiToolStripMenuItem.Text = "Datei";
			// 
			// einstellungenÖffnenToolStripMenuItem
			// 
			this.einstellungenÖffnenToolStripMenuItem.Name = "einstellungenÖffnenToolStripMenuItem";
			this.einstellungenÖffnenToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.einstellungenÖffnenToolStripMenuItem.Text = "Einstellungen öffnen";
			this.einstellungenÖffnenToolStripMenuItem.Click += new System.EventHandler(this.EinstellungenÖffnenToolStripMenuItemClick);
			// 
			// einstellungenSpeichernToolStripMenuItem
			// 
			this.einstellungenSpeichernToolStripMenuItem.Name = "einstellungenSpeichernToolStripMenuItem";
			this.einstellungenSpeichernToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.einstellungenSpeichernToolStripMenuItem.Text = "Einstellungen speichern";
			this.einstellungenSpeichernToolStripMenuItem.Click += new System.EventHandler(this.EinstellungenSpeichernToolStripMenuItemClick);
			// 
			// schließenToolStripMenuItem
			// 
			this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
			this.schließenToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.schließenToolStripMenuItem.Text = "Schließen";
			this.schließenToolStripMenuItem.Click += new System.EventHandler(this.SchließenToolStripMenuItemClick);
			// 
			// open_settings
			// 
			this.open_settings.Filter = "Konfigurationsdateien|*.cfg";
			// 
			// save_settings
			// 
			this.save_settings.DefaultExt = "cfg";
			this.save_settings.Filter = "Konfigurationsdateien|*.cfg";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(310, 514);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.label_about);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.statusStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Timer";
			((System.ComponentModel.ISupportInitialize)(this.hours_input_game)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minutes_input_game)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.seconds_input_game)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.sound_volume)).EndInit();
			this.groupBox_begin.ResumeLayout(false);
			this.groupBox_mid.ResumeLayout(false);
			this.groupBox_end.ResumeLayout(false);
			this.groupBox_last_minute.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.seconds_input_pause)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minutes_input_pause)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hours_input_pause)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tab_music.ResumeLayout(false);
			this.tab_music.PerformLayout();
			this.tab_game.ResumeLayout(false);
			this.tab_game.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.tab_sponsor.ResumeLayout(false);
			this.tab_sponsor.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sponsor_intervall)).EndInit();
			this.tab_pause.ResumeLayout(false);
			this.tab_pause.PerformLayout();
			this.tab_spielplan.ResumeLayout(false);
			this.tab_spielplan.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_spielplan_dauer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_spielplan_intervall)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
        }
		private System.Windows.Forms.SaveFileDialog save_settings;
		private System.Windows.Forms.OpenFileDialog open_settings;
		private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem einstellungenSpeichernToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem einstellungenÖffnenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Timer timer_wait;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.OpenFileDialog open_pause_file;
		private System.Windows.Forms.Button btn_open_pause;
		private System.Windows.Forms.Button btn_pause_sound_stop;
		private System.Windows.Forms.Button btn_pause_sound_start;
		private System.Windows.Forms.TextBox textBox_pause;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.NumericUpDown numericUpDown_spielplan_dauer;
		private System.Windows.Forms.Button btn_sponsor_stop;
		private System.Windows.Forms.Button btn_sponsor_start;
		private System.Windows.Forms.Button btn_spielplan_accept;
		private System.Windows.Forms.Button btn_spielplan_reset;
		private System.Windows.Forms.OpenFileDialog open_spielplan_file;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox textBox_spielplan;
		private System.Windows.Forms.Button btn_open_spielplan;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.NumericUpDown numericUpDown_spielplan_intervall;
		private System.Windows.Forms.TabPage tab_spielplan;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.NumericUpDown numericUpDown_sponsor_intervall;
		private System.Windows.Forms.FolderBrowserDialog open_sponsor_folder;
		private System.Windows.Forms.TabPage tab_music;
		private System.Windows.Forms.TextBox textBox_sponsor_directory;
		private System.Windows.Forms.Button btn_open_sponsor;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TabPage tab_sponsor;
		private System.Windows.Forms.TabPage tab_pause;
		private System.Windows.Forms.TabPage tab_game;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Timer timer_pause;
		private System.Windows.Forms.Button btn_reset_pause;
		private System.Windows.Forms.Button btn_start_pause;
		private System.Windows.Forms.Button btn_pause_pause;
		private System.Windows.Forms.Button btn_stop_pause;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label time_show_pause;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label time_over_pause;
		private System.Windows.Forms.NumericUpDown hours_input_pause;
		private System.Windows.Forms.NumericUpDown minutes_input_pause;
		private System.Windows.Forms.NumericUpDown seconds_input_pause;
		private System.Windows.Forms.Button btn_save_pause;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.OpenFileDialog open_end_file;
		private System.Windows.Forms.OpenFileDialog open_begin_file;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btn_open_end;
		private System.Windows.Forms.Button btn_open_begin;
		private System.Windows.Forms.TextBox textBox_end_song_direc;
		private System.Windows.Forms.TextBox textBox_begin_song_direc;
		private System.Windows.Forms.Label separator1;
		private System.Windows.Forms.Label separator2;
		private System.Windows.Forms.Label separator3;
		private System.Windows.Forms.Button btn_reset_game;
		private System.Windows.Forms.Label time_show_game;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.Timer timer_game;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_save_game;
		private System.Windows.Forms.Button btn_stop_game;
		private System.Windows.Forms.Button btn_pause_game;
		private System.Windows.Forms.NumericUpDown seconds_input_game;
		private System.Windows.Forms.NumericUpDown minutes_input_game;
		private System.Windows.Forms.NumericUpDown hours_input_game;
		private System.Windows.Forms.Button btn_start_game;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar sound_volume;
        private System.Windows.Forms.Button btn_sound_pause;
        private System.Windows.Forms.Button btn_sound_stop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label time_over_game;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_open_mid;
        private System.Windows.Forms.TextBox textBox_mid_song_direc;
        private System.Windows.Forms.CheckBox checkBox_begin_song;
        private System.Windows.Forms.CheckBox checkBox_mid_song;
        private System.Windows.Forms.CheckBox checkBox_end_song;
        private System.Windows.Forms.OpenFileDialog open_mid_file;
        private System.Windows.Forms.RadioButton radioButton_begin_choose;
        private System.Windows.Forms.RadioButton radioButton_begin_random;
        private System.Windows.Forms.FolderBrowserDialog open_begin_folder;
        private System.Windows.Forms.FolderBrowserDialog open_mid_folder;
        private System.Windows.Forms.FolderBrowserDialog open_end_folder;
        private System.Windows.Forms.GroupBox groupBox_begin;
        private System.Windows.Forms.GroupBox groupBox_mid;
        private System.Windows.Forms.RadioButton radioButton_mid_choose;
        private System.Windows.Forms.RadioButton radioButton_mid_random;
        private System.Windows.Forms.GroupBox groupBox_end;
        private System.Windows.Forms.RadioButton radioButton_end_choose;
        private System.Windows.Forms.RadioButton radioButton_end_random;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_extern_view;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox_last_minute;
        private System.Windows.Forms.RadioButton radioButton_last_minute_choose;
        private System.Windows.Forms.RadioButton radioButton_last_minute_random;
        private System.Windows.Forms.TextBox textBox_last_minute_song_direc;
        private System.Windows.Forms.Button btn_open_last_minute;
        private System.Windows.Forms.CheckBox checkBox_last_minute_song;
        private System.Windows.Forms.FolderBrowserDialog open_last_minute_folder;
        private System.Windows.Forms.OpenFileDialog open_last_minute_file;
        private System.Windows.Forms.Label label_about;
		
		
	}
}
