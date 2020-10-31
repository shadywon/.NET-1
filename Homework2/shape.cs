using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    interface Shape //图形接口
    {
        // calculate the area of the shape
        double Area { get; }

        // base information of the shape
        string Info { get; }

        //verify the shape
        bool Verify();
    }
}
