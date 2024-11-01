namespace Yves
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Define the size and position of the circle
            int diameter = Math.Min(panel3.Width, panel3.Height) - 10; // Increase the diameter to make it larger
            int x = (panel3.Width - diameter) / 2; // X-coordinate for centering
            int y = (panel3.Height - diameter) / 2; // Y-coordinate for centering

            // Create a brush to fill the circle
            using (SolidBrush brush = new SolidBrush(Color.Blue)) // Change Color.Blue to your preferred color
            {
                // Draw the circle
                g.FillEllipse(brush, x, y, diameter, diameter);
            }

            // Optionally, you can draw the outline of the circle
            using (Pen pen = new Pen(Color.Black, 2)) // Change Color.Black and thickness as needed
            {
                g.DrawEllipse(pen, x, y, diameter, diameter);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
