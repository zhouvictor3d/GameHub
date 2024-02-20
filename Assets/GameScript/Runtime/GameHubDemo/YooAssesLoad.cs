using UnityEngine;
using UnityEngine.UI;
using YooAsset;

namespace GameScript.Runtime.GameHubDemo
{
    public class YooAssesLoad : MonoBehaviour
    {

        [SerializeField] private Button btnLoadTheme1;

        [SerializeField] private Button btnLoadTheme2;
        
        // Start is called before the first frame update
        void Start()
        {
          btnLoadTheme1.onClick.AddListener(OnLoadTheme1);
          btnLoadTheme2.onClick.AddListener(OnLoadTheme2);
        }

        private void OnLoadTheme2()
        {
            throw new System.NotImplementedException();
        }

        private void OnLoadTheme1()
        {
            ResourcePackage resourcePackage = YooAssets.CreatePackage("Theme1");
            ResourceDownloaderOperation resourceDownloaderOperation= resourcePackage.CreateResourceDownloader(10, 1);
            resourceDownloaderOperation.BeginDownload();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
 