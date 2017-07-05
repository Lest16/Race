using UnityEngine;

namespace Assets.Scripts
{
    public class MoveRoad : MonoBehaviour
    {
        public float Speed = 0.9f;

        private Vector3 startPosition;

        public void Start () {
            startPosition = transform.position;
        }

        public void Update () {
            Debug.Log(transform.position.y);
            var newPosition = Mathf.Repeat(Time.time * Speed, 7.17f);
            transform.position = startPosition + Vector3.up * newPosition;
        }
    }
}
