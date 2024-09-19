using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    GameObject player; //reference to the player so we can track its position
    Renderer rend; //Reference to the renderer so we can modify its textures

    float playerStartPos; //float used to track the starting position of the player
    public float speed = 0.5f; //how fast should we scroll? we change this for each layer

    void Start()
    {
        player = GameObject.Find("Player"); //find the player
        rend = GetComponent<Renderer>(); //find the renderer
        playerStartPos = player.transform.position.x; //save our starting position
    }

    void Update()
    {
        float offset = (player.transform.position.x - playerStartPos) * speed;

        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0f));
    }
}
