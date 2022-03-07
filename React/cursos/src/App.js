import React,{Component} from 'react';

import './App.css'; 
import Courses from "./components/Course"
import NewCourse from './components/NewCourse';

import {CourseService} from './services/CourseService'
import {CategoryService} from './services/CategoryService'

class App extends Component {

  constructor(props){
    super(props);
    this.state ={
      courses:
      [     
      ],
    }
    this.startData = this.startData.bind(this);
    this.remove = this.remove.bind(this);
    this.add = this.add.bind(this);

    this.startData();
  }

  async startData(){
    const [courses,categories]=await Promise.all([
      CourseService.list(),
      CategoryService.list()
    ])
    this.setState({
      courses,
      categories
    });
  }

  async add(course){
    
      const {courses} = this.state,
      newCourse = await CourseService.create(course);
      console.log(JSON.stringify(newCourse))
      console.log(JSON.stringify(course))
      courses.push(newCourse);
      this.setState({course});
  }

  async remove(courseId){
    const {courses} = this.state,
      courseIndex = courses.findIndex(c=> c.id==courseId);
      await CourseService.remove(courseId)
      courses.splice(courseIndex,1);
      this.setState({courses});
  }

  render() {
    const {state} = this;
    return (
      <div className="App">  
          <NewCourse onSubmit={this.add} categories={state.categories}/>
          <hr/>
          <ul className='courses-list'>
            {
              state.courses.map(c => <Courses course={c} onRemove={this.remove} />)
            }
          </ul>

      </div>
    );    
  }

}

export default App;
