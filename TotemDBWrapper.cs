using System;
using System.Collections;
using UnityEngine.Networking;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using System.IO;
using Codice.CM.WorkspaceServer.Lock;


namespace TotemDB {
    public class TotemDBWrapper: MonoBehaviour {
        #region common
        public Coroutine coroutine { get; private set; }
        public string items;
        public string avatars;
        public static System.Version Version
        {
            get
            {
                return typeof(TotemDBWrapper).Assembly.GetName().Version;
            }
        }

        public void GetDB()
        {
            // StartCoroutine(GetAllAvatars());
            StartCoroutine(GetAllItems());
        }

        #endregion
        
        private IEnumerator GetAllAvatars() {
            const string URL = "https://x8ki-letl-twmt.n7.xano.io/api:y8B1f40J/avatars";
            using (UnityWebRequest webRequest = UnityWebRequest.Get(URL))
            {
                // Request and wait for the desired page.
                webRequest.SendWebRequest();

                if (webRequest.result == UnityWebRequest.Result.ConnectionError)
                {
                    Debug.Log(webRequest.error);
                }
                else
                {
                    Debug.Log(":\nReceived: " + webRequest.downloadHandler.text);
                    avatars = webRequest.downloadHandler.text;
                    yield return webRequest.downloadHandler.text;
                }
            }
        }

        private IEnumerator GetAllItems() {
            const string URL = "https://x8ki-letl-twmt.n7.xano.io/api:y8B1f40J/items";
            using (UnityWebRequest webRequest = UnityWebRequest.Get(URL))
            {
                // Request and wait for the desired page.
                webRequest.SendWebRequest();
            
                if (webRequest.result == UnityWebRequest.Result.ConnectionError)
                {
                    Debug.Log(webRequest.error);
                }
                else
                {
                    Debug.Log(":\nReceived: " + webRequest.downloadHandler.text);
                    items = webRequest.downloadHandler.text;
                    yield return items;
                }
            }
        }
    }
}