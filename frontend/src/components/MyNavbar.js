import React from "react";
import { NavLink as RRNavLink, useLocation } from "react-router-dom";
import { Navbar, Nav, NavDropdown } from "react-bootstrap";
import "../App.css"; // Import the global CSS file

function MyNavbar() {
  const location = useLocation();
  const isCategoriesActive = location.pathname.startsWith("/categories");

  return (
    <Navbar bg="info" expand="md" fixed="top" className="px-3">
      <Navbar.Brand href="/">
        <img
          id="navbar-logo"
          src="/public/logo192.png"
          alt="CompanyLogo"
          height="30"
          className="d-inline-block align-top"
        />
      </Navbar.Brand>
      <Navbar.Toggle aria-controls="basic-navbar-nav" />
      <Navbar.Collapse id="basic-navbar-nav">
        <Nav className="me-auto">
          <Nav.Link as={RRNavLink} to="/">
            Home
          </Nav.Link>
          <NavDropdown
            title="Categories"
            id="navbarDropdownServices"
            className={isCategoriesActive ? "active-dropdown" : ""}
          >
            <NavDropdown.Item href="/categories/pants">Pants</NavDropdown.Item>
            <NavDropdown.Item href="/categories/shirts">
              Shirts
            </NavDropdown.Item>
            <NavDropdown.Item href="/categories/accessories">
              Accessories
            </NavDropdown.Item>
          </NavDropdown>
          <Nav.Link as={RRNavLink} to="/sale">
            Sales
          </Nav.Link>
          <Nav.Link as={RRNavLink} to="/signin">
            Sign in
          </Nav.Link>
        </Nav>
      </Navbar.Collapse>
    </Navbar>
  );
}

export default MyNavbar;
