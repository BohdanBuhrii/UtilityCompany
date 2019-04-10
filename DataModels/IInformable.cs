using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public interface IInformable
    {
        string[] GetFieldsValue();
        string[] GetFieldsName();
    }
}
