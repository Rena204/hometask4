Console.Clear();
Console.Write("Введите число А :");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B :");
int B = Convert.ToInt32(Console.ReadLine());
int start = A;
for (int i = 1; i<B; i++) {
    start = start * A;
}
Console.Write("A в степени В = " + start);
