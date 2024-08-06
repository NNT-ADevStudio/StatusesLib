using System;

namespace StatusesLib.Models.DefaultModels
{
    /// <summary>
    /// Error
    /// </summary>
    /// <typeparam name="T">Тип значения</typeparam>
    public class Error<T> : Status<T>
    {
        public override string Name => "Error";

        public override TypeStatus Type => TypeStatus.Error;

        /// <summary>
        /// Исключение
        /// </summary>
        public Exception Exception { get; set; }

        public Error(string name, Exception ex) : base(name) => Exception = ex;

        public Error(string name, T value, Exception ex) : base(name, value) => Exception = ex;

        public Error(string name, T value, string message, Exception ex) : base(name, value, message) => Exception = ex;
    }
}
