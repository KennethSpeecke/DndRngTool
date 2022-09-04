import * as React from 'react';
import {
    BrowserRouter as Router,
    Link,
    Route,
    Routes,
    useParams,
    useNavigate,
  } from "react-router-dom";

import { useState, useEffect } from 'react';
import Header from '../components/Header';
import CharacterSheet from '../components/CharacterSheet';

const CharacterDetails = () => {
  const [currentCharacter, setCurrentCharacter] = useState(null);
  const token = sessionStorage.getItem("token");
  const navigator = useNavigate();

  useEffect(() => {
      // GET request using fetch inside useEffect React hook
      fetch(`https://localhost:7163/api/Character/${id}`, {
        method: 'GET',
        headers: {
          'Content-type': 'application/json',
          'Authorization': `Bearer ${token}`},
      })
          .then(response => response.json())
          .then(data => setCurrentCharacter(data))
          .catch();
  
  // empty dependency array means this effect will only run once (like componentDidMount in classes)
  }, [])
    const {id} = useParams();
    if (currentCharacter != null && currentCharacter != undefined)
    {
      return (
        <div>
        <Header nav1='Character'></Header>
        <CharacterSheet character={currentCharacter} characterId={id} isNew={false}></CharacterSheet>
      </div>
      );
    }
    else{
      return (<div className='container'> Loading character sheet!</div>);
    };
}

export default CharacterDetails;