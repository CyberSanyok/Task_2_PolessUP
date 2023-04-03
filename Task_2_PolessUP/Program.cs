int[] nums = new int[4] { 2, 11, 15,7 };
int target = 9;
int[] answer = new int[2];
Function(answer, nums, target);
Console.WriteLine("[" + answer[0] + "," + answer[1] + "]");


void Function(int[] answer, int[] nums, int target)
{
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = 0; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target && i != j)
            {
                // 
                answer[0] = i; answer[1] = j;
                return;
            }

        }
    }
}
