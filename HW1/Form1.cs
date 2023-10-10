namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Paint += new PaintEventHandler(Form1_Paint);
        }
 
        private void Form1_Paint(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 2);

            //line
            graphics.DrawLine(p, 250, 150, 500, 150);

            //point
            graphics.DrawEllipse(p, 100, 100, 2, 2);
            
            //circle
            graphics.DrawEllipse(p, 200, 200, 50, 50);

            //rect
            graphics.DrawRectangle(p, 300, 300, 100, 50);
        }

    }
}