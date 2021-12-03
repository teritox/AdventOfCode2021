using _2_December.Controllers;
using _2_December.Models;
using System;
using System.Collections.Generic;

namespace _2_December
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1 Submarine

            //List<Movement> course = FileReader.GetCourse();

            //Submarine submarine = new Submarine();
            //SubmarineController controller = new SubmarineController(submarine);

            //controller.MoveSubmarineThroughCourse(course);
            //controller.DisplaySubmarinePosition();

            //Part 2 Submarine

            List<Movement> course = FileReader.GetCourse();

            AimingSubmarine submarine = new AimingSubmarine();
            AimingSubmarineController aimingController = new AimingSubmarineController(submarine);

            aimingController.MoveAimingSubmarineThroughCourse(course);
            aimingController.DisplayAimingSubmarinePosition();
        }

    }
}
