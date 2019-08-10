﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selecionar : MonoBehaviour
{
    public GameObject Icon;
    public GameObject Voltar;
    public string Funcao;
    public GameObject popup;

    public static bool Bylogah = false;
    public static bool Ju = false;
    public static bool Furry = false;
    public static bool Ilhas = false;

    void OnMouseOver()
    {
        if(!TransitionCamera.locked)
            Icon.SetActive(true);
        if (Input.GetMouseButtonDown(0))
        {
            popup.SetActive(true);
            if (Funcao == "ClickBylougah")
            {
                ClickBylougah();
                print("Bylougah");
            }
            if (Funcao == "ClickJubatan")
            {
                ClickJubatan();
                print("Jubathan");
            }
            if (Funcao == "ClickFurry")
            {
                ClickFurry();
                print("Furry");
            }
            if (Funcao == "ClickIlhas")
            {
                ClickIlhas();
                print("Ilhas");
            }
        }
    }

    void OnMouseExit()
    {
        Icon.SetActive(false);
    }

    public void ClickJubatan()
    {
        Ju = true;
        Voltar.SetActive(true);
    }
    public void ClickBylougah()
    {
        Bylogah = true;
        Voltar.SetActive(true);
    }
    public void ClickFurry()
    {
        Furry = true;
        Voltar.SetActive(true);
    }

    public void ClickIlhas()
    {
        Ilhas = true;
        Voltar.SetActive(true);
    }

    public void ClickVoltar()
    {
        Voltar.SetActive(false);
        Bylogah = false;
        Ju = false;
        Furry = false;
        Ilhas = false;
    }
}
