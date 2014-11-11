using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Media.SpeechSynthesis;
using Bing.Speech;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Streams;
using System.Runtime.Serialization;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MelonCompanion
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;


            
        }
         protected override void OnNavigatedTo(NavigationEventArgs e)
{
    Uri targeturi = new Uri("http://companion.n0url.com/view.php?id=10705");
    w1.Navigate(targeturi);
}

           SpeechRecognizer SR;

           string s1, s2;
        MediaElement mediaElement = new MediaElement();
        int i,l,j;
        public async void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
          
            // Apply credentials from the Windows Azure Data Marketplace.
           
            for (i=0;i<3;i++)
            {
                if (i == 0)
                {
                    
                    var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
                    SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("Hi dear how r u?");
                    mediaElement.SetSource(stream, stream.ContentType);
                    mediaElement.Play();
                   // return;
                   await sprecog();
                  
                
                   
                }
                else
                    if (i == 1)
                    {
                        var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
                        SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync( "What is your name?");
                        mediaElement.SetSource(stream, stream.ContentType);
                        mediaElement.Play();
                       await sprecog();

                       s2 = s1;
                        //return;
                       
                    }
                        else
                        if(i==2)
                        {
                            string s3;
                            s3 = s2.Substring(0, s2.Length - 1);
                            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
                            SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync( s3 +"You look Gorgeous!!");
                            mediaElement.SetSource(stream, stream.ContentType);
                            mediaElement.Play();
                         await   sprecog();
                        }
                    else
                        break;
               }
            
       
            

        }
        
        private void ResultText_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage1));
        }
        public async  Task sprecog()
        {
            var credentials = new SpeechAuthorizationParameters();
            credentials.ClientId = "Melon123";
            credentials.ClientSecret = "rdYPQe/38BLyNPbPa7ReaRIGUANK9DW9T5mSO2L9Dds=";
            SR = new SpeechRecognizer("en-US", credentials);
            try
            {
                var result = await SR.RecognizeSpeechToTextAsync();
                ResultText.Text = result.Text;
               s1 = ResultText.Text;
               return;
            }
            catch (System.Exception ex)
            {
                // ResultText.Text = ex.Message;
                ResultText.Text = ex.Message;
                
            }
            

        }

        private void WebView_LoadCompleted(object sender, NavigationEventArgs e)
        {

           
        }
        
        
    }
}
            // Initialize the speech recognizer.
           // SR = new SpeechRecognizer("en-US", credentials);*/
            /*  SpeechControl.SpeechRecognizer = SR;
              MediaElement mediaElement = new MediaElement();
              var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
              SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("Hello World! Windows can talk!");
              mediaElement.SetSource(stream, stream.ContentType);
              mediaElement.Play();
              return;*/
         /*   try
            {

                // Start speech recognition.
                var result = await SR.RecognizeSpeechToTextAsync();
                //ResultText.Text = result.Text;
                ResultText.Text = result.Text;

                s1 = ResultText.Text;
                int x;

                for (i = 0; i < 5; i++)
                {
                    a = string.Compare(s2[i], s1);
                    if (a == 0)
                    {
                        // r = i;
                        goto x;
                    }


                }
            x:

                if (i == 0)
                {
                    tb3.Text = "asdf";
                    var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
                    SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("Cheer Up");
                    mediaElement.SetSource(stream, stream.ContentType);
                    mediaElement.Play();
                }
                else
                    if (i == 1)
                    {
                        tb3.Text = "sa";
                        var sp = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
                        SpeechSynthesisStream stream = await sp.SynthesizeTextToStreamAsync("Mother Teresa Is a symbol of Love");
                        mediaElement.SetSource(stream, stream.ContentType);
                        mediaElement.Play();

                    }
                    else
                        if (i == 2)
                        {
                            tb3.Text = "ang";
                            var me = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
                            SpeechSynthesisStream stream = await me.SynthesizeTextToStreamAsync("hi baby");
                            mediaElement.SetSource(stream, stream.ContentType);
                            mediaElement.Play();
                        }
                        else
                            if (i == 3)
                            {
                                tb3.Text = "exc";
                                var candy = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
                                SpeechSynthesisStream stream = await candy.SynthesizeTextToStreamAsync("hw do u do?");
                                mediaElement.SetSource(stream, stream.ContentType);
                                mediaElement.Play();
                            }
                            else
                            {
                                tb3.Text = "peaaaaaaaaaceeee";
                                var de = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
                                SpeechSynthesisStream stream = await de.SynthesizeTextToStreamAsync("Chow");
                                mediaElement.SetSource(stream, stream.ContentType);
                                mediaElement.Play();
                                //  if (a == 0)
                                //this.Frame.Navigate(typeof(BlankPage1));
                            }

                


            }
            catch (System.Exception ex)
            {
                // ResultText.Text = ex.Message;
                ResultText.Text = ex.Message;
            }
        }

        private async void SpeakButton_Click(object sender, RoutedEventArgs e)
        {
          
          SpeechControl.SpeechRecognizer = SR;
            try
            {
                // Start speech recognition.
                var result = await SR.RecognizeSpeechToTextAsync();
                //ResultText.Text = result.Text;
                ResultText.Text = result.Text;
                int x;

                for (i = 0; i < 5; i++)
                {
                    a = string.Compare(s2[i], s1);
                    if (a == 0)
                    {
                        // r = i;
                        goto x;
                    }


                }
            x:

                if (i == 0)
                {
                    tb3.Text = "asdf";
                    var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
                    SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("Cheer Up");
                    mediaElement.SetSource(stream, stream.ContentType);
                    mediaElement.Play();
                }
                else
                    if (i == 1)
                    {
                        tb3.Text = "sa";
                        var sp = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
                        SpeechSynthesisStream stream = await sp.SynthesizeTextToStreamAsync("Mother Teresa Is a symbol of Love");
                        mediaElement.SetSource(stream, stream.ContentType);
                        mediaElement.Play();

                    }
                    else
                        if (i == 2)
                        {
                            tb3.Text = "ang";
                            var me = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
                            SpeechSynthesisStream stream = await me.SynthesizeTextToStreamAsync("hi baby");
                            mediaElement.SetSource(stream, stream.ContentType);
                            mediaElement.Play();
                        }
                        else
                            if (i == 3)
                            {
                                tb3.Text = "exc";
                                var candy = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
                                SpeechSynthesisStream stream = await candy.SynthesizeTextToStreamAsync("hw do u do?");
                                mediaElement.SetSource(stream, stream.ContentType);
                                mediaElement.Play();
                            }
                            else
                            {
                                tb3.Text = "peaaaaaaaaaceeee";
                                var de = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
                                SpeechSynthesisStream stream = await de.SynthesizeTextToStreamAsync("Chow");
                                mediaElement.SetSource(stream, stream.ContentType);
                                mediaElement.Play();
                                //  if (a == 0)
                                //this.Frame.Navigate(typeof(BlankPage1));
                            }

                
            }
            catch (System.Exception ex)
            {
                // ResultText.Text = ex.Message;
                ResultText.Text = ex.Message;
            }
        }
       
       // string s2;
       
        string[] s2 = { "Happy.", "Love.", "Mother.", "Excited.", "Peace." };

        private async  void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               
                // Start speech recognition.
                var result = await SR.RecognizeSpeechToTextAsync();
                //ResultText.Text = result.Text;
                ResultText.Text = result.Text;

              s1 = ResultText.Text;
              int x;

              for (i = 0; i < 5; i++)
              {
                  a = string.Compare(s2[i], s1);
                  if (a == 0)
                  {
                      // r = i;
                      goto x;
                  }


              }
                x:
                   
                        if (i == 0)
                        {
                            tb3.Text = "asdf";
                            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
                            SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("Cheer Up");
                            mediaElement.SetSource(stream, stream.ContentType);
                            mediaElement.Play();
                        }
                        else
                            if (i == 1)
                            {
                                tb3.Text = "sa";
                                var sp = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
                                SpeechSynthesisStream stream = await sp.SynthesizeTextToStreamAsync("Mother Teresa Is a symbol of Love");
                                mediaElement.SetSource(stream, stream.ContentType);
                                mediaElement.Play();
                              
                            }
                            else
                                if (i == 2)
                                {
                                    tb3.Text = "ang";
                                    var me = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
                                    SpeechSynthesisStream stream = await me.SynthesizeTextToStreamAsync("hi baby");
                                    mediaElement.SetSource(stream, stream.ContentType);
                                    mediaElement.Play();
                                }
                                else
                                    if (i == 3)
                                    {
                                        tb3.Text = "exc";
                                        var candy = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
                                        SpeechSynthesisStream stream = await candy.SynthesizeTextToStreamAsync("hw do u do?");
                                        mediaElement.SetSource(stream, stream.ContentType);
                                        mediaElement.Play();
                                    }
                                    else
                                    {
                                        tb3.Text = "peaaaaaaaaaceeee";
                                        var de = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
                                        SpeechSynthesisStream stream = await de.SynthesizeTextToStreamAsync("Chow");
                                        mediaElement.SetSource(stream, stream.ContentType);
                                        mediaElement.Play();
                                        //  if (a == 0)
                                        //this.Frame.Navigate(typeof(BlankPage1));
                                    }

                
            }
            catch (System.Exception ex)
            {
                // ResultText.Text = ex.Message;
                ResultText.Text = ex.Message;
            }
        }

        private void ResultText_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }




        int a,  r,flag=0,x;
        static int i;
        private async void Button_Click(object sender, RoutedEventArgs e)
        {

            tb1.Text = s1;

            for (i = 0; i < 5; i++)
            {
                a = string.Compare(s2[i], s1);
                if (a == 0)
                {
                   // r = i;
                    goto x;
                }
            }
            x:
                   
                        if (i == 0)
                        {
                            tb3.Text = "asdf";
                            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
                            SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("Cheer Up");
                            mediaElement.SetSource(stream, stream.ContentType);
                            mediaElement.Play();
                        }
                        else
                            if (i == 1)
                            {
                                tb3.Text = "sa";
                                var sp = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
                                SpeechSynthesisStream stream = await sp.SynthesizeTextToStreamAsync("Mother Teresa Is a symbol of Love");
                                mediaElement.SetSource(stream, stream.ContentType);
                                mediaElement.Play();
                              
                            }
                            else
                                if (i == 2)
                                {
                                    tb3.Text = "ang";
                                    var me = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
                                    SpeechSynthesisStream stream = await me.SynthesizeTextToStreamAsync("hi baby");
                                    mediaElement.SetSource(stream, stream.ContentType);
                                    mediaElement.Play();
                                }
                                else
                                    if (i == 3)
                                    {
                                        tb3.Text = "exc";
                                        var candy = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
                                        SpeechSynthesisStream stream = await candy.SynthesizeTextToStreamAsync("hw do u do?");
                                        mediaElement.SetSource(stream, stream.ContentType);
                                        mediaElement.Play();
                                    }
                                    else
                                    {
                                        tb3.Text = "peaaaaaaaaaceeee";
                                        var de = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
                                        SpeechSynthesisStream stream = await de.SynthesizeTextToStreamAsync("Chow");
                                        mediaElement.SetSource(stream, stream.ContentType);
                                        mediaElement.Play();
                                    }
                    }

       
                
                

            }
           
        }





     /*   private void Button_Click_1(object sender, RoutedEventArgs e)*/
      /*  {
             string s2 = "Hello.";
             int a;
           a=  string.Compare(s2, s1);
           tb2.Text = Convert.ToString(a);
           if (a == 0)
            this.Frame.Navigate(typeof(BlankPage1)); 
        } */


        



        /*private void b1_Click(object sender, RoutedEventArgs e)
        {
            tb2.Text = ResultText.Text;
          
            
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {

            tb2.Text = ResultText.Text;
        }*/

       
   // }

