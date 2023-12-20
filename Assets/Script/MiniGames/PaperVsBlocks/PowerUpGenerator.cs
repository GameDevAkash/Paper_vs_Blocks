using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpGenerator : MonoBehaviour
{
    [SerializeField] GameObject PowerUpPrefab;
    //set custom range for random position
    public float MinX = 3;
    public float MaxX = -3;
    public float MinY = -50;
    public float MaxY = 50;
    // Start is called before the first frame update
    void Start()
    {
        Spawner();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawner()
    {
        for (int i = 0; i <= 5; i++)
        {
            //var dist = Vector3.Distance(GameObject.FindGameObjectWithTag("Block").transform.position, transform.position);
            ////Then check how far they are away.
            //if (dist < .02)//Checks if there within .2 of each other.
            //{
            //do something
            float x = Random.Range(MinX, MaxX);
            float y = Random.Range(MinY, MaxY);
            GameObject PowerUp = Instantiate(PowerUpPrefab, new Vector3(transform.position.x + x, .5f, transform.position.z + y), Quaternion.identity);
            PowerUp.transform.SetParent(gameObject.transform);
            //}
        }
    }
}
