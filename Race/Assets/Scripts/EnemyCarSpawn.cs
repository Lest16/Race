using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class EnemyCarSpawn : MonoBehaviour
    {
        private const float MaxPos = 1.292401f;

        public GameObject EnemyCar;

        public float delayTimer = 0.6f;

        private float timer;
        // Use this for initialization
        void Start ()
        {
            timer = delayTimer;
        }
	
        // Update is called once per frame
        void Update ()
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                var carPos = new Vector3(Random.Range(-MaxPos, MaxPos), transform.position.y, transform.position.z);
                Instantiate(EnemyCar, carPos, transform.rotation);
                timer = delayTimer;
            }

            
        }

    }
}
