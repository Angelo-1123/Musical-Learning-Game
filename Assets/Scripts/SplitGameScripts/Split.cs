using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Split : MonoBehaviour
{
    public MeshRenderer mR;
    public Material hoverMaterial;
    public Material clickMaterial;
    bool permanent = false;
    public bool isCorrect = false;

    void OnMouseEnter()
    {
        mR.enabled = true;
        mR.material = hoverMaterial;
    }
    
    void OnMouseDown()
    {
        if(!permanent)
        {
            GameManager.instance.MarkSplit(1, isCorrect);
            permanent = true;
            mR.material = clickMaterial;
        }
        else
        {
            GameManager.instance.MarkSplit(-1, isCorrect);
            permanent = false;
            mR.material = hoverMaterial;
        }
    }

    void OnMouseExit()
    {
        if(!permanent)
        {
            mR.enabled = false;
        }
        else
        {
            mR.material = clickMaterial;
        }
        
    }
}
