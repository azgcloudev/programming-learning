// main function always should be in a kotlin project
fun main() {
    println("Hello World!")

    /* VARIABLES */
    var whole = 11
    var fractional = 3.14
    var words = "This is a string"
    // variables are mutable
    whole += 3
    println(whole)

    /* CONSTANTS */
    val IVA = 0.13
    val taxAmount = 10500 * IVA
    println("Total price is $taxAmount")
}