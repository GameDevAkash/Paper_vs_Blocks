using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public GameObject BlockPrefab;
    [SerializeField] Transform[] SpawnPos;
    int last_j =61;

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
        for (int i = 0; i <= 51; i++)
        {
            GameObject Blocks = Instantiate(BlockPrefab, SpawnPos[i].position, Quaternion.identity);
            Blocks.transform.SetParent(gameObject.transform);
            
            /*else
            {
                j = Random.Range(0, 32);
            }*/
        }
    }
}
