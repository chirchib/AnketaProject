﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnketaProject
{
    class Profile
    {
		//Конструктор класса, с обработкой исключений и передачей аргументов в словарь
		public Profile(in string Name, in string Surname, in uint Age, in string Gender)
		{
			name = Name;
			surname = Surname;
			age = Age;
			gender = Gender;
			DateTime = DateTime.Now;
		}

		private string Name;//Имя
		public string name
		{
			get
			{
				return Name;
			}
			private set
			{
				try
				{
					if (value == null)
						throw new ArgumentNullException();
				}
				catch (ArgumentNullException)
				{
					Console.WriteLine("Исключение: Не корректное имя!");
				}
				Name = value;
			}
		}


		private string Surname;//Фамилия
		public string surname
		{
			get
			{
				return Surname;
			}
			private set
			{
				try
				{
					if (value == null)
						throw new ArgumentNullException();
				}
				catch (ArgumentNullException)
				{
					Console.WriteLine("Исключение: Не корректная фамилия!");
				}
				Surname = value;
			}
		}


		private uint Age;//Возраст
		public uint age
		{
			get
			{
				return Age;
			}
			private set
			{
				try
				{
					if (value < 0)
					{
						throw new ArgumentOutOfRangeException();
					}
				}
				catch (ArgumentOutOfRangeException)
				{
					Console.WriteLine("Исключение: Не корректный возраст!");
				}
				Age = value;
			}
		}


		private string Gender;//Пол
		public string gender
		{
			get
			{
				return Gender;
			}
			private set
			{
				try
				{
					if (value == null)
					{
						throw new ArgumentNullException();
					}
				}
				catch (ArgumentNullException)
				{
					Console.WriteLine("Исключение: Не корректный пол!");
				}
				Gender = value;
			}
		}

		public DateTime DateTime { get; private set; }//Дата

		//Правописание «год», «года» или «лет»
		private string Year(uint year)
		{
			uint t1 = year % 10;
			uint t2 = year % 100;
			if (t1 == 1 && t2 != 11)
				return "год";
			if (t1 >= 2 && t1 <= 4 && (t2 < 10 || t2 >= 20))
				return "года";
			else
				return "лет";
		}

		//Возврат строки
		public string FormateToString()
		{
			return $"{Name} {Surname} {Age} {Year(Age)} {Gender}";
		}
	}
}
