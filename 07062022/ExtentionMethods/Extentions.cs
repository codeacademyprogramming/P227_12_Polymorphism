using System;
using System.Collections.Generic;
using System.Text;

namespace ExtentionMethods
{
    internal static class Extentions
    {
        public static int Add(this int number,int additionalNum)
        {
            return number + additionalNum;
        }

        public static string ToCapitalize(this string str)
        {
            if (str != null && str.Length>1)
            {
                str = str.ToLower();
                str = Char.ToUpper(str[0]) + str.Substring(1);
            }

            return str;
        }

        public static bool HasDigit(this string str)
        {
            if (!String.IsNullOrWhiteSpace(str))
            {
                foreach (var chr in str)
                {
                    if (Char.IsDigit(chr))
                        return true;
                }
            }
            return false;
        }

        public static int[] Add(this int[] arr,int num)
        {
            if (arr != null)
            {
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = num;
            }

            return arr;
        }
    }
}
