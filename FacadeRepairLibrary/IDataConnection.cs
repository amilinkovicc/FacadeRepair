using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeRepairLibrary
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
