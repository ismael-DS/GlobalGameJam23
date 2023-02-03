using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Assets.SimpleLocalization;

public class Dialogue : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textComponent;
    [SerializeField] string[] lines;
    [SerializeField] float textSpeed;
    [SerializeField] TextMeshProUGUI[] textLines;
    [SerializeField] int index;
    [SerializeField] float timeCount;

    void Awake(){
        LocalizationManager.Read();
        LocalizationManager.Language = "Portuguese";
        for(int i = 0; i < lines.Length; i++){
            lines[i] = textLines[i].text;
        }
    }
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if(textComponent.text == lines[index]){
            timeCount += Time.deltaTime;
            if(timeCount > 3f){
                NextLine();
                timeCount = 0;
            }

        }
    }

    void StartDialogue(){
        index = 0;
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine(){
        foreach(char c in lines[index].ToCharArray()){
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine(){
        if(index < lines.Length-1){
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }else{
            gameObject.SetActive(false);
        }
    }
}
