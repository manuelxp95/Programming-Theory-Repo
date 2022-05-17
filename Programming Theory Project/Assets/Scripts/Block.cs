using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    private Material mat= new Material (Shader.Find("Standard"));
    public Material[] values;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // move the block under player
    public void moveToPlayer(){ //ABSTRACTION
        this.transform.position = new Vector3(0,0,0);
    }

    //Block turns transparent
    public void Disappear(){  //ABSTRACTION
        this.mat.color= new Color(255,255,255,0);
    }


}
