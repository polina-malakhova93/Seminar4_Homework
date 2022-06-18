int numberA = Input("Введите число А: ");
int numberB = Input("Введите число В: ");
int result = 1;

for(int i = 1; i <= numberB; i++)
{
    result *=numberA;
}
Console.WriteLine(result);

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}