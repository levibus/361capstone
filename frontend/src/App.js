import React from "react";
import "./App.css";
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import "bootstrap/dist/css/bootstrap.min.css"; // Bootstrap CSS
import Homepage from "./pages/Homepage";
import MyNavbar from "./components/MyNavbar";
import Signin from "./pages/user/SigninPage";
import ShirtsPage from "./pages/Categories/ShirtsPage";
import PantsPage from "./pages/Categories/PantsPage";
import CreateAccountPage from "./pages/user/CreateAccountPage";
// import {BrowserRouter, Route, Switch, NavLink} from 'react-router-dom';     from video

function App() {
  return (
    <Router>
      <div className="App">
        <MyNavbar />
        <div className="main-content">
          <Routes>
            <Route path="/" element={<Homepage />} />
            <Route path="/signin" element={<Signin />} />
            <Route path="/newuser" element={<CreateAccountPage />} />
            <Route path="/categories/pants" element={<PantsPage />} />
            <Route path="/categories/shirts" element={<ShirtsPage />} />
          </Routes>
        </div>
      </div>
    </Router>
  );
}

export default App;
