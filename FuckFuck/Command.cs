using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckFuck
{
    public enum Command : byte
    {
        IncrementPointer = 1,
        DecrementPointer = 2,
        IncrementData = 3,
        DecrementData = 4,
        Output = 5,
        Input = 6,
        BeginLoop = 7,
        EndLoop = 8
    }
}
