using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Platform : MonoBehaviour
{
    public string levelToLoad;
    public bool person0 = false;
    public bool person1 = false;
    TransitionManager _transitionManager;

    private void Start()
    {
        _transitionManager = FindObjectOfType<TransitionManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.CompareTag("Player0"))
        {
            person0 = true ;   
        }
        else if (other.gameObject.CompareTag("Player1")){
            person1 = true;
        }
        if(person0 && person1)
        {
            //_transitionManager.LoadScene(levelToLoad);
            _transitionManager.LoadScene(levelToLoad);
        }
    }
}
