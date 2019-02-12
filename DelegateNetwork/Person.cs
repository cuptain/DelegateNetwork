﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateNetwork
{
    public enum TGender { MAN, WOMAN } //Пол
    public enum TStatus { NOT_CHOSEN, NOT_MARRIED, IN_RELATIONSHIP, ENGAGED, MARRIED, IN_LOVE, COMPLICATED, IN_ACTIVE_SEARCH, LONELY_LOOSER } //Семейные положения

    public delegate void PersonHandler(object source, PersonHandlerEventArgs args); //Делегат

    public class Person
    {
        #region Properties
        private string fullName; //ФИО
        private DateTime birthDate; //Дата рождения
        private TGender gender; //Пол
        private string school; //Школа
        private string university; //Университет
        private TStatus martialStatus; //Семейное положение
        #endregion

        #region Fields
        public List<Person> friends; //Список друзей
        public List<string> news; //Список новостей
        public List<string> pictures; //Список изоюражений
        private Journal journal; //Журнал обновлений
        #endregion

        public event PersonHandler PersonChanged; //Событие

        public void OnPersonChanged(object source, PersonHandlerEventArgs args) //Фиксатор изменений
        {
            PersonChanged(source, args);
        }

        #region SelfInfoChanges
        public void CheckBirth(Person person) //Проверка на ДР
        {
            if (DateTime.Now.Day == person.birthDate.Day && DateTime.Now.Month == person.birthDate.Month)
            {
                person.OnPersonChanged(person,
                    new PersonHandlerEventArgs(person.fullName, "Новости, День рождения", DateTime.Now, "Сегодня " + person.fullName + " отмечает День Рождения!"));
            }
        }

        public string FullName //Смена ФИО
        {
            get => fullName;
            set
            {
                OnPersonChanged(this,
                    new PersonHandlerEventArgs(fullName + $"({value})", "Смена личной информации, ФИО", DateTime.Now, $"ФИО изменено с {fullName} на {value}"));
                fullName = value;
                CheckBirth(this);
            }
        }

        public DateTime BirthDate //Смена Даты Рождения
        {
            get => birthDate;
            set
            {
                OnPersonChanged(this,
                    new PersonHandlerEventArgs(fullName, "Смена личной информации, Дата Рождения", DateTime.Now, $"Дата рождения изменена с {birthDate.Date} на {value.Date}"));
                birthDate = value;
                CheckBirth(this);
            }
        }

        public TGender Gender //Смена пола
        {
            get => gender;
            set {
                OnPersonChanged(this,
                    new PersonHandlerEventArgs(fullName, "Смена личной информации, Пол", DateTime.Now, $"Пол изменён с {gender} на {value}"));
                gender = value;
                CheckBirth(this);
            }
        }

        public string School //Смена школы
        {
            get => school;
            set
            {
                OnPersonChanged(this,
                    new PersonHandlerEventArgs(fullName, "Смена личной информации, Школа)", DateTime.Now, $"Школа изменена с {school} на {value}"));
                school = value;
                CheckBirth(this);
            }
        }

        public string University //Смена университета
        {
            get => university;
            set
            {
                OnPersonChanged(this,
                    new PersonHandlerEventArgs(fullName, "Смена личной информации, ВУЗ", DateTime.Now, $"ВУЗ изменен с {university} на {value}"));
                university = value;
                CheckBirth(this);
            }
        }

        public TStatus MartialStatus //Смена семейного положения
        {
            get => martialStatus;
            set
            {
                OnPersonChanged(this,
                    new PersonHandlerEventArgs(fullName, "Смена личной информации, Семейное положение", DateTime.Now, $"Семейное положение изменено с {martialStatus} на {value}"));
                martialStatus = value;
                CheckBirth(this);
            }
        }
        #endregion
    }
}
