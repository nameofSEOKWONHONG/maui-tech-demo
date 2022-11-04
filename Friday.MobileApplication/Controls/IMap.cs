using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friday.MobileApplication.Controls
{
    public interface IMap : IView
    {
        MapType MapType { get; }
        bool IsShowingUser { get; }
        bool HasScrollEnabled { get; }
        bool HasZoomEnabled { get; }
        bool HasTrafficEnabled { get; }
    }
}
