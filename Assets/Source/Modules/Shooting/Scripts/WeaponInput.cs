using UnityEngine;

namespace Shooting
{
    public class WeaponInput : MonoBehaviour
    {

        //private readonly string Fire = "Fire";

        [SerializeField] private Weapon _weapon;

        private bool active = false;

        private void Update()
        {
            if (!active)
                return;

            if (Input.GetMouseButtonDown(0))
            {
                _weapon.Shoot();
            }
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
