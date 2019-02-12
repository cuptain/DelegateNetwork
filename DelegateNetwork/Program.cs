using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateNetwork
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Person person1 = new Person("Белкина Галина Степановна", new DateTime(1987, 1, 19), "Женский", "Школа №122", "ПНИПУ", "Замужем");
            Person person2 = new Person("Василюк Василий Алексеевич", new DateTime(1999, 4, 1), "Мужской", "Лицей №4", "НИУ ВШЭ", "Не женат");
            Person person3 = new Person("Подмышкин Олег Александрович", new DateTime(2001, 12, 12), "Мужской", "Гимназия №1", "МГУ", "В активном поиске");
            Person person4 = new Person("Упорова Элен Азаматовна", new DateTime(1998, 6, 26), "Женский", "Лицей для одарённых детей", "ПГНИУ", "Свободна");

            person4.AddFriend(ref person1);
            person4.AddFriend(ref person3);
            person3.AddFriend(ref person2);
            person3.AddFriend(ref person4);          
            person4.AddNews("Я поела");
            person4.AddPicture("Я на первой паре. Сплю");         
            person1.AddFriend(ref person4);
            person2.AddFriend(ref person4);
            person2.AddFriend(ref person3);
            person4.DeleteNews("Нашла 50 рублей на улице. Куплю поесть");
            person4.FullName = "Здравова Полина Эдуардовна";
            person4.MartialStatus = "Замужем";      
            person3.AddPicture("Смотрите, где я. Это автобус");
            person4.DeleteFriend(ref person1);
            person3.AddNews("Меня выгнали из автобуса из-за фото");
            person3.DeleteNews("Хочу прокатиться на автобусе");
            person3.BirthDate = new DateTime(1998, 1, 1);
            person3.AddNews("Теперь я совершеннолетний");
            person3.MartialStatus = "Свободен";
            person1.AddNews("Пошла гулять с собакой");
            person1.AddPicture("Бегущая собака");         
            person2.AddFriend(ref person4);
            person2.AddFriend(ref person3);
            person1.AddNews("Моя собака убежала от меня");
            person2.AddFriend(ref person1);
            person2.AddNews("Люблю друзей");
            person2.AddPicture("Сфоткался с оценками по КПО. Всё отлично");
            person2.AddPicture("Ловите скриншот моей новой лабы по КПО. Выглядит отпадно");
            person2.DeleteNews("Если поступать, то только в политех");
            person2.DeleteNews("Ищу девушку");   
            person1.AddPicture("У меня растут усы, надо что-то делать");
            person1.Gender = "Мужской";
            person1.FullName = "Краснов Михаил Михайлович";
            person1.AddNews("И такое бывает");

            Console.WriteLine(person1.Show());
            Console.WriteLine(person2.Show());
            Console.WriteLine(person3.Show());
            Console.WriteLine(person4.Show());
            Console.ReadKey();
        }
    }
}
