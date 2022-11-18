import { PageContainer, PageTitle } from "../../components/MainComponents";
import { PageArea } from "./styled";

const Login = () => {
  return(
    <PageContainer>
      <PageTitle>Login</PageTitle>
      <PageArea>
      <form >
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
            <div className="area--title">Senha</div>
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
            <div className="area--title">Lembrar Senha</div>
            <div className="area--input">
              <input 
                type="checkbox" 
                //disabled={disabled}
                //cheked={rememberPasword} 
                //onChange={() => setRememberPasword(!rememberPasword)}
              />
            </div>
          </label>
          <label className="area">
            <div className="area--title"></div>
            <div className="area--input">
              <button>Fazer Login</button>
            </div>
          </label>
        </form>
      </PageArea>
    </PageContainer>
  )

}
export default Login;