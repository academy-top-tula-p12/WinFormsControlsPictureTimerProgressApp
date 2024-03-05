namespace WinFormsControlsPictureTimerProgressApp
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            trackRed = new TrackBar();
            trackGreen = new TrackBar();
            trackBlue = new TrackBar();
            lblRed = new Label();
            lblGreen = new Label();
            lblBlue = new Label();
            timer = new System.Windows.Forms.Timer(components);
            lblTimer = new Label();
            btnMove = new Button();
            btnTimer = new Button();
            progressBar1 = new ProgressBar();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            monthCalendar1 = new MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)trackRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // trackRed
            // 
            trackRed.Location = new Point(12, 232);
            trackRed.Maximum = 255;
            trackRed.Name = "trackRed";
            trackRed.Size = new Size(414, 45);
            trackRed.TabIndex = 0;
            trackRed.TickFrequency = 10;
            trackRed.TickStyle = TickStyle.Both;
            trackRed.Scroll += trackRed_Scroll;
            // 
            // trackGreen
            // 
            trackGreen.Location = new Point(12, 304);
            trackGreen.Maximum = 255;
            trackGreen.Name = "trackGreen";
            trackGreen.Size = new Size(414, 45);
            trackGreen.TabIndex = 0;
            trackGreen.TickFrequency = 10;
            trackGreen.TickStyle = TickStyle.Both;
            trackGreen.Scroll += trackRed_Scroll;
            // 
            // trackBlue
            // 
            trackBlue.Location = new Point(12, 380);
            trackBlue.Maximum = 255;
            trackBlue.Name = "trackBlue";
            trackBlue.Size = new Size(414, 45);
            trackBlue.TabIndex = 0;
            trackBlue.TickFrequency = 10;
            trackBlue.TickStyle = TickStyle.Both;
            trackBlue.Scroll += trackRed_Scroll;
            // 
            // lblRed
            // 
            lblRed.AutoSize = true;
            lblRed.Font = new Font("Segoe UI", 18F);
            lblRed.Location = new Point(451, 232);
            lblRed.Name = "lblRed";
            lblRed.Size = new Size(78, 32);
            lblRed.TabIndex = 1;
            lblRed.Text = "label1";
            // 
            // lblGreen
            // 
            lblGreen.AutoSize = true;
            lblGreen.Font = new Font("Segoe UI", 18F);
            lblGreen.Location = new Point(451, 304);
            lblGreen.Name = "lblGreen";
            lblGreen.Size = new Size(78, 32);
            lblGreen.TabIndex = 1;
            lblGreen.Text = "label1";
            // 
            // lblBlue
            // 
            lblBlue.AutoSize = true;
            lblBlue.Font = new Font("Segoe UI", 18F);
            lblBlue.Location = new Point(451, 380);
            lblBlue.Name = "lblBlue";
            lblBlue.Size = new Size(78, 32);
            lblBlue.TabIndex = 1;
            lblBlue.Text = "label1";
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 18F);
            lblTimer.Location = new Point(938, 228);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(78, 32);
            lblTimer.TabIndex = 2;
            lblTimer.Text = "label1";
            // 
            // btnMove
            // 
            btnMove.BackColor = Color.Red;
            btnMove.Location = new Point(597, 276);
            btnMove.Name = "btnMove";
            btnMove.Size = new Size(75, 60);
            btnMove.TabIndex = 3;
            btnMove.UseVisualStyleBackColor = false;
            // 
            // btnTimer
            // 
            btnTimer.Font = new Font("Segoe UI", 16F);
            btnTimer.Location = new Point(905, 284);
            btnTimer.Name = "btnTimer";
            btnTimer.Size = new Size(111, 52);
            btnTimer.TabIndex = 4;
            btnTimer.Text = "Start";
            btnTimer.UseVisualStyleBackColor = true;
            btnTimer.Click += btnTimer_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(597, 380);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(419, 43);
            progressBar1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Red;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 16F);
            dateTimePicker1.Font = new Font("Segoe UI", 16F);
            dateTimePicker1.Location = new Point(283, 23);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(299, 36);
            dateTimePicker1.TabIndex = 7;
            // 
            // monthCalendar1
            // 
            monthCalendar1.AnnuallyBoldedDates = new DateTime[]
    {
    new DateTime(2024, 1, 1, 0, 0, 0, 0)
    };
            monthCalendar1.Font = new Font("Segoe UI", 16F);
            monthCalendar1.Location = new Point(717, 23);
            monthCalendar1.MaxSelectionCount = 17;
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 450);
            Controls.Add(monthCalendar1);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(progressBar1);
            Controls.Add(btnTimer);
            Controls.Add(btnMove);
            Controls.Add(lblTimer);
            Controls.Add(lblBlue);
            Controls.Add(lblGreen);
            Controls.Add(lblRed);
            Controls.Add(trackBlue);
            Controls.Add(trackGreen);
            Controls.Add(trackRed);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackRed;
        private TrackBar trackGreen;
        private TrackBar trackBlue;
        private Label lblRed;
        private Label lblGreen;
        private Label lblBlue;
        private System.Windows.Forms.Timer timer;
        private Label lblTimer;
        private Button btnMove;
        private Button btnTimer;
        private ProgressBar progressBar1;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private MonthCalendar monthCalendar1;
    }
}
