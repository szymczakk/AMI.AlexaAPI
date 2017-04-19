using System.Threading.Tasks;
using AlexaSkillsKit.Speechlet;
using AlexaSkillsKit.UI;

namespace AMI.AlexaAPI.Services
{
    public class MySpeechletServiceAsync: SpeechletAsync
    {
        string wellcomeResponse = "Hi! I'm answering from selfhosted server.";
        public override Task OnSessionStartedAsync(SessionStartedRequest sessionStartedRequest, Session session)
        {
            return new Task(() => { });
        }

        public override Task OnSessionEndedAsync(SessionEndedRequest sessionEndedRequest, Session session)
        {
            return new Task(() => { });
        }

        public override Task<SpeechletResponse> OnIntentAsync(IntentRequest intentRequest, Session session)
        {
            return new Task<SpeechletResponse>(() => { 
                return BuildSpeechletResponse("Title", "Hello", true); 
            });
        }

        public override Task<SpeechletResponse> OnLaunchAsync(LaunchRequest launchRequest, Session session)
        {
            return new Task<SpeechletResponse>(() => { return BuildSpeechletResponse("", "", true); });
        }

        /**
         * Creates and returns the visual and spoken response with shouldEndSession flag
         * 
         * @param title
         *            title for the companion application home card
         * @param output
         *            output content for speech and companion application home card
         * @param shouldEndSession
         *            should the session be closed
         * @return SpeechletResponse spoken and visual response for the given input
         */
        private SpeechletResponse BuildSpeechletResponse(string title, string output, bool shouldEndSession) {
            // Create the Simple card content.
            SimpleCard card = new SimpleCard();
            card.Title = string.Format("SessionSpeechlet - {0}", title);
            card.Subtitle = string.Format("SessionSpeechlet - Sub Title");
            card.Content = string.Format("SessionSpeechlet - {0}", output);

            // Create the plain text output.
            PlainTextOutputSpeech speech = new PlainTextOutputSpeech();
            speech.Text = output;

            // Create the speechlet response.
            SpeechletResponse response = new SpeechletResponse();
            response.ShouldEndSession = shouldEndSession;
            response.OutputSpeech = speech;
            response.Card = card;
            return response;
        }
    }
}