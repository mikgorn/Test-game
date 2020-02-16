using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Player_movement_script : MonoBehaviour
{

    NavMeshAgent player_navmesh;
    // Start is called before the first frame update
    void Start()
    {
        player_navmesh = gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
            player_navmesh.Move((Vector3.forward)*0.1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            player_navmesh.Move((Vector3.back) * 0.1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            player_navmesh.Move((Vector3.left) * 0.1f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            player_navmesh.Move((Vector3.right) * 0.1f);
        }
    }
}
