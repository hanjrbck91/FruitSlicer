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
    [SerializeField] private GameObject[] WholeSlicesToMoveAside;
    [SerializeField] private GameObject[] diffFoodsToCut;
    int n = 5;
    int sliceCount = 0;
    int k = 1;

    [SerializeField] private GameObject KnifePos;
    [SerializeField] private GameObject KnifeSlidePos;
    void Start()
    {
        // Store the original rotation of the GameObject
        originalRotation = transform.rotation;
        diffFoodsToCut[Random.Range(0, diffFoodsToCut.Length - 1)].gameObject.SetActive(true);

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
        if(Input.GetKeyDown(KeyCode.LeftArrow) && !isCutting && sliceCount % 5 == 0)
        {
            transform.position = KnifeSlidePos.transform.position;
            Invoke("ResetKnifePos", .5f);
            int arrPos = sliceCount / 5 - 1;
            WholeSlicesToMoveAside[arrPos].transform.position = SlicedFoodsPos[arrPos].gameObject.transform.position;
            diffFoodsToCut[k].gameObject.SetActive(true);
            k++;
        }
    }

    private void ResetKnifePos()
    {
        transform.position = KnifePos.transform.position;   
    }

}
