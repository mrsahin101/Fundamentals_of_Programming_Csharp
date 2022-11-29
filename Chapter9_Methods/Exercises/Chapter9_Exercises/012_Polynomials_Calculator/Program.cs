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

    while(degree >= 0)
    {
        Console.Write("Enter " + degree + "th degree co-efficent :");
        coeffients[degree] = int.Parse(Console.ReadLine());
        degree--;
    }
    return coeffients;
}
static int[] CalculateSumPolynomial(int[] firstPolynomial, int[] secondPolynomial)
{
    int maxLength = firstPolynomial.Length;
    if (secondPolynomial.Length > maxLength)
        maxLength = secondPolynomial.Length;

    int[] coefficents = new int[maxLength];
    for (int i = 0; i < maxLength; i++)
        coefficents[i] = 0;

    for(int i = 0; i < firstPolynomial.Length; i++)
    {
        coefficents[i] += firstPolynomial[i];
    }
    for (int i = 0; i < secondPolynomial.Length; i++)
    {
        coefficents[i] += secondPolynomial[i];
    }
    return coefficents;
}
static void PrintResultPolynomial(int[] coefficents)
{
    Console.Write("( ");
    for(int i = coefficents.Length - 1; i >= 0; i--)
    {
        Console.Write(coefficents[i] );
        if (i != 0)
            Console.Write("*x" + i.ToString() + " + ");
    }
    Console.Write(" )");
}
static void PrintLines(int count)
{
    for(int i = 0; i < count; i++)
        Console.WriteLine();
}
PrintResultPolynomial(CalculateSumPolynomial(createPolynomial(), createPolynomial()));