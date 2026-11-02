using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    public class StudentSolution
    {
        class Action
        {
            public string Name;
            public int Value;
        }

        #region Lecture

        public (int Count, int Popped, int Peek, int CountAfterPeek) LCT01_StackSyntax()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            int count = stack.Count;
            int popped = stack.Pop();
            int peek = stack.Peek();
            int countAfterPeek = stack.Count;

            return (count, popped, peek, countAfterPeek);
        }

        public (int Count, int Dequeued, int Peek, int CountAfterPeek) LCT02_QueueSyntax()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            int count = queue.Count;
            int dequeued = queue.Dequeue();
            int peek = queue.Peek();
            int countAfterPeek = queue.Count;

            return (count, dequeued, peek, countAfterPeek);
        }

        public string[] LCT03_ActionStack()
        {
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };

            Stack<Action> stack = new Stack<Action>();
            stack.Push(action1);
            stack.Push(action2);
            stack.Push(action3);

            int c = stack.Count;
            List<string> actions = new List<string>();
            for (int i = 0; i < c; i++)
            {
                var action = stack.Pop();
                actions.Add(action.Name);
            }

            return actions.ToArray();
        }

        public string[] LCT04_ActionQueue()
        {
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };

            Queue<Action> queue = new();
            queue.Enqueue(action1);
            queue.Enqueue(action2);
            queue.Enqueue(action3);

            int c = queue.Count;
            List<string> actions = new List<string>();
            for (int i = 0; i < c; i++)
            {
                var a = queue.Dequeue();
                actions.Add(a.Name);
            }

            return actions.ToArray();
        }

        #endregion

        #region Assignment

        public string ASN01_ReverseString(string str)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char character in str)
            {
                stack.Push(character);
            }

            StringBuilder reversed = new StringBuilder(str.Length);
            while (stack.Count > 0)
            {
                reversed.Append(stack.Pop());
            }

            return reversed.ToString();
        }

        public bool ASN02_StackPalindrome(string str)
        {
            return str == ASN01_ReverseString(str);
        }

        #endregion

        #region Extra

        public bool EX01_ParenthesesChecker(string str)
        {
            Stack<char> openingBrackets = new Stack<char>();

            foreach (char bracket in str)
            {
                switch (bracket)
                {
                    case '(':
                    case '[':
                    case '{':
                        openingBrackets.Push(bracket);
                        break;

                    case ')':
                    case ']':
                    case '}':
                        if (openingBrackets.Count == 0)
                        {
                            return false;
                        }

                        char openingBracket = openingBrackets.Pop();
                        if ((bracket == ')' && openingBracket != '(')
                            || (bracket == ']' && openingBracket != '[')
                            || (bracket == '}' && openingBracket != '{'))
                        {
                            return false;
                        }
                        break;
                }
            }

            return openingBrackets.Count == 0;
        }

        #endregion
    }
}
