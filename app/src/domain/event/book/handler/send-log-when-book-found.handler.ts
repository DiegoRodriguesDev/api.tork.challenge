import EventHandlerInterface from "../../@shared/event-handler.interface";
import BookFoundEvent from "../book-found.event";

export default class SendLogWhenBooksFoundHandler implements EventHandlerInterface<BookFoundEvent> {
    
    handle(event: BookFoundEvent): void
    {
        console.log(`Books found: ${event.eventData.Count}`);
    }
    
}