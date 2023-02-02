using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LagartaStalker : MonoBehaviour
{
   /* public float activationDistance; 
    public float moveSpeed; 
    public Animator animator; 

    private bool activated = false;

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
            // Mover o inimigo em direção ao jogador
            Vector2 direction = (Player.Instance.transform.position - transform.position).normalized;
            Vector2 position = transform.position;
            position += direction * moveSpeed * Time.deltaTime;
            transform.position = position;
        }
    }*/
}
