using LINQDavomi8;

var products = GetProducts();
var anotherProduct = GetAnotherProducts();
ProductComparer productCompare = new();

var result = products.SequenceEqual(anotherProduct, productCompare);






#region Count, Min, MinBy, Max, MaxBy, Sum, Average, Aggregate ForEach, SequanceEqual
//Console.WriteLine("-------------------------Count, Min, MinBy, Max, MaxBy, Sum, Average, Aggregate-------------------------------");

//var count = query.Count(p => p.Color == "Qora");
//Console.WriteLine("Count: " + count);

//var min = query.Select(p => p.Prise).Min();
//Console.WriteLine("MIN: " + min);

//var minBy = query.MinBy(p => p.Prise);
//Console.WriteLine($"MinBY: {minBy.Id}, {minBy.Name}, {minBy.Prise}");

//var max = query.Max(p => p.Prise);
//Console.WriteLine("MAX: " + max);

//var maxBY = query.MaxBy(p => p.Prise);
//Console.WriteLine($"MAXBY: {maxBY.Id}, {maxBY.Name}, {maxBY.Prise}");

//var average1 = query.Select(p => p.Prise).Average();
//Console.WriteLine("Average1: " + average1);

//var average2 = query.Average(p => p.Prise);
//Console.WriteLine($"Average2: {average2}");

//var sum1 = query.Sum(p => p.Prise);
//Console.WriteLine("Yig'ndi: " + sum1);

//var sum2 = query.Sum(p => p.Prise);
//Console.WriteLine($"Sum: {sum2}");

//var aggregate = query.Aggregate(0m, (sum, product) => sum += product.Prise * product.Quantity);
//Console.WriteLine("Aggregate: " + aggregate);



//query.ForEach(p => Console.WriteLine(p.Quantity * p.Prise));

//query.ForEach(p =>
//{
//    var tmp = p.TotalStock = (int)p.Prise * p.Quantity;
//    Console.WriteLine(tmp);
//});

//query.ForEach(p => p.TotalStock = p.Quantity * (int)p.Prise);

//var result = (from p in query
//              let tmp = p.TotalStock = (int)p.Prise * p.Quantity
//              select p).ToList();


//List<int> list = new() { 1, 2, 3, 4, 5, 6};
//List<int> anotherList = new() { 1, 2, 3, 4, 5 };

//var query2 = list.SequenceEqual(anotherList);
//Console.WriteLine(query2);

//List<int> list1 = new() { 1, 2, 3, 4, 5, 6 };
//List<int> anotherList2 = new() { 1, 2, 3, 4, 5 };

//var query3 = list1.Except(anotherList2).ToList();
//foreach (var item in query3)
//{
//    Console.WriteLine(item);
//}

#endregion


#region Contains, Except, ExceptBy Intersect, IntersectBy

//var products = GetProducts();
//var anotherProducts = GetAnotherProducts();
//ProductComparer comparer = new();
//ProductComparer idComparer = new();
////Product product = products.Last();
//var product = products.LastOrDefault(p => p.Id > 13);

//var query = products.Union(anotherProducts, comparer).ToList();

////foreach (var item in query)
////{
////    Console.WriteLine($"{item.Id}, {item.Name}, {item.Color}");
////}

//Console.WriteLine("---------------------------Contains-----------------------");

////var result = query.Select(p => p.Color).Contains("Qora");
//var result2 = query.Contains(product, idComparer);

////Console.WriteLine(result);
//Console.WriteLine(result2);

//Console.WriteLine("-------------------------ECEPT------------------------------");
//var products = GetProducts();
//var productId = new List<int>() { 1, 2, 3, 4, 5, 6};

//var surov = products.ExceptBy(productId, product => product.Id).ToList();

//foreach(var item in surov)
//{
//    Console.WriteLine($"{item.Id}, {item.Name}, {item.Color}");
//}

//List<int> list = new() { 1, 2, 3, 4, 5, 6 };
//List<int> anotherList = new() { 4, 5, 6 };

//var quary = anotherList.Except(list).ToList();

//foreach (var item in quary)
//    Console.WriteLine(item);


//var query = products.Union(anotherProduct, comparer).ToList();

//foreach(var item in query)
//{
//    Console.WriteLine($"{item.Id}, {item.Name}, {item.Color}");
//}

//Console.WriteLine("------------------------------INTERSECTBY---------------------------");

