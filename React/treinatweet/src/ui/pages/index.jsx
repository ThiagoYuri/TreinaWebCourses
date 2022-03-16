import { useIndex } from "../../data/hooks/pages/useIndex.page"
import TextInput from "../components/inputs/TextInput/TextInput";
import Tweet from "../components/data-display/Tweet/Tweet";
import styles from '../styles/pages/index.module.css'

const tweet = {
    date:'há 5 dias',
    text:'Meu Primeiro tweet',
    user:{
        name:'Thiago Yuri',
        username:'thiagoyuri',
        picture:'https://github.com/ThiagoYuri.png'
    }
}

export default function Index(){
    useIndex();
    return (
    <div>        
        <Tweet tweet={tweet}/>
        <TextInput/>
    </div>
    );
}