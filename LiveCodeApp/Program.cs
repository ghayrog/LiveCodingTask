using LiveCodeApp;

const double WELL_DIAMETER = 0.1;
const double WELL_DEPTH = 2000;

IWell well = new VerticalWell(WELL_DIAMETER, WELL_DEPTH);
IReservoir reservoir = new SimpleReservoir(120);
ISolver solver = new TabularSolver(0, 2000, 1000000000);

//TODO: С помощью решателя уравнений (ISolver) найти такое значение дебита (Flow rate) для заданного пользователем устьевого давления (Top node pressure),
//что забойное давление (GetBottomPressure) скважины (VerticalWell) совпадает с забойным давлением (GetBottomPressure) пласта (SimpleReservoir).
//Приложение должно получать устьевое давление (top node pressure) вводом из консоли
//Приложение должно вывести полученное значение дебита (flow rate) в консоль
//Приложение не должно "повисать" в процессе расчета и должно выводить прогресс расчета (затраченное время и оценку оставшегося времени) в консоль
//По возможности отрефакторить код в тех местах, которые считаете необходимым