using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LagartaBasic : MonoBehaviour
{
    public float activationDistance; // Distância para ativar o inimigo
    public float moveSpeed; // Velocidade de movimento do inimigo
    public float directionChangeTime = 2f; // Tempo para mudar de direção do inimigo

    private Animator animator; // Referência para o componente Animator
    private bool activated = false; // Indica se o inimigo está ativo
    private float direction = 1f; // Direção do inimigo
    private float directionChangeTimer = 0f; // Temporizador para mudança de direção

    private void Start()
    {
        animator = GetComponent<Animator>(); // Obtém a referência para o componente Animator
    }

    private void Update()
    {
        // Verificar a distância até o personagem
        float distanceToPlayer = Vector2.Distance(transform.position, Player.Instance.transform.position);
        if (!activated && distanceToPlayer <= activationDistance)
        {
            // Ativar inimigo
            activated = true;
            animator.SetBool("Activated", true);
        }

        if (activated)
        {
            // Atualizar o temporizador de mudança de direção
            directionChangeTimer -= Time.deltaTime;
            if (directionChangeTimer <= 0f)
            {
                direction *= -1f;
                directionChangeTimer = directionChangeTime;
            }

            // Mover o inimigo
            Vector2 position = transform.position;
            position.x += direction * moveSpeed * Time.deltaTime;
            transform.position = position;

            // Verificar colisões
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right * direction, moveSpeed * Time.deltaTime, LayerMask.GetMask("Ground"));
            if (hit.collider != null || position.x < 0 || position.x > Screen.width)
            {
                // Inverter a direção
                direction *= -1f;
                directionChangeTimer = directionChangeTime;
            }
        }
    }
}
