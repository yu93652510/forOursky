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
	
	public static int[] NextFiboNumber(int[] c){
		int[] answer = new int[c.Length];
		for (int j = 0; j < c.Length; j++){
			for (int i = 0; i < c[j] ; i++){
				if (FiboNumber(i) > c[j]){
					answer.SetValue(FiboNumber(i),j);
					Console.WriteLine(answer[j]);
					break;
					}
			}
		} 
		return answer;
	}
	
	public static void Main(){
	
		int[] c = {19,55,21,1000}; // input the array here
		NextFiboNumber(c);
		
	}


}
