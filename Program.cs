// сформировать из исходного массива массив строк, длина которых меньше 3-х символов 
Console.WriteLine("Введите кол-во элементов в массиве:");
int m = Convert.ToInt32(Console.ReadLine());
arstring = new string[m];
for (int count1 = 0; count1 < m; count1++)
{
    arstring[count1] = Console.ReadLine();
}
int count2 = 0;
arstring2 = new string[m];
for (int count1 = 0; count1 < m; count1++)
{
    if (arstring[count1].Length <= 3)
        {
            arstring2[count2] = arstring[count1];
            Console.WriteLine(arstring2[count2]);
            count2 = count2+1;
        }
}
int n = count2 - 1;
