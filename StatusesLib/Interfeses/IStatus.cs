namespace StatusesLib.Interfeses
{
    /// <summary>
    /// Интерфейс статуса
    /// </summary>
    /// <typeparam name="T">Тип значения</typeparam>
    /// <typeparam name="K">Тип статуса</typeparam>
    internal interface IStatus<T, K>
    {
        string Name { get; set; }

        T Value { get; set; }

        K Type { get; set; }

        string ToJsonWithDisplayName();
    }
}
