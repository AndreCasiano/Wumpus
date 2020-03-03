using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WumpusTest

{
    public class Trivia
    {
        private string fileName;

        public Trivia(String name)
        {
            fileName = name;     
        }
        public string getQuestion()​
        {​
            string que = "Question";​
            return que;​
        }​
        public String getAnswer()​
        {​
            String ans = "Question";​
            return ans;​
        }​
    }
}
