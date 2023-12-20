using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public static float b_speed;
    [SerializeField]float timer;
    // Start is called before the first frame update
    void Start()
    {
        b_speed = 7;
        timer = 3;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * b_speed * Time.deltaTime);
        //if(timer>0)
        //{
        //    timer -= Time.deltaTime;
        //}
        //else
        //{
        //    timer = 3;
        //    b_speed++;
        //    Debug.Log(b_speed);
        //}
    }
}
