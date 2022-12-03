using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnCollisionEnter(Collision collisionInfo) {
        if(collisionInfo.collider.tag == "obstacle")
        {
            FindObjectOfType<GameMenager>().GameOver();
            //FindObjectOfType<GameMenager>().GameOver();
        }
    }
}
