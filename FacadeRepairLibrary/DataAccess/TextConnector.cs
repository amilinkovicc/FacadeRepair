using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeRepairLibrary.Model;
using FacadeRepairLibrary.DataAccess.TextHelpers;

namespace FacadeRepairLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string POINTSFILE = "PointModels.csv";

        // TODO - Make the CreatePoint actually save to the txt file.
        /// <summary>
        /// Saves a new point to the Text file.
        /// </summary>
        /// <param name="model">The point informations.</param>
        /// <returns>The point informations, including the unique identifier.</returns>
        public PointModel CreatePoint(PointModel model)
        {
            //Load the text file and Convert the text to List<PointModel>
            List<PointModel> points = POINTSFILE.FullFilePath().LoadFile().ConvertToPointModels();

            //Find the max ID
            int currentId = 1;

            if (points.Count > 0)
            {
                currentId = points.OrderByDescending(p => p.Id).First().Id + 1;
            }

            model.Id = currentId;

            //Add the new record with the new ID (max + 1)
            points.Add(model);

            //Convert the prizes to List<string>
            //Save the List<string> to the text file
            points.SaveToPointsFile(POINTSFILE);

            return model;
        }
    }
}
