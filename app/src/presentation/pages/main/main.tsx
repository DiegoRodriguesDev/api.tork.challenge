import React, { useState } from 'react';
import './main.css';
import BookTable from './components/book-table';
import FilterTable from './components/filter-table';
import BookApplication from '../../../application/book/book.application';
import { SearchBy } from '../../../domain/entity/searchBy.enum';
import Book from '../../../domain/entity/book';

function Main()
{
  const [books, setBooks] = useState<Book[]>([]);

  const handleFilterClick = async (selectSearchBy: SearchBy, inputSearch: string) =>
  {
    try {
      let booksResponse = await BookApplication.GetBooks(selectSearchBy, inputSearch)
      setBooks(booksResponse);
    }
    catch (error) {
      alert(error)
      setBooks([]);
    }
  }

  return (
    <div className="Main">
      <div className="Main-head">
        <h2>Library | Search for books</h2>
      </div>

      <div className="Main-content">
        <FilterTable onFilterClick={handleFilterClick} />
        <BookTable rows={books} />
      </div>

      <footer>
        Developed by Diego Rodrigues: <br />
        <a href='https://www.linkedin.com/in/diegorodriguesdev/' target="_blank">LinkedIn</a>
      </footer>
    </div>
  );
}

export default Main;
