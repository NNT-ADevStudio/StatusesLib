﻿using StatusesLib.Interfeses;
using System;
using System.ComponentModel;

namespace StatusesLib.Models
{
    /// <summary>
    /// Статус
    /// </summary>
    /// <typeparam name="T">тип значения</typeparam>
    public class Status<T> : IStatus<T, TypeStatus>
    {
        /// <summary>
        /// Индификатор
        /// </summary>
        [DisplayName("Индификатор")]
        public virtual Guid Id { get; } = Guid.NewGuid();


        private string _name;

        /// <summary>
        /// Название
        /// </summary>
        [DisplayName("Название")]
        public virtual string Name
        {
            get => _name;
            set => _name = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Сообщение
        /// </summary>
        [DisplayName("Сообщение")]
        public string Message { get; set; }

        /// <summary>
        /// Значение
        /// </summary>
        [DisplayName("Значение")]
        public T Value { get; set; }

        /// <summary>
        /// Тип статуса
        /// </summary>
        [DisplayName("Тип статуса")]
        public virtual TypeStatus Type { get; set; }

        public Status() { }

        public Status(string name) => Name = name;

        public Status(string name, T value) : this(name) => Value = value;

        public Status(string name, T value, string message) : this(name, value) => Message = message;
    }
}
