using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EdabitTest.Hard
{
    class SnakeToCamelAndBack
    {
        public static string ToCamelCase(string sentence)
        {
            var arr = sentence.Split('_');
            var camelCase = arr[0];
            for (var i = 1; i < arr.Length; i++)
            {
                var stringy = arr[i];
                camelCase += char.ToUpper(stringy[0]) + stringy.Substring(1);
            }
            return camelCase;
        }
        public static string ToSnakeCase(string sentence)
        {
            var snake_case = string.Empty;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (char.IsUpper(sentence[i]))
                {
                    snake_case += "_" + char.ToLower(sentence[i]);
                }
                else snake_case += sentence[i];
            }
            return snake_case;
        }
    }
}
