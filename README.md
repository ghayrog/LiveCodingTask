# Задание для Live Coding
 
Пример проекта консольного приложения Visual Studio. Содержит 3 интерфейса и 3 класса, реализующих этот интерфейс.

Скважина (IWell, VerticalWell) - представляет собой ствол газовой скважины, может рассчитать забойное давление (bottom pressure) исходя из перепада давления вдол ствола скважины, если известен дебит газа (flow rate) и устьевое давление (top node pressure).

Пласт (IReservoir, SimpleReservoir) - представляет собой газовый пласт, может рассчитать забойное давление (bottom pressure) исходя из продуктивных характеристик пласта и пластового давления, если известен дебит (flow rate).

Решатель (ISolver, TabularSolver) - может решать уравнения вида f1(x) = f2(x) - находить такое значение x, при котором две произвольные функции равны.

# Постановка задачи

Дописать консольное приложение. Оно должно находить такое значение дебита (Flow rate) для заданного пользователем устьевого давления (Top node pressure),
что забойное давление (GetBottomPressure) скважины (VerticalWell) совпадает с забойным давлением (GetBottomPressure) пласта (SimpleReservoir).

Приложение должно получать устьевое давление (top node pressure) вводом из консоли команды "calc <число>"

Приложение должно вывести полученное значение дебита (flow rate) в консоль

Приложение не должно позволять запустить новый расчет до тех пор, пока не закончится предыдущий (и выводить соответствующее предупреждение)

Приложение должно адекватно реагировать на некорректный ввод числа

Приложение не должно "повисать" в процессе расчета и должно продолжать принимать другие команды (help, stat и т.д.)

При вводе команды stat приложение должно выводить сообщение с текущим состоянием расчета - 
процент выполнения, затраченное время и оценку оставшегося времени.
Если расчет не выполняется - выводить соответствующее предупреждение.