//}

            // Add speech recognition event handlers.
          /*  SR.AudioCaptureStateChanged += SR_AudioCaptureStateChanged;
            SR.AudioLevelChanged += SR_AudioLevelChanged;
            SR.RecognizerResultReceived += SR_RecognizerResultReceived;
        }

        void SR_RecognizerResultReceived(SpeechRecognizer sender,
            SpeechRecognitionResultReceivedEventArgs args)
        {
            IntermediateResults.Text = args.Text;
        }

        void SR_AudioLevelChanged(SpeechRecognizer sender,
            SpeechRecognitionAudioLevelChangedEventArgs args)
        {
            var v = args.AudioLevel;
            if (v > 0) VolumeMeter.Opacity = v / 50;
            else VolumeMeter.Opacity = Math.Abs((v - 50) / 100);
        }

        void SR_AudioCaptureStateChanged(SpeechRecognizer sender,
            SpeechRecognitionAudioCaptureStateChangedEventArgs args)
        {
            // Show the panel that corresponds to the current state.
            switch (args.State)
            {
                case SpeechRecognizerAudioCaptureState.Complete:
                    if (uiState == "ListenPanel" || uiState == "ThinkPanel")
                    {
                        SetPanel(CompletePanel);  
                    }
                    break;
                case SpeechRecognizerAudioCaptureState.Initializing:
                    SetPanel(InitPanel);
                    break;
                case SpeechRecognizerAudioCaptureState.Listening:
                    SetPanel(ListenPanel);
                    break;
                case SpeechRecognizerAudioCaptureState.Thinking:
                    SetPanel(ThinkPanel);
                    break;
                default:
                    break;
            }
        }

        string uiState = "";
        private void SetPanel(StackPanel panel)
        {
            // Hide all the panels.
            InitPanel.Visibility = Visibility.Collapsed;
            ListenPanel.Visibility = Visibility.Collapsed;
            ThinkPanel.Visibility = Visibility.Collapsed;
            CompletePanel.Visibility = Visibility.Collapsed;
            StartPanel.Visibility = Visibility.Collapsed;

            // Show the selected panel and the cancel button.
            panel.Visibility = Visibility.Visible;
            //CancelButton.Visibility = Visibility.Visible;

            uiState = panel.Name;
        }

        
        private async void SpeakButton_Click(object sender, RoutedEventArgs e)
        {
            // Always use a try block because RecognizeSpeechToTextAsync
            // depends on a web service.
            try
            {
                // Start speech recognition.
                var result = await SR.RecognizeSpeechToTextAsync();

                // Display the text.
                FinalResult.Text = result.Text;

                // Show the TextConfidence.
                ShowConfidence(result.TextConfidence);

                // Fill a string array with the alternate results.
                var alternates = result.GetAlternates(5);
                if (alternates.Count > 1)
                {
                    string[] s = new string[alternates.Count];
                    for (int i = 1; i < alternates.Count; i++)
                    {
                        s[i] = alternates[i].Text;
                    }

                    // Populate the alternates ListBox with the array.
                    AlternatesListBox.ItemsSource = s;
                    AlternatesTitle.Visibility = Visibility.Visible;
                }
                else
                {
                    AlternatesTitle.Visibility = Visibility.Collapsed;
                }

                //AlternatesListBox.ItemsSource = result.GetAlternates(5);
            }
            catch (Exception ex)
            {
                // If there's an exception, show it in the Complete panel.
                if (ex.GetType() != typeof(OperationCanceledException))
                {
                    FinalResult.Text = string.Format("{0}: {1}",
                                ex.GetType().ToString(), ex.Message);
                    SetPanel(CompletePanel); 
                }
            }
        }

        private void ShowConfidence(SpeechRecognitionConfidence confidence)
        {
            switch (confidence)
            {
                case SpeechRecognitionConfidence.High:
                    ConfidenceText.Text = "I am almost sure you said:";
                    break;
                case SpeechRecognitionConfidence.Medium:
                    ConfidenceText.Text = "I think you said:";
                    break;
                case SpeechRecognitionConfidence.Low:
                    ConfidenceText.Text = "I think you might have said:";
                    break;
                case SpeechRecognitionConfidence.Rejected:
                    ConfidenceText.Text = "I'm sorry, I couldn't understand you."
                    + " Please click the Cancel button and try again.";
                    break;
            }
        }

       private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            // Cancel the current speech session and return to start.
            SR.RequestCancelOperation();
           SetPanel(StartPanel);
           CancelButton.Visibility= Visibility.Collapsed;
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            // Stop listening and move to Thinking state.
            SR.StopListeningAndProcessAudio();
        }

        private void AlternatesListBox_SelectionChanged(object sender, 
            SelectionChangedEventArgs e)
        {
            // Check in case the ListBox is still empty.
            if (null != AlternatesListBox.SelectedItem)
            {
                // Put the selected text in FinalResult and clear ConfidenceText.
                FinalResult.Text = AlternatesListBox.SelectedItem.ToString();
                ConfidenceText.Text = ""; 
            }
        }
    }
}*/
        /*SpeechRecognizer SR;
        void SpeechRecognizerUx()
        {

        }
        
        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            var credentials = new SpeechAuthorizationParameters();
            credentials.ClientId = "Melon Companion";
            credentials.ClientSecret = "W1ZuAVzsievGFT/1i1o2cg7xWU0q5JWeDZSmdeVb55I=";
            SR = new SpeechRecognizer("en-US", credentials);
            var SpeechControl = new. SpeechRecognizerUx();
    SpeechControl.SpeechRecognizer = SR;
            

        }*/

       

    

    
