import { ApiServices } from "./ApiServices";

const endpoint = 'courses';

export const CourseService ={
    list(){
        return ApiServices.get(endpoint);
    },
    create(newCourse){
        return ApiServices.post(endpoint,newCourse)
    },
    remove(courseId){
        return ApiServices.delete(endpoint,courseId)
    }
}