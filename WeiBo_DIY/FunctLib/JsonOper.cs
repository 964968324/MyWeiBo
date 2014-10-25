using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeiBo_DIY
{
    /// <summary>
    /// 对Json文件进行处理，返回需要的类型值
    /// </summary>
    class JsonOper
    {
        dynamic JsonText;
        public JsonOper(dynamic pJsonTxt)
        {
            JsonText = pJsonTxt;
        }

        void JsonInfo() 
        {
            foreach (KeyValuePair<string, object> sKeyValuePair in JsonText)
            {
                //lstMessage.Items.Insert(0, sKeyValuePair.Value);
                if (sKeyValuePair.Key.ToUpper().ToString() == "STATUSES")
                {
                    dynamic KeyValue = sKeyValuePair.Value;
                    foreach (dynamic Status in KeyValue)
                    {
                        foreach (KeyValuePair<string, object> Pair in Status)
                        {
                            Console.WriteLine (Pair.Key + ":" + Pair.Value);
                        }
                    }
                }
            }

        }
    }
}
