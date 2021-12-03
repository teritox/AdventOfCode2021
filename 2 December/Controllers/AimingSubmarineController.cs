using _2_December.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_December.Controllers
{
    public class AimingSubmarineController
    {
        private AimingSubmarine AimingSubmarine;

        public AimingSubmarineController(AimingSubmarine AS)
        {
            AimingSubmarine = AS;

        }

        public void MoveAimingSubmarineThroughCourse(List<Movement> course)
        {
            foreach (var movement in course)
            {
                switch (movement.Direction)
                {
                    case "forward":
                        AimingSubmarine.HorizontalPosition += movement.Steps;
                        AimingSubmarine.DepthPosition += movement.Steps * AimingSubmarine.Aim;
                        break;
                    case "up":
                        AimingSubmarine.Aim -= movement.Steps;
                        break;
                    case "down":
                        AimingSubmarine.Aim += movement.Steps;
                        break;

                    default:
                        break;
                }
            }
        }

        public void DisplayAimingSubmarinePosition()
        {
            Console.WriteLine($"Submarine Horizontal Position: { AimingSubmarine.HorizontalPosition }");
            Console.WriteLine($"Submarine Depth Position: { AimingSubmarine.DepthPosition }");
            Console.WriteLine($"Submarine Aim Position: {AimingSubmarine.Aim}");
            Console.WriteLine();
            Console.WriteLine($"{ AimingSubmarine.HorizontalPosition } * { AimingSubmarine.DepthPosition } = { AimingSubmarine.HorizontalPosition * AimingSubmarine.DepthPosition}");
        }
    }
}
