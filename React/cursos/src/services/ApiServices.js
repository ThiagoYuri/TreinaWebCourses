const api = "http://localhost:3002/api/react-cursos/";
export const ApiServices = {
    get(endpoint){
        return fetch(`${api}${endpoint}`)
        .then(reponse => reponse.json());
    },
    post(endpoint,data){
        return fetch(`${api}${endpoint}`,
        {
            method:"POST",
            body:JSON.stringify(data)
        }).then(reponse => reponse.json());
        
    },
    delete(endpoint,id){
        return fetch(`${api}${endpoint}?id=${id}`,
        {
            method:"DELETE",           
        }).then(reponse => reponse.json());
        
    }
}