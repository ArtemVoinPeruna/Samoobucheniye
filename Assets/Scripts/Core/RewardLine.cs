using UnityEngine;

namespace Core.Rewards
{
    public class RewardLine : MonoBehaviour
    {
        private int _coin = 0;

        public int Coins
        {
            get { return _coin; }
            private set { _coin = value; }
        }

        public void Start()
        {
            InvokeRepeating(nameof(AddCoins), 1f, 1f);
        }

        public void AddCoins()
        {
            Coins++;
        }

        public void CollectionsCoin()
        {
            Coins = 0;
        }

        public void KnopkaSbora()
        {
            CollectionsCoin();
        }
    }

}
