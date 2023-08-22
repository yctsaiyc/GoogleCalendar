using System;
using System.Threading;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Util.Store;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.HttpMethod == "POST")
        {
            string method = Request.Form["method"];
            if (method == "btnAuthorizeGoogle_Click")
            {
                btnAuthorizeGoogle_Click();
            }
        }
    }
     protected void btnAuthorizeGoogle_Click()
    {
        string[] scopes = new[] { CalendarService.Scope.Calendar }; // 授權用戶訪問的Google服務範圍
        string clientId = "278469403681-brc5stonu5gtn4r0q6lumpdnv12cd55d.apps.googleusercontent.com"; //用戶端編號
        string clientSecret = "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"; //用戶端密鑰

        //讓用戶登入Google帳戶，執行Google授權
        UserCredential credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
            new ClientSecrets { ClientId = clientId, ClientSecret = clientSecret },
            scopes,
            "user", //使用當前用戶的憑證
            CancellationToken.None, //在授權過程中取消標記，不使用
            new FileDataStore("Calendar.Auth.Store") //將用戶的授權憑證保存在本地，避免重複授權
        ).Result; 
    }
}