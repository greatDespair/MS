using _3_laba;

Console.WriteLine("Моделирование систем. Лабораторная работа №3. Выполнил ст-т гр. 20ВП1 Акмашев С.В.");
Console.WriteLine("Для просмотра работы автомата введите входной параметр значением от 1-3. Для выхода введите exit.");

StateMachineNWO stateMachineNWO = new StateMachineNWO();

Console.WriteLine(stateMachineNWO.ToString());

while (true)
{
    string? inputArg = Console.ReadLine();

    if (inputArg == "exit")
        break;

    int x;
    if(Int32.TryParse(inputArg, out x))
    {
        if(stateMachineNWO.Input(x))
        {
            Console.WriteLine(stateMachineNWO.ToString());
            continue;
        }
    }
    Console.WriteLine("Отказ. Допущена синтаксическая ошибка " +
        "или данные для конечного автомата - недействительны.");
}
