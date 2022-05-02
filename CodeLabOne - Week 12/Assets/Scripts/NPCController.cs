using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MathUtil;

public class NPCController : MonoBehaviour
{

    [SerializeField]
    GameObject player;

    private void Start()
    {
        player = GameObject.Find("Player");
    }

    private void Update()
    {
        if (Util.CanSeeObj(player, gameObject, 0.5f))
        {
            //Debug.Log("Can see Player");
        }
        Util.ObjSide(player, gameObject);
                  
    }
}
