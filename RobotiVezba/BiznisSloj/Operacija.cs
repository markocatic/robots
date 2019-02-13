using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotiVezba.BiznisSloj
{
    public abstract class Operacija
    {
        protected bool operacijaIzvrsena = false;
        public abstract void izvrsi();
        public abstract void opozovi();
    }

    public abstract class OperacijaPomeriRobota : Operacija
    {
        protected Robot robot;
        protected double pomeraj;

        public OperacijaPomeriRobota(Robot robot, double pomeraj)
        {
            this.robot = robot;
            this.pomeraj = pomeraj;
        }
    }

    public class PomeriRobotaLevo : OperacijaPomeriRobota
    {
        public PomeriRobotaLevo(Robot robot, double pomeraj) 
            : base(robot, pomeraj)
        {
        }

        public override void izvrsi()
        {
            if (!operacijaIzvrsena)
            {
                robot.pomeriX(-pomeraj);
                this.operacijaIzvrsena = true;
            }

        }

        public override void opozovi()
        {

            if (operacijaIzvrsena)
            {
                robot.pomeriX(pomeraj);
                this.operacijaIzvrsena = false;
            }
        }
    }

    public class PomeriRobotaDesno : OperacijaPomeriRobota
    {
        public PomeriRobotaDesno(Robot robot, double pomeraj) 
            : base(robot, pomeraj)
        {
        }

        public override void izvrsi()
        {
            if (!operacijaIzvrsena)
            {
                robot.pomeriX(pomeraj);
                this.operacijaIzvrsena = true;
            }
        }

        public override void opozovi()
        {
            if (operacijaIzvrsena)
            {
                robot.pomeriX(-pomeraj);
                this.operacijaIzvrsena = false;
            }
        }
    }

    public class BlokOperacija : Operacija
    {
        private List<Operacija> litaOperacija = new List<Operacija>();

        public List<Operacija> LitaOperacija
        {
            get { return litaOperacija; }
        }
        public override void izvrsi()
        {
            for (int i = 0; i < litaOperacija.Count; i++)
            {
                if(this.litaOperacija[i] !=null)
                    this.litaOperacija[i].izvrsi();
            }
        }

        public override void opozovi()
        {
            for (int i = this.litaOperacija.Count - 1; i >= 0; i--)
            {
                if(this.litaOperacija!=null) 
                    this.litaOperacija[i].opozovi();
            }
        }
    }
}
