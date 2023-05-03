using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUIInactive : MonoBehaviour
{
    public GameObject deactivateGameObject;

    public void DeactivateUI()
    {
        deactivateGameObject.SetActive(false);
    }
}
