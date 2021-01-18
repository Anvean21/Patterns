using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// Американский доллар.
    /// </summary>
    public class Euro : MoneyBase
    {
        /// <summary>
        /// Уникальный код.
        /// </summary>
        public Guid Number { get; private set; }

        /// <summary>
        /// Номинал валюты.
        /// </summary>
        public int Volume { get; private set; }

        /// <summary>
        /// Создать новый экземпляр.
        /// </summary>
        /// <param name="volume"> Номинал. </param>
        public Euro(int volume)
            : base("Euro", "Е")
        {
            // Проверяем входные данные на корректность.
            if (volume <= 0)
            {
                throw new ArgumentException("Номинал валюты должен быть больше нуля.", nameof(volume));
            }

            Number = Guid.NewGuid();
            Volume = volume;
        }

        /// <summary>
        /// Приведение объекта к строке.
        /// </summary>
        /// <returns> Информация о купюре. </returns>
        public override string ToString()
        {
            return $"{Name} {Number} номиналом {Volume}{Symbol}";
        }
    }
}
