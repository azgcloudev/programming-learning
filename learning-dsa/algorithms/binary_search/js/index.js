// x is the item to search
function binarySearch(arr, x) {
  let left = 0;
  let right = arr.length;

  while (left <= right) {
    let middle = Math.floor((left + right) / 2);

    // check if the guess matcxhes current position
    if (arr[middle] === x) {
      return middle;
    }

    // check if x is lower than middle
    if (x < middle) {
      // remove the right side
      right = middle - 1;
    } else if (x > middle) {
      // remove the left side block
      left = middle + 1;
    }
  }

  // number not found
  return -1;
}

const arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13];
const guess = 21;

const result = binarySearch(arr, guess);

if (guess === -1) {
  console.log("Number was not found.");
} else {
  console.log(`Number ${guess} is at index ${result}.`);
}
