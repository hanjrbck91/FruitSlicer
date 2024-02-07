using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutVegetableInput : MonoBehaviour
{
    private Quaternion originalRotation;
    private bool isCutting = false;

    void Start()
    {
        // Store the original rotation of the GameObject
        originalRotation = transform.rotation;
    }

    void Update()
    {
        // Rotate the GameObject to a specific angle (e.g., 90 degrees)
        if (Input.GetKeyDown(KeyCode.DownArrow) && !isCutting)
        {
            transform.Rotate(0f, 0f, -33f);
            isCutting = true;
        }

        // Reset the rotation to its original state
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.rotation = originalRotation;
            isCutting = false;
        }
    }

}
