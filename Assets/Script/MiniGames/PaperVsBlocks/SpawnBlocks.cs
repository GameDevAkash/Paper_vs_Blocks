using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour
{
    Vector3 MainPos;
    [SerializeField] List<Vector3> spawnPoints = new List<Vector3>();
    [SerializeField] Block BlockPrefab;
    [SerializeField] PowerUp PowerUpPrefab;
    [SerializeField] GameObject Barrier;
    [SerializeField] private int SpawnIndex;
    
    // Start is called before the first frame update
    void Start()
    {
        MainPos = transform.position;
        //for (int i = 5; i > 0; i--)
        //if(SpawnIndex == 3 || SpawnIndex == 4)
            GenerateSpawnPoints(); //PowerUpSpawner();
        //MainPos = transform.position;
        blockspawner();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateSpawnPoints()
    {
        //int j = -4;
        //for (int i=5;i>0;i--)
        {
            //MainPos.x = MainPos.x;// * i
            for (int j = -4;j<5;j+=2)
            {
                var x = MainPos.x + j;
                spawnPoints.Add(new Vector3(x, MainPos.y, MainPos.z));
            }
        }
    }
   public void blockspawner()
    {
        for (int i = 0; i < spawnPoints.Count; i++)
        {
            Block go=Instantiate<Block>(BlockPrefab, spawnPoints[i], Quaternion.identity);
            PowerUp po = Instantiate<PowerUp>(PowerUpPrefab, new Vector3(spawnPoints[i].x, spawnPoints[i].y, spawnPoints[i].z + 1.7f), Quaternion.identity);
            //po.transform.SetParent(go.transform);
            if(i>0)
            {
                GameObject Ba = Instantiate(Barrier, new Vector3(spawnPoints[i].x - 1, spawnPoints[i].y, spawnPoints[i].z), Quaternion.identity);
                if (Random.Range(0, 2) == 0)
                    Destroy(Ba);
            }
            go.SpawnesIndex = SpawnIndex;
            go.parent=this;
        }
    }

    public void PowerUpSpawner()
    {
        for (int i = 0; i < spawnPoints.Count; i++)
        {
            
        }
    }
}
