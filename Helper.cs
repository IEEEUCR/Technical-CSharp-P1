public static class Helper {
	public static void PrintEntries(this Dictionary<string, string> dict) {
		foreach((var key, var val) in dict) {
			Console.WriteLine($"{key}: {val}");
		}
	}
	
	public static void PrintKeys(this Dictionary<string, string> dict, string prefix) {
		//Use the magical powers of LINQ!
		var keys =  from key						//Variable name
					in dict.Keys					//Collection of items
					where key.StartsWith(prefix)	//Filter condition
					select key;						//Transform the result if needed
		foreach(var k in keys) {
			Console.WriteLine(k);
		}
	}
	
	public static void Add(ref int a, int b) {
		a += b;
	}
}
/*
//random stuff

dynamic thing = 0;
thing = new Dictionary<string, string>();
thing.Keys

int n = 0;

ref int m = ref n;
m += 10;
//n == 10

Add(ref n, 10);
//n == 10


(int a, int b) = (10, 20);
(b, a) = (a, b);
(int x, int y, int z) vector = (1, 2, 3);

struct A {
	int n;
}
record Vec3(int x, int y, int z) {}
class Vec3 {
	int x, y, z;
	public Vec3(int x, int y, int z) {
		this.x = x;
		this.y = y;
		this.z = z;
	}
}
	
var v = new Vec3(0, 1, 2);
*/