using System;

namespace DefaultNamespace {
    [UnityEngine.CreateAssetMenu(fileName = "Fish", menuName = "Submawinee:3/Fish")]
    public class Fishes : UnityEngine.ScriptableObject {
        public float health;
        public float speed;
    }

    [Serializable]
    public struct FishesD {
        public float health;
        public float speed;
    }
}