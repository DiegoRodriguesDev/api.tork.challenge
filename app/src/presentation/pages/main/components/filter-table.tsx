import React, { useState } from 'react';
import Form from 'react-bootstrap/Form'
import Button from 'react-bootstrap/Button';
import { SearchBy, StringToSearchByEnum } from '../../../../domain/entity/searchBy.enum';

interface FilterTableProps
{
    onFilterClick: (selectSearchBy: SearchBy, inputSearch: string) => void;
}

const FilterTable: React.FC<FilterTableProps> = ({ onFilterClick }) =>
{
    const [selectSearchBy, setSelectSearchBy] = useState('1');
    const [inputSearch, setInputSearch] = useState('');

    const handleClick = () => {
        onFilterClick( StringToSearchByEnum(selectSearchBy), inputSearch);
    }

    const handleSelectChange = (event: React.ChangeEvent<HTMLSelectElement>) => {
        setSelectSearchBy(event.target.value);
    }

    const handleInputChange = (event: React.ChangeEvent<HTMLInputElement>) => {
        setInputSearch(event.target.value);
    }

    return (
        <div className='filter'>
            <div className='component-filter'>
                <Form.Label>Search By:</Form.Label>
                <Form.Select value={selectSearchBy} onChange={handleSelectChange}>
                    <option value="1">Title</option>
                    <option value="2">Category</option>
                </Form.Select>
            </div>

            <div className='component-filter'>
                <Form.Label>Your search:</Form.Label>
                <Form.Control type="text" value={inputSearch} onChange={handleInputChange} />
            </div>

            <div className='filter-button'>
                <Button variant="primary" onClick={handleClick}>Apply</Button>
            </div>
        </div>
    )
}

export default FilterTable;