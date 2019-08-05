using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpIndexer.src
{
    public class Test
    {
        private int _count;
        private int[] numbers;

        public Test(int count)
        {
            _count = count;
            numbers = new int[_count];
        }

        public Test()
        {
            this._count = 1;
            numbers = new int[_count];
        }


        #region Indexer

        public int this[int index]
        {
            get
            {
                return numbers[index];
            }
            set
            {
                numbers[index] = value;
            }
        }

        #endregion
    }
}
