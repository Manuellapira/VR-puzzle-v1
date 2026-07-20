using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartObjectScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RestartTargetObject"))
        {
            SceneManager.LoadScene(
                SceneManager.GetActiveScene().buildIndex);

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
