using System;
using System.Collections;
using UnityEngine.Networking;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using System.IO;
using System.Threading.Tasks;
using Codice.CM.WorkspaceServer.Lock;


namespace TotemDB {
    public class TotemDBWrapper: MonoBehaviour {
        #region common
        public string items;
        public string avatars;
        public static System.Version Version
        {
            get
            {
                return typeof(TotemDBWrapper).Assembly.GetName().Version;
            }
        }
        #endregion
        
        public IEnumerator GetAllAvatars(Action<string> callback) {
            const string URL = "https://x8ki-letl-twmt.n7.xano.io/api:y8B1f40J/avatars";
            using (UnityWebRequest webRequest = UnityWebRequest.Get(URL))
            {
                // Request and wait for the desired page.
                yield return webRequest.SendWebRequest();

                if (webRequest.result == UnityWebRequest.Result.ConnectionError)
                {
                    Debug.Log(webRequest.error);
                }
                else
                {
                    // Debug.Log(":\nReceived: " + webRequest.downloadHandler.text);
                    callback(webRequest.downloadHandler.text);
                }
            }
        }

        public IEnumerator GetAllItems(Action<string> callback) {
            const string URL = "https://x8ki-letl-twmt.n7.xano.io/api:y8B1f40J/items";
            using (UnityWebRequest webRequest = UnityWebRequest.Get(URL))
            {
                // Request and wait for the desired page.
                yield return webRequest.SendWebRequest();
            
                if (webRequest.result == UnityWebRequest.Result.ConnectionError)
                {
                    Debug.Log(webRequest.error);
                }
                else
                {
                    // Debug.Log(":\nReceived: " + webRequest.downloadHandler.text);
                    callback(webRequest.downloadHandler.text);
                }
            }
        }
    }
}