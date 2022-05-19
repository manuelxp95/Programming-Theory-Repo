using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePosition : MonoBehaviour
{
    private float speed = 10f;
    private bool canMove= false;
    private Vector3 nextPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Moving();
    }

    public void NewPosition(Vector3 newPosition){
       // transform.position = this.transform.position+newPosition; 
        nextPosition= newPosition + this.transform.position;
        canMove=true;
    }

    private void Moving(){
        if (canMove){
            transform.position = Vector3.MoveTowards(transform.position,nextPosition,Time.deltaTime*speed);
              if (Vector3.Distance(transform.position,nextPosition)< 0.001f){
                canMove=false;
            }
        }
    }
}
