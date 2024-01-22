using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeRepairLibrary.Model;

namespace FacadeRepairLibrary.DataAccess
{
    // TODO summary
    /// <summary>
    /// 
    /// </summary>
    public interface IDataConnection
    {
        PointModel CreatePoint(PointModel model);
    }
}
