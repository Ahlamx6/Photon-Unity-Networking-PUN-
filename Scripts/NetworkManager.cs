using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    #region singleton

    public static NetworkManager instance;

    private void Awake()
    {
        instance = this;
    }
    #endregion

    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
    public bool ConnectToServer()
    {
        bool result = PhotonNetwork.ConnectUsingSettings();
        Debug.Log($"Create room:{result}");
        return result;
    }

    public bool CreateRoom(string roomName)
    {
        bool result = PhotonNetwork.CreateRoom(roomName);
        Debug.Log($"Create room\"{roomName}\": {result}");
        return result;
    }

    public bool JoinRoom(string roomName)
    {
        bool result = PhotonNetwork.JoinRoom(roomName);
        Debug.Log($"Create room\"{roomName}\": {result}");
        return result;
    }
 
    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to master");
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        Debug.Log("Joined Lobby");
       // OnCreatedRoom();
    }
    public override void OnCreatedRoom()
    {
        Debug.Log("We have created a room");
    }
    public override void OnJoinedRoom()
    {
        Debug.Log("We have joined a random room");
    }

   #region Fail listeners
    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log($"OnCreateRoomFailed()\nreturntCode: {returnCode}\nmessage:{message}");
    }
    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        Debug.Log($"OnCreateRoomFailed()\nreturntCode: {returnCode}\nmessage:{message}");
    }
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log($"OnCreateRoomFailed()\nreturntCode: {returnCode}\nmessage:{message}");
    }
    public override void OnCustomAuthenticationFailed(string debugmessage)
    {
        Debug.Log($"OnCustomAuthenticationFailedd()\ndebugmessage:{debugmessage}");

    }

    #endregion
    
    
    

    
   
}