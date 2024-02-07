using UnityEngine;

public class SlicingFoods : MonoBehaviour
{
    public float sliceSpeed = 5f; // Adjust the speed as needed
    [SerializeField] private GameObject[] SlicedVeggiesPosition = new GameObject[5];
    private void OnTriggerEnter(Collider other)
    {
        GameObject obj = other.gameObject;

        if (obj.CompareTag("Slice1"))
        {
            Debug.Log("Collision happened with bread slice1");
            obj.transform.position = SlicedVeggiesPosition[0].gameObject.transform.position;
        }

        if (obj.CompareTag("Slice2"))
        {
            Debug.Log("Collision happened with bread slice2");
            obj.transform.position = SlicedVeggiesPosition[1].gameObject.transform.position;
        }

    
        if (obj.CompareTag("Slice3"))
        {
            Debug.Log("Collision happened with bread slice3");
            obj.transform.position = SlicedVeggiesPosition[2].gameObject.transform.position;
        }

        if (obj.CompareTag("Slice4"))
        {
            Debug.Log("Collision happened with bread slice4");
            obj.transform.position = SlicedVeggiesPosition[3].gameObject.transform.position;
        }

        if (obj.CompareTag("Slice5"))
        {
            Debug.Log("Collision happened with bread slice5");
            obj.transform.position = SlicedVeggiesPosition[4].gameObject.transform.position;
        }
    }
}
