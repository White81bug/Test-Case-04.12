using UnityEngine;
using Random = UnityEngine.Random;

public class Fireball : MonoBehaviour
{

    private Rigidbody _rb;
    private float _speed;
    private Score _score;
    [SerializeField] private float minSpeed;
    [SerializeField] private float maxSpeed;
    [SerializeField] private int scorePenalty;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _speed = Random.Range(minSpeed, maxSpeed);
        _score = GameObject.FindWithTag("ScoreManager").GetComponent<Score>();
    }

    void FixedUpdate()
    {
        _rb.AddForce(transform.forward * _speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("HIT");
            _score.AddScore(-scorePenalty);
        }
            
        Destroy(gameObject);
    }
}
