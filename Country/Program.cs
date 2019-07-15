using System;
using static System.Console;

namespace Country
{
    class Program
    {
        static void Main(string[] args)
        {


            Country country = new Country();
            do
            {

                WriteLine("1. Поле\n2. Расписание для полива\n3.Поиск по культуре\n");
                WriteLine("Выберите номер раздела меню: ");
                var menuAnswer = Int32.Parse(ReadLine());
                switch (menuAnswer)
                {
                    case 1:
                        WriteLine("1. Создать\n2. Редактировать\n3. Удалить");
                        var fieldMenuAnswer = Int32.Parse(ReadLine());
                        switch (fieldMenuAnswer)
                        {
                            case 1:
                                country.CreateField();
                                break;
                            case 2:
                                country.EditField();
                                break;
                            case 3:
                                break;
                        }
                        break;
                    case 2:
                        WriteLine("1. Создать\n2. Редактировать\n3. Удалить");
                        var wateringMenuAnswer = Int32.Parse(ReadLine());
                        switch (wateringMenuAnswer)
                        {
                            case 1:
                                country.CreateWatering();
                                break;
                            case 2:
                                country.EditWatering();
                                break;
                            case 3:
                                break;
                        }
                        break;
                    case 3:
                        WriteLine("Введите слово для поиска:");
                        var wordForSearch = ReadLine();
                        country.SearchCrop(wordForSearch);
                        break;

                }
            }
            while (true);
        }
    }
}
