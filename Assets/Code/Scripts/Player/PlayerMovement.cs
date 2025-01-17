using UnityEngine;
using UnityEngine.InputSystem;
using XaviEssencials;

namespace XaviGames.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [Header("Script Settings")]
        [SerializeField]
        private PlayerManager _playerManager;

        [SerializeField]
        private float _movementSpeed = 0.3f;

        [field: Header("Debug")]
        [field: SerializeField]
        [field: ReadOnly]
        public Vector2 MovementInput { get; private set; }

        [SerializeField]
        [ReadOnly]
        private GameObject _objectToMove;

        private void Start()
        {
            _objectToMove = _playerManager.gameObject; 
        }

        private void FixedUpdate()
        {
            Vector3 currentPosition = _objectToMove.transform.position;
            Vector3 newPosition = Vector3.zero;
            newPosition.z = currentPosition.z + MovementInput.x * _movementSpeed;
            _objectToMove.transform.position = newPosition;
        }

        public void OnMovementInput(InputAction.CallbackContext context)
        {
            MovementInput = context.ReadValue<Vector2>();
        }
    }
}
