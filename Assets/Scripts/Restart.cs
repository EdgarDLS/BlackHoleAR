using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour {

    public GameObject oldPrefab;

    void Update()
    {
        if (Input.touchCount > 2 || Input.GetMouseButtonDown(2))
        {
            Destroy(oldPrefab);
            GameObject blackHole = Instantiate(Resources.Load("Prefabs", typeof(GameObject))) as GameObject;
            blackHole.transform.rotation = Quaternion.Euler(-90, 0, 0);
            blackHole.transform.parent = this.transform;
            oldPrefab = blackHole.gameObject;
        }
    }
}
