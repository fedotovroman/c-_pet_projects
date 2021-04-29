using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDate
{
     static class DataChecker
    {
        public static string ClientRegCheck(string fnam,string nam,string lastn,string pass,string phonen,string ser_p,string numbp) 
        {
            char[] arr_ru = {'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'э', 'ю', 'я', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Э', 'Ю', 'Я' };
            char[] arr_en = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z','1','2','3','4','5','6','7','8','9','0' };
            char[] arr_numb = { '0','1','2','3','4','5','6','7','8','9'};
            foreach (char c in fnam.Replace(" ", ""))
            {
                if (!arr_ru.Contains(c)) 
                    return "Ошибка: ФИО должно состоять только из букв русского алфавита";  
            }

            foreach (char c in nam.Replace(" ", ""))
            {
                if (!arr_ru.Contains(c))
                    return "Ошибка: ФИО должно состоять только из букв русского алфавита";
            }

            foreach (char c in lastn.Replace(" ", ""))
            {
                if (!arr_ru.Contains(c))
                    return "Ошибка: ФИО должно состоять только из букв русского алфавита";
            }

            foreach (char c in pass.Replace(" ", ""))
            {
                if (!arr_en.Contains(c))
                    return "Ошибка: пароль может состоять только из символов английского алфавита и цифр от 1 до 9";
            }

            foreach (char c in ser_p.Replace(" ", ""))
            {
                if (!arr_numb.Contains(c))
                    return "Ошибка: серия паспорта введена неверно";
            }

            foreach (char c in numbp.Replace(" ", ""))
            {
                if (!arr_numb.Contains(c))
                    return "Ошибка: номер паспорта введен неверно";
            }

            foreach (char c in phonen.Replace(" ", ""))
            {
                if (!arr_numb.Contains(c))
                    return "Ошибка: номер телефона введен неверно";
            }

            if (pass.Length <= 6) return "Ошибка: Пароль должен состоять более чем из 6 символов";
            if (numbp.Length != 6) return "Ошибка: Номер паспорта введен неверно";
            if (ser_p.Length != 4) return "Ошибка: Серия паспорта введен неверно";


            return "YES";
        }
    }
}
