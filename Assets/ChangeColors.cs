using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColors : MonoBehaviour
{
    // Start is called before the first frame update
   public void getBlack(){
       this.GetComponent<Renderer>().material.color = Color.black;
   }
   public void getBlue(){
       this.GetComponent<Renderer>().material.color = Color.blue;
   }
   public void getGreen(){
       this.GetComponent<Renderer>().material.color = Color.green;
   }
}
