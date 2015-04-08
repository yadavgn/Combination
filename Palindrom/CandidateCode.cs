using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;


namespace Palindrom
{
    public class CandidateCode
    {
        public static int PalindromeLengthPuzzle(string[] input1)
        {
            //Write code here
            string Initials = input1.Aggregate("", (current, t) => current + t[0]);
            var selected = new int[input1.Length];
            selected.Initialize();

            return PalindromeLengthPuzzle(Initials, 0, input1.Length-1, 1);
        }
        
        // Using Divide and conquer to sole the problem
        public static int PalindromeLengthPuzzle(string Initials, int front, int rear, int pass)
        {
            if (front > rear) return 0;
            int length1 = 0, length2 = 0;
            
            string subStr = Initials.Substring(front, rear - front+1);
            Debug.WriteLine("{"+pass+"} subStr ->" +subStr);

            if (front == rear)
            {
                Debug.WriteLine("Single char." );
                return 1;
            }
            if (Initials[rear] == Initials[front])
            {
                Debug.WriteLine("consider it substring and proceed with next.");
                return 2 + PalindromeLengthPuzzle(Initials, front + 1, rear - 1, pass + 1);
            }

            Debug.WriteLine("escape first and proceed to next");
            length1 = PalindromeLengthPuzzle(Initials, front + 1, rear, pass + 1);

            Debug.WriteLine("escape last and proceed to next");
            length2 = PalindromeLengthPuzzle(Initials, front, rear - 1, pass + 1);

            return length1 > length2 ? length1: length2;
        }
    }
}
