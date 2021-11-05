using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    
    GameObject player;
    Vector3 offset;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player0");
        offset = transform.position - player.transform.position;

    }
    void LateUpdate()
    {   
        player = GameObject.FindGameObjectWithTag("Player" + PublicVars.playerNum);
        transform.position = player.transform.position + offset;
    }
}
