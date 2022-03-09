using CalculatorLibrary;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Addition add = new Addition();
           
            OutputBox.Text = add.Add(textBox1.Text, textBox2.Text);


        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            Subtraction sub = new Subtraction();
            
            OutputBox.Text = sub.Subtract(textBox1.Text, textBox2.Text);


        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            Multiplication mult = new Multiplication();
            
            OutputBox.Text = mult.Multiply(textBox1.Text, textBox2.Text);


        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            Division div = new Division();
            OutputBox.Text = div.Divide(textBox1.Text, textBox2.Text);
        }

        private void buttonPower_Click(object sender, EventArgs e)
        {
            Power power = new Power();
            OutputBox.Text = power.RaiseToPower(textBox1.Text, textBox2.Text);
        }

        private void buttonSquareRoot_Click(object sender, EventArgs e)
        {
            SquareRoot root = new SquareRoot();
            OutputBox.Text = root.Square(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}