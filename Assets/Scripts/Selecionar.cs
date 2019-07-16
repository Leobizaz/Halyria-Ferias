using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selecionar : MonoBehaviour
{
    public GameObject Icon;



    void OnMouseOver()
    {
        Icon.SetActive(true);
    }

    void OnMouseExit()
    {
        Icon.SetActive(false);
    }
}
