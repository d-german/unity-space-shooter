using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed = 4f;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.down * (_speed * Time.deltaTime));
        if (transform.position.y < -5f)
        {
            transform.position = new Vector3(Random.Range(-8f, 8f), 7, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var gameObj = GameObject.Find("Player");
            var player = gameObj.GetComponent<Player>();
            if (player != null) player.Damage();           

            Destroy(gameObject);
        }

        if (other.CompareTag("Laser"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
