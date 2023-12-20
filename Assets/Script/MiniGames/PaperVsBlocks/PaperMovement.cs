using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PaperMovement : MonoBehaviour
{
    [SerializeField] public int playerHealth;
    [SerializeField] TextMeshProUGUI p_Health;
    [SerializeField] UiManager manager;
    [SerializeField] float score;
    [SerializeField] TextMeshProUGUI ScoreText;
    [SerializeField] private bool canMoveplus;
    [SerializeField] private bool canMoveminus;
    [SerializeField] private Transform plus;
    [SerializeField] private Transform minus;
    [SerializeField] LayerMask barrier;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth <= 0)
        {
            Time.timeScale = 0;
            manager.Activate();
        }
        //RaycastHit hit;
        canMoveplus = !Physics.CheckSphere(plus.position,0.48f, barrier);
        canMoveminus = !Physics.CheckSphere(minus.position, 0.48f, barrier);


        if ((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) && transform.position.x >= -4 && transform.position.x < 4&& canMoveplus)
            transform.position +=new Vector3(2,0,0); 
        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) && transform.position.x <=4  && transform.position.x > -4& canMoveminus)
            transform.position += new Vector3(-2, 0, 0);
        p_Health.text = playerHealth.ToString();
        if (Move.b_speed == 7)
        {
            score += 1 * Time.deltaTime;
            ScoreText.text = string.Format("{0:0}", score);
        }
    }
}
