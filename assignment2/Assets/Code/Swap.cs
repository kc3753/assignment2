using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PublicVars.playerNum = 0;
    }

    // Update is called once per frame
    void Update()
    {   

        if(Input.GetKeyDown("space")){
            print(PublicVars.playerNum);
            if(PublicVars.playerNum == 1){
                PublicVars.playerNum = 0;
            }
            else if(PublicVars.playerNum == 0){
                PublicVars.playerNum = 1;
            }
            print(PublicVars.playerNum);
        }
    }
}
