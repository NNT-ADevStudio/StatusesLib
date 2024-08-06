namespace StatusesLib.Models.StaticModels
{
    internal class OK<T> : Status<T>
    {
        public override string Name => "OK";

        public override TypeStatus Type => TypeStatus.OK;
    }
}
