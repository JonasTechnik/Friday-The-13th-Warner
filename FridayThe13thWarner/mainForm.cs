namespace FridayThe13thWarner
{
    public partial class mainForm : Form
    {
        private bool moving = false;
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
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
            resultLabel.Text = selected.ToString("dd.MM.y");
        }

        private void dragBar_MouseDown(object sender, MouseEventArgs e)
        {
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
                Location = new Point(Cursor.Position.X - e.X, Cursor.Position.Y - e.Y);
            }
        }
    }
}