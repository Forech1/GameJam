using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class DestroySrtipt : MonoBehaviour
{
    [SerializeField]float destroyTime =2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject, destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
