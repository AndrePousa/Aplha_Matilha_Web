import styled from "styled-components";
import { PageContainer, PageTitle } from "../../components/MainComponents";
import { PageArea } from "./styled";

const Login = () => {
  return(
    <PageContainer>
      <PageTitle>Cadastre-se</PageTitle>
      <PageArea>
      <form >
          <label className="area">
            <div className="area--title">Nome</div>
            <div className="area--input">
              <input 
                type="email" 
                //disabled={disabled} 
                //value={email}
                //onChange={e => setEmail(e.target.value)}
                required
              />
            </div>
          </label>
          <label className="area">
            <div className="area--title">E-mail</div>
            <div className="area--input">
              <input 
                type="email" 
                //disabled={disabled} 
                //value={email}
                //onChange={e => setEmail(e.target.value)}
                required
              />
            </div>
          </label>
          <label className="area">
            <div className="area--title">Endereço</div>
            <div className="area--input">
              <input 
                type="password" 
                //disabled={disabled} 
                //value={password}
                //onChange={e => setPassword(e.target.value)}
                required
              />
            </div>
          </label>
          <label className="area">
            <div className="area--title"></div>
            <div className="area--input">
              <button>Cadastrar</button>
            </div>
          </label>
        </form>
      </PageArea>
    </PageContainer>
  )

}
export default Login;