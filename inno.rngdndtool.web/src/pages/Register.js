import React, {useState} from 'react'
import { Link, useNavigate } from 'react-router-dom';

const Register = () => {

const FORM_ENDPOINT = "https://localhost:7163/api/Account/Register"
const currentReg = {};
const navigator = useNavigate();
const [name, setName] = useState('');
const [email, setEmail] = useState('');
const [password, setPassword] = useState('');
const [confirmPassword, setConfirmPassword] = useState('');

const updateReg = async () => {
    currentReg.name = name;
    currentReg.email = email;
    currentReg.password = password;
    currentReg.confirmPassword = confirmPassword;
}

const handleRegistration = async (e) => {
    e.preventDefault();
    await updateReg();
    const res = await fetch(FORM_ENDPOINT, {
      method: 'POST',
      header: {'Content-Type': 'Application/json'},
      body: JSON.stringify(currentReg)
    })
    const data = await res.json();
    //redirect to login
    navigator('/login')
  }
  return (
    <div>
        <br/>
      <div class="container">
        <div class="row justify-content-center">
          <div class="col-md-5">
            <div class="card">
              <h2 class="card-title text-center">Register
              </h2>
              <div class="card-body py-md-4">
                <form _lpchecked="1">
                  <div class="form-group">
                    <input type="text" class="form-control" id="name" placeholder="Nickname" onChange={(e) => setName(e.target.value)}/>
                  </div>
                  <div class="form-group">
                    <input type="email" class="form-control" id="email" placeholder="Email" onChange={(e) => setEmail(e.target.value)}/>
                  </div>
                  <div class="form-group">
                    <input type="password" class="form-control" id="password" placeholder="Password" onChange={(e) => setPassword(e.target.value)}/>
                  </div>
                  <div class="form-group">
                    <input type="password" class="form-control" id="confirm-password" placeholder="confirm-password" onChange={(e) => setConfirmPassword(e.target.value)}/>
                  </div>
                  <div class="d-flex flex-row align-items-center justify-content-between">
                    <Link to="/Login">Login</Link>
                    <button class="btn btn-primary"onClick={(e) => handleRegistration(e)}>Create Account</button>
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

export default Register
