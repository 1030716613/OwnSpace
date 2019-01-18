using qcloudsms_csharp;
using System.Collections.Generic;

namespace Own.Common
{
    public class Utils
    {
        /// <summary>
        /// 腾讯云发短信
        /// </summary>
        public static void TencentSmsMethod()
        {
            //地址：https://console.cloud.tencent.com/sms/smsContent
            // 短信应用SDK AppID
            const int appid = 111;
            // 短信应用SDK AppKey
            const string appkey = "111";
            //模板Id
            int templateId = 269006;
            // 签名 NOTE: 这里的签名只是示例，请使用真实的已申请的签名, 签名参数使用的是`签名内容`，而不是`签名ID`
            string smsSign = "程序源于生活";
            // 需要发送短信的手机号码
            var phoneNumbers = new List<string> { "12", "12" };

            #region 指定模板单发短信   
            //var ssender = new SmsSingleSender(appid, appkey);
            //var result = ssender.sendWithParam("86", phoneNumbers[0],
            //    templateId, new[] { "5678","2" }, smsSign, "", "");  // 签名参数未提供或者为空时，会使用默认签名发送短信

            #endregion

            #region 指定模板群发
            var ssender = new SmsMultiSender(appid, appkey);
            var sresult = ssender.sendWithParam("86", phoneNumbers, templateId,
                new List<string> { "5678", "2" }, null, "", "");  // 签名参数未提供或者为空时，会使用默认签名发送短信

            #endregion
        }
    }
}