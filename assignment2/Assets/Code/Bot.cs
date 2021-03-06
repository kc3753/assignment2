using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Bot : MonoBehaviour
{
    NavMeshAgent _navMeshAgent;
    GameObject player;

    void Start()
    {
         _navMeshAgent = GetComponent<NavMeshAgent>();
         player = GameObject.FindGameObjectWithTag("Player1");
         StartCoroutine(LookForPlayer());
    }
    IEnumerator LookForPlayer()
    {
        while(true)
        {
            yield return new WaitForSeconds(.5f);
            _navMeshAgent.destination = player.transform.position;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
