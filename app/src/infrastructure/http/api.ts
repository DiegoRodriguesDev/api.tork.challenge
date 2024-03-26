import ApiAdapterInterface from "../../domain/adapters/http/api-adapter.interface";
import Book from "../../domain/entity/book";
import { SearchBy } from "../../domain/entity/searchBy.enum";
import axios from 'axios'

const API_URL = 'https://localhost:44361/'

const api = axios.create({
    baseURL: API_URL
});

export default class Api implements ApiAdapterInterface
{

    async getBooks(searchBy: SearchBy, search: string): Promise<Book[]>
    {
        try
        {
            const method = `v1/Book?searchBy=${searchBy}&search=${search}`;
            const response = await api.get(method);

            const books: Book[] = response.data;

            return books;
        }
        catch (error)
        {
            throw error;
        }
    }

}