import styled from "styled-components";

export const Container = styled.div`
  display: flex;
  justify-content: center;
  align-items: center;
  height: 100vh;
`;

export const ContainerLogin = styled.div`

  width: 100%;
  min-height: 100vh;
  display: flex;
  flex-wrap: wrap;
  align-items: center;
  justify-content: center;
  padding: 15px;
  //background-color: #111;
`;


export const WrapLogin = styled.div`
  width: 390px;
  background-color:#3a3b3e;
  border-radius: 10px;
  overflow: hidden;
  padding: 77px 55px 33px 55px;
  box-shadow: 0 5px 10px 0px rgba(0, 0, 0, 0.2);

  .login-form {
  width: 100%;
  }

  .login-form-title {
  font-family: Nunito, sans-serif;
  display: block;
  font-size: 30px;
  color: azure;
  line-height: 1.2;
  text-align: center;
}

.login-form-title img {
  width: 90px;
}

.wrap-input {
  width: 100%;
  position: relative;
  border-bottom: 2px solid #adadad;
  margin-bottom: 37px;
}

.input {
  font-size: 15px;
  color: #fff;
  line-height: 1.2;
  border: none;
  display: block;
  width: 100%;
  height: 45px;
  background-color: transparent;
  padding: 0 5px;
  font-family: Nunito, sans-serif;
}

.focus-input {
  position: absolute;
  display: block;
  width: 100%;
  height: 100%;
  top: 0;
  left: 0;
  pointer-events: none;
  color: #adadad;
  font-family: Nunito, sans-serif;
}

.focus-input::before {
  content: "";
  display: block;
  position: absolute;
  bottom: -2px;
  left: 0;
  width: 0;
  height: 2px;
  -webkit-transition: all 0.4s;
  -o-transition: all 0.4s;
  -moz-transition: all 0.4s;
  transition: all 0.4s;
  background: #0c3c6c;
  background: -webkit-linear-gradient(to left, #0c3c6c, #1688bc);
  background: -o-linear-gradient(to left, #0c3c6c, #1688bc);
  background: -moz-linear-gradient(to left, #0c3c6c, #1688bc);
  background: linear-gradient(to left, #0c3c6c, #1688bc);
}

.focus-input::after {
  font-family: Nunito, sans-serif;
  font-size: 15px;
  color: #999999;
  line-height: 1.2;
  content: attr(data-placeholder);
  display: block;
  width: 100%;
  position: absolute;
  top: 16px;
  left: 0px;
  padding-left: 5px;
  -webkit-transition: all 0.4s;
  -o-transition: all 0.4s;
  -moz-transition: all 0.4s;
  transition: all 0.4s;
}

.input:focus {
  outline: 0;
}

.input:focus+.focus-input::after {
  top: -15px;
}

.input:focus+.focus-input::before {
  width: 100%;
}

.has-val+.focus-input::after {
  top: -15px;
}

.has-val+.focus-input::before {
  width: 100%;
}

.container-login-form-btn {
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
  padding-bottom: 13px;
}

.login-form-btn {
  font-size: 15px;
  border: none;
  border-radius: 10px;
  color: #fff;
  line-height: 1.2;
  text-transform: uppercase;
  display: flex;
  justify-content: center;
  align-items: center;
  width: 100%;
  height: 50px;
  background: #0c3c6c;
  background: -webkit-linear-gradient(to left, #0c3c6c, #1688bc);
  background: -o-linear-gradient(to left, #0c3c6c, #1688bc);
  background: -moz-linear-gradient(to left, #0c3c6c, #1688bc);
  background: linear-gradient(to left, #0c3c6c, #1688bc);
}

.login-form-btn:hover {
  cursor: pointer;
}

.text-center {
  display: flex;
  justify-content: center;
  align-items: center;
  margin-top: 20px;
}

.txt1 {
  font-size: 14px;
  color: #adadad;
  line-height: 1.5;
  padding-right: 5px;
}

.txt2 {
  font-size: 14px;
  color: #e6475c;
  line-height: 1.5;
  text-decoration: none;
}

`;

