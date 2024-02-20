using System;

namespace StatusesLib.Models
{
    internal class StatusError<T> : Status<T>
    {
        public Exception Exception { get; set; }

        public StatusError(int id, string name, Exception ex) : base(id, name) => Exception = ex;

        public StatusError(int id, string name, T value, Exception ex) : base(id, name, value) => Exception = ex;

        public StatusError(int id, string name, T value, string message, Exception ex) : base(id, name, value, message) => Exception = ex;
    }
}
