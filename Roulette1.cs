using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace bot
{
    public class Messages : ModuleBase
    {
        private readonly Dictionary<int, string> rule = new Dictionary<int, string>()
        {
            {0, "ルーレット"},
        };
        private readonly Dictionary<int, string> stage = new Dictionary<int, string>()
        {
            {0,   "1"},
            {1 ,  "2"},
            {2 ,  "3"},
            {3 ,  "4"},
            {4 ,  "5"},
            {5 ,  "6"},
            {6 ,  "7"},
            {7 ,  "8"},
            {8 ,  "9"},
            {9 ,  "10"},
            {10,  "11"},
            {11,  "12"},
            {12,  "13"},
            {13,  "14"},
            {14,  "15"},
            {15,  "16"},
            {16,  "17"},
            {17,  "18"},
            {18,  "19"},
            {19,  "20"},
            {20,  "21"},
            {21,  "22"},
            {22,  "23"},
            {23,  "24"},
            {24,  "25"},
            {25,  "26"},
            {26,  "27"},
            {27,  "28"},
            {28,  "29"},
            {29,  "30"},
            {30,  "31"},
            {31,  "32"},
            {32,  "33"},
            {33,  "34"},
            {34,  "35"},
            {35,  "36"},
            {36,  "0" },
        };
        [Command("ルーレット")]
        public async Task ルーレット()
        {
            Random random = new Random();
            int randomRule = random.Next(1);
            int randomStage = random.Next(37);
            string Messages = "\n ・**" + rule[randomRule].ToString() + "結果:\n" + stage[randomStage].ToString() + "**\n";
            await ReplyAsync(Messages);
        }
    }
}