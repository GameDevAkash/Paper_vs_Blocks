using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExit : MonoBehaviour
{
    Coroutine m_routine;
    float threeshold=0.0f;
    [SerializeField] SpawnBlocks[] blocks;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator BlockSpawnner(SpawnBlocks block,Block bblock=null)
    {
        //print(bblock?.SpawnesIndex);
        threeshold = Time.time;
        block.blockspawner();
        yield return new WaitForSeconds(1f);
        m_routine = null;
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //if ((Time.time - threeshold) < 1) 
              // return;
        if(other.TryGetComponent<Block>(out var m_Blocks)||other.tag == "PowerUp"|| other.tag == "Barrier")
        {
            //int spaWneerindex = m_Blocks.SpawnesIndex;
            Destroy(other.gameObject, .25f);

            if(m_routine==null)
                m_routine= StartCoroutine(BlockSpawnner(blocks[3],m_Blocks));
        }
    }
}
