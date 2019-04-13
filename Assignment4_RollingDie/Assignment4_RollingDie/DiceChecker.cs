using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_RollingDie
{
    public class DiceEventArgs : EventArgs
    {
        public List<int> die_List { get; set; }
        public int I { get; set; }
    }
    class DiceChecker
    {
        public delegate void CheckDiceCombination(object source, DiceEventArgs args);
        public event CheckDiceCombination HasDouble4;
        public event CheckDiceCombination HasSum20;

        public List<int> dieList { get; set; }
        public DiceChecker(List<int> dielist)
        {
            this.dieList = dielist;
        }

        public void Check_Double4()
        {
            for (int i = 0; i < dieList.Count - 1; ++i)
            {
                if ((dieList[i] == 4) && (dieList[i + 1] == 4))
                {
                    if (this.HasDouble4 != null)
                    HasDouble4(this, new DiceEventArgs() { die_List = dieList, I = i });
                }
            }
        }
        public void Check_Sum20()
        {
            for (int i = 0; i < dieList.Count - 4; ++i)
            {
                if ((dieList[i] + dieList[i + 1] + dieList[i + 2] + dieList[i + 3] + dieList[i + 4]) >= 20)
                {
                    if (this.HasSum20 != null)
                    HasSum20(this, new DiceEventArgs() { die_List = dieList, I = i});
                }
            }
        }
    }
}
