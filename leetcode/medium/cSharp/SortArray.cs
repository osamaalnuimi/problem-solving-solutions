public class Solution {
    public int[] SortArray(int[] nums) {
    mergeSort(nums, 0, nums.Length - 1);
    return nums;
}

void mergeSort(int[] arr, int low, int high)
{
    if (low >= high) return;

    int mid = (low + high) / 2;
    mergeSort(arr, low, mid);
    mergeSort(arr, mid + 1, high);
    merge(arr, low, high, mid);
}
void merge(int[] arr, int low,int high, int mid)
{
    List<int> temp = new List<int>();

    int left = low;
    int right = mid + 1;

    while (left <= mid && right <= high)
    {
        if (arr[left] <= arr[right])
        {
            temp.Add(arr[left]);
            left++;
        }
        else
        {
            temp.Add(arr[right]);
            right++;
        }
    }
        while (left <= mid)
        {
            temp.Add(arr[left]);
            left++;
            
        }
        while (right<= high)
        {
            temp.Add(arr[right]);
            right++;
        }
        for (int i = low; i <= high; i++)
        {
            arr[i] = temp[i-low];
        }
    
}
}
