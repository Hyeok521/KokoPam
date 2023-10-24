namespace cocopalm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Base_panel.Width += 3; //길어지는 panel
            if (Base_panel.Width >= 370)
            {
                timer1.Stop();
                this.Size = new Size(370, 480);
                Time_panel.Visible = false; //라인 panel
                Base_panel.Visible = false; // 길어지는 panel
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}