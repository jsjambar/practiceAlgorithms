using System;
using System.Linq;

namespace practiceAlgorithms
{
	public class MergeSort
	{
		public static int[] mSort(int[] numbers)
		{
			int countNumbers = numbers.Count();

			if (countNumbers < 2)
			{
				return numbers;
			}

			int mid = countNumbers / 2;
			int[] left = new int[mid];
			int[] right = new int[countNumbers - mid];

			for (int i = 0; i <= mid - 1; i++)
			{
				left[i] = numbers[i];
			}

			for (int i = mid; i <= countNumbers - 1; i++)
			{
				right[i - mid] = numbers[i];
			}

			mSort(left);
			mSort(right);
			Merge(left, right, numbers);

			return numbers;
		}

		public static int[] Merge(int[] L, int[] R, int[] A)
		{
			int countLeft = L.Count();
			int countRight = R.Count();
			int leftCounter = 0;
			int rightCounter = 0;
			int mainCounter = 0;

			while (leftCounter < countLeft && rightCounter < countRight)
			{
				if (L[leftCounter] <= R[rightCounter])
				{
					A[mainCounter] = L[leftCounter];
					leftCounter++;
				}
				else
				{
					A[mainCounter] = R[rightCounter];
					rightCounter++;
				}

				mainCounter++;

			}

			while (leftCounter < countLeft)
			{
				A[mainCounter] = L[leftCounter];
				leftCounter++;
				mainCounter++;
			}

			while (rightCounter < countRight)
			{
				A[mainCounter] = R[rightCounter];
				rightCounter++;
				mainCounter++;

			}

			return A;

		}
	}
}
