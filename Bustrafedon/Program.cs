using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
namespace Bustrafedon
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//GitHub

			///Нужно такое понятие как строка, пока попробую массивом строк бустрафайдить одну строку из массива на вход
			//Получение текста от пользователя
			//string[] textStrings = new string[500000];
			List<string> textStrings = new List<string>();
			//textStrings[0] = "Октябрь уж наступил — уж роща отряхает";
			//textStrings[1] = "Последние листы с нагих своих ветвей;";
			//textStrings[2] = "Дохнул осенний хлад — дорога промерзает.";
			//textStrings[3] = "Журча еще бежит за мельницу ручей.";

			//консольный ввод
			//Console.WriteLine("Чтобы закончить ввод нажмите Esc:");
			//bool userInput = true;
			//string userText;
			//int i = 0;
			//while (userInput)
			//{
			//	Console.WriteLine("Введите строку:");
			//	userText = Console.ReadLine();
			//	if (userText == "")
			//	{
			//		break;
			//	}
			//	textStrings[i] = userText;
			//	i++;

			//}

			//вариант с копипастом из файла
			string path = "UserText.txt";
			//передаем построчно то что находится в файле в массив textStrings
			using(StreamReader sr = new StreamReader(path, Encoding.UTF8)) 
			{
				string line;
				//int lineCounter = 0;
				while ((line = sr.ReadLine()) != null)
				{
					//lineCounter++;
					Console.WriteLine(line);
					textStrings.Add(line);
				}
			}

			//foreach (string s in textStrings)//вывели исходный текст
			//{
			//	if(s != null)
			//	Console.WriteLine(s);
			//}
			Console.WriteLine();


			//BustrafideText(textStrings);//Должно вывести текст, где каждая 2 строка развернута в обратную сторону

			BustrafideAndWriteToTXT(textStrings);

			//Console.WriteLine();
			//string outputPath = "ProcessedText.txt";
			//using (StreamWriter sw = new StreamWriter(outputPath))
			//{
			//	foreach (string line in textStrings)
			//	{
			//		sw.WriteLine(line);
			//	}
			//}

			//написать текст в документ
			//for (int i = 0; i < textStrings.Count; i++)
			//{
			//	using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
			//	{
			//		sw.WriteLine(textStrings[i]);
			//	}
			//}

			Console.ReadKey();
		}
		static void BustrafideText(List<string> text)
		{
			//Получаем текст
			//List<string> bustrafidedText = new List<string>();
			
			//Печатает первую, после 2 в обратной и т д
			//Берем каждую второю строку
			
			for (int i = 0; i < text.Count; i++)
			{
				//можно в одну text[i] != null вынести
				if (i % 2 == 1)
				{
					if (text[i] != null && text[i] != " ")
					{
						text[i].ToCharArray();
						for (int j = text[i].Length - 1; j >= 0; j--)
						{
							Console.Write(text[i][j]);							
						}
					}
				}
				else
				{
					if (text[i] != null && text[i] != " ")
					{
						Console.Write(text[i]);
						
						//sw.Write(text[i]);
					}

				}
				if (text[i] != null && text[i] != " ")
				{
					Console.WriteLine();
					
				}

			}

			//записать в файл текст
			
			

			//Разворачиваем ее
			//Выводим весь текст
		}
		static void BustrafideAndWriteToTXT(List<string> text)
		{
			//Получаем текст
			//List<string> bustrafidedText = new List<string>();

			//Печатает первую, после 2 в обратной и т д
			//Берем каждую второю строку
			string outputPath = "ProcessedText.txt";
			//using (StreamWriter sw = new StreamWriter(outputPath))
			using (StreamWriter streamWriter = new StreamWriter(outputPath))
			{
				for (int i = 0; i < text.Count; i++)
				{
					//можно в одну text[i] != null вынести
					if (i % 2 == 1)
					{
						if (text[i] != null && text[i] != " ")
						{
							text[i].ToCharArray();
							for (int j = text[i].Length - 1; j >= 0; j--)
							{
								//Console.Write(text[i][j]);
								streamWriter.Write(text[i][j]);
							}
						}
					}
					else
					{
						if (text[i] != null && text[i] != " ")
						{
							//Console.Write(text[i]);
							streamWriter.Write(text[i]);
						}

					}
					if (text[i] != null && text[i] != " ")
					{
						//Console.WriteLine();
						streamWriter.WriteLine();
					}

				}

			}

			//записать в файл текст



			//Разворачиваем ее
		}

	}
}
