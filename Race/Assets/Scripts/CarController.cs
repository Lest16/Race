using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class CarController : MonoBehaviour
    {
        public float MaxPos = 1.292401f;
        private Vector3 position;

        void Start ()
        {
            transform.position = new Vector3(0, -1.8f, 0);
            position = transform.position;
	    
        }

        void Update ()
        {
	    
            position.x += Input.GetAxis("Horizontal") * Time.deltaTime * 10;
            position.x = Mathf.Clamp(position.x, -MaxPos, MaxPos);
            transform.position = position;
        }

        void OnCollisionEnter2D(Collision2D col)
        {
            if (col.gameObject.tag == "Enemy")
            {
                Destroy(gameObject);
                SceneManager.LoadScene(0);
            }
        }
    }
}
