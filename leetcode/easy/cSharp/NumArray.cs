public class NumArray {

   
    private int[] _nums;
    public NumArray(int[] nums) {
        this._nums = nums;
    }
    
    public int SumRange(int left, int right) {
        int sum = 0;
        for (int i = left; i <= right; i++)
        {
            sum += this._nums[i];

        }
        return sum;
    }
}
