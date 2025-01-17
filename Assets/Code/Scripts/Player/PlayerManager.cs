using UnityEngine;

namespace XaviGames.Player
{
    public class PlayerManager : MonoBehaviour
    {
        [field: SerializeField]
        public PlayerMovement PlayerMovement {  get; private set; }
    }
}
