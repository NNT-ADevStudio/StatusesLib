namespace StatusesLib.Models.StaticModels
{
    /// <summary>
    ///  OK
    /// </summary>
    /// <typeparam name="T">тип значения</typeparam>
    public class OK<T> : Status<T>
    {
        public override string Name => "OK";

        public override TypeStatus Type => TypeStatus.OK;

        public OK(string name) : base(name) { }

        public OK(string name, T value) : base(name, value) { }

        public OK(string name, T value, string message) : base(name, value, message) { }
    }
}