//var productIds = new List<int>() { 1, 2, 3, 4, 5, 6};

//var result = query.IntersectBy(productIds, product => product.Id).ToList();

//foreach(var item in result)
//{
//    Console.WriteLine($"{item.Id}, {item.Name}, {item.Color}");
//}
//Console.WriteLine("------------------------------INTERSECT---------------------------");
//List<int> list = new() { 1, 2, 3, 4, 5};
//List<int> anotherList = new() { 4, 5, 6};

//var surov = list.Intersect(anotherList).ToList();

//foreach(var item in surov)
//{ Console.WriteLine(item); }


//Console.WriteLine();
#endregion 


static List<Product> GetProducts()
{
    var products = new List<Product>()
    {

        new Product { Id = 7, Name = "Sharf", Color = "Yashil" , Prise = 15, Quantity = 11, TotalStock = 42},
        new Product { Id = 8, Name = "Krassovka", Color = "Qizil", Prise = 12, Quantity = 13, TotalStock = 9},
        new Product { Id = 9, Name = "Kostyum", Color = "Qora", Prise = 14, Quantity = 34, TotalStock = 2},
        new Product { Id = 10, Name = "Xalat", Color = "Pushti", Prise = 17, Quantity = 54, TotalStock = 1},
        new Product { Id = 11, Name = "Ko'ylak", Color = "Sariq", Prise = 67, Quantity = 345, TotalStock = 12},
        new Product { Id = 12, Name = "Bo'yinbog'", Color = "Binafsharang", Prise = 45, Quantity = 321, TotalStock = 95},
        new Product { Id = 13, Name = "Kepka", Color = "Kulrang", Prise = 34, Quantity =231, TotalStock = 57},
        new Product { Id = 14, Name = "Futbolka", Color = "Ko'k", Prise = 56, Quantity = 32, TotalStock = 85},
        new Product { Id = 15, Name = "Mayka", Color = "Oq", Prise = 76, Quantity = 56, TotalStock = 64},
        new Product { Id = 16, Name = "Paypoq", Color = "Qora", Prise = 45, Quantity = 43, TotalStock = 46},
        new Product { Id = 17, Name = "Sho'rtik", Color = "Kulrang", Prise = 43, Quantity = 25, TotalStock = 75},
        new Product { Id = 18, Name = "Shim", Color = "Qo'ng'ir", Prise = 63, Quantity = 58, TotalStock = 58},
        new Product { Id = 19, Name = "Tufli", Color = "Jigarrang", Prise = 54, Quantity = 23, TotalStock = 39},
    };
    return products;
}

static List<Product> GetAnotherProducts()
{
    var products = new List<Product>()
    {
        new Product { Id = 1, Name = "Futbolka", Color = "Ko'k", Prise = 32, Quantity = 36, TotalStock = 76},
        new Product { Id = 2, Name = "Mayka", Color = "Oq", Prise = 69, Quantity = 89, TotalStock = 12},
        new Product { Id = 3, Name = "Paypoq", Color = "Qora", Prise = 54, Quantity = 78, TotalStock = 76},
        new Product { Id = 4, Name = "Sho'rtik", Color = "Kulrang", Prise = 67, Quantity = 76, TotalStock = 73},
        new Product { Id = 5, Name = "Shim", Color = "Qo'ng'ir", Prise = 78, Quantity = 28, TotalStock = 764},
        new Product { Id = 6, Name = "Tufli", Color = "Qora", Prise = 98, Quantity = 27, TotalStock = 766},
        new Product { Id = 7, Name = "Sharf", Color = "Yashil", Prise = 76, Quantity = 37, TotalStock = 762},
        new Product { Id = 8, Name = "Krosofka", Color = "Qizil", Prise = 45, Quantity = 72, TotalStock = 7671},
        new Product { Id = 9, Name = "Kostyum", Color = "Qora", Prise = 25, Quantity = 94, TotalStock = 76239},
        new Product { Id = 10, Name = "Xalart", Color = "Pushti", Prise = 43, Quantity = 51, TotalStock = 7671},
        new Product { Id = 11, Name = "Ko'ylak", Color = "Sariq", Prise = 21, Quantity = 42, TotalStock = 760},
        new Product { Id = 12, Name = "Boyinbog'", Color = "jigarrang", Prise = 23, Quantity = 36, TotalStock = 7600}
    };
    return products;
}