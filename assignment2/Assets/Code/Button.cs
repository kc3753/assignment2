using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    public GameObject activate;
    private void OnTriggerEnter(Collider other)
        {
            
            if(other.gameObject.CompareTag("Player0") || other.gameObject.CompareTag("Player1") )
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.05f, transform.position.z);
                transform.GetChild(0).GetComponent<Light>().enabled = true;
                activate.SetActive(false);
            }
        }

    private void OnTriggerExit(Collider other)
        {
            if(other.gameObject.CompareTag("Player0") || other.gameObject.CompareTag("Player1") )
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + 0.05f, transform.position.z);
                transform.GetChild(0).GetComponent<Light>().enabled = false;
                activate.SetActive(true);
            }
        }
}
