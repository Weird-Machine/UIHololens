using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{

    private Color[] colors = new Color[] { Color.red, Color.cyan };
    private int i = 0;
    private Renderer rend;
    // public GameObject cube2;
    void Start()
    {

        rend = GetComponent<Renderer>();

    }

    public void OnInputClicked(InputClickedEventData eventData)
    {

        rend.material.color = colors[i];
        i = (i + 1) % colors.Length;
    }


}
