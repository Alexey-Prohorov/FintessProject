using FitnessProject.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProject.BL.Controller
{
    public class UserController
    {
        /// <summary>
        /// Пользователь приложения
        /// </summary>
        public User User { get; }

        /// <summary>
        /// Создание нового контроллера пользователя.
        /// </summary>
        /// <param name="user"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public UserController (string userName, string genderName, DateTime birthDate, double weigth, double heigth)
        {
            //TODO: Проверка
            var gender = new Gender(genderName);
            User = new User(userName, gender, birthDate, weigth, heigth);
        }
        /// <summary>
        /// Сохранить данные пользователя
        /// </summary>
        public void Save ()
        { 
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("user.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }
        /// <summary>
        /// Получить данные пользователя
        /// </summary>
        /// <returns>Пользователь приложения.</returns>
        public UserController()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("user.dat", FileMode.OpenOrCreate))
            {
                if (formatter.Deserialize(fs) is User user)
                {
                    User = user; 
                }
                //TODO: что делать если не прочитали?
            }
        }
    }
}
