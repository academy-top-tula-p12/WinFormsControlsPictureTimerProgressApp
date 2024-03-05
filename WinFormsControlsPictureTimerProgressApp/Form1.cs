namespace WinFormsControlsPictureTimerProgressApp
{
    public partial class Form1 : Form
    {
        int dx = 5;
        int count = 0;

        public Form1()
        {
            InitializeComponent();

            lblRed.Text = trackRed.Value.ToString();
            lblGreen.Text = trackGreen.Value.ToString();
            lblBlue.Text = trackBlue.Value.ToString();

            this.BackColor = Color.FromArgb(trackRed.Value, trackGreen.Value, trackBlue.Value);

            lblTimer.Text = count.ToString();
        }

        private void trackRed_Scroll(object sender, EventArgs e)
        {
            lblRed.Text = trackRed.Value.ToString();
            lblGreen.Text = trackGreen.Value.ToString();
            lblBlue.Text = trackBlue.Value.ToString();

            this.BackColor = Color.FromArgb(trackRed.Value, trackGreen.Value, trackBlue.Value);
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
                btnTimer.Text = "Start";
            }
            else
            {
                timer.Start();
                btnTimer.Text = "Stop";
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            btnMove.Left += dx;
            lblTimer.Text = (++count).ToString();

            progressBar1.PerformStep();
        }
    }
}
