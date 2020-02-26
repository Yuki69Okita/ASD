using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerBitArray
{
    struct BitArray32
    {
        private uint mValue;
        public int this[int index]
        {
            get
            {
                if (index >= 0 && index <= 31)
                {
                    if ((mValue & (1 << index)) == 0)
                        return 0;
                    else
                        return 1;
                }
                else
                {
                    throw new ApplicationException(string.Format("Index {0} is invalid!", index));
                }
            }
            set
            {
                if (index < 0 || index > 31)
                {
                    throw new ApplicationException(string.Format("Index {0} is invalid.", index));
                }
                if (value < 0 || value > 1)
                {
                    throw new ApplicationException(String.Format("Value {0} is invalid.", value));
                }
                //Clear the bit at position index
                mValue &= ~((uint)(1 << index));

                //Set the bit at position index to value
                mValue |= (uint)(value << index);
            }
        }

        #region The Indexer can be written returning bool
        //public bool this[int index]
        //{
        //    get
        //    {
        //        if (index >= 0 && index <= 31)
        //        {
        //            if ((mValue & (1 << index)) == 0)
        //                return false;
        //            else
        //                return true;
        //        }
        //        else
        //        {
        //            throw new ApplicationException(string.Format("Index {0} is invalid!", index));
        //        }
        //    }
        //    set
        //    {
        //        if (index < 0 || index > 31)
        //        {
        //            throw new ApplicationException(string.Format("Index {0} is invalid.", index));
        //        }
        //        //Clear the bit at position index
        //        mValue &= ~((uint)(1 << index));

        //        //Set the bit at position index to value
        //        mValue |= (uint)(value ? 1 : 0 << index);
        //    }
        //}
        #endregion
    }
}
