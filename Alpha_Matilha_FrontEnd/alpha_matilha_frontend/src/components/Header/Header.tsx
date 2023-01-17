import { Link } from "react-router-dom";
import { HeaderArea } from "./styled";
import logo from '../../assets/avatar.png'
import ModalDogs from "../Dogs/Modals/ModalDogs";
import { useState } from "react";


const Header = () => {

  const [visibleModal, setVisibleModal] = useState(false);

  const handleModalClickHeader = () =>{
    setVisibleModal(true)
  }

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
            <li>
              <button onClick={handleModalClickHeader} className="linkHeader">Cães</button>
            </li>
          </ul>
        </nav>
        <ModalDogs 
          visibleModal={visibleModal} 
          setVisibleModal={setVisibleModal}
        >
      </ModalDogs>
      </HeaderArea>
  )
}

export default Header;