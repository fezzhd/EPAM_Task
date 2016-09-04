﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackGeneric
{
    class Stack<T> where T:class
    {
        private T[] _stackArray;

        public int Length{
            get { return _stackArray.Length; }
        }


        public Stack()
        {
           _stackArray = new T[0];
        }


        public void Push(T newElement)
        {
            Array.Resize(ref _stackArray, _stackArray.Length + 1);
            for (int i = _stackArray.Length - 1; i > 0; i--)
            {
                _stackArray[i] = _stackArray[i - 1];
            }
            _stackArray[0] = newElement;
        }


        public T Pop()
        {
            T popedElement = _stackArray[0];
            for (int i = 1; i < _stackArray.Length; i++)
            {
                _stackArray[i - 1] = _stackArray[i];
            }
            Array.Resize(ref _stackArray, _stackArray.Length - 1);
            return popedElement;
        }


        public T Peek()
        {
            return _stackArray[0];
        }


        public T[] ToArray()
        {
            return _stackArray;
        }


        public void Clear()
        {
            Array.Clear(_stackArray, 0, _stackArray.Length);
            Array.Resize(ref _stackArray, 0);
        }
    }
}