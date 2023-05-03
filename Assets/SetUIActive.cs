using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUIActive : MonoBehaviour
{
    public GameObject activateGameObject, deactivateGameObject2, activateGameObject3;

    public void ActivateUI()
    {
        
        activateGameObject.SetActive(true);
        deactivateGameObject2.SetActive(false);
        activateGameObject3.SetActive(true);
        
    }

   
}
