using System;

namespace StatusesLib.Models
{
    public class Status<T>
    {
        public virtual Guid Id { get; } = Guid.NewGuid();

        public virtual string Name { get; set; }

        public string Message { get; set; }

        public T Value { get; set; }

        public virtual TypeStatus Type { get; set; }

        public Status() { }

        public Status(string name) => Name = name;

        public Status(string name, T value) : this(name) => Value = value;

        public Status(string name, T value, string message) : this(name, value) => Message = message;
    }
}
