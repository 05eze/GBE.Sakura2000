using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorLock : MonoBehaviour
{
    void Start()
    {
        //Press key to apply no locking to the Cursor
       // if (Input.GetKey(KeyCode.Alpha1))
            Cursor.lockState = CursorLockMode.None;
    }

    void OnGUI()
    {
        //Press this button to lock the Cursor
        if (Input.GetKey(KeyCode.Alpha2))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
