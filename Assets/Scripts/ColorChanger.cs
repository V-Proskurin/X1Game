using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using System.Runtime.CompilerServices;
using StarterAssets;

public class ColorChanger : NetworkBehaviour   //¬ешаетс€ на персонажа с коллайдером в материал указываетс€ с цветом тела
{
    [SerializeField] private Renderer _rend;
    [SerializeField] private Color _color;

    private void Start()
    {
        if (!isLocalPlayer) return;
        _color = Color.white;
    }
    public override void OnStartLocalPlayer()
    {
        RpcSetColor(_color);
    }
    [ClientRpc]
    public void RpcSetColor(Color color)
    {
        _color = color;
        _rend.material.color = color;

        Debug.Log("ColorChanged");
    }
}
