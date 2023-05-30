/**
 Do not return anything, modify nums in-place instead.
 */
function moveZeroes(nums: number[]): void {
if (nums.length >= 1) {
      let readPointer = 0;
      for (let index = 0; index < nums.length; index++) {
        if (nums[readPointer] === 0) {
          nums.splice(readPointer, 1);
          nums.push(0);
        } else {
          readPointer++;
        }
      }
    }
};
