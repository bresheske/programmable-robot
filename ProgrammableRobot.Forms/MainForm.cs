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

            listBox2.Items.AddRange(new Object[]
            {
                "World1",
                "World2"
            });

            listBox2.SelectedIndex = 0;
        }



        public void RunProgram()
        {
            errormessage.Text = string.Empty;
            var world = GetWorld();
            engine = new Engine(world, textBox1.Text);
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

        private void button2_Click(object sender, EventArgs e)
        {
            var line = listBox1.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(line))
                return;
            textBox1.Text += (line + Environment.NewLine);
        }

        private BaseWorld GetWorld()
        {
            var str = listBox2.SelectedItem.ToString();
            return str == "World1" ? new World1()
                : str == "World2" ? new World2()
                : null
                as BaseWorld;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var world = GetWorld();
            engine = new Engine(world, textBox1.Text);
            pictureBox1.Image = engine.Render();
        }
    }
}
