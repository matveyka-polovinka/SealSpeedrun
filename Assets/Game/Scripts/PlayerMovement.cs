using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float move_force = 1f, rotate_force = 5f;
    private Rigidbody rb;
    private float horizontal = 0f, vertical = 0f;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        rb.AddForce(transform.forward * vertical * move_force, ForceMode.Impulse);
        rb.MoveRotation(rb.rotation * Quaternion.Euler(horizontal * rotate_force * Time.fixedDeltaTime * Vector3.up));
    }
}