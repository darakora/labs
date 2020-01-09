using System;

namespace MyLib
{
    public delegate void MyEventDelegate(MyClassEventArgs args);
    public class MyClassEventArgs : EventArgs
    {
        public string Message { get; set; }
        public MyClassEventArgs(string message)
        {
            this.Message = message;
        }
        public void ShowMessage()
        {
            Console.WriteLine(this.Message);
        }
    }
    public class CircleInTrapezoid
    {
        public event MyEventDelegate ObjCreated;

        private double a;
        public double A
        {
            get
            {
                return a;
            }
            private set
            {
                a = value;
            }
        }
        public double b { get; private set; }
        public double c { get; private set; }
        public double d { get; private set; }
        public double r { get; private set; }

        CircleInTrapezoid() { }
        public CircleInTrapezoid(double a, double b, double c, double d, double r)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.r = r;

            ObjCreated += Obj_Created;

            ObjCreated(new MyClassEventArgs("Obj Created"));
        }

        ~CircleInTrapezoid()
        {
            Console.WriteLine("Obj Deleted");
        }
        private void Obj_Created(MyClassEventArgs args)
        {
            args.ShowMessage();
        }

        public override string ToString()
        {
            return "a " + this.a + "\n" + "b " + this.b + "\n" + "c " + this.c + "\n" + "d " + this.d + "\n" + "r " + this.r + "\n";
        }

        public void CheckForExistence()
        {
            if (a + c == b + d)
            {
                Console.WriteLine("Obj created");
            }
            else
            {
                Console.WriteLine("Invalid side values");
            }
        }

        public double TrapezoidalPerim()
        {
            return a + b + c + d;
        }
        public double TrapezoidalSquare()
        {
            return (TrapezoidalPerim() / 2) * r;
        }

        public double CircleSquare()
        {
            return Math.PI * Math.Pow(r, 2);
        }
    }
}
