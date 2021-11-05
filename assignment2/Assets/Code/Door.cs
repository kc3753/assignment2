using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.CompareTag("Player0") || other.gameObject.CompareTag("Player1") )
        {
            if(PublicVars.hasKey==0)
            {
                return;
            }
            else 
            {
                PublicVars.hasKey--;
                Destroy(gameObject);
            }
        }
    }
}
