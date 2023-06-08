int[,] matrix = new int[3, 3] {
    { 2, 7, 6 },
    { 9, 5, 1 },
    { 4, 3, 8 }
};

bool linearCheck(int[,] matrix, int size, bool horizontal)
{
    bool flag = true;
    int lastSum = 0;

    for (int i = 0; i < size; i++)
    {
        int sum = 0;
        for (int j = 0; j < size; j++)
        {
            if (horizontal)
            {
                sum += matrix[i, j];
            }
            else
            {
                sum += matrix[j, i];
            }
        }

        if (i != 0 && lastSum != sum)
        {
            flag = false;
        }
        else
        {
            lastSum = sum;
        }
    }

    return flag;
}

bool diagonalCheck(int[,] matrix, int size)
{
    int leftSum = 0;
    int rightSum = 0;

    for (int i = 0; i < size; i++)
    {
        leftSum += matrix[i, i];
        rightSum += matrix[i, (size - 1) - i];
    }

    return (leftSum == rightSum);
}

// https://www.tiktok.com/@kvmn09/video/7121185718289960238
if (linearCheck(matrix, 3, true) && linearCheck(matrix, 3, false) && diagonalCheck(matrix, 3))
{
    Console.WriteLine("es magica bro, es magica");
}
else
{
    Console.WriteLine("se acabo la magia, se acabo el camino");
}

Console.ReadKey();