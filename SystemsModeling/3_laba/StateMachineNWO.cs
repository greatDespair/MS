using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_laba
{
    public class StateMachineNWO
    {
        private Dictionary<int, Dictionary<int, int>> _inputToStates 
            = new Dictionary<int, Dictionary<int, int>>()
        {
            {1, new Dictionary<int, int>()
            {
                {1, 2},
                {2, 3},
                {3, 4},
                {4, 5},
                {5, 6},
                {6, 1}
            } },
        
            {2, new Dictionary<int, int>()
            {
                {1, 3},
                {2, 4},
                {3, 5},
                {4, 6},
                {5, 1},
                {6, 2}
            } },
        
            {3, new Dictionary<int, int>()
            {
                {1, 3},
                {2, 4},
                {3, 5},
                {4, 6},
                {5, 1},
                {6, 2}
            } }
        };
        private int _prevState;
        public int _currentState { get; private set; }

        public StateMachineNWO()
        {
            _prevState = 0;
            _currentState = 1;
        }
        public bool Input(int x)
        {
            if (_inputToStates.ContainsKey(x))
            {
                if (_inputToStates[x].ContainsKey(_currentState))
                {
                    _prevState = _currentState;
                    _currentState = _inputToStates[x][_currentState];
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {
            if(_prevState != 0)
                return "Текущее состояние: Z" + _currentState + "\n" +
                    "Последнее изменение автомата: Z" + _prevState + " -> Z" + _currentState;
            else
                return "Текущее состояние: Z" + _currentState + "\n" +
                    "Последнее изменение автомата: н/д";
        }
    }
}
