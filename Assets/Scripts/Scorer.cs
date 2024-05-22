using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    [SerializeField] TextMeshProUGUI score;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {

            hits++;
            score.SetText(hits.ToString());
            // Debug.Log("You've bumped into a thing this many times: " + hits);
        }
    }
}
