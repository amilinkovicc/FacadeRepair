using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeRepairLibrary
{
    public static class GlobalConfig
    {
        // TODO summary
        /// <summary>
        /// 
        /// </summary>
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        /// <param name="textFile"></param>
        public static void InitializeConnection (bool database, bool textFile)
        {
            if (database) 
            {
                // TODO - Set up the SQL connection properly
                SqlConnector sql = new SqlConnector ();
                Connections.Add (sql);
            }

            if (textFile) 
            {
                // TODO - Create the TextFile connection
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    }
}
