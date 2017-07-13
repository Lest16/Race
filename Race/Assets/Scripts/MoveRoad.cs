using UnityEngine;

namespace Assets.Scripts
{
    public class MoveRoad : MonoBehaviour
    {
        public float Speed = 0.9f;

        private Vector2 offset;

        public void Start () {

        }

        public void Update () {
            offset = new Vector2(0, Time.time * Speed);
            GetComponent<Renderer>().material.mainTextureOffset = offset;
        }
    }
}
