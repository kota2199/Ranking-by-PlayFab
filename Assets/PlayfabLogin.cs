using UnityEngine;
using PlayFab.ClientModels;
using PlayFab;

public class PlayfabLogin : MonoBehaviour
{
    void Start()
    {
        var request = new LoginWithCustomIDRequest
        {
            CustomId = "sample-custom-id",
            CreateAccount = true
        };
        PlayFabClientAPI.LoginWithCustomID(request,
            result =>
            {
                Debug.Log("ログイン成功:" + result);
            },
            error =>
            {
                Debug.Log("ログイン失敗:" + error);
            });
    }
}