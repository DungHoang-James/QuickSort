
int[] array = { 2, 5, 1, 8, 3, 9, 0, 4, 7, 6 };

PrintResult(array, "Before sort");

QuickSort(array, 0, array.Length - 1);

PrintResult(array, "After sort");

static void QuickSort(int[] array, int leftIndex, int rightIndex)
{
    if (leftIndex >= rightIndex)
    {
        return;
    }

    Random r = new Random();
    int indexPivot = r.Next(leftIndex, rightIndex + 1);

    Swap(array, indexPivot, leftIndex);

    int pivot = leftIndex;

    int i = leftIndex + 1;
    int j = rightIndex;

    while (true)
    {
        while (array[i] <= array[pivot] && i < rightIndex)
        {
            i++;
        }

        while (array[j] > array[pivot] && j > 0)
        {
            j--;
        }

        if (i >= j)
        {
            break;
        }

        Swap(array, i, j);
    }

    Swap(array, pivot, j);
    pivot = j;

    QuickSort(array, leftIndex, pivot - 1);
    QuickSort(array, pivot + 1, rightIndex);
}

static void Swap(int[] array, int index1, int index2)
{
    int tmpValue = array[index1];
    array[index1] = array[index2];
    array[index2] = tmpValue;
}

static void PrintResult(int[] array, string title)
{
    Console.WriteLine($"{title}");
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write("\t");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}