using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class MainBall : MonoBehaviour
{
    [SerializeField] private float force;
    
    private Rigidbody rb;
    private Transform _transform;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        _transform = transform;
    }
    
    public void Hit()
    {
        rb.AddForce(_transform.forward * force, ForceMode.Impulse);
    }
}
