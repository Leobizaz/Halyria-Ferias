using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionCamera : MonoBehaviour
{
    public Transform[] views;
    public float transitionSpeed;
    Transform currentView;

    // Use this for initialization
    void Start()
    {


    }

    void FixedUpdate()
    {

        if (Selecionar.Bylogah == false && Selecionar.Ju == false && Selecionar.Furry == false)
        {
            currentView = views[0];
        }

        if (Selecionar.Bylogah == true && Selecionar.Ju == false && Selecionar.Furry == false)
        {
            currentView = views[1];
        }

        if (Selecionar.Bylogah == false && Selecionar.Ju == true && Selecionar.Furry == false)
        {
            currentView = views[2];
        }

        if (Selecionar.Bylogah == false && Selecionar.Ju == false && Selecionar.Furry == true)
        {
            currentView = views[3];
        }


    }


    void LateUpdate()
    {

        //Lerp position
        transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * transitionSpeed);

        Vector3 currentAngle = new Vector3(
         Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentView.transform.rotation.eulerAngles.x, Time.deltaTime * transitionSpeed),
         Mathf.LerpAngle(transform.rotation.eulerAngles.y, currentView.transform.rotation.eulerAngles.y, Time.deltaTime * transitionSpeed),
         Mathf.LerpAngle(transform.rotation.eulerAngles.z, currentView.transform.rotation.eulerAngles.z, Time.deltaTime * transitionSpeed));

        transform.eulerAngles = currentAngle;
    }
}
