const arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13];
const N = arr.length;
const x = 11;

const result = search(arr, N, x);

// check the result and output it
if (result === -1) {
  console.log(`The item ${x} is not in the array.`);
} else {
  console.log(`The item ${x} is at index position ${result}`);
}

function search(arr, N, x) {
  for (let i = 0; i < N; i++) {
    if (arr[i] === x) {
      // returns the current item index position
      return arr[i];
    }
  }

  // return if the item is not found
  return -1;
}
