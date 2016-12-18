using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject
{
    class ValidationClass
    {
        public bool ValidateVolume(string volume)
        {
            if (volume.Contains('.')) volume = volume.Replace('.', ',');
            decimal temp;
            bool vol = decimal.TryParse(volume,out temp);
            return vol;
        }
    }

    class CorrectValue
    {
        public string CorrectVolume(string str)
        {
            string volume = str.Contains('.') ? str.Replace('.', ',') : str;
            if (volume.Contains(','))
            {
                volume += "000";
                volume = volume.Substring(0, volume.IndexOf(',') + 4);
            }
            return volume;
        }
    }
}
