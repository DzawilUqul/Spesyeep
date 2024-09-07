using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SectionTrigger : MonoBehaviour
{
    public GameObject enemySection;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Trigger"))
        {
            Instantiate(enemySection);
        }
    }
}
