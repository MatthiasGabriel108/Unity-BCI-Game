using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveToObject : MonoBehaviour
{
    //private GameObject target;
    //public GameObject target2;
    //public GameObject target3;
    //public GameObject target4;
    private GameObject[] targets;
    private GameObject randomTarget;
    // Start is called before the first frame update
    void Start()
    {
      //var possibleTargets = GameObject.FindGameObjectsWithTag("Goal");
      //target = possibleTargets[Random.Range(0, possibleTargets.length)].transform;
       targets = GameObject.FindGameObjectsWithTag("Goal");
       randomTarget = targets[Random.Range(0, targets.Length)];
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, randomTarget.transform.position, 10f*Time.deltaTime);
    }
}
