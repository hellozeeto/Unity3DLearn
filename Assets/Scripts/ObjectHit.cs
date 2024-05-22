using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) // 개체가 서로 충돌했을때 사용
    {
        if(other.gameObject.tag == "Player" )
        {
            GetComponent<MeshRenderer>().material.color = Color.blue;
            gameObject.tag = "Hit";
        }
          
    }
}
