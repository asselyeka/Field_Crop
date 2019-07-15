using System;
using System.Collections.Generic;
using System.Text;

namespace Country
{
    public class Watering
    {
        private int         _waterVolume;
        private DateTime    _startDate;
        private DateTime    _endDate;
        private int         _frequency; // 1-everyday, 2- once per 2 days, 3- once per 3 days, etc

        public Watering()
        {
            _waterVolume = 0;
            _startDate = DateTime.Now;
            _endDate = _startDate.AddMonths(1);
            _frequency = 0;
        }

        public void SetSchedule(int waterVolume, DateTime startDate, DateTime endDate, int frequency)
        {
            _waterVolume = waterVolume;
            _startDate = startDate;
            _endDate = endDate;
            _frequency = frequency;
        }


    }
}
