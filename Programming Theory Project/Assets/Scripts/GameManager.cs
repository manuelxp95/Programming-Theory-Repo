using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //this is ugly D:
    private Vector3[] posCards=new[]{
        new Vector3(0,0,19),
        new Vector3(-12,0,19),
        new Vector3(12,0,19)
    };
    // private Vector3 posCard1= new Vector3(0,0,12);
    // private Vector3 posCard2= new Vector3(-12,0,12);
    // private Vector3 posCard3= new Vector3(12,0,12);
    
    //para encapsular

    public GameObject CardPrefab;
    public bool canSelect= true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextSteps(float xPlayer,float zPlayer){
        Vector3 playerPosition= new Vector3(xPlayer,0,zPlayer);
        foreach (Vector3 item in posCards)
        {
            Instantiate(CardPrefab,item+playerPosition,CardPrefab.transform.rotation);
        }
        canSelect=true;
    }
}
