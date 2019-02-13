using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotiVezba.BiznisSloj
{
    public class Pozicija
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }
    public class Robot
    {
        private static int broj = 0;
        private readonly int id;
        private readonly string ime;
        private Pozicija pozicija = new Pozicija();

        public Robot(string ime, Pozicija pozicija)
        {
            this.id = ++Robot.broj;
            this.ime = ime;
            this.pozicija = new Pozicija
            {
                X = pozicija.X,
                Y = pozicija.Y,
                Z = pozicija.Z
            };
        }

        public int Id
        {
            get { return this.id; }
        }

        public string Ime
        {
            get { return this.ime; }
        }

        public void pomeri(Pozicija delta)
        {
            this.pozicija.X += delta.X;
            this.pozicija.Y += delta.Y;
            this.pozicija.Z += delta.Z;
        }

        public void pomeriX(double delta)
        {
            this.pozicija.X += delta;
        }

        public void pomeriY(double delta)
        {
            this.pozicija.Y += delta;
        }
        public void pomeriZ(double delta)
        {
            this.pozicija.Z += delta;
        }

        public override string ToString()
        {
           return this.ime + ", x=" + Math.Round(this.pozicija.X, 2) +
                  ", y=" + Math.Round(this.pozicija.Y, 2) +
                  ", z=" + Math.Round(this.pozicija.Z, 2);
        }
    }
}
