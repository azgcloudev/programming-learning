namespace FunWithBitwiseOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Fun with Bitwise Operations =====");
            Console.WriteLine("6:{2} & 4:{3} = {0} binary: {1}", 6 & 4, Convert.ToString((6 & 4), 2), Convert.ToString(6, 2), Convert.ToString(4, 2));
            Console.WriteLine("6:{2} | 4:{3} = {0} binary: {1}", 6 | 4, Convert.ToString((6 | 4), 2), Convert.ToString(6, 2), Convert.ToString(4, 2));
            Console.WriteLine("6:{2} ^ 4:{3} = {0} binary: {1}", 6 ^ 4, Convert.ToString((6 ^ 4), 2), Convert.ToString(6, 2), Convert.ToString(4, 2));
            Console.WriteLine("6:{2} << 1 = {0} binary: {1}", 6 << 1, Convert.ToString((6 << 1), 2), Convert.ToString(6, 2));
            Console.WriteLine("6:{2} >> 1 = {0} binary: {1}", 6 >> 1, Convert.ToString((6 >> 1), 2), Convert.ToString(6, 2));
            Console.WriteLine("~1:{0} = {1}: b{2}", Convert.ToString(1, 2), ~1, Convert.ToString(~1, 2));
            Console.WriteLine("Int.MaxValue: {0}", Convert.ToString((int.MaxValue), 2));

            // Enums with bitwise
            Console.WriteLine();
            ContactPreference emailAndPhone = ContactPreference.Email | ContactPreference.Phone;

            Console.WriteLine("None? {0}", (emailAndPhone | ContactPreference.None) == emailAndPhone);
            Console.WriteLine("Email? {0}", (emailAndPhone  | ContactPreference.Email) == emailAndPhone);
            Console.WriteLine("Phone? {0}", (emailAndPhone | ContactPreference.Phone) == emailAndPhone);
            Console.WriteLine("Text? {0}", (emailAndPhone | ContactPreference.Ponyexpress) == emailAndPhone);

            // end
            Console.ReadLine();
        }
    }
}