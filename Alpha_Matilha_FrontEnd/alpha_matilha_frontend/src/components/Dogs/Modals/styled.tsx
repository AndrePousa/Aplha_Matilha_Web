import styled from "styled-components";

export const ModalBackground = styled.div`
  position:fixed;
  left:0;
  top:0;
  right:0;
  bottom:0;
  z-index:90;
  background-color:rgba(0,0,0,0.7);
  display:${props => props.visibleModal ? 'flex' : 'none'};
  justify-content: center;
  align-items:center;
`;

export const ModalArea = styled.div`
  width: 600px;
  height: 570px;
  margin-top:50px;
  background-color: #ffffff;
  border-radius:10px;
  box-shadow: 0px 0px 50px #000;
  display: flex;

  .containerImgDog{
    margin: 20px;
    width: 200px;
    height: 200px;
    background-color:#c91515;
    border-radius:10px;
  }

  .areaInfo{
    margin:20px;
    width:300px;
    //background-color:#c91515;
    margin-bottom: 200px;
  }

  .informations{
    display: flex;
    padding:20px;
    padding-top: 0px;
    font-weight:bold;
  }

  .paginations{
    margin-left: 20px;
    background-color:#0c3c6c;
    border:0;
    outline:0;
    border-radius:4px;
    color:#fff;
    font-size:15px;
    cursor:pointer;

    &:hover{
          background-color:#006fce;
    }
  }

  .ImgDog{
    //margin: 20px;
    width: 200px;
    height: 200px;
    background-color:#c91515;
    border-radius:10px;
  }

  .areButtons{

  }
`;
