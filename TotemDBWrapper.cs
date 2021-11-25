using System;
using UnityEngine.Networking;
using System.Collections.Generic;

namespace TotemDB {
    public static class TotemDBWrapper {
        #region common

        public Pagination pagination { get; set; }
        public List<ITotem> items { get; set; }

        public static System.Version Version
        {
            get
            {
                return typeof(TotemDBWrapper).Assembly.GetName().Version;
            }
        }

        #endregion

        
        IEnumerator GetAllAvatars() {
            const string URL = "https://x8ki-letl-twmt.n7.xano.io/api:y8B1f40J/avatars";
            UnityWebRequest wr = UnityWebRequest.Get(URL);

            if (wr.result != UnityWebRequest.Result.Success) {
                Debug.Log(wr.error);
                return;
            }
            Debug.Log(wr.data);
            return wr.downloadHandler.data;
        }

        IEnumerator GetAllItems() {
            const string URL = "https://x8ki-letl-twmt.n7.xano.io/api:y8B1f40J/items";
            UnityWebRequest wr = UnityWebRequest.Get(URL);

            if (wr.result != UnityWebRequest.Result.Success) {
                Debug.Log(wr.error);
                return;
            }
            Debug.Log(wr.data);
            return wr.downloadHandler.data;
        }
    }
}