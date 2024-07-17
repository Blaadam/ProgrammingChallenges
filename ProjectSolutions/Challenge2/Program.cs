using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Challenge2
{
    internal class Program
    {
        static float SpeedLimit = 30;
        static float MilesApart = 1;
        static bool IsSpeeding(float SecondsTaken)
        {
            float Hours = SecondsTaken / 3600;
            float VehucleSpeed = MilesApart / Hours;
            // 10% lee-way added for the speed limit
            return VehucleSpeed > SpeedLimit + (SpeedLimit*0.1);
        }

        static bool HasIllegalPlate(string Plate)
        {
            return !Regex.IsMatch(Plate, "[A-Za-z][A-Za-z]\\d\\d\\s[A-Za-z][A-Za-z][A-Za-z]");
        }

        static void Main(string[] args)
        {
            string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "CarData.txt");
            Console.WriteLine($"Attempting to open file at: {filePath}");

            using (StreamReader File = new StreamReader(filePath))
            {
                // Your reading logic here
                int rowCount = 0;

                while (!File.EndOfStream)
                {
                    string Row = File.ReadLine();
                    rowCount = rowCount + 1;

                    // Exclude headers
                    if (rowCount <= 1) { continue; }

                    var Data = Row.Split(',');

                    string LicensePlate = Data[0];
                    int TimeTaken = Convert.ToInt32(Data[1]);

                    bool VehicleSpeeding = IsSpeeding(TimeTaken);
                    if (VehicleSpeeding)
                    {
                        Console.WriteLine(LicensePlate + " is travelling over the speed limit");
                    }
                    else
                    {
                        Console.WriteLine(LicensePlate + " is obeying the speed limit");
                    }
                    if (HasIllegalPlate(LicensePlate))
                    {
                        Console.WriteLine(LicensePlate + " is an illegal plate");
                    }
                    else
                    {
                        Console.WriteLine(LicensePlate + " is a legal plate");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
