using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePosition : MonoBehaviour
{
    private float speed = 10f;
    private bool canMove= false;
    private Vector3 nextPosition;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Moving();
    }

    public void NewPosition(Vector3 newPosition){
        //nextPosition=Vector3.ZERO;
        nextPosition= newPosition + new Vector3(0,this.transform.position.y,0);
        Debug.Log("posicion camara: "+this.transform.position);
        Debug.Log("soy nuevo posion: "+newPosition);
        canMove=true;
    }

    private void Moving(){
        if (canMove){
            transform.position = Vector3.MoveTowards(transform.position,nextPosition,Time.deltaTime*speed);
              if (Vector3.Distance(transform.position,nextPosition)< 0.001f){
                canMove=false;
                gameManager.NextSteps(transform.position.x,transform.position.z);
            }
        }
    }
}
