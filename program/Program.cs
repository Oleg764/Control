


Console.WriteLine("Введите кол-во строк,которое собираетесь ввести:  " );
int count=Convert.ToInt32(Console.ReadLine());
string[] list = new string[count];
    
      for (int i = 0; i <list.Length ; i++)
        {
        Console.WriteLine( "Введите строку  : ");
        list [i] = Console.ReadLine();
        
        }
     

 Console.WriteLine ("Строки , длинна которых меньше или равна 3 символа : ");
for (int i = 0; i < list.Length; i++)
    if (list[i].Length != 0 && list[i].Length <= 3)
        Console.WriteLine( $"  { list[i]}");
Console.ReadKey();

