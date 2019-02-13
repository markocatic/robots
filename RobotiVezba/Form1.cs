using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RobotiVezba.BiznisSloj;

namespace RobotiVezba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BlokOperacija blokOp = new BlokOperacija();
            Robot robot1 = new Robot("Pera",new Pozicija{X = 1,Y = 2, Z = 3});
            Robot robot2 = new Robot("Sima", new Pozicija { X = 6, Y = -1, Z = 0 });
            blokOp.LitaOperacija.Add(new PomeriRobotaLevo(robot1, 2));
            blokOp.LitaOperacija.Add(new PomeriRobotaDesno(robot1, 5));
            blokOp.LitaOperacija.Add(new PomeriRobotaDesno(robot2, 4));
            blokOp.LitaOperacija.Add(new PomeriRobotaLevo(robot1, 5.4));
            blokOp.LitaOperacija.Add(new PomeriRobotaLevo(robot2, 6.1));
            blokOp.LitaOperacija.Add(new PomeriRobotaDesno(robot1, 11.5));
            blokOp.LitaOperacija.Add(new PomeriRobotaLevo(robot1, 6.1));
            blokOp.LitaOperacija.Add(new PomeriRobotaLevo(robot2, 4.3));
            blokOp.LitaOperacija.Add(new PomeriRobotaDesno(robot1, 7.2));
            this.textBox1.Text = robot1.ToString() + Environment.NewLine +
                                 robot2.ToString() + Environment.NewLine;
            blokOp.izvrsi();
            this.textBox1.Text += robot1.ToString() + Environment.NewLine +
                                  robot2.ToString() + Environment.NewLine;
            blokOp.opozovi();
            this.textBox1.Text += robot1.ToString() + Environment.NewLine +
                                  robot2.ToString() + Environment.NewLine;
        }
    }
}
