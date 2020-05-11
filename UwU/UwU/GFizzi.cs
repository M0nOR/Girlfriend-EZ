using System;
using System.Drawing;
using System.Windows.Forms;

namespace UwU
{
    public partial class GFizzi : Form
    {
        Random r = new Random();
        public GFizzi()
        {
            InitializeComponent();
        }
        private void NO_MouseEnter(object sender, EventArgs e)
        {
            // Aquí es donde ocurre toda la magia JAJAJAJJAJAJAJAJJAJA
            // Es muy simple la mera verdad
            int newX = r.Next(0, this.Size.Width - NO.Size.Width);
            int newY = r.Next(0, this.Size.Height - NO.Size.Height);
            NO.Location = new Point(newX, newY);
        }
        private void SI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ya sabía que querias ser mi novia jiji :3", "Uwu");
            Environment.Exit(0);
        }
    }
}
