using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    //private Material mat= new Material (Shader.Find("Standard"));
    //private int index;
    public Material[] typesBlocks;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //CHOOSE A CARD
    // public Material takeCard(){
    //     index= Random.Range(0,typesBlocks.Length-1);
    //     return typesBlocks[index];
    // }

    // move the block under player
    public void moveToPlayer(){ //ABSTRACTION
        this.transform.position = new Vector3(0,0,0);
    }

    //Block turns transparent
    public Material Disappear(Material mat){  //ABSTRACTION
        mat.color= new Color(255,255,255,0);
        return mat;
    }


}
