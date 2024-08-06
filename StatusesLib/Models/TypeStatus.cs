using System.ComponentModel;

namespace StatusesLib.Models
{
    public enum TypeStatus
    {
        [Description("ОК")]
        OK,
        [Description("ОШИБКА")]
        Error,
        [Description("ПРЕДУПРЕЖДЕНИЕ")]
        Warning,
        [Description("ИНФОРМАЦИЯ")]
        Info,
        [Description("НЕИЗВЕСТНО")]
        Unknown,
        [Description("НЕОПРЕДЕЛЕНО")]
        None,
        [Description("Собственный")]
        Custom
    }
}
