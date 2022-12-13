import { useState } from "react";
import { Link } from "react-router-dom";
import { PageContainer, PageTitle } from "../../components/MainComponents";
import { Container, ContainerLogin, WrapLogin } from "./styled";

const Login = () => {

  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');

  return(
    <Container>
      <ContainerLogin>
        <WrapLogin>
          <form className='login-form'>
            <span className='login-form-title'>
              <PageTitle>Login</PageTitle>
            </span>
            <div className='wrap-input'>
              <input
                className={email !== "" ? "has-val input" : "input"}
                type='email'
                value={email}
                onChange={(e) => setEmail(e.target.value)}
              />
              <span className='focus-input' data-placeholder='Email'></span>
            </div>

            <div className='wrap-input'>
              <input
                 className={password !== "" ? "has-val input" : "input"}
                 type='password'
                 value={password}
                 onChange={(e) => setPassword(e.target.value)}
              />
              <span className='focus-input' data-placeholder='Password'></span>
            </div>

            <div className='container-login-form-btn'>
              <button className='login-form-btn'>Login</button>
            </div>

            <div className='text-center'>
              <span className='txt1'>Não é cadastrado ?</span>
              <Link className='txt2' to='/registration'>Cadastre-se</Link>
            </div>
            <div className='text-center'>
              <span className='txt1'>Conheça a Alpha Matilha :</span>
              <Link className='txt2' to='/home'>Entre</Link>
            </div>
          </form>
        </WrapLogin>
      </ContainerLogin>
    </Container>
  )

}
export default Login;