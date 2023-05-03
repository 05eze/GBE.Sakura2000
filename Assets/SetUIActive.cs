using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUIActive : MonoBehaviour
{
    public GameObject gameObject;

    public void ActivateUI()
    {
        if(gameObject.tag == "Player")
        {
            gameObject.SetActive(true);
        }
        
    }
}
