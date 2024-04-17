import React from "react";
import "./App.css";
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import "bootstrap/dist/css/bootstrap.min.css"; // Bootstrap CSS
import Homepage from "./pages/Homepage";
import MyNavbar from "./components/MyNavbar";
import SignInPage from "./pages/SigninPage";
import ShirtsPage from "./pages/Categories/ShirtsPage";
import PantsPage from "./pages/Categories/PantsPage";
import SalesPage from "./pages/Sale/SalePage";
import AccessoriesPage from "./pages/Categories/AccessoriesPage";

function App() {
  return (
    <Router>
      <div className="App">
        <MyNavbar />
        <div className="main-content">
          <Routes>
            <Route path="/" element={<Homepage />} />
            <Route path="/signin" element={<SignInPage />} />
            <Route path="/categories/pants" element={<PantsPage />} />
            <Route path="/categories/shirts" element={<ShirtsPage />} />
            <Route
              path="/categories/accessories"
              element={<AccessoriesPage />}
            />
            <Route path="/sale" element={<SalesPage />} />
          </Routes>
        </div>
      </div>
    </Router>
  );
}

export default App;
