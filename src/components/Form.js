import React,{useState} from 'react'

const Form = () => {
    const[score, setScore] = useState("10");
    const[comment, setComment] = useState("")
    const handleSubmit = (e)=>{
        e.preventDefault();
        if(Number(score)<=5 && comment.length<=10){
            alert("Please let us know why your experience was poor")
        }
        setComment(" ")
        setScore("10")
    }
  return (
    <div>
        <form onSubmit={handleSubmit}>
        <fieldset>
            <h2>Feedback Form</h2>
            <div className='field'>
                <label htmlFor='range'>Score: {score}</label>
                <input type="range" id="range" min="0" max="10" value={score} onChange={e=>{setScore(e.target.value)}}/>
            </div>
            <div className='field'>
            <label>Comment: {comment}</label>
            <textarea value={comment} onChange={e=>{setComment(e.target.value)}}/>
            </div>

            <button type='submit'>Submit</button>
        </fieldset>
        </form>
       
    </div>
  )
}

export default Form