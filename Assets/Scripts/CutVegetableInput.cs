using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutVegetableInput : MonoBehaviour
{
    private Quaternion originalRotation;
    private bool isCutting = false;
    [SerializeField] private GameObject[] slicesPosition = new GameObject[5];
    [SerializeField] private GameObject[] slices = new GameObject[5];
    [SerializeField] private GameObject[] SlicedFoodsPos = new GameObject[3];
    [SerializeField] private GameObject vegetable;
    int n = 5;
    int sliceCount = 0;

    [SerializeField] private GameObject KnifePos;
    [SerializeField] private GameObject KnifeSlidePos;
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
            sliceCount++;
            print(sliceCount);
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
        if(Input.GetKeyDown(KeyCode.LeftArrow) && !isCutting && sliceCount == 5)
        {
           // Vector3 iPos = gameObject.transform.position;
            //Vector3 fPos = new Vector3(0f, 0f, 100f);
            //transform.Translate(KnifeSlidePos.transform.position);
            //transform.Translate(KnifePos);
            transform.position = KnifeSlidePos.transform.position;
            Invoke("ResetKnifePos", 1);
            vegetable.transform.position = SlicedFoodsPos[0].gameObject.transform.position;
        }
    }

    private void ResetKnifePos()
    {
        transform.position = KnifePos.transform.position;   
    }

}
