using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimator : MonoBehaviour
{
    
    public void getAnimatorPatting()
    {
        this.GetComponent<Animator>().Play("Patting");
    }

    public void getAnimatorWalking()
    {
        this.GetComponent<Animator>().Play("Walking");
    }

    public void getAnimatorSlow_Run()
    {
        this.GetComponent<Animator>().Play("Slow Run");
    }
}
