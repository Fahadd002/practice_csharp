using generics;

BubbleSorts<double> bubbleSort = new BubbleSorts<double>([3.3, 1.2, 5.9, 7.7, 3.1, 4.6, 9.2]);
bubbleSort.Sort();

foreach (var item in bubbleSort.Items)
    Console.WriteLine(item);