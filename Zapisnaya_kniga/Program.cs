using System;
using System.Collections.Generic;

namespace Zapisnaya_kniga
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Привет!это записная книжка! Напишите Create, чтобы создать нового абонента , Edit - редактировать , Delete - удалить , Show - просмотреть все учетные записи , Maininfo - просмотреть основную информацию (Фамилия, Имя, Номер)");
            Function_of_book eks = new Function_of_book();
        }

    }
    public class Zapis
    {
        public string name { get; set; }
        public string sername { get; set; }
        public string number { get; set; }

        public string otches { get; set; }
        public string country { get; set; }
        public string datebirth { get; set; }
        public string org { get; set; }
        public string doljnost { get; set; }
        public string zametki { get; set; }


        //public override string ToString()
        //{
        //    return $"{sername},{name},{otches},{number},{country},{datebirth},{org},{doljnost},{zametki}";
        //}
    }
    public class Function_of_book
    {
        public Dictionary<int, Zapis> polya = new Dictionary<int, Zapis>();
        public static int id = 0;
        public Function_of_book()
        {
            Console.WriteLine("Привет!это записная книжка!");
            while (true)
            {
                Console.WriteLine("Напишите Create, чтобы создать нового абонента  \nEdit - редактировать  \nDelete - удалить \nShow - просмотреть все учетные записи  \nMaininfo - просмотреть основную информацию (Фамилия, Имя, Номер)  \nExit - выйти с приложения");
                string srewa = Console.ReadLine();
                switch (srewa)
                {
                    case "Create":
                        {
                            Create();
                            break;
                        }
                    case "Edit":
                        {
                            Edit();
                            break;
                        }
                    case "Delete":
                        {
                            Delete();
                            break;
                        }
                    case "Show":
                        {
                            Show();
                            break;
                        }
                    case "Maininfo":
                        {
                            Maininfo();
                            break;
                        }
                    case "Exit":
                        {
                            Console.WriteLine("Пока");
                            break;
                        }
                    default:
                        Console.WriteLine("\nВы ввели неправильную команду\n");

                        break;
                }
            }

        }
        public void Create()
        {
            Console.WriteLine("Чтобы создать упрощенного контакта введите 1 \nЧтобы создать обычного контакта введите 2");
         string  kakasha= Console.ReadLine();
            Zapis es = new Zapis();
            while (true)
            {
                
                    if (kakasha == "1")
                    {
                        Console.WriteLine("Введите фамилию");
                        es.sername = Console.ReadLine();
                        Console.WriteLine("Введите имя");
                        es.name = Console.ReadLine();
                        Console.WriteLine("Введите отчество ");
                        es.otches = Console.ReadLine();
                        break;
                    }
                    else if (kakasha == "2")
                    {
                        Console.WriteLine("Введите фамилию");
                        es.sername = Console.ReadLine();
                        Console.WriteLine("Введите имя");
                        es.name = Console.ReadLine();
                        Console.WriteLine("Введите отчество ");
                        es.otches = Console.ReadLine();
                        Console.WriteLine("Введите номер телефона ");
                        es.number = Console.ReadLine();
                        Console.WriteLine("Введите cтрану ");
                        es.country = Console.ReadLine();
                        Console.WriteLine("Введите дату рождения  ");
                        es.datebirth = Console.ReadLine();
                        Console.WriteLine("Введите организацию ");
                        es.org = Console.ReadLine();
                        Console.WriteLine("Введите должность  ");
                        es.doljnost = Console.ReadLine();
                        Console.WriteLine("Введите прочие заметки ");
                        es.zametki = Console.ReadLine();
                        break;
                    }
                    else
                        Console.WriteLine("Введена неверная цифра, повторите запрос");
                       kakasha= Console.ReadLine();


            }
           
            id++;
            polya.Add(id, es);
            Console.WriteLine("\nКонтанктик создан\n ");
        }
        public void Edit()
        {
            Console.WriteLine("Введите id записи для изменения");
            int edit = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("Какие поля вы хотите изменить?\n\t1 - Фамилия\n\t2 - Имя\n\t3 - Отчество\n\t4 - Телефон\n\t5 - Страна\n\t6 - Дата рождения\n\t7 - Организация\n\t8 - Должность\n\t9 - Примечание");
                int edisa = Convert.ToInt32(Console.ReadLine());
                switch (edisa)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите новое значение поля ");
                            polya[edit].sername = Console.ReadLine();
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Введите новое значение поля ");
                            polya[edit].name = Console.ReadLine();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Введите новое значение поля ");
                            polya[edit].otches = Console.ReadLine();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Введите новое значение поля ");
                            polya[edit].number = Console.ReadLine();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Введите новое значение поля ");
                            polya[edit].country = Console.ReadLine();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Введите новое значение поля ");
                            polya[edit].datebirth = Console.ReadLine();
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Введите новое значение поля ");
                            polya[edit].org = Console.ReadLine();
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Введите новое значение поля ");
                            polya[edit].doljnost = Console.ReadLine();
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("Введите новое значение поля ");
                            polya[edit].zametki = Console.ReadLine();
                            break;
                        }

                    default:
                        Console.WriteLine("Такого поля нет существует");
                        break;
                        
                }
                
                Console.WriteLine("Если желаете продолжить редактирование, введите 1. Если же выйти из режима редактирования введите 2 ");
                string sda = Console.ReadLine();
                if (sda == "1")
                {
                    Console.WriteLine("\nПоля редактированы\n");
                    continue;
                }
                else 
                {
                    break;
                }
                
            }
        }
        public void Delete()
        {
            Console.WriteLine("Введите id записи для удаления");
            int delete = Convert.ToInt32(Console.ReadLine());
            polya.Remove(delete);
            id --;
            Console.WriteLine("\n Id успешно удалено\n");
        }
        public void Show()
        {
            
            foreach (var es in polya)
            {
                // Console.WriteLine(es.Value.ToString());{number},{country},{datebirth},{org},{doljnost},{zametki}
                Console.Write(es.Value.sername + " ");
                Console.Write(es.Value.name + " ");
                Console.Write(es.Value.otches + " ");
                Console.Write(es.Value.number + " ");
                Console.Write(es.Value.country + " ");
                Console.Write(es.Value.datebirth + " ");
                Console.Write(es.Value.org + " ");
                Console.Write(es.Value.doljnost + " ");
                Console.Write(es.Value.zametki+ "\n");
            }
        }
        public void Maininfo()
        {
            foreach (var es in polya)
            {
                Console.WriteLine(es.Value.sername);
                Console.WriteLine(es.Value.name);
                Console.WriteLine(es.Value.otches);
            }
        }
    }
}
