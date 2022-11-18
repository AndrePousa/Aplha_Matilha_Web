import styled from "styled-components";

export const HeaderArea = styled.header`
  
  background-color:#0c3c6c;
  //background-color:#FFF;
  height:80px;
  border-botton:1px solid #CCC;

  .container {
    max-width:1000px;
    margin:auto;
    display:flex;
    padding: 0;
  }

  .linkHeader{
    color:#e6475c;
  }

  .linkHeader {
    font-size:14px;

    &:hover{
      color:#fff;
    }
    &:Hover{
      //background-color:#e6475c;
      //border-radius:4px;
      color:#fff;
      //padding:5px 10px; //5 emcima e embaixo, 10px na direita e na esquerda.
    }
  }
   

  .logo {
    flex: 1;
    display: flex; 
    aling-items: center;
  }

  .avatar {
    margin-top:0;
    height:80px;
  }

  nav ul,
  nav li,
  a {
    list-style: none;
    text-decoration: none;
  }

  /*nav{
    padding-top: 10px;
    padding-botton: 10px;
  } */

  ul, li {
    margin: 0;
    padding: 0;
    list-style: none;
  }

  ul{
    display: flex;
    align-items: center;
    height: 40px;
  }

  li{
    margin-left:20px;
    margin-right:20px;
    padding-top: 40px;
  }
`;