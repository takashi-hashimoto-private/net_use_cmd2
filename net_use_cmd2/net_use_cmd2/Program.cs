using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace net_use_cmd2
{
    class Program
    {
        static void Main(string[] args)
        {

            string user_name = Environment.UserName;

            System.Diagnostics.Process open_singo06 = new System.Diagnostics.Process();
            open_singo06.StartInfo.FileName = "cmd.exe";            // コマンド名
            open_singo06.StartInfo.Arguments = @"net user \\singo06 /user:" + user_name;    // 引数②

            Console.WriteLine(open_singo06.StartInfo.Arguments.ToString());

            open_singo06.StartInfo.CreateNoWindow = true;           // DOSプロンプトの黒い画面を非表示
            open_singo06.StartInfo.UseShellExecute = false;         // プロセスを新しいウィンドウで起動するか否か
            open_singo06.StartInfo.RedirectStandardOutput = true;   // 標準出力をリダイレクトで取得したい
            open_singo06.Start();
        }
    }
}
