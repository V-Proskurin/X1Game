using UnityEngine;
using Mirror;
using TMPro;

public class NameOnPerson : NetworkBehaviour        // синх и вывод имени на перса вешается на канвас имени на пересе
{
    [SyncVar] private string _name = "Player";
    [SerializeField] private TextMeshProUGUI _nameText;

    private void Start()
    {
        if (!isLocalPlayer) return;
        if (PlayerPrefs.GetString("name") != "")
        {
            _name = PlayerPrefs.GetString("name");
        }
    }
    private void Update()
    {
        if (!isServer) return;
        RpcSetName(_name);
    }

    [ClientRpc] 
    private void RpcSetName(string name) 
    {
        _nameText.text = name;
    }
}
