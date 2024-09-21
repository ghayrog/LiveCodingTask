using LiveCodeApp;

const double WELL_DIAMETER = 0.1;
const double WELL_DEPTH = 2000;
const string HELP = "HELP";
const string EXIT = "EXIT";
const string CALC = "CALC";
const string STAT = "STAT";
const string BARK = "BARK";

IWell well = new VerticalWell(WELL_DIAMETER, WELL_DEPTH);
IReservoir reservoir = new SimpleReservoir(120);
ISolver solver = new TabularSolver(0, 2000, 1000000000);

string? consoleCommand = "";

while (consoleCommand?.ToUpper().Trim() != EXIT)
{
    Console.WriteLine("Введите команду (help - справка):");
    consoleCommand = Console.ReadLine();
    switch (consoleCommand?.ToUpper().Trim().Split(" ")[0])
    {
        case HELP:
            PrintHelp();
            break;
        case CALC:
            //TODO: С помощью решателя уравнений (ISolver) найти такое значение дебита (Flow rate) для заданного пользователем устьевого давления (Top node pressure),
            //что забойное давление (GetBottomPressure) скважины (VerticalWell) совпадает с забойным давлением (GetBottomPressure) пласта (SimpleReservoir).
            //Приложение должно получать устьевое давление (top node pressure) вводом из консоли команды "calc <число>"
            //Приложение должно вывести полученное значение дебита (flow rate) в консоль
            //Приложение не должно позволять запустить новый расчет до тех пор, пока не закончится предыдущий (и выводить соответствующее предупреждение)
            //Приложение должно адекватно реагировать на некорректный ввод числа
            //Приложение не должно "повисать" в процессе расчета и должно продолжать принимать другие команды (см. PrintHelp)
            break;
        case STAT:
            //TODO: При вводе команды stat приложение должно выводить сообщение с текущим состоянием расчета - 
            //процент выполнения, затраченное время и оценку оставшегося времени.
            //Если расчет не выполняется - выводить соответствующее предупреждение
            break;
        case BARK:
            Console.WriteLine("Гав-гав!");
            break;
        default:
            Console.WriteLine("Команда не распознана.");
            break;
    }
}

void PrintHelp()
{
    Console.WriteLine("help - справка");
    Console.WriteLine("exit - выход");
    Console.WriteLine("calc <число> - вычислить дебит");
    Console.WriteLine("stat - статус расчета");
    Console.WriteLine("bark - ???");
}