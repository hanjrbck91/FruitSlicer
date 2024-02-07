using UnityEngine;

public class SlicingFoods : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject obj = other.gameObject;

        if (obj.CompareTag("Slice1"))
        {
            Debug.Log("Collision happened with bread slice");

            // Calculate the translation vector to move the object left along the z-axis
            Vector3 translation = new Vector3(0, 0, 150f);

            // Move the object to the specified position
            obj.transform.Translate(translation);
        }

        if (obj.CompareTag("Slice2"))
        {
            Debug.Log("Collision happened with bread slice");

            // Calculate the translation vector to move the object left along the z-axis
            Vector3 translation = new Vector3(0, 0, 140f);

            // Move the object to the specified position
            obj.transform.Translate(translation);
        }

        if (obj.CompareTag("Slice3"))
        {
            Debug.Log("Collision happened with bread slice");

            // Calculate the translation vector to move the object left along the z-axis
            Vector3 translation = new Vector3(0, 0, 130f);

            // Move the object to the specified position
            obj.transform.Translate(translation);
        }

        if (obj.CompareTag("Slice4"))
        {
            Debug.Log("Collision happened with bread slice");

            // Calculate the translation vector to move the object left along the z-axis
            Vector3 translation = new Vector3(0, 0, 120f);

            // Move the object to the specified position
            obj.transform.Translate(translation);
        }

        if (obj.CompareTag("Slice5"))
        {
            Debug.Log("Collision happened with bread slice");

            // Calculate the translation vector to move the object left along the z-axis
            Vector3 translation = new Vector3(0, 0, 110f);

            // Move the object to the specified position
            obj.transform.Translate(translation);
        }
    }
}
