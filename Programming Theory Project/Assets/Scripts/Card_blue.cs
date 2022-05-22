using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card_blue : Card
{
    static Vector3 spawnPosition = new Vector3(0f,0f,-6.51f);
    private GameObject[] allCards;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerCamera = GameObject.Find("Main Camera").GetComponent<MovePosition>();
        playerHealth = GameObject.Find("/Canvas/HealthBar").GetComponent<Slider>();
        HideCard();//ABSTRACTION
    }


    public override void applyAttribute(){  //POLYMORPHISM
        playerCamera.NewPosition(spawnPosition);
        deletCards();
    }

    public void deletCards(){
        allCards = GameObject.FindGameObjectsWithTag("Card");
        foreach (GameObject item in allCards)
        {
            Destroy(item);
        }
        gameManager.NextSteps(spawnPosition.x,spawnPosition.z);
    }
    
}
