namespace StatusesLib.Models.DefaultModels
{
    /// <summary>
    ///  OK
    /// </summary>
    /// <typeparam name="T">тип значения</typeparam>
    public class OK<T> : Status<T>
    {
        public override TypeStatus Type => TypeStatus.OK;

        public OK() : base("OK") { }

        public OK(T value) : base("OK", value) { }

        public OK(T value, string message) : base("OK", value, message) { }
    }
}
