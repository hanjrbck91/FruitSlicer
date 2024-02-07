using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutVegetableInput : MonoBehaviour
{
    private Quaternion originalRotation;
    private bool isCutting = false;
    [SerializeField] private GameObject[] slicesPosition = new GameObject[5];
    [SerializeField] private GameObject[] slices = new GameObject[5];
    int n = 5;
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
            //slices[].gameObject.transform.position = slicesPosition[i].gameObject.transform.position;

            for(int i = 0; i < n-1; i++)
            {
                slices[i] = slices[i+1];
            }
            n--;
            for(int i = 0; i < n; i++)
            {
                slices[i].gameObject.transform.position = slicesPosition[i].gameObject.transform.position;
            }
            
        }
    }

}
