// See https://aka.ms/new-console-template for more information
var NumList = ListBuilder();

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

List<int> ListBuilder()
{
    var done = false;
    var nums = new List<int>();
    while (!done)
    {
        Console.WriteLine("Type a number you wish to add to you list, press n to complete:");
        var num = Console.ReadLine();
        if (num.ToLower() == "n")
        {
            done = true;
            continue;
        }
        else
        {
            try
            {
                var testNum = Convert.ToInt32(num);
            } catch (Exception ex)
            {
                Console.WriteLine("Invalid character");
                continue;
            }
            nums.Add(Convert.ToInt32(num));
        }
    }
    return nums;
}
