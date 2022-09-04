import React, { Component } from 'react';
import { BrowserRouter, Routes, Route } from "react-router-dom";
import Layout from "./pages/Layout";
import Home from "./pages/Home";
import Games from "./pages/Games";
import Characters from "./pages/Characters";
import Maps from "./pages/Maps";
import NoPage from "./pages/NoPage";
import CharacterDetails from './pages/CharacterDetails';
import Register from './pages/Register';
import Login from './pages/Login'
import NotAuthorized from './pages/NotAuthorized';
import NewCharacter from './pages/NewCharacter';
import 'react-toastify/dist/ReactToastify.css';


export default class App extends Component {
    static displayName = App.name;

    render() {
        return (
            <div className="container">
                <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700&display=swap"/>
                <link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons"/>

            <BrowserRouter>
                <Routes>
                    <Route path="/" element={<Layout />}>
                        <Route index element={<Home />} />
                        <Route path="games" element={<Games />} />
                        <Route path="characters" element={<Characters />} />
                        <Route path="maps" element={<Maps />} />
                        <Route path="*" element={<NoPage />} />
                        <Route path="characterDetails/:id" element={<CharacterDetails/>}/>
                        <Route path="register" element={<Register/>}/>
                        <Route path="login" element={<Login/>}/>
                        <Route path='notAuthorized' element={<NotAuthorized/>}/>
                        <Route path='newCharacter' element={<NewCharacter/>}/>
                    </Route>
                </Routes>
                </BrowserRouter>
            </div>
        );
    }
}