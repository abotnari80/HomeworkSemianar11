System.Console.WriteLine("Введите кол-во ячеек в массиве info");
int iK = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во ячеек в массиве data");
int dK = Convert.ToInt32(Console.ReadLine());

int[] info = new int[iK];
int[] data = new int[dK];
int[] tmpResult = new int[iK];
int[] result = new int[iK];

System.Console.WriteLine("Заполните массив data:");
for (int i = 0; i < dK; i++)
{
    data[i] = Convert.ToInt32(Console.ReadLine());
}

System.Console.WriteLine("Заполните массив info:");
int time = Convert.ToInt32(Console.ReadLine());
int dOst = dK;
if (time > dK)
{
    for (int i = 0; i < iK; i++)
    {
        info[iK] = 0;
    }
}
else
{
    info[0] = time;
    dOst = dOst - info[0];
    int iX = 1;
    while (dOst > 0 || iX < iK)
    {
        info[iX] = Convert.ToInt32(Console.ReadLine());
        dOst = dOst - info[iX];
        iX = iX + 1;
    }
    if (dOst <= 0 && iX < iK)
    {
        for (int i = iX; i < iK; i++)
        {
            info[i] = 0;
        }
    }
}

for (int i = 0; i < iK; i++)
{
    result[i] = 1;
}

int[] answer = new int[iK];

int x = 0;
int y = 0;
int z = 0;

for (int i = 0; i < iK; i++)
{
    x = info[i];
    for (int j = y; j < (x + y); j++)
    {
        tmpResult[i] = (tmpResult[i] * 10) + data[j];
        z++;
    }
    y = z;
}

int tmp = 0;
int n = 2;

for (int i = 0; i < iK; i++)
{
    if (tmpResult[i] > 0)
    {
        tmp = tmpResult[i] % 10;
        tmpResult[i] = tmpResult[i] / 10;
        result[i] = tmp * 1;
        answer[i] = result[i] + answer[i];
    }
    else result[i] = 0;
    while (tmpResult[i] > 0)
    {
        tmp = tmpResult[i] % 10;
        tmpResult[i] = tmpResult[i] / 10;
        result[i] = tmp * n;
        n = n * n;
        answer[i] = result[i] + answer[i];
    }
}

for (int i = 0; i < iK; i++)
{
    System.Console.Write(answer[i]);
}