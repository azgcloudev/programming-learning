use std::io;


fn main() {
    println!("Guess the number!");

    println!("Please input your guess:");

    let mut guess = String::new();
    let mut apellido: String; // declaration

    io::stdin().read_line(&mut guess).expect("Failed to read line");

    println!("Your guess: {guess}");
}