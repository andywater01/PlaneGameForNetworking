using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class PlayerListing : MonoBehaviourPunCallbacks
{
    public Text playerName;

    public TextMeshProUGUI playerTime;

    private Player player;

    GameObject pd;

    public void SetPlayerInfo(Player _player)
    {
        player = _player;
        playerName.text = _player.NickName;
    }

    public void SetPlayerScore(Player _player)
    {
        
        player = _player;
        playerName.text = _player.NickName;

        pd = GameObject.FindWithTag("Plane");

        pd.gameObject.GetComponent<PlaneMove>().GetTime();
        Debug.Log(pd);

        playerTime.text = "Time: " + pd;

    }

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        if(player == otherPlayer)
        {
            Destroy(gameObject);
        }
    }

    public override void OnLeftRoom()
    {
        Destroy(gameObject);
    }
}
