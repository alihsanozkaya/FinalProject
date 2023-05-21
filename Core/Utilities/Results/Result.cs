using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //2 parametreli olan constructora:this(success) da yapabiliriz
        public Result(bool success, string message)
        {
            Message = message;
            Succees = success;
        }
        public Result(bool success)
        {
            Succees = success;
        }
        public bool Succees { get; }

        public string Message { get; }
    }
}
