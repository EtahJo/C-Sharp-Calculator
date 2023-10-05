import { createContext, useState, useContext } from "react";

const userContext = createContext(undefined);

export const UserProvider = ({children})=>{
    const [user]= useState({
        name:'John',
        email:"john@example.com",
        dob: "01/01/1994"
    })
    return <userContext.Provider value={{user}}>
        {children}
    </userContext.Provider>
}

export const useUser = ()=>useContext(userContext)