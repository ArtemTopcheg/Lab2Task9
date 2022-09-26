//Task9

int[] nums1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] nums2 = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
int temp;
for (int i = 0; i < nums1.Length - 1; i++)
{
    for (int j = i + 1; j < nums1.Length; j++)
    {
        if (nums1[i] < nums1[j])
        {
            temp = nums1[i];
            nums1[i] = nums1[j];
            nums1[j] = temp;
        }
    }
}
for (int i = 0; i < nums2.Length - 1; i++)
{
    for (int j = i + 1; j < nums2.Length; j++)
    {
        if (nums2[i] < nums2[j])
        {
            temp = nums2[i];
            nums2[i] = nums2[j];
            nums2[j] = temp;
        }
    }
}
int count = 0;
for (int i = 0; i < nums1.Length; i++)
{
    if (nums1[i] != nums2[i])
    {
        count++;
    }
}
if (count == 0)
{
    Console.WriteLine("Массивы равны");
}
else
{
    Console.WriteLine("Массивы не равны");
}
foreach (int i in nums1)
{
    Console.Write(nums1[i] + " ");
}
Console.WriteLine();
foreach (int i in nums2)
{
    Console.Write(nums2[i] + " ");
}