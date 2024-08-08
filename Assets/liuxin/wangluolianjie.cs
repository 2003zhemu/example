using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class wangluolianjie : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
        PhotonNetwork.JoinOrCreateRoom("room",new Photon.Realtime.RoomOptions() { MaxPlayers=2},default);
    }
    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        PhotonNetwork.Instantiate("tanke", new Vector3(1, 1, 0), Quaternion.identity, 0);
    }
}
