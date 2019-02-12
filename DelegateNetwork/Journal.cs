using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateNetwork
{
    class Journal
    {
        private readonly string Name;
        private JournalEntry[] journal = new JournalEntry[0]; //Массив элементов журнала

        public Journal(string _name) //Конструктор
        {
            Name = _name;
        }

        public void Add(JournalEntry message) //Добавление записи в журнал
        {
            Array.Resize(ref journal, journal.Length + 1);
            journal[journal.Length - 1] = message;
        }

        public override string ToString() //Нормальный вывод
        {
            var title = $"\nНовости для {Name}:\n";
            var count = 0;
            foreach (var message in journal)
            {
                title = string.Concat(title, ++count, ". ", message.ToString(), "\n");
            }
            return title;
        }

        public void JournalChanged(object source, PersonHandlerEventArgs args) //Обработчик сообщений
        {
            var message = new JournalEntry(args.Source, args.Changes, args.Time, args.Information);
            Add(message);
        }
    }
}
