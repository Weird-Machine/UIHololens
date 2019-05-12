using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pannello : MonoBehaviour
{
    bool AriaCheked = false;
    bool CentralinaCheked = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckAria()
    {
        if (CentralinaCheked)
        {
            AriaCheked = true;
            Debug.Log("Pannello: Aria");
            this.GetComponent<Renderer>().material.color = Color.green;
        }
    }

    public void CheckCentralina()
    {
        if (!CentralinaCheked)
        {
            CentralinaCheked = true;
            Debug.Log("Pannello: Centralina");
            this.GetComponent<Renderer>().material.color = Color.yellow;
        }
    }
}
