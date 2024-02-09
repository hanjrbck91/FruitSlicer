using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutVegetableInput : MonoBehaviour
{
    private Quaternion originalRotation;
    private bool isCutting = false;
    private bool isSliding = false;
    [SerializeField] private GameObject[] slicesPosition = new GameObject[5];
   // [SerializeField] private GameObject[] slices = new GameObject[5];
    [SerializeField] private GameObject[] SlicedFoodsPos = new GameObject[3];
    //[SerializeField] private GameObject[] WholeSlicesToMoveAside;
    [SerializeField] private GameObject[] diffFoodsToCut;
    [SerializeField] private GameObject foodSpawnPosition;
    private GameObject spawnedFruit;
    int sliceNumber = 1;
    int sliceCount = 0;
    int slicePosition = 0;

    [SerializeField] private GameObject KnifePos;
    [SerializeField] private GameObject KnifeSlidePos;
    void Start()
    {
        // Store the original rotation of the GameObject
        originalRotation = transform.rotation;
        spawnedFruit = Instantiate(diffFoodsToCut[Random.Range(0, diffFoodsToCut.Length - 1)], foodSpawnPosition.transform.position,Quaternion.identity);

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
            for (int i = sliceNumber, slicePosition = 0; i < spawnedFruit.transform.childCount; i++,slicePosition++)
            {
                GameObject currentChild = spawnedFruit.transform.GetChild(i).gameObject;
                currentChild.transform.position = slicesPosition[slicePosition].gameObject.transform.position;
            }
            sliceNumber++;

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && !isCutting && sliceCount % 5 == 0)
        {
            isSliding = true;
            transform.position = KnifeSlidePos.transform.position;
            Invoke("ResetKnifePos", .5f);
            int arrPos = sliceCount / 5 - 1;
            if (arrPos >=3 )
            {
                arrPos = 0;
            }
            spawnedFruit.transform.position = SlicedFoodsPos[arrPos].gameObject.transform.position;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && !isCutting && isSliding)
        {
            isSliding = false;
            transform.position = KnifePos.transform.position;
            spawnedFruit = Instantiate(diffFoodsToCut[Random.Range(0, diffFoodsToCut.Length - 1)], foodSpawnPosition.transform);
            sliceNumber = 1;
            slicePosition = 0;
        }
    }

}
