/*1.Создать примитивный англо-русский и русскоанглийский словарь, содержащий пары слов —
названий стран на русском и английском языках.
Пользователь должен иметь возможность выбирать
направление перевода и запрашивать перевод*/
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Green;
            Hashtable dictionary = new Hashtable();
            dictionary.Add("Abkhazia", "Абхазия");
            dictionary.Add("Afghanistan", "Афганистан");
            dictionary.Add("Albania", "Албания");
            dictionary.Add("Algeria", "Алжир");
            dictionary.Add("Argentina", "Аргентина");
            dictionary.Add("Armenia", "Армения");
            dictionary.Add("Australia", "Австралия");
            dictionary.Add("Austria", "Австрия");
            dictionary.Add("Azerbaijan", "Азербайджан");
            dictionary.Add("Bahamas", "Багамские о-ва");
            dictionary.Add("Bahrain", "Бахрейн");
            dictionary.Add("Bangladesh", "Бангладеш");
            dictionary.Add("Belarus", "Беларусь");
            dictionary.Add("Belgium", "Бельгия");
            dictionary.Add("Bermuda Islands", "Бермудские о-ва");
            dictionary.Add("Bolivia", "Боливия");
            dictionary.Add("Brazil", "Бразилия");
            dictionary.Add("Bulgaria", "Болгария");
            dictionary.Add("Burundi", "Бурунди");
            dictionary.Add("Cambodia", "Камбоджа");
            dictionary.Add("Cameroon", "Камерун");
            dictionary.Add("Canada", "Канада");
            dictionary.Add("Chile", "Чили");
            dictionary.Add("China", "Китай");
            dictionary.Add("Colombia", "Колумбия");
            dictionary.Add("Congo", "Конго");
            dictionary.Add("Costa Rica", "Коста-Рика");
            dictionary.Add("Cuba", "Куба");
            dictionary.Add("Cyprus", "Кипр");
            dictionary.Add("Czech Republic", "Чехия");
            dictionary.Add("Denmark", "Дания");
            dictionary.Add("Dominican Republic", "Доминиканская Республика");
            dictionary.Add("Ecuador", "Эквадор");
            dictionary.Add("Egypt", "Египет");
            dictionary.Add("El Salvador", "Сальвадор");
            dictionary.Add("Estonia", "Эстония");
            dictionary.Add("Ethiopia", "Эфиопия");
            dictionary.Add("Finland", "Финляндия");
            dictionary.Add("France", "Франция");
            dictionary.Add("Georgia", "Грузия");
            dictionary.Add("Germany", "Германия");
            dictionary.Add("Ghana", "Гана");
            dictionary.Add("Gibraltar", "Гибралтар");
            dictionary.Add("Great Britain", "Великобритания");
            dictionary.Add("United Kingdom", "Соединенное королевство");
            dictionary.Add("Greece", "Греция");
            dictionary.Add("Guatemala", "Гватемала");
            dictionary.Add("Guinea", "Гвинея");
            dictionary.Add("Haiti", "Гаити");
            dictionary.Add("Hawaii", "Гавайи");
            dictionary.Add("Honduras", "Гондурас");
            dictionary.Add("Hong Kong", "Гонконг");
            dictionary.Add("Hungary", "Венгрия");
            dictionary.Add("Iceland", "Исландия");
            dictionary.Add("India", "Индия");
            dictionary.Add("Indonesia", "Индонезия");
            dictionary.Add("Iran", "Иран");
            dictionary.Add("Iraq", "Ирак");
            dictionary.Add("Ireland", "Ирландия");
            dictionary.Add("Israel", "Израиль");
            dictionary.Add("Italy", "Италия");
            dictionary.Add("Ivory Coast", "Берег Слоновой Кости");
            dictionary.Add("Jamaica", "Ямайка");
            dictionary.Add("Japan", "Япония");
            dictionary.Add("Kazakhstan", "Казахстан");
            dictionary.Add("Kenya", "Кения");
            dictionary.Add("Kuwait", "Кувейт");
            dictionary.Add("Kyrgyzstan", "Киргизия");
            dictionary.Add("Latvia", "Латвия");
            dictionary.Add("Lebanon", "Ливан");
            dictionary.Add("Liberia", "Либерия");
            dictionary.Add("Libya", "Ливия");
            dictionary.Add("Lithuania", "Литва");
            dictionary.Add("Luxemburg", "Люксембург");
            dictionary.Add("Madagascar", "Мадагаскар");
            dictionary.Add("Malawi", "Малави");
            dictionary.Add("Malaysia", "Малайзия");
            dictionary.Add("Malta", "Мальта");
            dictionary.Add("Mexico", "Мексика");
            dictionary.Add("Moldova", "Молдавия");
            dictionary.Add("Monaco", "Монако");
            dictionary.Add("Mongolia", "Монголия");
            dictionary.Add("Morocco", "Марокко");
            dictionary.Add("Nepal", "Непал");
            dictionary.Add("Netherlands", "Нидерланды");
            dictionary.Add("Holland", "Голландия");
            dictionary.Add("New Zeland", "Новая Зеландия");
            dictionary.Add("Nicaragua", "Никарагуа");
            dictionary.Add("Nigeria", "Нигерия");
            dictionary.Add("North Korea", "Северная Корея");
            dictionary.Add("Norway", "Норвегия");
            dictionary.Add("Oman", "Оман");
            dictionary.Add("Pakistan", "Пакистан");
            dictionary.Add("Panama", "Панама");
            dictionary.Add("Papua New Guinea", "Папуа — Новая Гвинея");
            dictionary.Add("Paraguay", "Парагвай");
            dictionary.Add("Peru", "Перу");
            dictionary.Add("Philippines", "Филиппины");
            dictionary.Add("Poland", "Польша");
            dictionary.Add("Portugal", "Португалия");
            dictionary.Add("Puerto Rico", "Пуэрто-Рико");
            dictionary.Add("Romania", "Румыния");
            dictionary.Add("Russia", "Россия");
            dictionary.Add("Rwanda", "Руанда");
            dictionary.Add("Saudi Arabia", "Саудовская Аравия");
            dictionary.Add("Senegal", "Сенегал");
            dictionary.Add("Sierra Leone", "Сьерра-Леоне");
            dictionary.Add("Singapore", "Сингапур");
            dictionary.Add("Slovakia", "Словакия");
            dictionary.Add("Slovenia", "Словения");
            dictionary.Add("South Africa", "Южная Африка");
            dictionary.Add("South Korea", "Южная Корея");
            dictionary.Add("South Ossetia", "Южная Осетия");
            dictionary.Add("Spain", "Испания");
            dictionary.Add("Sri Lanka", "Шри-Ланка");
            dictionary.Add("Sudan", "Судан");
            dictionary.Add("Sweden", "Швеция");
            dictionary.Add("Switzerland", "Швейцария");
            dictionary.Add("Syria", "Сирия");
            dictionary.Add("Taiwan", "Тайвань");
            dictionary.Add("Tajikistan", "Таджикистан");
            dictionary.Add("Thailand", "Таиланд");
            dictionary.Add("Togo", "Того");
            dictionary.Add("Tunisia", "Тунис");
            dictionary.Add("Turkey", "Турция");
            dictionary.Add("Turkmenistan", "Туркменистан");
            dictionary.Add("Uganda", "Уганда");
            dictionary.Add("Ukraine", "Украина");
            dictionary.Add("United Arab Emirates", "Объединенные Арабские Эмираты");
            dictionary.Add("United States of America / USA", "США");
            dictionary.Add("USA", "США");
            dictionary.Add("Uruguay", "Уругвай");
            dictionary.Add("Uzbekistan", "Узбекистан");
            dictionary.Add("Venezuela", "Венесуэла");
            dictionary.Add("Yemen", "Йемен");
            dictionary.Add("Zaire", "Заир");
            dictionary.Add("Zambia", "Замбия");
            dictionary.Add("Zimbabwe", "Зимбабве");
            WriteLine("\tДобро пожаловать в англо-русский и русско-английский словарь!");
            int answer = 0;
            do
            {
                WriteLine("Выберите направление перевода:");
                WriteLine("Нажмите 1 - англо-русский");
                WriteLine("Нажмите 2 - русско-английский");
                WriteLine("Нажмите 0 для завершения работы");
                try
                {
                    answer = Convert.ToInt32(ReadLine());
                }
                catch (Exception ex)
                {
                    WriteLine(ex.Message);
                }
                switch (answer)
                {
                    case 1:
                        WriteLine("Введите название страны на английском:");
                        string country = ReadLine();
                        if (dictionary.ContainsKey(country))
                        {
                            foreach (object item in dictionary.Keys)
                            {
                                if (country == Convert.ToString(item))
                                    WriteLine("перевод: " + dictionary[item]);
                            }
                        }
                        else
                            WriteLine("Такой страны в словаре нет, проверьте правильность ввода");
                        break;
                    case 2:
                        WriteLine("Введите название страны на русском:");
                        country = ReadLine();
                        if (dictionary.ContainsValue(country))
                        {
                            foreach (object item in dictionary.Keys)
                            {
                                if (country == Convert.ToString(dictionary[item]))
                                    WriteLine("перевод: " + item);
                            }
                        }
                        else
                            WriteLine("Такой страны в словаре нет, проверьте правильность ввода");
                        break;
                    default:
                        break;
                }

            }
            while (answer != 0);

            ReadKey();
        }
    }
}
