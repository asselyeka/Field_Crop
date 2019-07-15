using System;
using System.Collections.Generic;
using System.Text;

namespace Country
{
    public class Field
    {
        private string _crop;
        private Watering _watering;

        public string GetCrop() { return _crop; }

        public void SetCrop(string crop) { _crop = crop; }
        public void SetWatering(int waterVolume, DateTime startDate, DateTime endDate, int frequency)
        {
            _watering = new Watering();
            _watering.SetSchedule(waterVolume, startDate, endDate, frequency);
        }


    }
}
