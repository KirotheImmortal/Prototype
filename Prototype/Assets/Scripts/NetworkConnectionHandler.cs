using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class NetworkConnectionHandler : MonoBehaviour {
	public virtual void OnServerDisconnect(NetworkConnection conn)
	{
		NetworkServer.DestroyPlayersForConnection(conn);
	}

 
}


