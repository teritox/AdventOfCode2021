using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_December
{
    public class SubmarineController
    {
        private Submarine Submarine;

        public SubmarineController(Submarine s)
        {
            Submarine = s;

        }

        public void MoveSubmarineThroughCourse(List<Movement> course)
        {
            foreach (var movement in course)
            {
                switch (movement.Direction)
                {
                    case "forward":
                        Submarine.HorizontalPosition += movement.Steps;
                        break;
                    case "up":
                        Submarine.DepthPosition -= movement.Steps;
                        break;
                    case "down":
                        Submarine.DepthPosition += movement.Steps;
                        break;

                    default:
                        break;
                }
            }
        }

        public void DisplaySubmarinePosition()
        {
            Console.WriteLine($"Submarine Horizontal Position: { Submarine.HorizontalPosition }");
            Console.WriteLine($"Submarine Depth Position: { Submarine.DepthPosition }");
            Console.WriteLine();
            Console.WriteLine($"{ Submarine.HorizontalPosition } * { Submarine.DepthPosition } = { Submarine.HorizontalPosition * Submarine.DepthPosition}");
        }

    }
}
