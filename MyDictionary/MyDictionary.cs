using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<FValue>
    {
        FValue[] values;

        public MyDictionary()
        {

            values = new FValue[0];
        }

        public void Add(FValue value)
        {

            FValue[] tempArray = values;

            values = new FValue[values.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {

                values[i] = tempArray[i];
            }


            values[values.Length - 1] = value;
        }

    }
}
