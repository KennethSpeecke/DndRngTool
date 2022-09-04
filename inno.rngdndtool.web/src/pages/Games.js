import GameCard from '../components/GameCard';
import Header from '../components/Header';
import { useState } from 'react';

const Games = () => {
    const [games, setGames] = useState([
        {
            id: 1, 
            title: "test", 
            active: true
        }
    ])

    return (
        <div className="container">
            <Header nav1 = "Games"/>
            <br></br>
            <div className='container'>
            {games.map((game) => (<GameCard id={game.id} title={game.title} active={game.active}></GameCard>))}
            </div>
        </div>
    )
};

export default Games;