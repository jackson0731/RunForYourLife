using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class MiniMap : MonoBehaviour
{
    public Camera minicamera;
    public Transform player;
    public Transform miniplayerIcon;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        minicamera.transform.position = new Vector3(player.position.x, minicamera.transform.position.y, player.position.z);
        miniplayerIcon.eulerAngles = new Vector3(0, player.eulerAngles.y, 0);
        miniplayerIcon.transform.position = new Vector3(player.position.x, miniplayerIcon.transform.position.y, player.position.z);
    }
}
