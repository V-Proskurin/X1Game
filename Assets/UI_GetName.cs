using UnityEngine;
using TMPro;
using System.Runtime.InteropServices;

public class UI_GetName : MonoBehaviour     //для получения имени с канваса вешается на инпут
{
    [DllImport("__Internal")]
    private static extern string getUserNickname();

    [SerializeField] private TMP_InputField _inputField;

    private string _name;
    private void Start()
    {
        if (PlayerPrefs.GetString("name") != null)
        {
            _inputField.text = PlayerPrefs.GetString("name");  
            _name = PlayerPrefs.GetString("name");
        }
        _inputField.text = getUserNickname();
        _name = getUserNickname();
        Debug.Log(_name);
        SaveName();
    }
    public void SaveName()
    {
        _name = _inputField.text;
        PlayerPrefs.SetString("name", _name);
    }
}
