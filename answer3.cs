using System;
					
public class Program
{
	public static int FiboNumber(int n)
	{
		int f1 = 1;
		int f2 = 1;
		int fn;
		if ( n == 1 || n == 2){
			return 1;
		}else if (n > 2){
			for (int i = 2; i < n; i++){
				fn = f1 + f2;
				f1 = f2;
				f2 = fn;			
			}
		}
		return f2;		
	}
	
	public static int NextFiboNumber(int c){
		for (int i = 0; i < c ; i++){
			if (FiboNumber(i) > c){
				return FiboNumber(i);
				}
		}
		return -1;
	}
	
	public static void Main(){
	
		int c = 1000; // input the number here
		Console.WriteLine(NextFiboNumber(c));
		
	}


}
