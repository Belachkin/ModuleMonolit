using UnityEngine;

namespace Shooting
{
    internal class Bullet : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _lifetime;

        private float deathTimer = 0f;

        private void Update()
        {
            transform.Translate(_speed * Time.deltaTime * transform.forward);

            deathTimer += Time.deltaTime;

            if(deathTimer >= _lifetime)
            {
                Destroy(gameObject);
            }

        }
    }
 }
