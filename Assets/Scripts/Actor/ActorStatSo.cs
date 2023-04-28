
using UnityEngine;

namespace Actor
{
    [CreateAssetMenu(fileName = "Actor Data", menuName = "Scriptable Object/Actor Data")]
    public class ActorStatSo : ScriptableObject
    {
        public int health;
        public int atkPower;
        public int speed;
    }
}


