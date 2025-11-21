using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace MyTranslatorProject
{
    public class clsApiConnector
    {
        private static readonly string apiUrl = "https://api.cohere.ai/v1/chat";

        public static async Task<string> ChatWithCohere(string apiKey, string message)
        {
            using (var client = new HttpClient())
            {

                // إعداد الهيدر الصحيح
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                // إنشاء جسم الطلب
                var requestData = new
                {
                    model = "command-a-03-2025",  // أو command-r للخطة المجانية
                    message = message,
                    temperature = 0.7,
                };

                var serializer = new JavaScriptSerializer();
                string jsonContent = serializer.Serialize(requestData);

                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                // 🟢 إرسال الطلب بـ POST (وليس GET!)
                var response = await client.PostAsync(apiUrl, content);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return $"Error : {response.StatusCode}\n{responseContent}";
                }

                // تحليل الرد
                dynamic result = serializer.DeserializeObject(responseContent);

                return result["text"];
            }
        }

        public static string BuildPrompt (string sourceLang, string targetLang, string text)
        {
            return $"If the following text is written in {sourceLang} language," +
                $" translate it into {targetLang} language." +
                $" But if it is written in any other language different from {sourceLang}," +
                $" then translate it into {sourceLang} language." +
                $" However, if the text is not in a human language (for example, if it is code or a link)," +
                $" then return the following text: \"This text is not written in a translatable language\"" +
                $"\n The text to be translated is \"{text}\"" +
                $"\n Do not write anything else other than the translated text, Or," +
                $" if there is no translation, write only the alternative sentence, " +
                $" The text should be standalone without quotation marks or any additions.";
        }
    }
}
