using static System.Console;

WriteLine("Top-level function examples");
WhatsMyNamespace();

void WhatsMyNamespace()
{
    WriteLine("Namespace of program class: {0}", arg0: typeof(Program).Namespace ?? "null");
}