using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PowerUp : MonoBehaviour
{
    [SerializeField] int Health;
    [SerializeField] TextMeshProUGUI PU_Health;

    // Start is called before the first frame update
    void Start()
    {
        if (Random.Range(0, 2) == 0)
            Destroy(gameObject);
        Health = Random.Range(1, 5);
    }

    // Update is called once per frame
    void Update()
    {
        PU_Health.text = Health.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<PaperMovement>().playerHealth += Health;
            Destroy(gameObject);
        }
    }
}
