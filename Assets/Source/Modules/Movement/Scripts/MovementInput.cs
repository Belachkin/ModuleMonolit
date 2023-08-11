using UnityEngine;

namespace Movement
{
    public class MovementInput : MonoBehaviour
    {

        private readonly string Horizontal = "Horizontal";
        private readonly string Vertical = "Vertical";

        [SerializeField] private CharacterMovement _movement;

        private bool active;

        private void Update()
        {
            if (!active)
                return;
            Vector3 direction = new Vector3(Input.GetAxisRaw(Horizontal), 0f, Input.GetAxisRaw(Vertical));

            _movement.Move(direction);
        }

        public void Activate()
        {
            active = true;
        }

        public void Deactivate()
        {
            active = false;
        }

    }
}
