using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlayerPiece : PlayerPiece
{

    private void OnMouseDown() {
        canMove=true;
        StartCoroutine("MoveStepsEnum");
    }
    

    IEnumerator MoveStepsEnum(){
        if(canMove){
            for(int i=0;i<10;i++){
                transform.position = pathsParent.commonPathPoints[i].transform.position;
                yield return new WaitForSeconds(.25f);
            }
        }
        
    }
}









// // private void Start()
    // // {
    // //     //MoveSteps();
    // //     StartCoroutine("MoveStepsEnum");
    // // }

    // public void MoveSteps()
    // {
    //     for(int i=0;i<3;i++){
    //         transform.position = pathsParent.commonPathPoints[i].transform.position;
    //     }
    // }