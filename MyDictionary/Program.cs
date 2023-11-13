using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<Key, Value>
    {
        Key[] _keys;
        Value[] _values;

        public MyDictionary() 
        {
            _keys = new Key[0];
            _values = new Value[0];
        }

        public void Add(Key key, Value value)
        {
            Key[] tempKey = _keys;
            Value[] tempValue = _values;

            _keys = new Key[_keys.Length + 1];
            _values= new Value[_values.Length + 1];

            for (int i = 0; i < _keys.Length; i++)
            {
                _keys[i] = tempKey[i];
                _values[i] = tempValue[i];
            }
            _keys[tempKey.Length - 1] = key;
            _values[tempValue.Length - 1] = value;
        }

        public int Length
        {
            get { return _keys.Length; } 
        }

        public Key[] keys 
        {
            get { return _keys; } 
        }

        public Value[] values
        {
            get { return _values; }
        }
    }
}