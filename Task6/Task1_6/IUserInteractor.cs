using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_6
{
    public interface IUserInteractor
    {
        void PrintOptions();
        void PrintDisplayTypes(List<DisplayType> displayTypes);
        string ReadDisplayType();
    }
}
