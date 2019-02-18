using System;
					
public class Program
{
	public static void Main()
	{
		string[] array1 = { "A", "C","D","A"};
		string[] array2 = {"C","X","C"};
		if (isSubset(array1,array2)){
			Console.WriteLine("true");
		}else{
			Console.WriteLine("false");
		}
	}
	
	static bool isSubset(string[] arr1, string[] arr2){
		int arr1Length = arr1.Length;
		int arr2Length = arr2.Length;
		
		for (int i = 0; i < arr2Length ; i ++){
			for (int j = 0; j < arr1Length ; j++){
				if(arr1[j].Equals(arr2[i])==true){
					break;
				}
				if( j == arr1Length -1){
					return false;
				}
			}
			
		}		
		return true;
	}
