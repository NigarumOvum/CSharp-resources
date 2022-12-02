static singleWord = "bottle"
static pluralword = "bottles"
static zeroBeer = "no more"
static string test = "{0} {2} of beer on the wall, {0} {2} of beer\n" +
    "Take one down and pass it around, {1} {3} of beer on the wall\n\n";
static string end = "No more bottles of beer on the wall, no more bottles of beer\n" +
                "Go to the store and buy some more, 99 bottles of beer on the wall."
static void Main(string[] args)
{
    // With Iteration
    // for (int i=99; i>0; i--)
    // {
    //     Print(i)
    // }
    // With Functional Paradigm
    List<int> beers = Enumerable.Range(1, 99).ToList();
    beers.Reverse();
    beers.ForEach((i) => Print(i));
    Console.WriteLine(end);
}

static void Print(int num)
{
    Console.WriteLine(text,
     num,
      ((num-1) == 0) ? zeroBeer : (num-1),
      (num) == 1 ? singleWord : pluralword,
      (num -1) == 1 ? singleWord : pluralword);
}