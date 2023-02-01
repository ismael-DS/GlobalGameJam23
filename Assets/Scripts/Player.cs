using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Inicializando variáveis que serão usadas
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed, jumpForce;
    [SerializeField] float horizontalInput;
    [SerializeField] bool isGround;
    [SerializeField] GameObject head,body,player;
    [SerializeField] Animator headAnimator, bodyAnimator;
    [SerializeField] PlayerStats p1;



    void Start()
    {
       // Pegando Rigidbody e Animators
       rb = GetComponent<Rigidbody2D>();
       headAnimator = head.GetComponent<Animator>();
       bodyAnimator = body.GetComponent<Animator>();
       p1 = player.GetComponent<PlayerStats>();
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
        // Se o Input for positivo, eu dou flip no sprite e na Mask para o lado direito.
        }else if(horizontalInput > 0){
            body.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            head.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

        // Aplicando velocidade ao Rigidbody a partir do input.
        rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);

        
        // Chegando se o player esta tocando o chão e então poderá pular apertando W
        if(isGround && Input.GetKey(KeyCode.W)){
            Jump();
        }
        

        


    }

    // Função que aplica velocidade ao eixo Y do Rigidbody, fazendo o player pular.
    void Jump(){
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    // Função para testar se o player está colidindo com algum objeto.
    void OnCollisionEnter2D(Collision2D coll){
        if(coll.gameObject.tag == "ground"){
            isGround = true;
    }
        if(coll.gameObject.tag == "enemy"){
            p1.takeDamage(1);

        }
}
    // Função para testar se o player saiu da colisão com esse objeto.
    void OnCollisionExit2D(Collision2D coll){
        if(coll.gameObject.tag == "ground"){
            isGround = false;
        }
    }
}
