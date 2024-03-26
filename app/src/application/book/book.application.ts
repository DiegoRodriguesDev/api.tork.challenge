import Book from "../../domain/entity/book";
import { SearchBy } from "../../domain/entity/searchBy.enum";
import BookService from "../../domain/service/book.service";
import Api from "../../infrastructure/http/api";

export default class BookApplication {

    public static async GetBooks(searchBy: SearchBy, search: string): Promise<Book[]> {
        const api = new Api();
        const bookService = new BookService(api);
        return await bookService.searchBooks(searchBy, search);
    }

}