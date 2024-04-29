using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Bustrafedon
{
	internal class Program
	{
		static void Main(string[] args)
		{
			///Нужно такое понятие как строка, пока попробую массивом строк бустрафайдить одну строку из массива на вход
			//Получение текста от пользователя
			string[] textStrings = new string[4];
			textStrings[0] = "Октябрь уж наступил — уж роща отряхает";
			textStrings[1] = "Последние листы с нагих своих ветвей;";
			textStrings[2] = "Дохнул осенний хлад — дорога промерзает.";
			textStrings[3] = "Журча еще бежит за мельницу ручей.";
			foreach (string s in textStrings)
			{
				Console.WriteLine(s);
			}
			Console.WriteLine();
			//Разворото каждой второй строки
			BustrafideText(textStrings);
			Console.ReadKey();
		}
		static void BustrafideText(string[] text)
		{
			//Получаем текст
			

				for (int i = 1; i <= text.Length; i += 2)
				{
					
					text[i].ToCharArray();
					for (int j = text[i].Length - 1; j >= 0; j--)
					{
						Console.Write(text[i][j]);
					}
				}
				Console.WriteLine();
			
			//Берем каждую второю строку
			
			
			//Разворачиваем ее
			//Выводим весь текст
		}

	}
}
