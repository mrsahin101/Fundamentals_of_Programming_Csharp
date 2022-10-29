/* Write a program that converts Roman digits to Arabic ones. */

void convert_Roman_to_Arabic(string romanSequence)
{
    int sum = 0;
    Dictionary<string, int> romanMap = new Dictionary<string, int>()
    {
        {"I",1 },
        {"V",5 },
        {"X",10 },
        {"L",50 },
        {"C",100 },
        {"D",500 },
        {"M",1000 }
    };
    int indexTracker = 0; 
    for(int i = 0; i < romanSequence.Length; i++)
    {
        if (romanMap.ContainsKey(romanSequence[i].ToString()) == true)
        {
            if(((i + 1) < romanSequence.Length ) )
            {
                if(romanMap.ContainsKey(romanSequence[i + 1].ToString()) == true)
                {
                    if (romanSequence[i] < romanSequence[i + 1])
                        sum -= romanMap[romanSequence[i].ToString()];
                    else
                        sum += romanMap[romanSequence[i].ToString()];
                }
                else
                    throw new ArgumentOutOfRangeException("Please use only Roman digits!");
            }
            else
            {
                sum += romanMap[romanSequence[i].ToString()];
            }
        }
        else
            throw new ArgumentOutOfRangeException("Please use only Roman digits!");
        indexTracker++;
    }
    Console.WriteLine(sum);
}
convert_Roman_to_Arabic("VIM");