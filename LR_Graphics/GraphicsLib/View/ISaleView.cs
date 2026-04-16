using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLib.View
{
    public interface ISaleView
    {
        void DisplayChart(List<BooksSale> records);
    }
}
