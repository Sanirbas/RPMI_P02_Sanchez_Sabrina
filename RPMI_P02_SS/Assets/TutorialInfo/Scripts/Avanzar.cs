using Unity.VisualScripting;
using UnityEngine;

public class Avanzar : MonoBehaviour
{
        
    void Update()
    {
        transform.Translate(0, 0, 0.005f, Space.World);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (Collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
}
