public class ProductArray
{
	public static readonly int MAX_NUMBERS = 1;
	public static readonly int MIN_NUMBERS = 0;

    public static int CalculateProduct(int[] arr, int prodtype)
	{
		if (arr.Length == 0) return 0;

		int[] normalize = arr.Distinct().ToArray();
		Array.Sort(normalize);

		var productTwoMaxValues = 0;
		var productTwoMinValues = 0;

		if (normalize.Length == 1)
		{
			productTwoMaxValues = normalize[0] * normalize[0];
            productTwoMinValues = normalize[0] * normalize[0];
        }
		else
		{
			productTwoMaxValues = normalize[normalize.Length - 1] * normalize[normalize.Length - 2];
			productTwoMinValues = normalize[0] * normalize[1];
		}

		if (prodtype == MIN_NUMBERS)
		{
			return productTwoMinValues;
		}
		else
		{
			return productTwoMaxValues;
		}
	}

	public static int[] CalculateProductArray(int[] arr)
	{
		if (arr.Length == 0)
		{
			return new int[] { };
		}

		int[] prod = new int[arr.Length];

        for (var i = 0; i < arr.Length; i++)
		{
			prod[i] = MultiplyArrayDigits(arr, i);
        }

		return prod;
	}
    
    private static int MultiplyArrayDigits(int[] arr, int index)
    {
       int prod = 1;

        for (var i = 0; i < arr.Length; i++)
        {
            if (i == index)
            {
                prod *= 1;                
            }
            else
            {
                prod *= arr[i];                
            }
        }

        return prod;
    }
}
