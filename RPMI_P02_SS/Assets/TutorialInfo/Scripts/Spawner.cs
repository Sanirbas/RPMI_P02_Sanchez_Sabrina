using JetBrains.Annotations;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject adventurer;
    public Transform spawnPoint;

    private void OnMouseDown()
    {
     print("spawn");
     Debug.Log("spawn");

        //Instantiate(adventurer, Vector3.zero, Quaternion.identity);
        //Instantiate(adventurer, new Vector3(-6.500354f, 0.65f, -18.69f), Quaternion.identity);
        Instantiate(adventurer, spawnPoint.position, spawnPoint.rotation);
    }


}
