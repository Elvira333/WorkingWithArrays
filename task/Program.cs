
string[] value = { "15", "hello", "600", "4", "control Work", "by", "Annaeva" };
void Examination(string[] values)
{
    int count = 0;
    string[] valuesTwo = new string[values.Length];
    for (int i = 0; i < values.Length; i++)
    {
        string number = values[i];
        if (number.Length <= 3)
        {
            valuesTwo[count] = number;
            Console.Write($"{valuesTwo[count]} ");
            count++;
        }
    }
}
Examination(value);
