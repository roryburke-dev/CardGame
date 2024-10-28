using Enums;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(menuName = "ScriptableObjects/UnitCard")]
    public class SOUnitCard : ScriptableObject
    {
        public string cardName;
        public EClass cardClass;
        public EJob cardJob;
        public EKeyword[] keywords;
        public EAbility[] abilities;
        public int health, physicalPower, magicPower, speed;
    }
}
