using ProgrammableRobot.Core.Engine;
using ProgrammableRobot.Core.Worlds;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammableRobot.Forms
{
    public partial class MainForm : Form
    {
        private Engine engine;
        private Timer timer;
        
        public MainForm()
        {
            InitializeComponent();

            var sample = new StringBuilder()
                .AppendLine("RotateLeft();")
                .AppendLine("MoveForward();")
                .AppendLine("RotateRight();")
                .AppendLine("MoveForward();")
                .AppendLine("RotateLeft();")
                .ToString();

            textBox1.Text = sample;

            engine = new Engine(new World1(), textBox1.Text);
            pictureBox1.Image = engine.Render();
        }

        public void RunProgram()
        {
            errormessage.Text = string.Empty;
            engine = new Engine(new World1(), textBox1.Text);
            pictureBox1.Image = engine.Render();
            var compile = engine.CompileInput();
            if (!string.IsNullOrWhiteSpace(compile))
            {
                errormessage.Text = compile;
            }
            else
            {
                errormessage.Text = "Running...";
                timer = new Timer();
                timer.Interval = 500;
                timer.Tick += RenderAction;
                timer.Enabled = true;
            }
        }

        private void RenderAction(object sender, EventArgs e)
        {
            var nextframe = engine.ExecuteNextAction();
            pictureBox1.Image.Dispose();
            pictureBox1.Image = engine.Render();
            if (!nextframe)
            {
                timer.Enabled = false;
                errormessage.Text = "Stopped.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var input = textBox1.Text;
            RunProgram();
        }
    }
}
