using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card_red : Card
{
    public ParticleSystem explosion;
    private AudioSource soundExplotion;

    // Start is called before the first frame update
    void Start()
    {
        soundExplotion= GetComponent<AudioSource>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerCamera = GameObject.Find("Main Camera").GetComponent<MovePosition>();
        playerHealth = GameObject.Find("/Canvas/HealthBar").GetComponent<Slider>();
        explosion.Stop();
        HideCard();//ABSTRACTION

    }
    
    public override void applyAttribute(){  //POLYMORPHISM
        soundExplotion.Play();
        explosion.Play();
        playerHealth.value=playerHealth.value-1;
    }

}
