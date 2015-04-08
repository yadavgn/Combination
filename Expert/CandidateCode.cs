using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
public class CandidateCode
{
	public static string sequences(string input1)
	{
		//Write code here
	    var strs = input1.Split(',');
	    var inputInts = new List<int>(strs.Length);

        foreach (var number in strs)
	    {
            inputInts.Add(int.Parse(number)); // assuming valid input is provided.
	    }

	    var output = M2(inputInts, 0); // flag 0 initially.
	    return output[0].ToString();
	}

    private static List<int> M2(List<int> input, int flag)
    {
        var output = input;
        if(flag==0)
            flag = 1; // didn't really got the use of the flag. keeping here just to be in sync with problem statement.
        do
        {
            output = M1(output);
        } while (output.Count>1);

        flag = 2;
        return output;
    }

    // Machine one M1 implementation.
    private static List<int> M1(List<int> inputInts)
    {
        if (inputInts.Count == 1) return inputInts;

        var new_list = new List<int>(inputInts.Count - 1);
        for (int i = 1; i < inputInts.Count; i++)
        {
            new_list.Add(inputInts[i] - inputInts[i - 1]);
        }
        return new_list;
    }
}