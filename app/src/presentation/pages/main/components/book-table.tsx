import Book from '../../../../domain/entity/book';
import Table from 'react-bootstrap/Table'

interface BookTableProps
{
    rows: Book[];
}

const BookTable: React.FC<BookTableProps> = ({ rows }) =>
{
    return (
        <div>
            <Table striped bordered hover variant="dark">
                <thead>
                    <tr>
                        <th>Title</th>
                        <th>First Name</th>
                        <th>Last Name</th>
                        <th>Total Copies</th>
                        <th>Copies In Use</th>
                        <th>Type</th>
                        <th>Isbn</th>
                        <th>Category</th>
                    </tr>
                </thead>
                <tbody>
                    {
                        rows.map(book => (
                            <tr key={book.id}>
                                <td>{book.title}</td>
                                <td>{book.firstName}</td>
                                <td>{book.lastName}</td>
                                <td>{book.totalCopies}</td>
                                <td>{book.copiesInUse}</td>
                                <td>{book.type}</td>
                                <td>{book.isbn}</td>
                                <td>{book.category}</td>
                            </tr>
                        ))
                    }
                </tbody>
            </Table>
        </div>
    )
}
export default BookTable;