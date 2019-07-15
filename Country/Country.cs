using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Country
{
    public class Country
    {
        private Field[] _fields;
        private int _fieldSize;


        public void CreateField()
        {
            WriteLine("Введите культуру для нового поле: ");
            var crop = ReadLine();
            if (_fieldSize == 0)
            {
                _fieldSize = 1;
                _fields = new Field[_fieldSize];
                _fields[_fieldSize - 1] = new Field();
                _fields[_fieldSize - 1].SetCrop(crop);
            }
            else
            {
                _fieldSize += 1;
                _fields[_fieldSize-1]= new Field();
                _fields[_fieldSize - 1].SetCrop(crop);
            }
        }

        public void EditField()
        {
            for (int i = 0; i < _fieldSize; i++)
            {
                Write((i + 1) + "." + _fields[i].GetCrop());
            }
            WriteLine("\nВыберите номер поля для редактирования: ");
            var index = Int32.Parse(ReadLine());
            WriteLine("Введите культуру для поле: ");
            var crop = ReadLine();
            _fields[index - 1].SetCrop(crop);
        }


        public void CreateWatering()
        {
            for(int i = 0; i < _fieldSize; i++)
            {
                Write((i+1)+"."+ _fields[i].GetCrop());
            }
            WriteLine("\nВыберите номер поля для создания расписания полива: ");
            var index = Int32.Parse(ReadLine());
            WriteLine("Объем воды для полива: ");
            var waterVolume = Int32.Parse(ReadLine());
            WriteLine("Дата первого полива(формат ввода ГГГГ.ММ.ДД): ");
            var startDate = DateTime.Parse(ReadLine());
            WriteLine("Дата последнего полива(формат ввода ГГГГ.ММ.ДД): ");
            var endData = DateTime.Parse(ReadLine());
            WriteLine("Периодичность:");
            var frequency = Int32.Parse(ReadLine());
            //_fields[index] = new Field();
            _fields[index].SetWatering(waterVolume, startDate, endData, frequency);

        }
        public void EditWatering()
        {
            for (int i = 0; i < _fieldSize; i++)
            {
                Write((i + 1) + "." + _fields[i].GetCrop());
            }
            WriteLine("\nВыберите номер поля для редактирования расписания полива: ");
            var index = Int32.Parse(ReadLine());
            WriteLine("Объем воды для полива: ");
            var waterVolume = Int32.Parse(ReadLine());
            WriteLine("Дата первого полива(формат ввода ГГГГ.ММ.ДД): ");
            var startDate = DateTime.Parse(ReadLine());
            WriteLine("Дата последнего полива(формат ввода ГГГГ.ММ.ДД): ");
            var endData = DateTime.Parse(ReadLine());
            WriteLine("Периодичность:");
            var frequency = Int32.Parse(ReadLine());
            _fields[index].SetWatering(waterVolume, startDate, endData, frequency);

        }
        public string SearchCrop(string crop)
        {
            var fullCropName = "";
            foreach (Field element in _fields)
            {
                if (crop.Contains(element.GetCrop()))
                    fullCropName = element.GetCrop();
            }
            if (fullCropName == "")
                return "Нет такой культуры";
            else
                return fullCropName;
        }
       
        
    }
}
