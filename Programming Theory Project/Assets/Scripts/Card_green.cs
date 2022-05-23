using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card_green : Card
{
    public ParticleSystem heal;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerCamera = GameObject.Find("Main Camera").GetComponent<MovePosition>();
        playerHealth = GameObject.Find("/Canvas/HealthBar").GetComponent<Slider>();
        heal.Stop();
        HideCard();//ABSTRACTION
    }

    public override void applyAttribute(){  //POLYMORPHISM
        heal.Play();
        playerHealth.value=playerHealth.value+1;
    }

}
