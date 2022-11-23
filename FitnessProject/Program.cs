using FitnessProject.BL.Controller;
using FitnessProject.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace FitnessProject.CMD
{
    internal class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Вас приветствует приложение Fitness");
            Console.WriteLine("Введите имя пользователя");
            var name = Console.ReadLine();
            
            Console.WriteLine("Введите пол пользователя");
            var gender = Console.ReadLine();
            
            Console.WriteLine("Введите дату рождения");
            var birthdate =DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите вес");
            var weight =double.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите рост");
            var height = double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, birthdate, weight, height);
            userController.Save();
        
        }
    }
}
