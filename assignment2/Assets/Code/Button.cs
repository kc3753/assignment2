using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    //public GameObject activated;
    public GameObject buttonGameObjectLink;
    activatable buttonLink; 
    float up;
    float down;
    void Start(){
        buttonLink = buttonGameObjectLink.GetComponent<activatable>();
        up = transform.position.y;
        down = transform.position.y - 0.05f;
    }
    private void OnTriggerEnter(Collider other)
        {
            
            if(other.gameObject.CompareTag("Player0") || other.gameObject.CompareTag("Player1") )
            {
                transform.position = new Vector3(transform.position.x, down, transform.position.z);
                transform.GetChild(0).GetComponent<Light>().enabled = true;
                buttonLink.activate();
                //activated.SetActive(false);
            }
        }

    private void OnTriggerExit(Collider other)
        {
            if(other.gameObject.CompareTag("Player0") || other.gameObject.CompareTag("Player1") )
            {
                transform.position = new Vector3(transform.position.x, up, transform.position.z);
                transform.GetChild(0).GetComponent<Light>().enabled = false;
                buttonLink.deactivate();
                //activated.SetActive(true);
            }
        }
}
