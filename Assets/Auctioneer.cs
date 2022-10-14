using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Auctioneer : MonoBehaviour
{
    public TMP_Text tScore;
    public TMP_Text netScore;

    public GameObject winner;

    Rigidbody2D rb;

    public float bid = 0.00f;
    public static float netBid = 0.00f;

    float nickel = 0.0f;
    float dime = 0.0f;
    float quarter = 0.0f;

    public float thrust = 20f;

    // Start is called before the first frame update
    void Start()
    {
        nickel = 0.05f;
        dime = 0.1f;
        quarter = 0.25f;

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        tScore.text = "$" + bid.ToString("0.00");

        if(netBid < bid)
        {
            netBid = bid;
        }
        netScore.text = "Current Bid: $" + netBid.ToString("0.00");

        if(netBid > 1)
        {
            nickel = 0;
            dime = 0;
            quarter = 0;
            winner.SetActive(true);
        }
    }

    public void addNickel()
    {
        //Debug.Log("Hello World.");
        bid += nickel;
        rb.AddForce(transform.up * thrust);
    }

    public void addDime()
    {
        //Debug.Log("Hello World.");
        bid += dime;
        rb.AddForce(transform.up * thrust);
    }

    public void addQuarter()
    {
        //Debug.Log("Hello World.");
        bid += quarter;
        rb.AddForce(transform.up * thrust);
    }
}
