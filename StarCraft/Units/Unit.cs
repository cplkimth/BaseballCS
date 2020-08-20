using System;

namespace StarCraft.Units
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

        public int HP { get; protected set; }

        public virtual void TakeDamage(int damage)
        {
            while (damage > 0 && HP > 0)
            {
                damage--;
                HP--;

                if (HP == 0)
                {
                    OnDead(damage);
                    break;
                }
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

        #region Dead event things for C# 3.0
        public event EventHandler<DeadEventArgs> Dead;

        protected virtual void OnDead(DeadEventArgs e)
        {
            if (Dead != null)
                Dead(this, e);
        }

        private DeadEventArgs OnDead(int undamagedDamage)
        {
            DeadEventArgs args = new DeadEventArgs(undamagedDamage);
            OnDead(args);

            return args;
        }

        private DeadEventArgs OnDeadForOut()
        {
            DeadEventArgs args = new DeadEventArgs();
            OnDead(args);

            return args;
        }

        public class DeadEventArgs : System.EventArgs
        {
            public int UndamagedDamage { get; set; }

            public DeadEventArgs()
            {
            }

            public DeadEventArgs(int undamagedDamage)
            {
                UndamagedDamage = undamagedDamage;
            }
        }
        #endregion
    }
}
