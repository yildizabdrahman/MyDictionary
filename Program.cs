using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> adYas = new MyDictionary<string, int>();
            adYas.Add("Baran", 11);
        }
    }

    class MyDictionary<TK, TV>
    {
        TK[] _keys;
        TV[] _values;
        TK[] _tempKeys;
        TV[] _tempValues;

        public MyDictionary()
        {
            _keys = new TK[0];
            _values = new TV[0];
        }
        public void Add(TK key, TV value)
        {
            _tempKeys = _keys;
            _tempValues = _values;

            _keys = new TK[_keys.Length+1];
            _values = new TV[_values.Length+1];

            for (int i = 0; i < _tempKeys.Length; i++)
            {
                _keys[i] = _tempKeys[i];
                _values[i] = _tempValues[i];

            }

            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;

            Console.WriteLine("Tebrikler "+_keys[_keys.Length - 1]+" "+_values[_values.Length - 1] + " Eklendi");

        }
    }
}
