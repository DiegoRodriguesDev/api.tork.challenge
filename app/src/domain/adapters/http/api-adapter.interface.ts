import Book from "../../entity/book";
import { SearchBy } from "../../entity/searchBy.enum";

export default interface ApiAdapterInterface {
    getBooks(searchBy: SearchBy, search: string): Promise<Book[]>
}