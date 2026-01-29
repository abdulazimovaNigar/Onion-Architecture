using System;
using System.Collections.Generic;
using System.Text;

namespace Pustok.Business.Abstractions
{
    public interface IBaseException
    {
        public int StatusCode { get; }
    }
}
