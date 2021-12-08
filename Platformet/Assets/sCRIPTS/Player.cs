using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]private float jumpforce = 1f;
    private BoxCollider2D colider;
    private Rigidbody2D _body;
    [SerializeField]private float movementSpeed = 3f;
    private Transform _transform;
    
    public LayerMask WorldTiles;
    
    private void Update()
    {
        float movement = Input.GetAxisRaw("Horizontal");
        _transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * movementSpeed;
        
        
        if (Input.GetButton("Jump") && IsGrounded() && _body.velocity.y < 0.01f )
        {
            _body.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
            
        }

        if (transform.position.y < -5f)
        {
            _transform.position = new Vector3(transform.position.x, -4f);
            _body.velocity = Vector2.zero;
        }


    }
    
    
    private void Awake()
    {
        _transform = transform;
        _body = GetComponent<Rigidbody2D>();
        colider = GetComponent<BoxCollider2D>();
    }

    bool IsGrounded()
    {
        float extraHeight = 0.1f;
        RaycastHit2D raycastHit = Physics2D.BoxCast(colider.bounds.center, colider.bounds.size, 0f,
            Vector2.down, extraHeight, WorldTiles);
        
        return (raycastHit.collider != null);

    }
    
}
