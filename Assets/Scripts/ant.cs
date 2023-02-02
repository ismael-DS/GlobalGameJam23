using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ant : MonoBehaviour
{
    public float speed = 2f; // Velocidade do inimigo
    private bool facingRight = true; // Direção atual do inimigo
    private SpriteRenderer antSprite;
    
    public int life = 3; //vida do inimigo

    private Rigidbody2D rb; // Referencia ao componente Rigidbody2D do inimigo

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        antSprite = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        // Movimenta o inimigo na direção atual
        rb.velocity = new Vector2(speed * (facingRight ? 1 : -1), rb.velocity.y);

        if(facingRight){
            antSprite.flipX = true;
        }else{
            antSprite.flipX = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Muda a direção do inimigo quando ele colide com algo
        facingRight = !facingRight;
    }
}
