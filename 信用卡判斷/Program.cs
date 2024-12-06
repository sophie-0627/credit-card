string number = "5181271099000012";
int num_1 = 0;
int num_2 = 0;
string a = "";
int ten = 0;
int one = 0;
int count = 1;
int total = 0;

foreach (char num in number)
{
    if (count / 2 != 0)
    {
        int k = num * 2;
        a = k.ToString();

        foreach (int b in a)
        {
            ten = b / 10;
            one = b % 10;

            num_1 += ten + one;
            Console.WriteLine(ten);
            Console.WriteLine(one);
        }
    }
    else
    {
        num_2 += num;
    }
    count++;
}

total = num_1 + num_2;

if (total%10 != 0) 
{
    Console.WriteLine("total "+total+" is Valid");
}
else
{
    Console.WriteLine("total " + total+" is Invalid");
}
