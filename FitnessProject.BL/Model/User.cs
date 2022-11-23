using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProject.BL.Model
{
    internal class User
    {
        #region Свойства
        public string Name { get; }
        public Gender Gender { get; }
        public DateTime DateTime { get; }
        public double Weight { get; set; }
        public double Height { get; set; }
        #endregion

        /// <summary>
        /// Пользователь
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="gender">Пол</param>
        /// <param name="birthDate">День рождения</param>
        /// <param name="weight">Вес</param>
        /// <param name="height">Рост</param>
        public User(string name,
            Gender gender,
            DateTime birthDate,
            double weight,
            double height)
        {
            #region Проверка условий
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Имя не может пыть пустым", nameof(name));
            }

            if (gender == null)
            {
                throw new ArgumentNullException("Пол не может быть null", nameof(gender));
            }

            if (birthDate < DateTime.Parse("01.01.1900") || birthDate <= DateTime.Now)
            {
                throw new ArgumentException("Невозможная дата рождения", nameof(birthDate));
            }

            if (weight <= 0)
            {
                throw new ArgumentException("Вес не может быть меньше или равен нулю", nameof(weight));
            }

            if (height < 0)
            {
                throw new ArgumentException("Рост не может быть меньше или равен нулю", nameof(height));
            }
            #endregion
            Name = name;
            Gender = gender;
            DateTime = birthDate;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
