using System;
using System.ComponentModel;

namespace StatusesLib.Models.DefaultModels
{
    /// <summary>
    /// Error
    /// </summary>
    /// <typeparam name="T">Тип значения</typeparam>
    public class Error<T> : Status<T>
    {
        public override TypeStatus Type => TypeStatus.Error;

        /// <summary>
        /// Исключение
        /// </summary>
        [DisplayName("Исключение")]
        public Exception Exception { get; set; }

        public Error(Exception ex) : base("Error") => Exception = ex;

        public Error(T value, Exception ex) : base("Error", value) => Exception = ex;

        public Error(T value, string message, Exception ex) : base("Error", value, message) => Exception = ex;
    }
}
