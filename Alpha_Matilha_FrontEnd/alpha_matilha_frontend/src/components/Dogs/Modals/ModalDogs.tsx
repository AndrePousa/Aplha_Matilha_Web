import react, { Children, useState } from "react";
import { ModalArea, ModalBackground } from "./styled";
import avatar from "../../../assets/01.png";


const ModalDogs = ({children, visibleModal, setVisibleModal}) =>{

  const dog: any = new Object();
  dog.name = "Tyler";
  dog.breed = "Amstaf";
  dog.age = "6";
  dog.start_training = "16/01/2023";
  dog.active = "Ativo";
  dog.trainer = "André";
  dog.client = "André";

  const handleModalClick = (e) =>{
    console.log(e.target)
    if(e.target.classList.contains('modalBg')){
      setVisibleModal(false);
    }
    
  }

  return(
    <>
      <ModalBackground 
        className="modalBg"
        visibleModal={visibleModal}
        onClick={handleModalClick}
      >
        <ModalArea>
          <div className="containerImgDog">
            <img src={avatar} className="ImgDog"></img>
          </div>
          <div className="areaInfo">
            <div className="informations">Nome:{` ${dog.name}`}</div>
            <div className="informations">Raça:{` ${dog.breed}`}</div>
            <div className="informations">Idade:{` ${dog.age}`}</div>
            <div className="informations">Inicio das Aulas:{` ${dog.start_training}`}</div>
            <div className="informations">Estatus:{` ${dog.active}`}</div>
            <div className="informations">Proprietário:{` ${dog.client}`}</div>
            <div className="informations">Adestrador:{` ${dog.trainer}`}</div>
            <div className="areButtons">
              <button className="paginations">voltar</button>
              <button className="paginations">Proximo</button>
            </div>
          </div>
        </ModalArea>
      </ModalBackground>
    </>
  )
}

export default ModalDogs;