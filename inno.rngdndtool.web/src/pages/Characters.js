import Header from "../components/Header";
import CharacterCard from "../components/CharacterCard";
import { useState, useEffect } from "react";
import { Button } from "@mui/material";
import { useNavigate } from "react-router-dom";
import { toast, ToastContainer } from 'react-toastify'

const Characters = () => {
    const [characterList, setCharacterList] = useState(null);
    const navigator = useNavigate();

    useEffect(async () => {
        // GET request using fetch inside useEffect React hook
        await fetch('https://localhost:7163/api/Character')
            .then(response => response.json())
            .then(data => setCharacterList(data));
    
    // empty dependency array means this effect will only run once (like componentDidMount in classes)
    }, [])

    const handleNewCharacter = () => {
        navigator('/NewCharacter');
    }

    if(characterList != null )
    {
        var characterCards = [];

        characterList.forEach(element => {
            characterCards.push(<CharacterCard id={element.id} name={element.name} key={element.id}></CharacterCard>)
        });
        return (
            <div className="container">
                <ToastContainer/>
                <Header nav1 = "Characters"/>
                <Button onClick={handleNewCharacter}>Create new charater</Button>
                <br/>
                {characterCards}
            </div>
            );
    }
    else{ return (
    <div className="container">
        <ToastContainer/>
    Loading characters... Please wait. If the loading persists contact a administrator!
    </div>
    );
};
};

export default Characters;