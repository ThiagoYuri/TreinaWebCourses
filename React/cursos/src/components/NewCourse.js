import React,{Component} from "react";

class NewCourse extends Component{
    static defaultProps={
        onSubmit: ()=>{},
        categories:[]        
    }

    constructor(props){
        super(props);
        this.state={
            name:"",
            category:"",
            image:""
        }
        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    handleSubmit(event){
        event.preventDefault();
        const newCourse = this.state;
        if(newCourse.name && newCourse.image && newCourse.category){
            this.props.onSubmit(newCourse);
            this.setState({
                name:"",
                image:"",
            })
        }
    }

    handleChange(event){
        const {target} = event,
        {name,value} = target;

        this.setState({
            [name]:value,  
        }
        )

    }

    render(){
        const {props,state }= this;
        return (
            <form className="course-form" onSubmit={this.handleSubmit}>
                <label>
                    <span>Nome:</span>
                    <input name="name" value={state.name} onChange={this.handleChange}></input>
                </label>

                <label>
                    <span>Image:</span>
                    <input name="image" value={state.image} onChange={this.handleChange}></input>
                </label>

                <label>
                    <span>Category:</span>
                    <select name="category" value={state.category} onChange={this.handleChange}>
                        <option name="">Selecionar</option>
                        {
                            props.categories.map(x=> <option name={x.name}>{x.name}</option>)
                        }
                        
                    </select>
                </label>
                <button type="subimit">Criar Curso</button>
            </form>
        )
    }
}


export default NewCourse;