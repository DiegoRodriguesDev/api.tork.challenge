import ApiAdapterInterface from "../adapters/http/api-adapter.interface";
import Book from "../entity/book";
import { SearchBy } from "../entity/searchBy.enum";
import EventDispatcher from "../event/@shared/event-dispatcher";
import BookFoundEvent from "../event/book/book-found.event";
import SendLogWhenBooksFoundHandler from "../event/book/handler/send-log-when-book-found.handler";

export default class BookService {

    private api: ApiAdapterInterface;
    
    constructor(api: ApiAdapterInterface) {
        this.api = api;
    }
    
    public async searchBooks(searchBy: SearchBy, search: string): Promise<Book[]> {
        try {
            this.validParams(searchBy, search);
            const books = await this.api.getBooks(searchBy, search);
            if (books.length <= 0) {
                throw Error("Books not found");
            }

            this.eventRegister(books);
            
            return books;
        }
        catch (error) {
           throw error;
        }
        
    }

    private validParams(searchBy: SearchBy, search: string): void {
        if (searchBy == SearchBy.None) {
            throw Error("SearchBy invalid");
        }
        if (!search) {
            throw Error("Search field is empty");
        }
    }

    private eventRegister(books: Book[]) {
        const eventDispatcher = new EventDispatcher();
        const eventHandler = new SendLogWhenBooksFoundHandler();
        eventDispatcher.register("BookFoundEvent", eventHandler);
        
        this.eventNotify(eventDispatcher, books);
    }

    private eventNotify(eventDispatcher: EventDispatcher, books: Book[]) {
        const booksFoundEvent = new BookFoundEvent({
            Count: books.length
        });
        
        eventDispatcher.notify(booksFoundEvent);
    }
}