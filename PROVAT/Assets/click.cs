using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject testo;
    TextMesh textMesh;
    InputManager inputManager;
    TextMesh  testoDaCambiare;
    void Start()
    {
        testo = GameObject.Find("Bool1");
        testoDaCambiare = testo.GetComponent<TextMesh>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnInputClicked(InputClickedEventData eventData)
    {
        UpdateText();
    }
    public void UpdateText()
    {
        
        testoDaCambiare.text= "Success";

        Debug.Log("Success");
    }
}
