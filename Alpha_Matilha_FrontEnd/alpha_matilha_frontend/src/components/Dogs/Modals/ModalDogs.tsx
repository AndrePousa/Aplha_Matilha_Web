import react, { Children, useState } from "react";
import { ModalArea, ModalBackground } from "./styled";


const ModalDogs = ({children, visibleModal, setVisibleModal}) =>{

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
          Conteúdo do Modal
        </ModalArea>
      </ModalBackground>
    </>
  )
}

export default ModalDogs;