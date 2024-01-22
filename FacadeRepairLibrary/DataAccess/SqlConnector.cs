using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeRepairLibrary.Model;

namespace FacadeRepairLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public FacadeModel CreateFacade(FacadeModel model)
        {
            throw new NotImplementedException();
        }

        // TODO - Make the CreatePoint actually save to the database.
        /// <summary>
        /// Saves a new point to the database.
        /// </summary>
        /// <param name="model">The point informations.</param>
        /// <returns>The point informations, including the unique identifier.</returns>
        public PointModel CreatePoint(PointModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
