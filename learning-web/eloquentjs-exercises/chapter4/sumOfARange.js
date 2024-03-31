"use strict";

function range(n1, n2, step = 1) {
  const arr = [];

  if (n1 < n2) {
    for (let i = n1; i <= n2; i += step) {
      arr.push(i);
    }

    return arr;
  } else if (n2 < n1 && step < 0) {
    for (let i = n1; i >= n2; i -= Math.abs(step)) {
      arr.push(i);
    }
    return arr;
  }

  return [];
}

function sum(arr) {
  let sum = 0;

  for (let n of arr) {
    sum += n;
  }

  return sum;
}
