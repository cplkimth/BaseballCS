﻿namespace StarCraft.Units
{
    abstract class Unit
    {
        public int X { get; set; } // auto property

        private int _y;

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Unit()
        {
            HP = 50;
        }

        public int HP {get; protected set;}

        public virtual void TakeDamage(int damage)
        {
            while (damage > 0 && HP > 0)
            {
                damage--;
                HP--;
            }
        }

        public override string ToString()
        {
            return $"I am a {UnitName} and my HP is {HP}";
        }

        protected abstract string UnitName
        {
            get;
        }
    }
}
