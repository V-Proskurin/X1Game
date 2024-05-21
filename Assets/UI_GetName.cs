using UnityEngine;
using TMPro;

public class UI_GetName : MonoBehaviour     //для получения имени с канваса вешается на инпут
{
    [SerializeField] private TMP_InputField _inputField;

    private string _name;
    private void Start()
    {
        if (PlayerPrefs.GetString("name") != null)
        {
            _inputField.text = PlayerPrefs.GetString("name");  
            _name = PlayerPrefs.GetString("name");
        }
    }
    public void SaveName()
    {
        _name = _inputField.text;
        PlayerPrefs.SetString("name", _name);
    }
}
