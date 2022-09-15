using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;


namespace FunctionApp12345
{
    public class Class2
    {
       
        public static byte[] DownloadBlob(string connectionString, string containerName, string blobName, string folderName = null)
        {
            
            BlobContainerClient blobContainerClient = new BlobContainerClient(connectionString, containerName);
            BlobClient blobClient;
            // BlobClient blobClient = new BlobContainerClient(connectionString, containerName);

            var allBlobs = blobContainerClient.GetBlobs();
            // blobClient.GetBlobClient((!string.IsNullOrEmpty(folderName)) ? (folderName + "/" + blobName) : blobName);
            List<string> listFiles = new List<string>();

            foreach (var blob in allBlobs)
            {
                blobClient = blobContainerClient.GetBlobClient(blob.Name);
                if ((bool)blobClient.Exists())
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        BlobDownloadInfo blobDownloadInfo = blobClient.Download();
                        var streamRdr = new StreamReader(blobDownloadInfo.Content);
                        string filecontent = streamRdr.ReadToEnd();
                        var singleObj = JsonConvert.DeserializeObject<ZoomJsonCallLogModel>(filecontent);
                    }
                    
                   // MemoryStream memoryStream = new MemoryStream();
                   // memoryStream.BeginRead()

                    //using (MemoryStream memoryStream = new MemoryStream())
                    //{
                    //   // ((BlobDownloadInfo)blobClient.Download()).Content.CopyTo(memoryStream);

                    //    using (FileStream file = new FileStream(blob.Name, FileMode.Create, System.IO.FileAccess.Write))
                    //    memoryStream.CopyTo(file);
                    //   // return memoryStream.ToArray();
                    //}
                }
            }
            

            return null;
        
        
        }
    }
}
