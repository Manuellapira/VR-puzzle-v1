using UnityEngine;

public class DestroyObjectScript : MonoBehaviour
{
    [Header("Object must be placed here")]
    public GameObject requiredObject;

    [Header("Objects to destroy")]
    public GameObject[] objectsToDestroy;

    private bool activated = false;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject == requiredObject && !activated)
        {
            activated = true;

            DestroyAllObjects();
        }
    }

    private void DestroyAllObjects()
    {
        foreach (GameObject obj in objectsToDestroy)
        {
            if (obj != null)
            {
                Destroy(obj);
            }
        }
    }
}