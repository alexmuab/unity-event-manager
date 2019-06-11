

public class TestEventManager : MonoBehaviour{

    private void Start(){
        // subscribing to START_GAME EVENT    
        EventManager.StartListening(EventManager.EVENT_TYPE.START_GAME, OnInitGame);
    }

    /// <summary>
    /// This function is called when START_GAME event is triggered 
    /// getting an EventParam as parameter
    /// </summary>
    private void OnInitGame(EventParam evParam)
    {
        // ... do something

        // triggering the event INITIALIZE and passing as parameter an EventParam with a string value
        EventManager.TriggerEvent(
                EventManager.EVENT_TYPE.INITIALIZE, 
                new EventParam{ strParam = "Game initialized"; }
                );
    }

    private void OnDestroy() {
        // stop listening START_GAME event
        EventManager.StopListening(EventManager.EVENT_TYPE.START_GAME, OnInitGame);
    }
}