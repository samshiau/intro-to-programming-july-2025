
public class Calculator
{

    public int Add(string numbers)
    {
        if (numbers.Length == 0) return 0;


        if (numbers.Length == 1)
            return int.Parse(numbers);


        int res = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (char.IsDigit(numbers[i]))
            {
                res += int.Parse(numbers[i].ToString());
            }

        }
        return res;
    }


}
