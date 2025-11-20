using UnityEngine;

public class AvanzarLineal : MonoBehaviour
{
    public int avance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.Translate(0, 0, -10 * Time.deltaTime, Space.World);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
