using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Entityservice;
using DAL;

namespace PL
{
    public class ConsoleMenu
    {
        #region provider and services
        private static IDataProvider<List<Student>> studentDataProvider;
        private static IDataProvider<List<Baker>> bakerDataProvider;
        private static IDataProvider<List<Entrepreneur>> entrepreneurDataProvider;

        private static IEntityService<List<Student>> studentDataService;
        private static IEntityService<List<Baker>> bakerDataService;
        private static IEntityService<List<Entrepreneur>> entrepreneurDataService;

        static List<Student> students = new List<Student>();
        static List<Baker> bakers = new List<Baker>();
        static List<Entrepreneur> entrepreneurs = new List<Entrepreneur>();
        #endregion

        #region service functions

        private static string SetFileName()
        {
            Console.WriteLine("Введіть назву файлу:"); string inputPath = Console.ReadLine();
            Console.Clear();
            return inputPath + ".xml";
        }
        private static int SerializationTypeChoice()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Оберіть тип даних які хочете зберегти: ");
            Console.WriteLine("\n1 - Зберегти студентів");
            Console.WriteLine("2 - Зберегти пекарів");
            Console.WriteLine("3 - Зберегти підприємців");
            Console.WriteLine("-----------------------------------------");

            string _input = Console.ReadLine();
            int input = int.Parse(_input);
            Console.Clear();
            if (input >= 1 && input <= 3)
            {
                return input;
            }
            else { return -1; }
        }
        private static int DeSerializationTypeChoice()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Оберіть тип даних які хочете десереалізувати: ");
            Console.WriteLine("\n1 - Десереалізувати студентів");
            Console.WriteLine("2 - Десереалізувати пекарів");
            Console.WriteLine("3 - Десереалізувати підприємців");
            Console.WriteLine("-----------------------------------------");

