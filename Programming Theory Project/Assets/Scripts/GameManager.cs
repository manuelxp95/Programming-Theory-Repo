using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //this is ugly D:
    private Vector3[] posCards=new[]{
        new Vector3(0,0,19),
        new Vector3(-12,0,19),
        new Vector3(12,0,19)
    };
    
    //para encapsular

    public GameObject[] CardPrefabs;
    public bool canSelect= true;
    private Vector3 playerPos= new Vector3(0f,6.77f,-6.51f);
    public Card overTop;
    public int steps = 0;

    // Start is called before the first frame update
    void Start()
    {
        NextSteps(playerPos.x,playerPos.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextSteps(float xPlayer,float zPlayer){
        Vector3 playerPosition= new Vector3(xPlayer,0,zPlayer);
        
        foreach (Vector3 item in posCards)
        {
            int i=Random.Range(0,CardPrefabs.Length);
            Instantiate(CardPrefabs[i],
                item+playerPosition,
                CardPrefabs[i].transform.rotation
            );
            
        }
        canSelect=true;
    }

    public void cardEffect(){
        overTop.applyAttribute();
    }
}
