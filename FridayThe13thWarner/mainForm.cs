namespace FridayThe13thWarner
{
    public partial class mainForm : Form
    {
        private bool moving = false;
        Point oldPosition = new();
        public mainForm()
        {
            InitializeComponent();
            label1.Location = new Point((this.ClientSize.Width - label1.Size.Width) / 2, (this.ClientSize.Height - label1.Size.Height) / 2);
            DateTime selected = DateTime.Now;
            int offset = 13 - selected.Day;
            selected = selected.AddDays(offset);

            while (true)
            {
                if (selected.Day == 13 && selected.DayOfWeek == DayOfWeek.Friday && DateTime.Now < selected)
                {
                    break;
                }
                selected = selected.AddMonths(1);
            }
            resultLabel.Text = selected.ToString("dd.MM.yy");
            resultLabel.Location = new Point((this.ClientSize.Width - resultLabel.Size.Width) / 2, resultLabel.Location.Y);
        }

        private void dragBar_MouseDown(object sender, MouseEventArgs e)
        {
            oldPosition = Cursor.Position;
            moving = true;
        }

        private void dragBar_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
        }

        private void dragBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving)
            {
                Point newPosition = Cursor.Position;
                int offsetX = oldPosition.X - newPosition.X;
                int offsetY = oldPosition.Y - newPosition.Y;

                Location = new Point(Location.X - offsetX, Location.Y - offsetY);

                oldPosition = newPosition;
            }
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WriteInAnimation(Label owner, string text, int delay)
        {
            owner.Text = string.Empty;
            for (int step = 0; step < text.Length; step++)
            {

                Invoke(new Action(() =>
                {
                    owner.Text += text[step];
                }));

                Thread.Sleep(delay);
            }
        }
    }
}