namespace Dusty_JukeBox
{
    partial class _playButton
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _songsList = new ListBox();
            _openFiledialog_Button = new Button();
            _next_Button = new Button();
            _repeat_button = new Button();
            _previous_button = new Button();
            _shuffle_button = new Button();
            pictureBox1 = new PictureBox();
            _key_bpm = new Button();
            _play_button = new Button();
            _stop = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // _songsList
            // 
            _songsList.FormattingEnabled = true;
            _songsList.Location = new Point(148, 207);
            _songsList.Name = "_songsList";
            _songsList.Size = new Size(451, 164);
            _songsList.TabIndex = 0;
            _songsList.SelectedIndexChanged += _songsList_SelectedIndexChanged;
            // 
            // _openFiledialog_Button
            // 
            _openFiledialog_Button.Location = new Point(605, 207);
            _openFiledialog_Button.Name = "_openFiledialog_Button";
            _openFiledialog_Button.Size = new Size(119, 55);
            _openFiledialog_Button.TabIndex = 1;
            _openFiledialog_Button.Text = "Open Directory";
            _openFiledialog_Button.UseVisualStyleBackColor = true;
            _openFiledialog_Button.Click += _openFiledialog_Button_Click;
            // 
            // _next_Button
            // 
            _next_Button.Location = new Point(436, 377);
            _next_Button.Name = "_next_Button";
            _next_Button.Size = new Size(94, 29);
            _next_Button.TabIndex = 2;
            _next_Button.Text = "Next";
            _next_Button.UseVisualStyleBackColor = true;
            _next_Button.Click += _next_Button_Click;
            // 
            // _repeat_button
            // 
            _repeat_button.Location = new Point(536, 377);
            _repeat_button.Name = "_repeat_button";
            _repeat_button.Size = new Size(97, 29);
            _repeat_button.TabIndex = 5;
            _repeat_button.Text = "Repeat";
            _repeat_button.UseVisualStyleBackColor = true;
            _repeat_button.Click += _repeat_button_Click;
            // 
            // _previous_button
            // 
            _previous_button.Location = new Point(236, 377);
            _previous_button.Name = "_previous_button";
            _previous_button.Size = new Size(94, 29);
            _previous_button.TabIndex = 13;
            _previous_button.Text = "Previous";
            _previous_button.Click += _previous_button_Click;
            // 
            // _shuffle_button
            // 
            _shuffle_button.Location = new Point(136, 377);
            _shuffle_button.Name = "_shuffle_button";
            _shuffle_button.Size = new Size(94, 29);
            _shuffle_button.TabIndex = 7;
            _shuffle_button.Text = "Shuffle";
            _shuffle_button.UseVisualStyleBackColor = true;
            _shuffle_button.Click += _shuffle_button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(148, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(451, 120);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // _key_bpm
            // 
            _key_bpm.Location = new Point(605, 268);
            _key_bpm.Name = "_key_bpm";
            _key_bpm.Size = new Size(119, 38);
            _key_bpm.TabIndex = 9;
            _key_bpm.Text = "Key and Bpm";
            _key_bpm.UseVisualStyleBackColor = true;
            // 
            // _play_button
            // 
            _play_button.Location = new Point(336, 377);
            _play_button.Name = "_play_button";
            _play_button.Size = new Size(94, 29);
            _play_button.TabIndex = 11;
            _play_button.Text = "Play";
            _play_button.UseVisualStyleBackColor = true;
            _play_button.Click += _play_button_Click;
            // 
            // _stop
            // 
            _stop.Location = new Point(48, 342);
            _stop.Name = "_stop";
            _stop.Size = new Size(94, 29);
            _stop.TabIndex = 12;
            _stop.Text = "Stop";
            _stop.UseVisualStyleBackColor = true;
            _stop.Click += _stop_Click;
            // 
            // _playButton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_stop);
            Controls.Add(_play_button);
            Controls.Add(_key_bpm);
            Controls.Add(pictureBox1);
            Controls.Add(_shuffle_button);
            Controls.Add(_previous_button);
            Controls.Add(_repeat_button);
            Controls.Add(_next_Button);
            Controls.Add(_openFiledialog_Button);
            Controls.Add(_songsList);
            Name = "_playButton";
            Text = "Form1";
            Load += _playButton_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox _songsList;
        private Button _openFiledialog_Button;
        private Button _next_Button;
        private Button _repeat_button;
        private Button _previous_button;
        private Button _shuffle_button;
        private PictureBox pictureBox1;
        private Button _key_bpm;
        private Button _play_button;
        private Button _stop;
    }
}
