using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] float playerLife;
    [SerializeField] float maxLife = 10f;
    [SerializeField] GameObject popupText;
    [SerializeField] Material hitMaterial;
    [SerializeField] Material defaultMaterial;
    [SerializeField] float dmgImpulse;
    [SerializeField] Player p;
    [SerializeField] Animator anim;
    [SerializeField] int damageTaked;
    [SerializeField] Animator headReset;
    [SerializeField] GameObject body;
    [SerializeField] GameObject head;
    [SerializeField] GameObject color;
    [SerializeField] Vector3 player_pos;
    [SerializeField] RuntimeAnimatorController newController1, newController2, newController3, newController4, 
    newControllerHead, newControllerHead2, newControllerHead3, newControllerHead4;

    public AudioSource audioSource;
    public AudioClip hurtSound;


    // Start is called before the first frame update
    void Start()
    {
        
        defaultMaterial = body.GetComponent<SpriteRenderer>().material;
        anim = body.GetComponent<Animator>();
        headReset = head.GetComponent<Animator>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {



        player_pos = new Vector3(GameObject.FindGameObjectWithTag("Player").transform.position.x, GameObject.FindGameObjectWithTag("Player").transform.position.y, GameObject.FindGameObjectWithTag("Player").transform.position.z);


        damageTaked = (int)(playerLife - maxLife);

        popupText.GetComponent<TMP_Text>().text = damageTaked.ToString();

        if(playerLife <= 7.5f && playerLife > 5f){
             anim.runtimeAnimatorController = newController1;
             headReset.runtimeAnimatorController = newControllerHead;
        }
        else if(playerLife <= 5f && playerLife > 2.5f){
            anim.runtimeAnimatorController = newController2;
            headReset.runtimeAnimatorController = newControllerHead2;
        }
        else if(playerLife <= 2.5f && playerLife > 0){
            anim.runtimeAnimatorController = newController3;
            headReset.runtimeAnimatorController = newControllerHead3;
        }
        else if(playerLife <= 0){
            playerLife = 0;
            anim.runtimeAnimatorController = newController4;
            headReset.runtimeAnimatorController = newControllerHead4;
            StartCoroutine(DelayLoadScene("Game Over"));
        }
        IEnumerator DelayLoadScene(string sceneName)
        {   
            yield return new WaitForSeconds(5f);
            SceneManager.LoadScene(sceneName);
        }
    }

    public void takeDamage(float damage){
        playerLife -= damage;
        Instantiate(popupText, player_pos, Quaternion.identity, transform);
        p.setKnockback(dmgImpulse);
        StartCoroutine("Invunerability");
        audioSource.PlayOneShot(hurtSound);
    }
    IEnumerator Invunerability(){
        Physics2D.IgnoreLayerCollision(6, 7, true);
        body.GetComponent<SpriteRenderer>().material = hitMaterial;
        head.GetComponent<SpriteRenderer>().material = hitMaterial;
        color.GetComponent<SpriteRenderer>().material = hitMaterial;
        yield return new WaitForSeconds(.3f);
        body.GetComponent<SpriteRenderer>().material = defaultMaterial;
        head.GetComponent<SpriteRenderer>().material = defaultMaterial;
        color.GetComponent<SpriteRenderer>().material = defaultMaterial;
        head.GetComponent<SpriteRenderer>().enabled = !head.GetComponent<SpriteRenderer>().enabled;
        body.GetComponent<SpriteRenderer>().enabled = !body.GetComponent<SpriteRenderer>().enabled;
        body.GetComponent<SpriteMask>().enabled = !body.GetComponent<SpriteMask>().enabled;
        yield return new WaitForSeconds(.3f);
        head.GetComponent<SpriteRenderer>().enabled = !head.GetComponent<SpriteRenderer>().enabled;
        body.GetComponent<SpriteRenderer>().enabled = !body.GetComponent<SpriteRenderer>().enabled;
        body.GetComponent<SpriteMask>().enabled = !body.GetComponent<SpriteMask>().enabled;
        yield return new WaitForSeconds(.3f);
        head.GetComponent<SpriteRenderer>().enabled = !head.GetComponent<SpriteRenderer>().enabled;
        body.GetComponent<SpriteRenderer>().enabled = !body.GetComponent<SpriteRenderer>().enabled;
        body.GetComponent<SpriteMask>().enabled = !body.GetComponent<SpriteMask>().enabled;
        yield return new WaitForSeconds(.3f);
        head.GetComponent<SpriteRenderer>().enabled = !head.GetComponent<SpriteRenderer>().enabled;
        body.GetComponent<SpriteRenderer>().enabled = !body.GetComponent<SpriteRenderer>().enabled;
        body.GetComponent<SpriteMask>().enabled = !body.GetComponent<SpriteMask>().enabled;
        yield return new WaitForSeconds(.3f);
        head.GetComponent<SpriteRenderer>().enabled = !head.GetComponent<SpriteRenderer>().enabled;
        body.GetComponent<SpriteRenderer>().enabled = !body.GetComponent<SpriteRenderer>().enabled;
        body.GetComponent<SpriteMask>().enabled = !body.GetComponent<SpriteMask>().enabled;
        yield return new WaitForSeconds(.3f);
        head.GetComponent<SpriteRenderer>().enabled = !head.GetComponent<SpriteRenderer>().enabled;
        body.GetComponent<SpriteRenderer>().enabled = !body.GetComponent<SpriteRenderer>().enabled;
        body.GetComponent<SpriteMask>().enabled = !body.GetComponent<SpriteMask>().enabled;
        yield return new WaitForSeconds(.3f);
        head.GetComponent<SpriteRenderer>().enabled = !head.GetComponent<SpriteRenderer>().enabled;
        body.GetComponent<SpriteRenderer>().enabled = !body.GetComponent<SpriteRenderer>().enabled;
        body.GetComponent<SpriteMask>().enabled = !body.GetComponent<SpriteMask>().enabled;
        yield return new WaitForSeconds(.3f);
        head.GetComponent<SpriteRenderer>().enabled = !head.GetComponent<SpriteRenderer>().enabled;
        body.GetComponent<SpriteRenderer>().enabled = !body.GetComponent<SpriteRenderer>().enabled;
        body.GetComponent<SpriteMask>().enabled = !body.GetComponent<SpriteMask>().enabled;
        yield return new WaitForSeconds(.3f);
        head.GetComponent<SpriteRenderer>().enabled = !head.GetComponent<SpriteRenderer>().enabled;
        body.GetComponent<SpriteRenderer>().enabled = !body.GetComponent<SpriteRenderer>().enabled;
        body.GetComponent<SpriteMask>().enabled = !body.GetComponent<SpriteMask>().enabled;
        yield return new WaitForSeconds(.3f);
        head.GetComponent<SpriteRenderer>().enabled = !head.GetComponent<SpriteRenderer>().enabled;
        body.GetComponent<SpriteRenderer>().enabled = !body.GetComponent<SpriteRenderer>().enabled;
        body.GetComponent<SpriteMask>().enabled = !body.GetComponent<SpriteMask>().enabled;
        yield return new WaitForSeconds(.3f);
        head.GetComponent<SpriteRenderer>().enabled = !head.GetComponent<SpriteRenderer>().enabled;
        body.GetComponent<SpriteRenderer>().enabled = !body.GetComponent<SpriteRenderer>().enabled;
        body.GetComponent<SpriteMask>().enabled = !body.GetComponent<SpriteMask>().enabled;
        yield return new WaitForSeconds(.3f);
        head.GetComponent<SpriteRenderer>().enabled = !head.GetComponent<SpriteRenderer>().enabled;
        body.GetComponent<SpriteRenderer>().enabled = !body.GetComponent<SpriteRenderer>().enabled;
        body.GetComponent<SpriteMask>().enabled = !body.GetComponent<SpriteMask>().enabled;
        yield return new WaitForSeconds(.3f);
        Physics2D.IgnoreLayerCollision(6, 7, false);
    }
}
