using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;

namespace TTSApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SpeakButton_Click(object sender, EventArgs e)
        {


          SpeechSynthesizer synth = new SpeechSynthesizer();
          synth.Rate = SpeedTrackBar.Value;
          synth.Volume = SoundTrackBar.Value;
          if (PersonComboBox.Text == "Male")
          {
              synth.SelectVoiceByHints(VoiceGender.Male);
          }
          if (PersonComboBox.Text == "Female")
          {
              synth.SelectVoiceByHints(VoiceGender.Female);
          }
            synth.Speak(SpeechTextBox.Text);

        }
    }
}
