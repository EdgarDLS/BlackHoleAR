using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour {

    public float attractionForce = 0;
    public GameObject[] brokenPieces;

    void Start()
    {
        brokenPieces = GameObject.FindGameObjectsWithTag("brokenPiece");
        Destroy(this.gameObject, 3);
    }

    void Update()
    {
        foreach (GameObject brokenPiece in brokenPieces)
        {
            brokenPiece.transform.Translate((this.transform.position - brokenPiece.transform.position).normalized * attractionForce * Time.deltaTime);
        }

        attractionForce += Time.deltaTime*2;
    }

    void OnTriggerEnter(Collider brokenPiece)
    {
        Destroy(brokenPiece);
    }
}
