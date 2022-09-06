

List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine($"Are all elements greater than 0? {numbers.All(x=>x>0)}");

Console.WriteLine($"Are any element greater than 6? {numbers.Any(x=>x>6)}");

Console.WriteLine($"Does the list contain 3? {numbers.Contains(3)} ");