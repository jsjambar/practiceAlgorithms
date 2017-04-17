using System;
using System.Collections.Generic;
using System.Linq;

namespace practiceAlgorithms
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int[] numbs = new int[]{ 90, 12, 1, 4, 5 };
			var sorted = MergeSort.mSort(numbs);

			foreach (int num in sorted)
			{
				Console.WriteLine(num.ToString() + " ");
			}
		}

	}
}
