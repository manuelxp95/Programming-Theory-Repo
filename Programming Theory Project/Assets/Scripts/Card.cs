using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : Block //INHERITANCE
{
 
    private Color color;
    //para block
    private GameManager gameManager;
    private MovePosition playerCamera;
    

    // Start is called before the first frame update
    void Start(){
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerCamera = GameObject.Find("Main Camera").GetComponent<MovePosition>();
        HideCard();//ABSTRACTION
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void HideCard(){
        color = this.GetComponent<MeshRenderer>().material.color;
        color.a=0;
        GetComponent<MeshRenderer>().material.color= color;
    }

    private void OnMouseDown(){
        if (gameManager.canSelect){
            color.a=1;
            GetComponent<MeshRenderer>().material.color= color;
            gameManager.canSelect=false;
            playerCamera.NewPosition(this.transform.position);
        }
    }
}
