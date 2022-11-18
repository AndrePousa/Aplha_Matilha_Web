import React, { useState } from 'react'
import { BrowserRouter, Route, Routes } from 'react-router-dom';
import Footer from './components/Footer/FooterArea';
import Header from './components/Header/Header';
import About from './pages/about/About';
import Home from './pages/home/Home';
import Login from './pages/login/Login';
import Registration from './pages/registration/Registration';


const AppRouters = () => {

  const [logad, setLogad] = useState(true);

  return(
    <BrowserRouter>
    {logad !== true ? <Header/> : ''}
      <Routes>
        <Route path="/" element={<Login/>}/>
        <Route path="/home" element={<Home/>}/>
        <Route path="/about" element={<About/>}/>
        <Route path="/registration" element={<Registration/>}/>
      </Routes>
    {logad !== true ? <Footer/> : ''}
    </BrowserRouter>
  );
}

export default AppRouters;