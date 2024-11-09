using cxapi;

namespace Vortex_Executor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CoreFunctions.ExecuteScript(richTextBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CoreFunctions.KillRoblox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CoreFunctions.Inject();
        }
    }
}
