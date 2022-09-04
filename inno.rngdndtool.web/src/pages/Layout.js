import { Outlet, Link, useNavigate } from "react-router-dom";

const Layout = () => {
    const navigator = useNavigate();
    var authJsx = [];
    var token = sessionStorage.getItem("token");

    const RemoveToken = async (e) => {
        e.preventDefault();
        sessionStorage.removeItem("token");
        navigator('/home');
    }

    if(token == null || token == undefined ||token == "")
    {
        authJsx.push(                    
                    <div className="my-2 my-lg-0">
                        <Link className="btn btn-outline-primary my-2 my-sm-0" to="/Register" key="registerPage">Register</Link>
                        <Link className="btn btn-outline-primary my-2 my-sm-0" to="/Login" key="loginPage">Login</Link>
                    </div>
                    );
    }
    else 
    {
        authJsx.push(                    
            <div className="my-2 my-lg-0">
                <Link className="btn btn-outline-danger my-2 my-sm-0" to="/Home" onClick={(e) => RemoveToken(e)} key="logoutPage">Logout</Link>
            </div>
            );
    }
    return (
        <>
            <nav className="navbar navbar-expand-lg navbar-light bg-light">
                <a className="navbar-brand" href="/">RNG DND Tools</a>
                <div className="collapse navbar-collapse">
                    <ul className="navbar-nav mr-auto">
                        <li className="nav-item" key="homePage">
                            <Link className="nav-link" to="/">Home</Link>
                        </li>
                        <li className="nav-item" key="gamesPage">
                            <Link className="nav-link" to="/Games">Games & Sessions</Link>
                        </li>
                        <li className="nav-item" key="charactersPage">
                            <Link className="nav-link" to="/Characters">Characters</Link>
                        </li>
                        <li className="nav-item" key="mapsPage">
                            <Link className="nav-link" to="/Maps">Maps</Link>
                        </li>
                    </ul>
                    {authJsx}
                </div>
            </nav>
            <Outlet />
        </>
    )
};

export default Layout;