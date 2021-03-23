using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpWiindowScript : MonoBehaviour
{
    //Show Help Window
    public void Show(Animator a)
    {
        a.SetBool("visible", true);
    }

    //Hide Help Window
    public void Hide(Animator a)
    {
        a.SetBool("visible", false);
    }
        
}
