// See https://aka.ms/new-console-template for more information
var NumList = new List<int>() { 1, -24, 13, 100, -45, 12};

var FinishedList = BubbleSort(NumList);
foreach(var Item in FinishedList)
    Console.WriteLine(Item);

List<int> BubbleSort(List<int> list)
{
    

    for(var i = list.Count; i >= 0; i--)
    {
        for(var z = 0; z < i - 1; z++)
        {
            if (list[z] == list[z + 1])
                continue;
            if (list[z] - list[z + 1] < 0)
                continue;
            else
            {
                var num = list[z];
                list[z] = list[z + 1];
                list[z + 1] = num;
            }
        }
    }
    return list;
}
