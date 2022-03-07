import { ApiServices } from "./ApiServices";

const endpoint = 'category';

export const CategoryService ={
    list(){
        return ApiServices.get(endpoint);
    },
}