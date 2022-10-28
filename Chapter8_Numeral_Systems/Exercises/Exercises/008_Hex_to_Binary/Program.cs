using System.Text;

void convert_to_Binary(int x)
{
    StringBuilder myStr = new StringBuilder();
    while (x != 0)
    {
        int digit = x % 2;
        x /= 2;
        myStr.Insert(0, digit.ToString());
    }
    Console.Write(myStr.ToString());
    Console.WriteLine();
}

convert_to_Binary(0xFF);