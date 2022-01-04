using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowardToLinq
{
    internal class LambdaCapturingVariable
    {
        public static List<Action> CreateActions()
        {
            List<Action> actions = new List<Action>();
            for (int i = 0; i < 5; i++)
            {
                string text = string.Format("message{0}", i);
                actions.Add(() => Console.WriteLine(text));
            }
            return actions;
        }
    }
}
