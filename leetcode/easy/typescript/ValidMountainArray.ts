function validMountainArray(arr: number[]): boolean {
  let i = 0;
  let j = 1;
  if (arr && arr.length < 3) return false;

  const isSorted = arr.every(function (num, idx) {
    return num >= arr[idx + 1] || idx === arr.length - 1 ? 1 : 0;
  });
  if (isSorted) {
    return false;
  }

  const isSortedDesc = arr.every(function (num, idx) {
    return num <= arr[idx + 1] || idx === arr.length - 1 ? 1 : 0;
  });
  if (isSortedDesc) {
    return false;
  }
  while (j < arr.length) {
    if (
      arr[i] === arr[j] ||
      (i > 0 && arr[i - 1] > arr[i] && arr[i] < arr[j])
    ) {
      return false;
    }
    i++;
    j++;
  }

  return true;
}
