using AlexaSkillsKit.Speechlet;
using AlexaSkillsKit.UI;

namespace AMI.AlexaAPI.Services
{
  public class MySpeechletService : Speechlet
  {
    public override void OnSessionStarted(SessionStartedRequest sessionStartedRequest, Session session)
    {
    }

    public override void OnSessionEnded(SessionEndedRequest sessionEndedRequest, Session session)
    {
    }

    public override SpeechletResponse OnIntent(IntentRequest intentRequest, Session session)
    {
      return BuildSpeechletResponse("Title", "Hello", true);
    }

    public override SpeechletResponse OnLaunch(LaunchRequest launchRequest, Session session)
    {
      return BuildSpeechletResponse("t", "HI", true);
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
    private SpeechletResponse BuildSpeechletResponse(string title, string output, bool shouldEndSession)
    {
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