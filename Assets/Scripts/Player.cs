using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Inicializando variáveis que serão usadas
    [SerializeField] public Rigidbody2D rb;
    [SerializeField] float speed, jumpForce;
    [SerializeField] float horizontalInput;
    [SerializeField] public bool isGround;
    [SerializeField] float dmgKnockback;
    [SerializeField] GameObject head,body,player;
    [SerializeField] Animator headAnimator, bodyAnimator;
    [SerializeField] PlayerStats p1;
    [SerializeField] Transform attackPointRight, attackPointLeft;
    [SerializeField] bool isRight;
    [SerializeField] GameObject worm;

    public float attackRange = 2f; // :3 Distância máxima para atacar
    public float boomerangueRange = 5f; // :3 Distância máxima para atirar o boomerangue
    private Transform playerTransform; // :3 Referência ao Transform do player para calcular a distância entre ele e o inimigo

    void Start()
    {
       // Pegando Rigidbody e Animators
       rb = GetComponent<Rigidbody2D>();
       headAnimator = head.GetComponent<Animator>();
       bodyAnimator = body.GetComponent<Animator>();
       p1 = player.GetComponent<PlayerStats>();
       

       playerTransform = GetComponent<Transform>(); // :3 Inicializa a referência ao Transform do player
    }


    void FixedUpdate()
    {
        
        // Capturando input horizontal do jogador.
        horizontalInput = Input.GetAxis("Horizontal");


        // Se o Input for diferente de Zero, então mudo a animação para andar.
        if(horizontalInput != 0f){
            headAnimator.SetBool("isWalking", true);
            headAnimator.SetBool("isIdle", false);
            bodyAnimator.SetBool("isWalking", true);
            bodyAnimator.SetBool("isIdle", false);
        // Se não for, eu mudo para Idle.
        }else{
            headAnimator.SetBool("isWalking", false);
            headAnimator.SetBool("isIdle", true);
            bodyAnimator.SetBool("isWalking", false);
            bodyAnimator.SetBool("isIdle", true);
        }

        // Se o Input for negativo, eu dou flip no sprite e na Mask para o lado esquerdo.
        if(horizontalInput < 0){
            head.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            body.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            worm.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            isRight = false;

            

        // Se o Input for positivo, eu dou flip no sprite e na Mask para o lado direito.
        }else if(horizontalInput > 0){
            body.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            head.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            worm.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            isRight = true;
        }

        // Aplicando velocidade ao Rigidbody a partir do input.
        rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);
        if(dmgKnockback != 0){
            rb.velocity = new Vector2(dmgKnockback, rb.velocity.y);
            dmgKnockback = 0;
        }
        
        
        // Checando se o player esta tocando o chão e então poderá pular apertando W
        if(isGround && Input.GetKey(KeyCode.W)){
            Jump();
            bodyAnimator.SetBool("isJumping", true);
            bodyAnimator.SetBool("isWalking", false);
            bodyAnimator.SetBool("isIdle", false);
        }
        

        if (Input.GetKey(KeyCode.J)) // :3 Se o jogador apertar J ataca
        {
            worm.SetActive(true);
            if(isRight){
                worm.transform.position = attackPointRight.transform.position;
            }else{
                worm.transform.position = attackPointLeft.transform.position;
            }
            
            worm.GetComponent<Animator>().SetBool("isAttack", true);
            worm.GetComponent<Animator>().SetBool("isOut", false);
            worm.GetComponent<BoxCollider2D>().enabled = true;
            worm.GetComponent<SpriteRenderer>().sortingOrder = 7;

        }


            

        // Setando condição padrão da minhoca

        

        // Programar ataque boomerang

        /*if (Input.GetKeyDown(KeyCode.K)) 
        {
            
        }*/

    }

    // Função que aplica velocidade ao eixo Y do Rigidbody, fazendo o player pular.
    void Jump(){
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    // Função para testar se o player está colidindo com algum objeto.
    void OnCollisionEnter2D(Collision2D coll){
        if(coll.gameObject.tag == "ground"){
            bodyAnimator.SetBool("isJumping", false);
            isGround = true;
            
    }
        if(coll.gameObject.tag == "ant"){ // :3 Se o player colidir com uma formiga, ele perde 1 de vida (Modificado para inimigos darem direfentes tipos de dano)
            p1.takeDamage(2);
        }
        if(coll.gameObject.tag == "lagarta"){ // :3 Se o player colidir com uma lagarta, ele perde 2 de vida (Modificado para inimigos darem direfentes tipos de dano)
            p1.takeDamage(3);
        }
        /*if(coll.gameObject.tag == "passaro"){ // :3 Se o player colidir com um passaro, ele perde 3 de vida (Modificado para inimigos darem direfentes tipos de dano)
            p1.takeDamage(3);
        }*/
}
    // Função para testar se o player saiu da colisão com esse objeto.
    void OnCollisionExit2D(Collision2D coll){
        if(coll.gameObject.tag == "ground"){
            isGround = false;
        }
    }

    public void setKnockback(float dmgImpulse){
        if(body.transform.rotation.y == 1f){
            dmgKnockback = dmgImpulse;
        }
        else if(body.transform.rotation.y == 0f){
            dmgKnockback = -dmgImpulse;
        }
    }




}
