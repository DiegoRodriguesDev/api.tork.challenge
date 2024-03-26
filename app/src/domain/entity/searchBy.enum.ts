export enum SearchBy {
    None = "0",
    Title = "1",
    Category = "2",
}

export function StringToSearchByEnum(value: string): SearchBy {
    switch(value) {
        case "1": return SearchBy.Title;
        case "2": return SearchBy.Category;
        default: return SearchBy.None
    }
}