// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Threading.Channels;
using static MyCar;



//using (var timer = new OperatorTimer())
//{
//	for (int i = 0, j = 0; i < 10_000_000; i++, j++) ;
//}

GetTest getTest = new GetTest();
getTest.GetWinners();
Console.WriteLine();




#region IDisposible
public class OperatorTimer : IDisposable
{
	private Stopwatch stopwatc = new();
	private bool _disposed = false;
    public OperatorTimer()
    {
        stopwatc.Start();
    }
	~OperatorTimer() {
		Dispose(disposing:false);
	}

	public void Dispose() {
		Dispose(disposing:true);
		GC.SuppressFinalize(this);
			}
    public virtual void Dispose(bool disposing)
	{
		if (!_disposed)
		{
			stopwatc.Stop();
			var el = stopwatc.ElapsedMilliseconds;
			if (el > 10)
				Console.WriteLine($"Warning: {el} ms");
			_disposed = true;
		}
	}
}
#endregion

#region Select and SelectMany

public class Winner
{
    public required string Country { get; set; }
    public required int[] Years { get; set; }
}

public class GetTest() {

	
	public void GetWinners()
	{

		List<Winner> WinnerList = new()
		{
			new Winner(){ Country="US", Years=new[]{1978,1990 } },
			new Winner(){ Country="Germany", Years=new[]{2024,2000 } },
						new Winner(){ Country="France", Years=new[]{5222,3555 } }

		};
		//Console.WriteLine($"List Count: {WinnerList.Count}");
		//Console.WriteLine("Var Shresh Value: {0}, constant value shreshti: {1}", x, y );
		List<string> countries = WinnerList.Select(x => x.Country).ToList();
		var ints = WinnerList.SelectMany(x => x.Years, (x, y) => new { Country = x.Country, Years = y.ToString() })
			.OrderBy(x => x.Country)
			.ToList();
		//foreach (var i in ints)		
		//Console.WriteLine(i);
		//for (int i = 0; i < 100; i++)
		//{
		//}
		MyCar myCar = new MyCar();
		myCar.Run();
		//Shreshti shreshti = new Shreshti("Khavish", 8, "Brown", 125);
		//shreshti.GetShreshtiDetails();
		//string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
		//foreach(var car in cars)
		//	Console.WriteLine(car);




		//foreach (int[] ints2 in ints.SelectMany(x) { 

		//}
		//foreach (string country in countries) {
		//	if (country == "Germany")
		//	{
		//		Console.WriteLine($"Print Country:{country}");
		//	}
		//	else {
		//		Console.WriteLine($"---------------------------");
		//		Console.WriteLine($"Print Country:{country}");


		//	}


		//}

	}
}

#endregion


public class MyCar 
{ 

	public string Name { get; set; }
	public float Years { get; set; }
	public string Country { get; set; }

	public void Run() {
		Console.WriteLine("PLEASE WRITE Number: ");
		var number=Convert.ToInt32(Console.ReadLine());
		if (number == 10){
            Console.WriteLine(GetIfMatches(number));
        }
		Console.WriteLine("TABLE: {0} ",number);

		for (int i = 1; i < 21; i++) {
            Console.WriteLine("{0} X {1} = {2}", number,i, number * i );
        }

		//Console.WriteLine("You entered name: {0}",name);
		//Console.WriteLine("PLEASE WRITE number: ");
		//var number = Console.ReadLine();

		//Console.WriteLine("Your entered number: {0}", number.ToString());
    }

	public bool GetIfMatches( int number)
	{
		//if (number == 0) return false;
		//if (number == 1) return true;
		///if (number == 10) return true;


		return false;

	}

	public class Shreshti {
        public string name { get; set; }
        public int age { get; set; }
		public string color { get; set; }
		public int height { get; set; }

		public Shreshti(string name, int age, string color, int height)
		{
		Console.WriteLine($"Name: {name}, age: {age} , color : {color}, Height: {height} ");

		}

		public void GetShreshtiDetails()
		{
			name = "Shreshti";
			age = 10;
			color = "Brown";
			height = 143;
			Console.WriteLine($"Name: {name}, age: {age} , color : {color}, Height: {height} ");
		}
	}
}




