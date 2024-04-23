using System.Net;

namespace TS_Video_Stream_downloader
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string str = "http://di2g5yar1p6ph.cloudfront.net/61F3B413-B7B8-BB3D-6CD0-F99CD0AFCD23/passthru.hls/media-uvo0kzpcd_";
            string address1 = str + "56_s.ts";
            string fileName1 = "1.ts";
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile(address1, fileName1);
                Console.WriteLine("Downloaded 1 of 658");
                int num;
                for (int index = 57; index < 714; num = index++)
                {
                    string address2 = str + (object)index + ".ts";
                    num = index - 55;
                    string fileName2 = num.ToString() + ".ts";
                    webClient.DownloadFile(address2, fileName2);
                    Console.Clear();
                    Console.WriteLine("Downloaded " + (object)(index - 55) + " of 658");
                }
            }
            Console.WriteLine("Finished: Press any key to continue.");
            Console.Read();
        }
    }
}