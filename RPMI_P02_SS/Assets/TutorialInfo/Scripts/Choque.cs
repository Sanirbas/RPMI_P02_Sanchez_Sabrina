using UnityEngine;

public class Choque : MonoBehaviour
{
    public Transform Player;
    public Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.Translate(0, 0, 310 * Time.deltaTime, Space.World);
    }
    // Update is called once per frame
    void Update()
    {
        if (Player.transform)
        {
            transform.position = Player.position + offset;
        }

    }

  
    
   
}

