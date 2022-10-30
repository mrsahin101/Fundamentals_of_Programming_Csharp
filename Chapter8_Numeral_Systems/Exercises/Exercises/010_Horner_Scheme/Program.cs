/* Write a program that converts a binary number to decimal using the Horner scheme. */
void horner_scheme(string binary)
{
    int decimalOutput = int.Parse(binary[0].ToString());
    for (int i = 1; i < binary.Length; i++)
    {
        decimalOutput = (decimalOutput * 2) + int.Parse(binary[i].ToString());
    }
    Console.WriteLine(decimalOutput);
}
horner_scheme("0111");