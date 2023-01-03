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
`;
