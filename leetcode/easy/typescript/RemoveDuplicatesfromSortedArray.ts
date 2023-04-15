function removeDuplicates(nums: number[]): number {
  const uniqeItems = new Set(nums);
  const uniqeItemsSize = uniqeItems.size;
  const uniqeItemsValue = uniqeItems.values();
  for (let index = 0; index < nums.length; index++) {
    if (index < uniqeItemsSize) nums[index] = uniqeItemsValue.next().value;
  }
  return uniqeItemsSize;
}

// Optimization

function removeDuplicatesOptimization(nums: number[]): number {
  const uniqeItems = new Set(nums);
  const uniqeItemsSize = uniqeItems.size;
  const uniqeItemsValue = uniqeItems.values();
  for (let index = 0; index < nums.length; index++) {
    if (index < uniqeItemsSize) nums[index] = uniqeItemsValue.next().value;
    else return uniqeItemsSize;
  }
  return uniqeItemsSize;
}
