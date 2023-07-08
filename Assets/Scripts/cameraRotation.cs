using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRotation : MonoBehaviour
{
    public GameObject player;
    public Vector3 cameraPos;
    [Header("カメラ：プレイヤーからの距離")]
    [SerializeField]
    float cameraX;
    [SerializeField]
    float cameraY;
    [SerializeField]
    float cameraZ;
    [Header("カメラ：回転速度")]
    [SerializeField]
    private float rotSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        cameraPos = player.transform.position + new Vector3(cameraX, cameraY, cameraZ);

        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.A)) {
            transform.RotateAround(player.transform.position,new Vector3(0,1,0),-rotSpeed);
        }
        if(Input.GetKey(KeyCode.D)) {
            transform.RotateAround(player.transform.position, new Vector3(0, 1, 0), rotSpeed);
        }
    }
}
