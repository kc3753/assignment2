using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vanish : MonoBehaviour, activatable
{
    public bool DefaultVisibility = true;
    void Start(){
        gameObject.SetActive(DefaultVisibility);
    }
    void activatable.activate(){
        gameObject.SetActive(!DefaultVisibility);
    }

    void activatable.deactivate(){
        gameObject.SetActive(DefaultVisibility);
    }
}
