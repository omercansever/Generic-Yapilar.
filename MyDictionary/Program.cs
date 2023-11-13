using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<Key, Value>
    {
        Key[] _key;
        Value[] _value;

        public MyDictionary()
        {
            _key = new Key[0];   
            _value = new Value[0];
        }

        public void Add(Key keys, Value values)
        {
            Key[] tempKey = _key;
            Value[] tempValue = _value;

            _key = new Key[_key.Length + 1];
            _value = new Value[_value.Length + 1];

            for (int i = 0; i < _key.Length; i++)
            {
                _key[i] = tempKey[i];
                _value[i] = tempValue[i];
            }
            _key[tempKey.Length - 1] = keys;
            _value[tempKey.Length - 1] = values;
        }

        public int Length
        {
            get { return _key.Length; } 
        }

        public Key[] keys 
        {
            get { return _key; } 
        }

        public Value[] values
        {
            get { return _value; }
        }
    }
}