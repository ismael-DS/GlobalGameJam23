using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGalhos : MonoBehaviour
{
    [SerializeField] GameObject galhos;

    // Start is called before the first frame update
    void Start()
    {
        galhos.SetActive(true);
    }

}
