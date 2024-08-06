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
    }
}
