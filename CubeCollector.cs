using UnityEngine;

public class CubeCollector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().CollectCube(gameObject);
        }
    }
}
