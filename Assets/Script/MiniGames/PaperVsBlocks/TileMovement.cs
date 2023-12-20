using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public static float speed;
    Vector3 initpos;
    [SerializeField] GameObject spawnPos;

    void Start()
    {
        speed = 7;
        initpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
        if (transform.position.z <= -56f)
            RestTile();
    }

    public void RestTile()
    {
        transform.position = spawnPos.transform.position;
        foreach (Transform child in transform)
        {
            if(child.tag == "Block" || child.tag == "PowerUp")
                Destroy(child.gameObject);
        }
        GetComponent<BlockSpawner>().Spawner();
        GetComponent<PowerUpGenerator>().Spawner();
    }
}
