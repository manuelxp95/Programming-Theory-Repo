using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
    
 //INHERITANCE
{
 
    public Color color;
    //para block
    public GameManager gameManager;
    public MovePosition playerCamera;
    private int indexCard;
    public Material[] typesCards;
    public Slider playerHealth;
    

    public void HideCard(){
        color = this.GetComponent<MeshRenderer>().material.color;
        color.a=0;
        GetComponent<MeshRenderer>().material.color= color;
    }

    private void ChooseCard(){
        indexCard= Random.Range(0,typesCards.Length); // 0-->red 1-->blue 2-->green
        GetComponent<MeshRenderer>().material=typesCards[indexCard];
    }

    public void OnMouseDown(){
        if (gameManager.canSelect){
            color.a=1;
            GetComponent<MeshRenderer>().material.color= color;
            gameManager.overTop=this.GetComponent<Card>();
            playerCamera.NewPosition(this.transform.position);
            gameManager.canSelect=false;
        }
    }

    public virtual void applyAttribute(){ //POLYMORPHISM
        playerHealth.value=playerHealth.value-1;
    }
}
