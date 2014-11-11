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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MelonCompanion
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        public BlankPage1()
        {
            this.InitializeComponent();
            this.Loaded += BlankPage1_Loaded;

        }
        SpeechRecognizer SR;
        MediaElement mediaElement = new MediaElement();
        string s1;
        public async void BlankPage1_Loaded(object sender, RoutedEventArgs r)
        {
            var credentials = new SpeechAuthorizationParameters();
            credentials.ClientId = "MelonCompanion";
            credentials.ClientSecret = "HA/XeR06Ed/3bfM/MQXydP1Q4BdnoJGZ5pXBBVBB7YU=";
            SR = new SpeechRecognizer("en-US", credentials);
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



        
        
    

