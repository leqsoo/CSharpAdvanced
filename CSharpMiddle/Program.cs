namespace CSharpAdvanced
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var x = Rotate(new int[] { 1, 2, 3, 4, 5, 6 }, 3);
        }
        public static int[] Rotate(int[] nums, int k)
        {
            k %= nums.Length;
            int count = 0;
            for (int start = 0; count < nums.Length; start++)
            {
                int current = start;
                int prev = nums[start];
                do
                {
                    int next = (current + k) % nums.Length;
                    int temp = nums[next];
                    nums[next] = prev;
                    prev = temp;
                    current = next;
                    count++;
                } while (start != current);
            }
            return nums;
        }
    }
}