const printBoardLine = (size, boardLine) => {
  let line = "";

  // if board line is even start line with space
  if (boardLine % 2 === 0) {
    for (let i = 0; i < size; i++) {
      if (i % 2 === 0) {
        line += " ";
      } else {
        line += "#";
      }
    }
  }
  // if the board line is an odd line, start with a hash
  else {
    for (let i = 0; i < size; i++) {
      if (i % 2 === 0) {
        line += "#";
      } else {
        line += " ";
      }
    }
  }
  console.log(line);
}

const printBoard = (boardSize) => {
  for (let i = 0; i < boardSize; i++) {
    printBoardLine(boardSize, i);
  }
}

printBoard(9);