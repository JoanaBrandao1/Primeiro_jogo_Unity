using UnityEngine;
public class MovimentoDoPlayer : MonoBehaviour
{
    /* velocidade */
    public float speed;

    private Rigidbody2D rb;

    private Vector2 moveVelocity;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVelocity = moveInput.normalized * speed;
    }
    void FixedUpdate(){
        rb.MovePosition(rb. position + moveVelocity * Time.fixedDeltaTime);
    }
}
