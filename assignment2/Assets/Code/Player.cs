using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    public int num;
    NavMeshAgent _navMeshAgent;
    Camera mainCam;
    //public Transform spawnPoint;
    //public GameObject bulletPrefab;
    //float startTime;
    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        mainCam = Camera.main;
        PublicVars.playerNum = 0;
    }
    void Update()
    {   
        if(num == PublicVars.playerNum){
            if (Input.GetMouseButtonUp(0))
            {
                RaycastHit hit;
                if(Physics.Raycast(mainCam.ScreenPointToRay(Input.mousePosition),out hit, 200))
                {
                    _navMeshAgent.destination = hit.point;
                }
            }
        }
        /*
        if(Input.GetMouseButtonDown(0))
        {
            startTime = Time.time;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            if(Time.time -startTime < .2f)
            {
                RaycastHit hit;
                if(Physics.Raycast(mainCam.ScreenPointToRay(Input.mousePosition),out hit, 200))
                {
                    _navMeshAgent.destination = hit.point;
                }
            }
            else
            {
                RaycastHit hit;
                if(Physics.Raycast(mainCam.ScreenPointToRay(Input.mousePosition),out hit, 200))
                {
                    transform.LookAt(hit.point);
                    GameObject newBullet = Instantiate(bulletPrefab, spawnPoint.position, transform.rotation);
                    newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * 200);
                }
            }
        }
        */
    }

    private void OnTriggerEnter (Collider other)
    {   
        if(num == PublicVars.playerNum){
            print(other.gameObject.name);
            for(int i = 0; i< PublicVars.hasKey.Length; i++)
            {
                if (other.gameObject.CompareTag("Key" + i))
                {
                    Destroy(other.gameObject);
                    PublicVars.hasKey[i] = true;
                }
            }
        }
    }
}
