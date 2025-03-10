using System.Numerics;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject player;
    [SerializeField] public UnityEngine.Vector3 offset = new UnityEngine.Vector3(0 ,5, -7);
    

    // Update is called once per frame
    void LateUpdate()
    {
       transform.position = player.transform.position + offset; 
    }

}
