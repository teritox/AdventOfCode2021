using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_December
{
    public class FileReader
    {
        public static List<Movement> GetCourse()
        {
            StreamReader streamReader = new StreamReader("PlannedCourse.txt");
            List<Movement> movements = new List<Movement>();

            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                string[] directionAndSteps = line.Split(new string[] { " " }, StringSplitOptions.None);

                Movement movement = new Movement(); 
                movement.Direction = directionAndSteps[0];
                movement.Steps = Convert.ToInt32(directionAndSteps[1]);

                movements.Add(movement);   

            }

            return movements;

        }
    }
}
