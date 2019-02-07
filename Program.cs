using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Witchhunt2019
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> PRList = new List<string>();

            ReadPRInfo(PRList);
            DisplayPRInfo(PRList);
        }

        public static void ReadPRInfo(List<string> PRList)
        {
            /*
            PRList.Add("PR 1");
            PRList.Add("PR 2");
            PRList.Add("PR 3");
            PRList.Add("PR 4"); */
            /*
            var co = new CloneOptions();
            co.CredentialsProvider = (_url, _user, _cred) => new UsernamePasswordCredentials
            {
                Username = "username",
                Password = "password"
            };

            var clonedRepoPath = Repository.Clone(url, "path/to/clone", co);

            using (var repo = new Repository(clonedRepoPath))
            {
                foreach (Commit commit in repo.Commits)
                {

                    Console.WriteLine(commit.Author.Name);

                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
            }*/

            //HttpWebRequest request = WebRequest.Create("https://github.docusignhq.com/martini/prepare/pull/23/files") as HttpWebRequest;
            //HttpWebRequest request = WebRequest.Create("https://github.docusignhq.com/users/cristina.cris/repos?sort=pushed") as HttpWebRequest;
            //HttpWebRequest request = WebRequest.Create("https://github.docusignhq.com/users/cristina.cris/repos?sort=pushed") as HttpWebRequest;
            HttpWebRequest request = WebRequest.Create("https://github.docusignhq.com/api/v3") as HttpWebRequest;

            // repos /:cristina.cris /:martini/app/ pulls
            request.Credentials = CredentialCache.DefaultNetworkCredentials;
            request.Method = "GET";
            request.Proxy = null;

            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    Console.Write(reader.ReadToEnd());
                }
            }
        }

            public static void DisplayPRInfo (List<string> PRList)
        {
            foreach (string pr in PRList)
            {
                Console.WriteLine(pr);
            }
        }
    }
}
