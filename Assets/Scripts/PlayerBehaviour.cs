using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerBehaviour : MonoBehaviour
{

    Rigidbody Rb;
    public float jumpforce = 8f;
    public float movementspeed = 5f;
    public int Coins = 0;
    public int CoinsPlus = 5;
    public TextMeshProUGUI CoinsText;

    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rb.AddForce(transform.up * jumpforce, ForceMode.Impulse);
        }
        
        Vector3 movement = new Vector3();
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");

        Rb.AddForce(movement * Time.deltaTime * movementspeed, ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Coins"))
        {
            Coins = Coins + 1;
            Debug.Log("He recogido " + Coins + " Moneda");
        }else if (other.CompareTag("CoinsPlus"))
        {
            Coins = Coins + CoinsPlus;
            Debug.Log("Haz recogido una PLUS ahora tienes " + Coins + " Monedas");
        }

        if (other.tag.Contains("Coins"))
        {
            CoinsText.text = Coins.ToString();
            other.gameObject.SetActive(false);
        }

    }
}
