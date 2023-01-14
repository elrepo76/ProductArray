public class Program
{
    static void PrintArray(string comment, int[] arr)
    {
        Console.Write(comment + ": ");
        Console.WriteLine(String.Join(", ", arr));
    }
    public static void Main(string[] args)
    {
        int[] nums = { 5, 0, 3, 2, 5, 7, 1 };
        PrintArray("Original array", nums);
        int[] productArr = ProductArray.CalculateProductArray(nums);
        PrintArray(" Product array", productArr);
        Console.WriteLine(" ");

        int[] nums1 = { -2, -1, -3, 4, -8, 0 };
        PrintArray("Original array", nums1);
        productArr = ProductArray.CalculateProductArray(nums1);
        PrintArray(" Product array", productArr);
        Console.WriteLine(" ");

        int[] nums2 = { };
        PrintArray("Original array", nums2);
        productArr = ProductArray.CalculateProductArray(nums2);
        PrintArray(" Product array", productArr);
        Console.WriteLine(" ");

        int[] nums3 = { 3, 0, 0, 2, -8 };
        PrintArray("Original array", nums3);
        productArr = ProductArray.CalculateProductArray(nums3);
        PrintArray(" Product array", productArr);
        Console.WriteLine(" ");

        int[] nums4 = { 3, 3, 3 };
        PrintArray("Original array", nums4);
        productArr = ProductArray.CalculateProductArray(nums4);
        PrintArray(" Product array", productArr);
        Console.WriteLine(" ");

        PrintArray("Original array", nums);
        Console.Write("Product of 2 Biggest Numbers in array: ");
        Console.WriteLine(ProductArray.CalculateProduct(nums, ProductArray.MAX_NUMBERS));
        Console.Write("Product of 2 Smallest Numbers in array: ");
        Console.WriteLine(ProductArray.CalculateProduct(nums, ProductArray.MIN_NUMBERS));
        Console.WriteLine(" ");

        PrintArray("Original array", nums1);
        Console.Write("Product of 2 Biggest Numbers in array: ");
        Console.WriteLine(ProductArray.CalculateProduct(nums1, ProductArray.MAX_NUMBERS));
        Console.Write("Product of 2 Smallest Numbers in array: ");
        Console.WriteLine(ProductArray.CalculateProduct(nums1, ProductArray.MIN_NUMBERS));
        Console.WriteLine(" ");

        PrintArray("Original array", nums3);
        Console.Write("Product of 2 Biggest Numbers in array: ");
        Console.WriteLine(ProductArray.CalculateProduct(nums3, ProductArray.MAX_NUMBERS));
        Console.Write("Product of 2 Smallest Numbers in array: ");
        Console.WriteLine(ProductArray.CalculateProduct(nums3, ProductArray.MIN_NUMBERS));
        Console.WriteLine(" ");

        PrintArray("Original array", nums4);
        Console.Write("Product of 2 Biggest Numbers in array: ");
        Console.WriteLine(ProductArray.CalculateProduct(nums4, ProductArray.MAX_NUMBERS));
        Console.Write("Product of 2 Smallest Numbers in array: ");
        Console.WriteLine(ProductArray.CalculateProduct(nums4, ProductArray.MIN_NUMBERS));
    }
}