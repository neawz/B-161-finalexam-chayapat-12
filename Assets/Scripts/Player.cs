using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    public float MoveSpeed { get => moveSpeed; private set => moveSpeed = value; } //Property

    [SerializeField] private bool isInvulnerable = false;
    public bool IsInvulnerable { get => isInvulnerable; private set => isInvulnerable = value; } //Property

    private float jumpForce = 10f;

    private Rigidbody2D rb;
    private bool isInvulnerable1;
    private float moveSpeed1;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    public void SetMoveSpeed(float newSpeed)
    {
        MoveSpeed = newSpeed;
        Debug.Log("Speed Change to " +  newSpeed);
    }
    public void SetInvulnerability(bool isEnabled)
    {
        IsInvulnerable = isEnabled;
        Debug.Log("Is Invulnerable: " + isEnabled);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        PowerUpBase powerUpBase = other.GetComponent<PowerUpBase>(); //Check if collide with any of the PowerUpBase Code
        if (powerUpBase != null)
        {
            powerUpBase.ApplyEffect(this); //Call ApplyEffect from PowerUpBase
            Destroy(powerUpBase.gameObject); //Destroy powerup
        }
    }
}
