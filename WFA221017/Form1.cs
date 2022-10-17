namespace WFA221017
{
    public partial class Form1 : Form
    {
        static Random rnd = new();
        static int counter = 0;
        static int clicked = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            counter++;
            button1.Location = new Point(
                x: rnd.Next(this.Width - button1.Width), 
                y: rnd.Next(this.Height - button1.Height));
            lblCounter.Text = $"{counter}";

            this.BackColor = Color.FromArgb(
                red: rnd.Next(256),
                green: rnd.Next(256),
                blue: rnd.Next(256));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            
            
            MessageBox.Show("You Win!");
            counter = 0;
            clicked++;
            lblCounter.Text = $"{counter}";
            lblClicked.Text = $"{clicked}";
        }
    }
}