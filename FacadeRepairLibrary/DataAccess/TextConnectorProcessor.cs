using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeRepairLibrary.Model;

// * Load the text file
// * Convert the text to List<PointModel>
// * Find the max ID
// * Add the new record with the new ID (max + 1)
// * Convert the prizes to List<string>
// * Save the List<string> to the text file

namespace FacadeRepairLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath (this string fileName) //PointModel.csv
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<PointModel> ConvertToPointModels(this List<string> lines)
        {
            List<PointModel> output = new List<PointModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PointModel p = new PointModel();
                p.Id = int.Parse(cols[0]);
                p.x = double.Parse(cols[1]);
                p.y = double.Parse(cols[2]);
                output.Add(p);
            }

            return output;
        }

        public static void SaveToPointsFile(this List<PointModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PointModel p in models)
            {
                lines.Add($"{p.Id},{p.x},{p.y}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}
