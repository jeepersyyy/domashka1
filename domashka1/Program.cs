namespace domashka1
{
    class Program
    {
        static void Main(string[] args)
        {
            string фамилия;
            string имя;
            string отчество;
            string пол;
            int возраст;
            int рост;
            string улица;
            int номер_дома;
            string номер_телефона;
            string номер_лицевого_счета;
            string вид_пенсии;
            string срок_действия;
            string дата_выдачи;
            string кем_выдано;

            Console.Write("Этап оформления и заполнения анкеты для получения пенсионного удостоверения: \n \n");
            Console.Write("Введите фамилию: ");
            фамилия = Console.ReadLine().Trim();

            Console.Write("Введите имя: ");
            имя = Console.ReadLine().Trim();

            Console.Write("Введите отчество: ");
            отчество = Console.ReadLine().Trim();

            Console.Write("Введите свой пол: ");
            пол = Console.ReadLine().Trim();

            Console.Write("Введите возраст: ");
            возраст = int.Parse(Console.ReadLine());

            Console.Write("Введите рост в сантиметрах): ");
            рост = int.Parse(Console.ReadLine());

            Console.Write("Введите улицу: ");
            улица = Console.ReadLine().Trim();

            Console.Write("Введите номер дома: ");
            номер_дома = int.Parse(Console.ReadLine().Trim());

            Console.Write("Введите номер телефона: ");
            номер_телефона = Console.ReadLine().Trim();

            Console.Write("Введите номер лицевого счета(хххххх/уууу): ");
            номер_лицевого_счета = Console.ReadLine().Trim();

            Console.Write("Введите вид пенсии: ");
            вид_пенсии = Console.ReadLine().Trim();

            Console.Write("Введите срок действия пенсии(есть только пожизненный срок действия[наверное, я не знаю]): ");
            срок_действия = Console.ReadLine().Trim();

            Console.Write("Введите дату выдачи (ДД.ММ.ГГГГ): ");
            дата_выдачи = Console.ReadLine().Trim();

            Console.Write("Введите кем выданно удостоверение: ");
            кем_выдано = Console.ReadLine().Trim();




            Console.WriteLine("\nПЕНСИОННОЕ УДОСТОВЕРЕНИЕ:");
            Console.WriteLine($"Фамилия: {фамилия}");
            Console.WriteLine($"Имя: {имя}");
            Console.WriteLine($"Отчество: {отчество}");
            Console.WriteLine($"Пол: {пол}");
            Console.WriteLine($"Рост: {рост} сантиметров");
            Console.WriteLine($"Возраст: {возраст} лет");
            Console.WriteLine($"Адрес: улица {улица}, дом {номер_дома}");
            Console.WriteLine($"Номер телефона: {номер_телефона}");
            Console.WriteLine($"Номер лицевого счета: {номер_лицевого_счета}");
            Console.WriteLine($"Вид пенсии: {вид_пенсии}");
            Console.WriteLine($"Срок действия: {срок_действия}");
            Console.WriteLine($"Дата выдачи: {дата_выдачи}");
            Console.WriteLine($"Кем выдано: {кем_выдано}");
        }
    }
}