            string _input = Console.ReadLine();
            int input = int.Parse(_input);
            Console.Clear();
            if (input >= 1 && input <= 3)
            {
                return input;
            }
            else { return -1; }
        }

        private static void OutputStudent(Student student)
        {

            Console.WriteLine("\nName:" + student.Name);
            Console.WriteLine("Surname:" + student.Surname);
            Console.WriteLine("Age:" + student.Age);
            Console.WriteLine("BornOn:" + student.dateOfBirth.ToShortDateString());
            Console.WriteLine("ID:" + student.ID);
            Console.WriteLine("Year:" + student.Year);
            Console.WriteLine("StudentTicket:" + student.StudentTicket);
            Console.ReadKey();
        }
        private static void OutputBaker(Baker baker)
        {
            Console.WriteLine("\nName:" + baker.Name);
            Console.WriteLine("Surname:" + baker.Surname);
            Console.WriteLine("Age:" + baker.Age);
            Console.WriteLine("BornOn:" + baker.dateOfBirth.ToShortDateString());
            Console.WriteLine("ID:" + baker.ID);
            Console.ReadKey();
        }
        private static void OutputEnt(Entrepreneur entrepreneur)
        {
            Console.WriteLine("\nName:" + entrepreneur.Name);
            Console.WriteLine("Surname:" + entrepreneur.Surname);
            Console.WriteLine("Age:" + entrepreneur.Age);
            Console.WriteLine("BornOn:" + entrepreneur.dateOfBirth.ToShortDateString());
            Console.WriteLine("ID:" + entrepreneur.ID);
            Console.ReadKey();
        }

        private static Student AddStudent()
        {
            Console.Write("Ім'я: "); string inputName = Console.ReadLine();
            Console.Write("Прізвище: "); string inputSurname = Console.ReadLine();
            Console.WriteLine("Дата народження у форматі ----/--/--");
            Console.Write("Рік: "); string _DATEyear = Console.ReadLine(); int DATEyear = int.Parse(_DATEyear);
            Console.Write("Місяць: "); string _DATEmonth = Console.ReadLine(); int DATEmonth = int.Parse(_DATEmonth);
            Console.Write("Дата: "); string _DATEday = Console.ReadLine(); int DATEday = int.Parse(_DATEday);
            DateTime dateTime = new DateTime(DATEyear, DATEmonth, DATEday);
            Console.Write("ID: "); string _inputID = Console.ReadLine(); int inputID = int.Parse(_inputID);
            Console.Write("Курс: "); string _inputYear = Console.ReadLine(); int inputYear = int.Parse(_inputYear);
            Console.Write("Номер квитка: "); string _inputTicket = Console.ReadLine(); int inputTicket = int.Parse(_inputTicket);

            return new Student(inputName, inputSurname, inputID, inputYear, inputTicket, dateTime);
        }
        private static Baker AddBaker()
        {
            Console.Write("Ім'я: "); string inputName = Console.ReadLine();
            Console.Write("Прізвище: "); string inputSurname = Console.ReadLine();
            Console.WriteLine("Дата народження у форматі ----/--/--");
            Console.Write("Рік: "); string _DATEyear = Console.ReadLine(); int DATEyear = int.Parse(_DATEyear);
            Console.Write("Місяць: "); string _DATEmonth = Console.ReadLine(); int DATEmonth = int.Parse(_DATEmonth);
            Console.Write("Дата: "); string _DATEday = Console.ReadLine(); int DATEday = int.Parse(_DATEday);
            DateTime dateTime = new DateTime(DATEyear, DATEmonth, DATEday);

            Console.Write("ID: "); string _inputID = Console.ReadLine(); int inputID = int.Parse(_inputID);

            return new Baker(inputName, inputSurname, inputID, dateTime);
        }
        private static Entrepreneur AddEntrepreneur()
        {
            Console.Write("Ім'я: "); string inputName = Console.ReadLine();
            Console.Write("Прізвище: "); string inputSurname = Console.ReadLine();
            Console.WriteLine("Дата народження у форматі ----/--/--");
            Console.Write("Рік: "); string _DATEyear = Console.ReadLine(); int DATEyear = int.Parse(_DATEyear);
            Console.Write("Місяць: "); string _DATEmonth = Console.ReadLine(); int DATEmonth = int.Parse(_DATEmonth);
            Console.Write("Дата: "); string _DATEday = Console.ReadLine(); int DATEday = int.Parse(_DATEday);
            DateTime dateTime = new DateTime(DATEyear, DATEmonth, DATEday);
            Console.Write("Досвід роботи: "); string _inputYear = Console.ReadLine(); int inputYear = int.Parse(_inputYear);
            Console.Write("ID: "); string _inputID = Console.ReadLine(); int inputID = int.Parse(_inputID);

            return new Entrepreneur(inputName, inputSurname, inputID, inputYear, dateTime);
        }

        #endregion

        public static void MainMenu()
        {
            try
            {
                bool status = true;
                while (status)
                {
                    Console.WriteLine("\t\tMAIN MENU");
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("1 - Вивести БД");
                    Console.WriteLine("2 - Додати об'єкт до БД");
                    Console.WriteLine("3 - Видалити БД");
                    Console.WriteLine("4 - Пошук студентів 4 курсу");
                    Console.WriteLine("5 - Закінчити роботу");
                    Console.WriteLine("-----------------------------------------");

                    string str = Console.ReadLine();
                    int _str = int.Parse(str);

                    switch (_str)
                    {
                        case 1:
                            {
                                Console.Clear();
                                OutputMenu();
                                break;
                            }
                        case 2:
                            {
                                Console.Clear();
                                AppendMenu();
                                break;
                            }
                        case 3:
                            {
                                Console.Clear();
                                DeleteMenu();
                                break;
                            }
                        case 4:
                            {
                                Console.Clear();
                                //
                                break;
                            }
                        case 5:
                            {
                                Console.Clear();
                                Environment.Exit(0);
                                break;
                            }

                        default:
                            Console.Clear();
                            Console.Write("Перевірте коректність вводу даних!\n\nНатисніть ENTER щоб повернутись до MAIN MENU");
                            Console.ReadKey();
                            Console.Clear();
                            status = true;
                            break;
                    }
                }

            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine($@"Exception: {e.Message}");
                Console.Write("\nНатисніть ENTER щоб повернутись до MAIN MENU");
                Console.ReadKey();
                Console.Clear();
                MainMenu();
            }
        }

        #region service menus
        private static void AppendMenu()
        {
            try
            {
                bool status = true;
                while (status)
                {
                    Console.WriteLine("\t\tAPPEND MENU");
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("1 - Додати студента");
                    Console.WriteLine("2 - Додати пекаря");
                    Console.WriteLine("3 - Додати підприємця");
                    Console.WriteLine("4 - Зберегти дані до БД");
                    Console.WriteLine("5 - Повернутись до MAIN MENU");
                    Console.WriteLine("6 - Закінчити роботу з програмою");
                    Console.WriteLine("-----------------------------------------");

                    string str = Console.ReadLine();
                    int _str = int.Parse(str);

                    switch (_str)
                    {
                        case 1:
                            {
                                Console.Clear();
                                students.Add(AddStudent());
                                Console.Clear();
                                break;
                            }
                        case 2:
                            {
                                Console.Clear();
                                bakers.Add(AddBaker());
                                Console.Clear();
                                break;
                            }
                        case 3:
                            {
                                Console.Clear();
                                entrepreneurs.Add(AddEntrepreneur());
                                Console.Clear();
                                break;
                            }
                        case 4:
                            {
                                Console.Clear();
                                switch (SerializationTypeChoice())
                                {
                                    case 1:
                                        {
                                            studentDataProvider = new XMLProvider<List<Student>>(SetFileName());
                                            EntityService<List<Student>> entityService = new EntityService<List<Student>>(studentDataProvider);                                         
                                            entityService.SerializeData(students);
                                            break;
                                        }
                                    case 2:
                                        {
                                            bakerDataProvider = new XMLProvider<List<Baker>>(SetFileName());
                                            EntityService<List<Baker>> entityService = new EntityService<List<Baker>>(bakerDataProvider);                                          
                                            entityService.SerializeData(bakers);
                                            break;
                                        }
                                    case 3:
                                        {
                                            entrepreneurDataProvider = new XMLProvider<List<Entrepreneur>>(SetFileName());
                                            EntityService<List<Entrepreneur>> entityService = new EntityService<List<Entrepreneur>>(entrepreneurDataProvider);
                                            entityService.SerializeData(entrepreneurs);
                                            break;
                                        }
                                    default:
                                        Console.WriteLine("Некоректне введення даних!\n\nНатисніть ENTER щоб повернутись до APPEND MENU");
                                        Console.ReadKey();
                                        Console.Clear();
                                        AppendMenu();
                                        break;
                                }
                                break;
                            }
                        case 5:
                            {
                                Console.Clear();
                                MainMenu();
                                break;
                            }
                        case 6:
                            {
                                Console.Clear();
                                Environment.Exit(0);
                                break;
                            }
                        default:
                            Console.Clear();
                            Console.Write("Перевірте коректність вводу даних!\n\nНатисніть ENTER щоб повернутись до APPENT MENU");
                            Console.ReadKey();
                            Console.Clear();
                            status = true;
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine($@"Exception: {e.Message}");
                Console.Write("\nНатисніть ENTER щоб повернутись до APPEND MENU");
                Console.ReadKey();
                Console.Clear();
                AppendMenu();
            }
            finally { Console.Clear(); }
        }
        private static void DeleteMenu()
        {
            try
            {
                bool status = true;
                while (status)
                {
                    Console.WriteLine("\t\tDELETE MENU");
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("1 - Видалити дані з БД");
                    Console.WriteLine("2 - Видалити БД");
                    Console.WriteLine("3 - Повернутись до MAIN MENU");
                    Console.WriteLine("4 - Закінчити роботу");
                    Console.WriteLine("-----------------------------------------");

                    string str = Console.ReadLine();
                    int _str = int.Parse(str);
                    switch (_str)
                    {
                        case 1:
                            {
                                Console.Clear();
                                XMLProvider<object> provider = new XMLProvider<object>(SetFileName());
                                if (provider.FileExists())
                                {
                                    provider.DeleteFileData();
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Exception: Заданий файл не існує");
                                    Console.Write("\nНатисніть ENTER щоб повернутись до DELETE MENU");
                                    Console.ReadKey();
                                    Console.Clear();
                                    DeleteMenu();
                                }
                                break;
                            }
                        case 2:
                            {
                                Console.Clear();
                                XMLProvider<object> provider = new XMLProvider<object>(SetFileName());
                                if (provider.FileExists())
                                {
                                    provider.DeleteFile();
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Exception: Заданий файл не існує");
                                    Console.Write("\nНатисніть ENTER щоб повернутись до DELETE MENU");
                                    Console.ReadKey();
                                    Console.Clear();
                                    DeleteMenu();
                                }
                                break;
                            }
                        case 3:
                            {
                                Console.Clear();
                                MainMenu();
                                break;
                            }
                        case 4:
                            {
                                Console.Clear();
                                Environment.Exit(0);
                                break;
                            }
                        default:
                            Console.Clear();
                            Console.Write("Перевірте коректність вводу даних!\n\nНатисніть ENTER щоб повернутись до DELETE MENU");
                            Console.ReadKey();
                            Console.Clear();
                            status = true;
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine($@"Exception: {e.Message}");
                Console.Write("\nНатисніть ENTER щоб повернутись до DELETE MENU");
                Console.ReadKey();
                Console.Clear();
                DeleteMenu();
            }
        }
        private static void OutputMenu()
        {
            try
            {
                bool status = true;
                while (status)
                {
                    switch (DeSerializationTypeChoice())
                    {
                        case 1:
                            studentDataProvider = new XMLProvider<List<Student>>(SetFileName());
                            studentDataService = new EntityService<List<Student>>(studentDataProvider);
                            students = studentDataService.GetData(); 
                            foreach (var student in students)
                            {
                                OutputStudent(student); Console.Clear();
                            }

                            break;
                        case 2:
                            bakerDataProvider = new XMLProvider<List<Baker>>(SetFileName());
                            bakerDataService = new EntityService<List<Baker>>(bakerDataProvider);
                            bakers = bakerDataService.GetData(); 
                            foreach (var baker in bakers)
                            {
                                OutputBaker(baker); Console.Clear();
                            }
                            break;
                        case 3:
                            entrepreneurDataProvider = new XMLProvider<List<Entrepreneur>>(SetFileName());
                            entrepreneurDataService = new EntityService<List<Entrepreneur>>(entrepreneurDataProvider);
                            entrepreneurs = entrepreneurDataService.GetData(); 
                            foreach (var entrepreneur in entrepreneurs)
                            {
                                OutputEnt(entrepreneur); Console.Clear();
                            }
                            break;

                        default:
                            Console.Clear();
                            Console.Write("Перевірте коректність вводу даних!\n\nНатисніть ENTER щоб повернутись до OUTPUT MENU");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
            }
            catch(Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
                Console.Write("Перевірте коректність вводу даних!\n\nНатисніть ENTER щоб повернутись до OUTPUT MENU");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
    #endregion
}

