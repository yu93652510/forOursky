using System;
					
public class Program
{
	public static void Main()
	{
		char[] array1 = {'A', 'C', 'D', 'A'};
		char[] array2 = {'C', 'X', 'C'};
		if (isSubset(array1,array2)){
			Console.WriteLine("true");
		}else{
			Console.WriteLine("false");
		}
	}
	
	static bool isSubset(char[] arr1, char[] arr2){
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
