// сформировать из исходного массива массив строк, длина которых меньше 3-х символов 
Console.WriteLine("Введите кол-во элементов в массиве:");
int m = Convert.ToInt32(Console.ReadLine());
arstring = new string[m];
for (int count1 = 0; count1 < m; count1++)
{
    arstring[count1] = Console.ReadLine();
}


