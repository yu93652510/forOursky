using System;
					
public class Program
{
	public static void Main()
	{
		string[] array1 = { "A", "C","D","A"};
		string[] array2 = {"C","D","X"};
		if (isSubset(array1,array2)){
			Console.WriteLine("true");
		}else{
			Console.WriteLine("false");
		}
	}
	
	static bool isSubset(string[] arr1, string[] arr2){
		int arr1Length = arr1.Length;
		Console.WriteLine(arr1Length);
		int arr2Length = arr2.Length;
		Console.WriteLine(arr2Length);
		
		for (int i = 0; i < arr2Length ; i ++){
			 Console.WriteLine("i=" + i);
			for (int j = 0; j < arr1Length ; j++){
				Console.WriteLine("j=" + j);
				if(arr1[j].Equals(arr2[i])==true){
					break;
				}
				if( j == arr1Length -1){
					Console.WriteLine("hi");
					return false;
				}
			}
			
		}		
		return true;
	}




}
