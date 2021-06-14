using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{

    // for basis voids beginning
    public interface IResult
    {
        bool Success { get; }
        string Massage { get; }
    }
}
