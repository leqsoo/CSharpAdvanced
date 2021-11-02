using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMiddle.polimorfism3pirlarofOOP
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Circle");
        }
    }
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
    public class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public Position Position { get; set; }
        public virtual void Draw()
        {

        }
    }
}