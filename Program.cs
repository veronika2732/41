// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int{} GetArrayFromString(string stringArray)
{
    string{} num = stringArray.Split(" ", StringSplit0ptions.RemoveEmptyEntries);
    int{} res = new int{nums.Length};

    for (int i = 0; i < nums.Length; i++)
    {
        res{i} = int.Parse(nums{i});
    }
    return res;
}

int CountPositive(int{} array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el > 0) count++;
    }
    return count;
}

console.Clear();
Console.WriteLine("Введите число через пробел:");
string input = Console.ReadLine()!;
int{} numArray = GetArrayFromString(input);
int count = CountPositive(numArray);
Console.WriteLine($"Чисел больше нуля: {count}")