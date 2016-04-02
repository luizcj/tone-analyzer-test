using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace ToneAnalyzerTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            string baseURL;
            string username;
            string password;

            // Set the URL to the Tone Analyzer service and creds for the instance of the service ToneAnalyzer-tutorial-dsiebold
            // Be sure to set these vars or the text controls with the username and password of your instance of the Tone Analyzer service
            baseURL = "https://gateway.watsonplatform.net/tone-analyzer-beta/api/v3/tone?version=2016-02-11&sentences=false";
            username = txtUsername.Text;
            password = txtPassword.Text;

            // Get the data to be analyzed for tone
            string postData = "{\"text\": \"" + txtInput.Text + "\"}";

            // Create the web request
            var request = (HttpWebRequest)WebRequest.Create(baseURL);

            // Configure the BlueMix credentials
            string auth = string.Format("{0}:{1}", username, password);
            string auth64 = Convert.ToBase64String(Encoding.ASCII.GetBytes(auth));
            string credentials = string.Format("{0} {1}", "Basic", auth64);

            // Set the web request parameters
            request.Headers[HttpRequestHeader.Authorization] = credentials;
            request.Method = "POST";
            request.Accept = "application/json";
            request.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            // Set the ContentLength property of the WebRequest
            request.ContentLength = byteArray.Length;

            // Get the request stream
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length);
           
            // Get the response
            WebResponse response = request.GetResponse();
            // Display the status
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the service
            dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access
            StreamReader reader = new StreamReader(dataStream);
            // Read and format the content
            string responseFromServer = reader.ReadToEnd();
            responseFromServer = ToneAnalyzerTools.JsonPrettify(responseFromServer);
            // Display the content
            txtOutput.Text = responseFromServer;
            
            // Resets all the charts
            ResetChart();
            // Configure the chart that displays emotion scores
            crtEmotion.Titles.Add("Emotion");
            crtEmotion.Series.Add("Emotions");
            crtEmotion.Series["Emotions"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            crtEmotion.Series["Emotions"].IsVisibleInLegend = false;
            crtEmotion.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.Gainsboro;
            crtEmotion.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.Gainsboro;
            crtEmotion.ChartAreas["ChartArea1"].AxisX.LineColor = Color.Gainsboro;
            crtEmotion.ChartAreas["ChartArea1"].AxisY.LineColor = Color.Gainsboro;
            crtEmotion.ChartAreas["ChartArea1"].AxisY.Maximum = 1;
            crtEmotion.ChartAreas["ChartArea1"].BackColor = Color.Transparent;

            // Configure the chart that displays writing scores
            crtLanguage.Titles.Add("Language/Writing");
            crtLanguage.Series.Add("Language");
            crtLanguage.Series["Language"].IsVisibleInLegend = false;
            crtLanguage.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.Gainsboro;
            crtLanguage.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.Gainsboro;
            crtLanguage.ChartAreas["ChartArea1"].AxisX.LineColor = Color.Gainsboro;
            crtLanguage.ChartAreas["ChartArea1"].AxisY.LineColor = Color.Gainsboro;
            crtLanguage.ChartAreas["ChartArea1"].AxisY.Maximum = 1;
            crtLanguage.ChartAreas["ChartArea1"].BackColor = Color.Transparent;

            // Configure the chart that displays social scores
            crtSocial.Titles.Add("Social");
            crtSocial.Series.Add("Social");
            crtSocial.Series["Social"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            crtSocial.Series["Social"].Color = Color.CadetBlue;
            crtSocial.Series["Social"].IsVisibleInLegend = false;
            crtSocial.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.Gainsboro;
            crtSocial.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.Gainsboro;
            crtSocial.ChartAreas["ChartArea1"].AxisX.LineColor = Color.Gainsboro;
            crtSocial.ChartAreas["ChartArea1"].AxisY.LineColor = Color.Gainsboro;
            crtSocial.ChartAreas["ChartArea1"].IsSameFontSizeForAllAxes = true;
            crtSocial.ChartAreas["ChartArea1"].AxisY.Maximum = 1;
            crtSocial.ChartAreas["ChartArea1"].BackColor = Color.Transparent;


            // Dynamically assign the JSON to objects
            JObject DocumentTone = JObject.Parse(responseFromServer);
            JArray ToneCategories = (JArray)DocumentTone["document_tone"]["tone_categories"];
            
            // Loop through the categories returned in the JSON
            dynamic categories = ToneCategories;
            foreach (dynamic category in categories)
            {
                // Random troubleshooting code; did this in the beginning to check values
                Console.WriteLine(category.category_id);
                Console.WriteLine(category.category_name);

                // Add the emotion scores to the chart
                // This is the brute force approach; it's likely this can be done by assigning an array to the datasource of the chart
                // or something elegant like that
                if (category.category_id == "emotion_tone")
                {
                    int i = 0;
                    foreach (dynamic tone in category.tones)
                     
                    {
                        switch ((string)tone.tone_id)
                        {
                            case "anger":
                                crtEmotion.Series["Emotions"].Points.AddXY((string)tone.tone_name, (double)tone.score);
                                crtEmotion.Series["Emotions"].Points[i].Color = Color.Red;
                                i++;
                                break;
                            case "disgust":
                                crtEmotion.Series["Emotions"].Points.AddXY((string)tone.tone_name, (double)tone.score);
                                crtEmotion.Series["Emotions"].Points[i].Color = Color.Purple;
                                i++;
                                break;
                            case "fear":
                                crtEmotion.Series["Emotions"].Points.AddXY((string)tone.tone_name, (double)tone.score);
                                crtEmotion.Series["Emotions"].Points[i].Color = Color.Green;
                                i++;
                                break;
                            case "joy":
                                crtEmotion.Series["Emotions"].Points.AddXY((string)tone.tone_name, (double)tone.score);
                                crtEmotion.Series["Emotions"].Points[i].Color = Color.Yellow;
                                i++;
                                break;
                            case "sadness":
                                crtEmotion.Series["Emotions"].Points.AddXY((string)tone.tone_name, (double)tone.score);
                                crtEmotion.Series["Emotions"].Points[i].Color = Color.Blue;
                                i++;
                                break;
                        }
                    }
                }

                // Add the language/writing scores to the chart
                if (category.category_id == "writing_tone")
                {                
                    foreach (dynamic tone in category.tones)
                    {
                        crtLanguage.Series["Language"].Points.AddXY((string)tone.tone_name, (double)tone.score);
                    }
                }

                // Add the social scores to the chart
                if (category.category_id == "social_tone")
                {
                    foreach (dynamic tone in category.tones)
                    {
                        crtSocial.Series["Social"].Points.AddXY((string)tone.tone_name, (double)tone.score);
                    }
                }
            }

            // Sort the emotion chart by emotion names; it just so happens the alphabetical order matches the priority order
            // The emotions like anger and disgust should be at the top of the chart
            crtEmotion.DataManipulator.Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder.Descending, "AxisLabel", "Emotions");

            // Clean up the streams.
            reader.Close();
            dataStream.Close();
            response.Close();


        }
        private void ResetChart()
        {
            {
                crtEmotion.DataSource = null;
                crtEmotion.Series.Clear();
                crtEmotion.ChartAreas[0].AxisX.Interval = 0;
                crtEmotion.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
                crtEmotion.ChartAreas[0].AxisX.CustomLabels.Clear();
                crtEmotion.ChartAreas[0].Area3DStyle.Enable3D = false;
                crtEmotion.Titles.Clear();
                crtEmotion.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.All;

                crtLanguage.DataSource = null;
                crtLanguage.Series.Clear();
                crtLanguage.ChartAreas[0].AxisX.Interval = 0;
                crtLanguage.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
                crtLanguage.ChartAreas[0].AxisX.CustomLabels.Clear();
                crtLanguage.ChartAreas[0].Area3DStyle.Enable3D = false;
                crtLanguage.Titles.Clear();
                crtLanguage.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.All;

                crtSocial.DataSource = null;
                crtSocial.Series.Clear();
                crtSocial.ChartAreas[0].AxisX.Interval = 0;
                crtSocial.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
                crtSocial.ChartAreas[0].AxisX.CustomLabels.Clear();
                crtSocial.ChartAreas[0].Area3DStyle.Enable3D = false;
                crtSocial.Titles.Clear();
                crtSocial.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.All;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

     }
}
