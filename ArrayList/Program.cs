using System.Collections;

namespace ArrayListSample
{
  internal class Program
  {
    private static void Main()
    {
      ArrayList arrayList = new() { "a", "b", "c" };
      Console.WriteLine($"ArrayList Capacity: {arrayList.Capacity}");

      arrayList.Add("d");
      arrayList.Add("e");
      arrayList.Add("f");
      Console.WriteLine($"ArrayList Capacity: {arrayList.Capacity}");

      Console.Write("ArrayList Items After Add: ");
      foreach (string item in arrayList)
        Console.Write(item + " ");
      Console.WriteLine();

      arrayList.Remove("d");
      arrayList.Remove("e");
      Console.Write("ArrayList Items After Remove: ");
      foreach (string item in arrayList)
        Console.Write(item + " ");
      Console.WriteLine();

      arrayList.RemoveAt(2);
      Console.Write("ArrayList Items After RemoveAt: ");
      foreach (string item in arrayList)
        Console.Write(item + " ");
      Console.WriteLine();

      Console.WriteLine($"ArrayList Contains: {arrayList.Contains("a")}");

      Console.Write("ArrayList After Sort: ");
      arrayList.Add("d");
      arrayList.Add("e");
      arrayList.Sort();
      foreach (string item in arrayList)
        Console.Write(item + " ");
      Console.WriteLine();

      Console.Write("Array After CopyTo: ");
      int count = arrayList.Count;
      string[] copyList = new string[count];
      arrayList.CopyTo(copyList);
      foreach (string item in copyList)
        Console.Write(item + " ");
      Console.WriteLine();

      Console.Write("ArrayList Items After AddRange: ");
      arrayList.AddRange(copyList);
      foreach (string item in arrayList)
        Console.Write(item + " ");
      Console.WriteLine();

      Console.Write("ArrayList Items After Insert: ");
      arrayList.Insert(0, "d"); // Similar to RemoveAt
      foreach (string item in arrayList)
        Console.Write(item + " ");
      Console.WriteLine();

      Console.Write("ArrayList Items After Clear: ");
      arrayList.Clear();
      foreach (string item in arrayList)
        Console.Write(item + " ");
      Console.WriteLine();
    }
  }
}