using System;
using System.Collections.Generic;

namespace InspectorLib
{
    public class FunctionInsp
    {
        private string _carInspectionName = "Автоинспекция г. Чита";
        private string _chiefInspector = "Васильев Василий Иванович";
        private List<string> _workers = new List<string>() { "Иванов И.И.", "Зиронов Т.А.", "Миронов А.В.", "Васильев В.И." };
        private Random _random = new Random(); // Инициализируем Random здесь

        public string GetInspector()
        {
            return _chiefInspector;
        }

        public string GetCarInspection()
        {
            return _carInspectionName;
        }

        public bool SetInspector(string fullname)
        {
            if (_workers.Contains(fullname))
            {
                _chiefInspector = fullname;
                return true;
            }
            return false;
        }

        public string GenerateNumber(string symbol, int code = 75)
        {
            int number = _random.Next(1000, 10000); // Генерируем 4-значный номер
            return symbol.ToUpper() + number + "_" + code;
        }

        public List<string> GetWorkers()
        {
            return _workers;
        }

        public void AddWorker(string fullname)
        {
            _workers.Add(fullname);
        }
    }
}