using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.IO;
using System.Collections.Generic;
using System.Data.SQLite;

namespace HATCH_2023
{
    public partial class Dashboard : Form
    {
        private const string API_KEY = "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";
        private const string API_URL = "https://api.openai.com/v1/completions";
        private readonly SpeechSynthesizer _synthesizer;
        private readonly List<string> _conversation;
        public string myreader2;
        Login login = new Login();
        SaveFileDialog saveFileDialog = new SaveFileDialog();

        public Dashboard()
        {

            login.ShowDialog();
            InitializeComponent();
            myreader2 = login.myreader2;
            _synthesizer = new SpeechSynthesizer();
            _conversation = new List<string>();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exportBTN_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Text File|*.txt";
            saveFileDialog.Title = "Save conversation transcript";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
                {
                    streamWriter.WriteLine(responseTXT.Text);
                }
            }
        }



        private async void submitBTN_Click(object sender, EventArgs e)
        {
            string prompt = questionTXT.Text;

            if (!string.IsNullOrWhiteSpace(prompt))
            {
                JObject requestBody = new JObject(
                    new JProperty("model", "text-davinci-003"),
                    new JProperty("prompt", prompt),
                    new JProperty("temperature", 0.7),
                    new JProperty("max_tokens", 256),
                    new JProperty("top_p", 1),
                    new JProperty("frequency_penalty", 0),
                    new JProperty("presence_penalty", 0.6)

                );

                string requestBodyString = requestBody.ToString();

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + API_KEY);
                    StringContent content = new StringContent(requestBodyString, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(API_URL, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseString = await response.Content.ReadAsStringAsync();
                        JObject jsonResponse = JObject.Parse(responseString);
                        string generatedText = jsonResponse["choices"][0]["text"].ToString();

                        responseTXT.AppendText(generatedText + Environment.NewLine);

                        // Text-to-speec
                        var synth = new SpeechSynthesizer();
                        synth.Speak(generatedText);
                    }
                    else
                    {
                        MessageBox.Show("Error: " + response.StatusCode);
                    }
                }
            }
        }

        private void voiceBTN_Click(object sender, EventArgs e)
        {
            _synthesizer.SpeakAsync("Please speak.");
            var recognizer = new System.Speech.Recognition.SpeechRecognitionEngine();
            recognizer.SetInputToDefaultAudioDevice();
            recognizer.LoadGrammar(new System.Speech.Recognition.DictationGrammar());
            recognizer.RecognizeAsync(System.Speech.Recognition.RecognizeMode.Multiple);
            recognizer.SpeechRecognized += (s, args) =>
            {
                questionTXT.Text = args.Result.Text;
                submitBTN.PerformClick();
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void rapBTN_Click_1(object sender, EventArgs e)
        {
            questionTXT.Text += ", but in the form of a rap.";
            string prompt = questionTXT.Text;

            if (!string.IsNullOrWhiteSpace(prompt))
            {
                JObject requestBody = new JObject(
                    new JProperty("model", "text-davinci-003"),
                    new JProperty("prompt", prompt),
                    new JProperty("temperature", 0.7),
                    new JProperty("max_tokens", 256),
                    new JProperty("top_p", 1),
                    new JProperty("frequency_penalty", 0),
                    new JProperty("presence_penalty", 0.6)

                );

                string requestBodyString = requestBody.ToString();

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + API_KEY);
                    StringContent content = new StringContent(requestBodyString, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(API_URL, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseString = await response.Content.ReadAsStringAsync();
                        JObject jsonResponse = JObject.Parse(responseString);
                        string generatedText = jsonResponse["choices"][0]["text"].ToString();

                        responseTXT.AppendText(generatedText + Environment.NewLine);
                    }
                    else
                    {
                        MessageBox.Show("Error: " + response.StatusCode);
                    }
                }
            }
        }

        private async void twitterBTN_Click(object sender, EventArgs e)
        {
            questionTXT.Text += ", but in the form of a tweet.";
            string prompt = questionTXT.Text;

            if (!string.IsNullOrWhiteSpace(prompt))
            {
                JObject requestBody = new JObject(
                    new JProperty("model", "text-davinci-003"),
                    new JProperty("prompt", prompt),
                    new JProperty("temperature", 0.7),
                    new JProperty("max_tokens", 256),
                    new JProperty("top_p", 1),
                    new JProperty("frequency_penalty", 0),
                    new JProperty("presence_penalty", 0.6)

                );

                string requestBodyString = requestBody.ToString();

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + API_KEY);
                    StringContent content = new StringContent(requestBodyString, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(API_URL, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseString = await response.Content.ReadAsStringAsync();
                        JObject jsonResponse = JObject.Parse(responseString);
                        string generatedText = jsonResponse["choices"][0]["text"].ToString();

                        responseTXT.AppendText(generatedText + Environment.NewLine);
                    }
                    else
                    {
                        MessageBox.Show("Error: " + response.StatusCode);
                    }
                }
            }
        }

        private async void blogBTN_Click(object sender, EventArgs e)
        {
            questionTXT.Text += ", but in the form of a 500 word blog post.";
            string prompt = questionTXT.Text;

            if (!string.IsNullOrWhiteSpace(prompt))
            {
                JObject requestBody = new JObject(
                    new JProperty("model", "text-davinci-003"),
                    new JProperty("prompt", prompt),
                    new JProperty("temperature", 0.7),
                    new JProperty("max_tokens", 256),
                    new JProperty("top_p", 1),
                    new JProperty("frequency_penalty", 0),
                    new JProperty("presence_penalty", 0.6)

                );

                string requestBodyString = requestBody.ToString();

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + API_KEY);
                    StringContent content = new StringContent(requestBodyString, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(API_URL, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseString = await response.Content.ReadAsStringAsync();
                        JObject jsonResponse = JObject.Parse(responseString);
                        string generatedText = jsonResponse["choices"][0]["text"].ToString();

                        responseTXT.AppendText(generatedText + Environment.NewLine);
                    }
                    else
                    {
                        MessageBox.Show("Error: " + response.StatusCode);
                    }
                }
            }
        }

        private async void essayBTN_Click(object sender, EventArgs e)
        {
            questionTXT.Text += ", but in the form of a 750 word essay.";
            string prompt = questionTXT.Text;

            if (!string.IsNullOrWhiteSpace(prompt))
            {
                JObject requestBody = new JObject(
                    new JProperty("model", "text-davinci-003"),
                    new JProperty("prompt", prompt),
                    new JProperty("temperature", 0.7),
                    new JProperty("max_tokens", 256),
                    new JProperty("top_p", 1),
                    new JProperty("frequency_penalty", 0),
                    new JProperty("presence_penalty", 0.6)

                );

                string requestBodyString = requestBody.ToString();

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + API_KEY);
                    StringContent content = new StringContent(requestBodyString, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(API_URL, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseString = await response.Content.ReadAsStringAsync();
                        JObject jsonResponse = JObject.Parse(responseString);
                        string generatedText = jsonResponse["choices"][0]["text"].ToString();

                        responseTXT.AppendText(generatedText + Environment.NewLine);
                    }
                    else
                    {
                        MessageBox.Show("Error: " + response.StatusCode);
                    }
                }
            }
        }

        private void jokeBTN_Click(object sender, EventArgs e)
        {
            questionTXT.Text += ", but in the form of a joke.";
            string prompt = questionTXT.Text;

            if (!string.IsNullOrWhiteSpace(prompt))
            {
                JObject requestBody = new JObject(
                    new JProperty("model", "text-davinci-003"),
                    new JProperty("prompt", prompt),
                    new JProperty("temperature", 0.7),
                    new JProperty("max_tokens", 256),
                    new JProperty("top_p", 1),
                    new JProperty("frequency_penalty", 0),
                    new JProperty("presence_penalty", 0.6)

                );

                string requestBodyString = requestBody.ToString();

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + API_KEY);
                    StringContent content = new StringContent(requestBodyString, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(API_URL, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseString = await response.Content.ReadAsStringAsync();
                        JObject jsonResponse = JObject.Parse(responseString);
                        string generatedText = jsonResponse["choices"][0]["text"].ToString();

                        responseTXT.AppendText(generatedText + Environment.NewLine);
                    }
                    else
                    {
                        MessageBox.Show("Error: " + response.StatusCode);
                    }
                }
            }
    }
}
