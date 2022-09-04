import React, { useState } from 'react'
import { Link, useNavigate } from 'react-router-dom';
import { toast, ToastContainer } from 'react-toastify';

const Login = () => {
    const navigator = useNavigate();
    const FORM_ENDPOINT = "https://localhost:7163/api/Account/Login"
    const [userName, setUserName] = useState("");
    const [password, setPassword] = useState("");

    const currentLog = {};

    const setCurrentLog = async () => {
        currentLog.userName = userName;
        currentLog.password = password;
    }

    const handleLogin = async (e) => {
        e.preventDefault();
        await setCurrentLog();
        const res = await fetch(FORM_ENDPOINT, {
          method: 'POST',
          header: {'Content-Type': 'Application/json'},
          body: JSON.stringify(currentLog)
        })
        if(res.status == 200){
          const data = await res.json();
          sessionStorage.setItem("token", data.token);
          toast.success("Login success");
          navigator('/characters');
        }
        else{
          toast.error('Username and or password not found.');
        }

    }

  return (
    <div>
        <br/>
        <ToastContainer/>
      <div class="container">
        <div class="row justify-content-center">
          <div class="col-md-5">
            <div class="card">
              <h2 class="card-title text-center">Login
              </h2>
              <div class="card-body py-md-4">
                <form _lpchecked="1">
                  <div class="form-group">
                    <input type="text" class="form-control" id="name" placeholder="Username" onChange={(e) => setUserName(e.target.value)}/>
                  </div>
                  <div class="form-group">
                    <input type="password" class="form-control" id="password" placeholder="Password" onChange={(e) => setPassword(e.target.value)}/>
                  </div>
                  <div class="d-flex flex-row align-items-center justify-content-between">
                    <Link to="/Register">Register</Link>
                    <button class="btn btn-primary" onClick={(e) => handleLogin(e)}>Login</button>
                  </div>
                </form>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  )
}

export default Login
