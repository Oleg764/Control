
int count = 0;
string[] list = new string[count];
string s;
Console.WriteLine("Введите строки ( чтобы закончить ввод оставте пустую строку и нажмите энтер ) :");
do
{
    s = Console.ReadLine();

    if (s != "")
    {
        count++;
        string[] list2 = new string[count];
        for (int i = 0; i < list2.Length - 1; i++)

            list2[i] = list[i];
        list2[count - 1] = s;
        list = list2;
    }
} while (s != "");
Console.Write ("Строки , длинна которых меньше или равна 3 символа : ");
for (int i = 0; i < list.Length; i++)
    if (list[i].Length != 0 && list[i].Length <= 3)
        Console.Write( $" , {list[i]}");
Console.ReadKey();

