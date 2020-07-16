using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using System;

public class length : MonoBehaviour
{
    public Vector3 pos;
    public TextMeshPro panjang, lebar, tinggi, diagonalR, diagonalS;
    public GameObject panjangA, panjangB;
    public GameObject lebarA, lebarB;
    public GameObject tinggiA, tinggiB;
    public GameObject diagonalRA, diagonalRB;
    public GameObject diagonalSA, diagonalSB;


    // Start is called before the first frame update
    void Start()
    {
        float distance1= Vector3.Distance(panjangB.transform.position, panjangA.transform.position);
        distance1.ToString("F2");
        panjang.text = (Math.Round(distance1, 2) + " cm");

        float distance2 = Vector3.Distance(lebarB.transform.position, lebarA.transform.position);
        distance2.ToString("F2");
        lebar.text = (Math.Round(distance2, 2) + " cm");

        float distance3 = Vector3.Distance(tinggiB.transform.position, tinggiA.transform.position);
        distance3.ToString("F2");
        tinggi.text = (Math.Round(distance3, 2) + " cm");

        float distance4 = Vector3.Distance(diagonalRB.transform.position, diagonalRA.transform.position);
        distance4.ToString("F2");
        diagonalR.text = (Math.Round(distance4, 2) + " cm");

        float distance5 = Vector3.Distance(diagonalSB.transform.position, diagonalSA.transform.position);
        distance5.ToString("F2");
        diagonalS.text = (Math.Round(distance5, 2) + " cm");
    }

    // Update is called once per frame
    private void Update()
    {
        float distance1 = Vector3.Distance(panjangB.transform.position, panjangA.transform.position);
        distance1.ToString("F2");
        panjang.text = (Math.Round(distance1, 2) + " cm");

        float distance2 = Vector3.Distance(lebarB.transform.position, lebarA.transform.position);
        distance2.ToString("F2");
        lebar.text = (Math.Round(distance2, 2) + " cm");

        float distance3 = Vector3.Distance(tinggiB.transform.position, tinggiA.transform.position);
        distance3.ToString("F2");
        tinggi.text = (Math.Round(distance3, 2) + " cm");

        float distance4 = Vector3.Distance(diagonalRB.transform.position, diagonalRA.transform.position);
        distance4.ToString("F2");
        diagonalR.text = (Math.Round(distance4, 2) + " cm");

        float distance5 = Vector3.Distance(diagonalSB.transform.position, diagonalSA.transform.position);
        distance5.ToString("F2");
        diagonalS.text = (Math.Round(distance5, 2) + " cm");
        
    }
}
