using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Constants;

namespace Converters
{
    public static class Converter
    {
        public static int? BoolToInt(bool? value) => value is null ? null : (int?)((bool)value ? 0 : 1);

        public static bool? IntToBool(int? value) => value is null ? null : (bool?)(value == 0 ? true : false);

        public static string IntToString(int? value) => MainConstants.Mails.
            Select((item, index) => new { Index = (int?)index, Item = item }).
            FirstOrDefault((val) => val.Index == value).Item;

        public static int? StringToInt(string value) => MainConstants.Mails.
            Select((item, index) => new { Index = (int?)index, Item = item }).
            FirstOrDefault((val) => val.Item == value).Index;


    }
}
