using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TransitionCamera : MonoBehaviour
{
    public Transform[] views;
    public float transitionSpeed;
    Vector3 currentViewPos;
    Vector3 currentViewRot;

    public static bool locked;

    // Use this for initialization
    void Start()
    {


    }

    void FixedUpdate()
    {

        if (Selecionar.Bylogah == false && Selecionar.Ju == false && Selecionar.Furry == false)
        {
            currentViewPos = views[0].transform.position;
            currentViewRot = (views[0].transform.rotation).eulerAngles;
        }

        if (Selecionar.Bylogah == true && Selecionar.Ju == false && Selecionar.Furry == false)
        {
            transitionSpeed = 1;
            currentViewPos = views[1].transform.position;
            currentViewRot = (views[1].transform.rotation).eulerAngles;
            locked = true;
        }

        if (Selecionar.Bylogah == false && Selecionar.Ju == true && Selecionar.Furry == false)
        {
            transitionSpeed = 1;
            currentViewPos = views[2].transform.position;
            currentViewRot = (views[2].transform.rotation).eulerAngles;
            locked = true;
        }

        if (Selecionar.Bylogah == false && Selecionar.Ju == false && Selecionar.Furry == true)
        {
            transitionSpeed = 1;
            currentViewPos = views[3].transform.position;
            currentViewRot = (views[3].transform.rotation).eulerAngles;
            locked = true;
        }


    }


    void LateUpdate()
    {

        //Lerp position
        //transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * transitionSpeed);
        transform.DOMove(currentViewPos, transitionSpeed);
        transform.DORotate(currentViewRot, transitionSpeed, RotateMode.Fast);
         //Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentView.transform.rotation.eulerAngles.x, Time.deltaTime * transitionSpeed),
         //Mathf.LerpAngle(transform.rotation.eulerAngles.y, currentView.transform.rotation.eulerAngles.y, Time.deltaTime * transitionSpeed),
         //Mathf.LerpAngle(transform.rotation.eulerAngles.z, currentView.transform.rotation.eulerAngles.z, Time.deltaTime * transitionSpeed));

        if (!Selecionar.Ju || !Selecionar.Bylogah || !Selecionar.Furry)
        {
            if (!IsInvoking("Disable"))
            {
                Invoke("Disable", 1f);
            }
        }
    }

    void Disable()
    {
        transitionSpeed = 0.3f;
        locked = false;
    }
}
