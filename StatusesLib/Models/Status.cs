namespace StatusesLib.Models
{
    public class Status<T>
    {
        public virtual int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public T Value { get; set; }

        public Status() { }

        public Status(int id, string name) => (Id, Name) = (id, name);

        public Status(int id, string name, T value) : this(id, name) => Value = value;

        public Status(int id, string name, T value, string description) : this(id, name, value) => Description = description;
    }
}
