using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    /*
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */
    public void PlayGame()
    {
        //Application.LoadLevel("Fase Inicial 1");
        UnityEngine.SceneManagement.SceneManager.LoadScene("Fase Inicial 1");
    } 
    public void QuitGame()
    {
        Application.Quit();
       

    }
   /* public void Sound()
    {
        Application.volume = 0;
    }
*/
    /*
    public void Language()
    {
        Application.language = "pt";
    }
    */
}