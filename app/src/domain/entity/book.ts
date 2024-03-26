export default class Book
{
    private _id: number;
    private _title: string;
    private _firstName: string;
    private _lastName: string;
    private _totalCopies: number;
    private _copiesInUse: number;
    private _type: string;
    private _isbn: string;
    private _category: string;

    constructor(id: number, title: string, firstName: string, lastName: string,
        totalCopies: number, copiesInUse: number, type: string, isbn: string, category: string) 
    {
        this._id = id
        this._title = title
        this._firstName = firstName
        this._lastName = lastName
        this._totalCopies = totalCopies
        this._copiesInUse = copiesInUse
        this._type = type
        this._isbn = isbn
        this._category = category
    }

    get id(): number {
        return this._id;
    }

    get title(): string {
        return this._title;
    }

    get firstName(): string {
        return this._firstName;
    }

    get lastName(): string {
        return this._lastName;
    }

    get totalCopies(): number {
        return this._totalCopies;
    }

    get copiesInUse(): number {
        return this._copiesInUse;
    }

    get isbn(): string {
        return this._isbn;
    }

    get type(): string {
        return this._type;
    }

    get category(): string {
        return this._category;
    }
}