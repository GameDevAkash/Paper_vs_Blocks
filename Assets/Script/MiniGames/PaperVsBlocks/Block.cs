using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Block : MonoBehaviour
{
    //[SerializeField] TileMovement TileRef;
    [SerializeField] int Health;
    private int daamgeval = 0;
    float threeshold = 0f;
    private Coroutine m_routine;
    [SerializeField] TextMeshProUGUI e_Health;
   
    public int SpawnesIndex;
    public SpawnBlocks parent;
    private void Start()
    {

        if (Random.Range(0, 3) == 0)
            Destroy(gameObject);
            //gameObject.SetActive(false);
        
        Health = Random.Range(1, 25);
        if(Health<=7)
            GetComponent<MeshRenderer>().material.color = Color.cyan;
        else if(Health>7&&Health<=15)
            GetComponent<MeshRenderer>().material.color = Color.green;
        else
            GetComponent<MeshRenderer>().material.color = Color.red;
    }
    private void Update()
    {
        e_Health.text = Health.ToString();
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //TileMovement.speed = 0;
        if (other.tag == "Player")
        {
            Move.b_speed = 0;
            if (m_routine == null)
                m_routine = StartCoroutine(destroy(daamgeval,other.gameObject));
        }
    }
    private void OnTriggerExit(Collider other)
    {
        //TileMovement.speed = 7;
        Move.b_speed =7;
        StopAllCoroutines();
        m_routine = null;
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.collider.tag.Equals("Player"))
    //        UnityEditor.EditorApplication.isPaused = true;
    //}
    
    IEnumerator destroy(int a_daamgeval, GameObject Player)
    {
        daamgeval = Health;
        int i = 0;
        threeshold = Time.time;
        while (i < daamgeval)
        {
            Health -= 1;
            Player.GetComponent<PaperMovement>().playerHealth -= 1;
            ++i;
            yield return new WaitForSeconds(.2f);
        }
        //TileMovement.speed = 7;
        Move.b_speed =7;
        Destroy(gameObject);
        m_routine = null;
        //yield return new WaitForSeconds(Time.fixedDeltaTime);
    }
}
