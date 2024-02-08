using UnityEngine;

public class SlicingFoods : MonoBehaviour
{
    public float sliceSpeed = 5f; // Adjust the speed as needed
    [SerializeField] private GameObject[] SlicedVeggiesPosition = new GameObject[5];
    int i = 0;
    private void OnTriggerEnter(Collider other)
    {
        GameObject obj = other.gameObject;

        if (obj.CompareTag("Slice1"))
        {
            Debug.Log("Collision happened with bread slice1");
            obj.transform.position = SlicedVeggiesPosition[i].gameObject.transform.position;
            if(i >= SlicedVeggiesPosition.Length-1)
            {
                i = 0;
            }
            i++;
        }
    }
}
