/* * Write a method that calculates the product of two polynomials with integer coefficients, 
 * for example (3x2 + x - 3) * (x - 1) = (3x3 - 2x2 - 4x + 3).
 */
static int[] createPolynomial()
{
    Console.Write("Enter degree of your polynomial :");
    int degree = int.Parse(Console.ReadLine());
    if (degree < 0)
        throw new Exception("Invalid degree! Degree must be equal or greater than zero!");
    Console.WriteLine("Enter co-efficents of degrees!");
    PrintLines(2);
    // degree + 1 index -> show degree count
    int[] coeffients = new int[degree + 1];

    for (int i = 0; i < coeffients.Length; i++)
        coeffients[i] = 0;

    while (degree >= 0)
    {
        Console.Write("Enter " + degree + "th degree co-efficent :");
        coeffients[degree] = int.Parse(Console.ReadLine());
        degree--;
    }
    return coeffients;
}
static void PrintLines(int count)
{
    for (int i = 0; i < count; i++)
        Console.WriteLine();
}
static int[] CalculateSumPolynomial(int[] firstPolynomial, int[] secondPolynomial)
{
    int[] resultCoEfficents = new int[(firstPolynomial.Length - 1) + (secondPolynomial.Length - 1) + 1];
    for (int i = 0; i < resultCoEfficents.Length; i++)
        resultCoEfficents[i] = 0;

    for (int i = 0; i < firstPolynomial.Length; i++)
    {
        for (int j = 0; j < secondPolynomial.Length; j++)
        {
            resultCoEfficents[i + j] += firstPolynomial[i] * secondPolynomial[j];
        }
    }
    return resultCoEfficents;
}
static void PrintResultPolynomial(int[] coefficents)
{
    Console.Write("( ");
    for (int i = coefficents.Length - 1; i >= 0; i--)
    {
        Console.Write(coefficents[i]);
        if (i != 0)
            Console.Write("*x" + i.ToString() + " + ");
    }
    Console.Write(" )");
}
PrintResultPolynomial(CalculateSumPolynomial(createPolynomial(), createPolynomial()));