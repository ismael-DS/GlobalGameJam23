using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ant : MonoBehaviour
{
    public float speed = 2f; // Velocidade do inimigo
    private bool facingRight = true; // Direção atual do inimigo
    private SpriteRenderer antSprite;
    [SerializeField] float dmgKnockback;
    [SerializeField] float dmgImpulse;
    [SerializeField] GameObject popupText;
    [SerializeField] Vector3 ant_pos;
    [SerializeField] Material defaultMaterial;
    [SerializeField] Material hitMaterial;
    
    public float life = 5; //vida do inimigo

    private Rigidbody2D rb; // Referencia ao componente Rigidbody2D do inimigo

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        antSprite = GetComponent<SpriteRenderer>();
        defaultMaterial = gameObject.GetComponent<SpriteRenderer>().material;
    }

    private void Update()
    {
        ant_pos = gameObject.transform.position;
        // Movimenta o inimigo na direção atual
        rb.velocity = new Vector2(speed * (facingRight ? 1 : -1), rb.velocity.y);

        if(dmgKnockback != 0){
            rb.velocity = new Vector2(dmgKnockback, rb.velocity.y);
            dmgKnockback = 0;
        }

        if(facingRight){
            antSprite.flipX = true;
        }else{
            antSprite.flipX = false;
        }

        if(life <= 0){
            Destroy(gameObject, 1f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Muda a direção do inimigo quando ele colide com algo
        facingRight = !facingRight;
    }

    public void takeDamage(float dmg){
        life -= dmg;
        popupText.GetComponent<TMP_Text>().text = dmg.ToString();
        setKnockback(dmgImpulse);
        Instantiate(popupText, ant_pos, Quaternion.identity, transform);
        StartCoroutine("dmgHit");

        
    }

    void setKnockback(float dmgImpulse){
        if(gameObject.GetComponent<SpriteRenderer>().flipX == false){
            dmgKnockback = dmgImpulse;
        }
        else if(gameObject.GetComponent<SpriteRenderer>().flipX == true){
            dmgKnockback = -dmgImpulse;
        }
    }

    IEnumerator dmgHit(){
        gameObject.GetComponent<SpriteRenderer>().material = hitMaterial;
        yield return new WaitForSeconds(.3f);
        gameObject.GetComponent<SpriteRenderer>().material = defaultMaterial;

    }

}
