using System .Drawing;
using System;

namespace Sample19
{
    // Here am sharing  some common code, and data
    // data : color , thickness of any
       public abstract  class Shape
    {

        protected int Color { set; get;  }

        protected int Thickness { set; get; }

        //public abstract void Draw();
    
          protected void GetDc()
            {
                   // create a device context object
                   // device context object = windows ..
            }

        public abstract void Draw();
    }
      
     


    class Line : Shape
    {
        public Point LeftTop { get; set; }
        public Point RightBottom { get; set; }

        public Line(Point lefttop, Point rightbottom)
        {//
            this.Color = 0;
            this.Thickness = 1;

            GetDc();
            LeftTop = lefttop;
            RightBottom = rightbottom;

        }

        public override void Draw()
        {
            Console.WriteLine("Line Drawing");
        }

    }

     class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawa Rectangle Shape"); ;
        }

    }



    class Program
    {
        static void Main()
        {
            Point lefttop = new Point(10, 20);
            Point rightbottom = new Point(100, 80);
               
            //
            Line line = new Line(lefttop, rightbottom);
            //here reading the device context objects is bsracted
            line.Draw();
        }
    }
}
