using System;

namespace StatusesLib.Models.DefaultModels
{
    public class Error<T> : Status<T>
    {
        public override string Name => "Error";

        public override TypeStatus Type => TypeStatus.Error;

        public Exception Exception { get; set; }

        public Error(int id, string name, Exception ex) : base(id, name) => Exception = ex;

        public Error(int id, string name, T value, Exception ex) : base(id, name, value) => Exception = ex;

        public Error(int id, string name, T value, string message, Exception ex) : base(id, name, value, message) => Exception = ex;
    }
}
