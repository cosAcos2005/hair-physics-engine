using UnityEngine;

public class CubePhysicsMover : MonoBehaviour
{
    [SerializeField] private float forceAmount =10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 force = new Vector3(h,0f,v) * forceAmount;
        rb.AddForce(force); 

    }
}
