using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    public abstract class LifeGameRules
    {
        public abstract bool DoesCellChange(bool alive, int neighbourCount);
    }

    public class LifeGameRulesCustom : LifeGameRules
    {
        public bool[] AliveChanges { get; private set; }
        public bool[] DeadChanges { get; private set; }

        public LifeGameRulesCustom(bool[] aliveChanges, bool[] deadChanges)
        {
            if (aliveChanges.Length != 9)
            {
                throw new ArgumentException($"Array lenght must be 9");
            }
            if (deadChanges.Length != 9)
            {
                throw new ArgumentException($"Array lenght must be 9. This array has {aliveChanges.Length} elements");
            }
            AliveChanges = aliveChanges;
            DeadChanges = deadChanges;
        }

        public void SetChangesArray(bool alive, bool[] changes)
        {
            if (changes.Length != 9)
            {
                throw new ArgumentException($"Array lenght must be 9");
            }
            if (alive)
            {
                AliveChanges = changes;
            }
            else
            {
                DeadChanges = changes;
            }
        }

        public override bool DoesCellChange(bool alive, int neighbourCount)
        {
            return alive ? AliveChanges[neighbourCount] : DeadChanges[neighbourCount];
        }
    }

    public static class LifeGameRulesPresets
    {
        public static LifeGameRulesCustom Default => new(
            new bool[]
            {
                true, true, false, false, true, true, true, true, true
            },
            new bool[]
            {
                false, false, false, true, false, false, false, false, false
            }
        );

        public static LifeGameRulesCustom DayAndNight => new(
            new bool[]
            {
                true, true, true, false, false, true, false, false, false
            },
            new bool[]
            {
                false, false, false, true, false, false, true, true, true
            }
        );

        public static LifeGameRulesCustom HighLife => new(
            new bool[]
            {
                true, true, false, false, true, true, true, true, true
            },
            new bool[]
            {
                false, false, false, true, false, false, true, false, false
            }
        );

        public static LifeGameRulesCustom LifeWithoutDeath => new(
            new bool[]
            {
                false, false, false, false, false, false, false, false, false
            },
            new bool[]
            {
                false, false, false, true, false, false, false, false, false
            }
        );

        public static LifeGameRulesCustom Seeds => new(
            new bool[]
            {
                true, true, true, true, true, true, true, true, true
            },
            new bool[]
            {
                false, false, true, false, false, false, false, false, false
            }
        );
    }
}
