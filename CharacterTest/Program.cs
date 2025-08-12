class charactertest
{
    //input: abcd , output : a ab abc abcd b bc bcd c cd d
    // Hi how are you curitics
    private string inputStr;
    charactertest(string input)
    {
      inputStr = input;
    }

    public void displayString()
    {
        List<String> strList = new List<string>();
        string res = string.Empty;
        if (inputStr != null)
        {
            strList = inputStr.Split(' ').ToList();
            //reverse the order
            for (int i = strList.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(strList[i]);
                res += strList[i] + " ";
            }
        }
        else
        {
            Console.WriteLine("Enter a string");
        }
        Console.WriteLine("The string is: " + res);
    }

   public static void Main(String[] args)
    {
        charactertest ct = new charactertest("Hi how are you curitics");
        ct.displayString();
    }
}