import { Link } from "react-router-dom";
import { HeaderArea } from "./styled";
import logo from '../../assets/avatar.png'


const Header = ( ) => {
  return(
      <HeaderArea>
        <nav className="container">
          <div className="logo">
            <Link to="/home">
              <img className="avatar" src={logo}/>
            </Link>
          </div>

          <ul>
            <li>
              <Link className="linkHeader" to="/about">Sobre a Alpha Matilha</Link>
            </li>
            <li>
              <Link className="linkHeader" to="/">Login</Link>
            </li>
            <li>
              <Link className="linkHeader" to="/registration">Cadastre-se</Link>
            </li>
            <li>
              <Link className="linkHeader" to="/dog_registration">Cadastre os cães</Link>
            </li>
          </ul>
        </nav>
      </HeaderArea>
  )
}

export default Header;