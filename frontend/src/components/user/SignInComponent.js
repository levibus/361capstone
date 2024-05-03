import React, { useState } from "react";
import { Container, Row, Col, Card, Form, Button } from "react-bootstrap";
import { Link } from "react-router-dom";
// import { useNavigate } from "react-router-dom";
import axios from "axios";

function Signin() {
  const [loginForm, setloginForm] = useState({
    username: "",
    password: "",
  });
  const [Customer, setCustomer] = useState([]); // State to store user info

  const handleChange = (e) => {
    const { name, value } = e.target;
    const newLoginForm = { ...loginForm, [name]: value };
    setloginForm(newLoginForm);
  };
  const handleSubmit = async (e) => {
    e.preventDefault();
    const url = `http://localhost:5053/api/customer?username=${encodeURIComponent(
      loginForm.username
    )}&password=${encodeURIComponent(loginForm.password)}`;

    try {
      const response = await axios.get(url, loginForm, {
        headers: {
          Accept: "application/json",
          "Content-Type": "application/json",
        },
      });
      console.log("Received login:", response);
      if (response.status === 200) {
        setCustomer(response.data);
      } else {
        console.error("Error signing into account:", response.statusText);
      }
    } catch (error) {
      console.error("Error signing into account:", error);
      if (error.response) {
        console.error("Error Data:", error.response.data);
        console.error("Error Status:", error.response.status);
        console.error("Error Headers:", error.response.headers);
      } else if (error.request) {
        console.error("Error Request:", error.request);
      } else {
        console.error("Error", error.message);
      }
    }
  };

  return (
    <Container>
      <Row className="justify-content-md-center">
        <Col xs={12} sm={10} md={9} lg={8} xl={6}>
          <Card className="p-4 mt-4 mb-5 shadow-sm">
            <Card.Body>
              <h2 className="text-center mb-4">Sign In</h2>
              <Form onSubmit={handleSubmit}>
                <Form.Group controlId="userName">
                  <Form.Label>Username</Form.Label>
                  <Form.Control
                    type="text"
                    name="username"
                    placeholder="Enter username"
                    value={loginForm.username}
                    onChange={handleChange}
                  />
                </Form.Group>
                <Form.Label>Password</Form.Label>{" "}
                <Form.Group controlId="password">
                  <Form.Control
                    type="text"
                    name="password"
                    placeholder="Enter Password"
                    value={loginForm.password}
                    onChange={handleChange}
                  />
                </Form.Group>
                <Button variant="primary" type="submit" className="w-100 mt-3">
                  Sign In
                </Button>
              </Form>
              {Customer.length > 0 ? (
                Customer.map((customer) => (
                  <div className="mt-4">
                    <h3>Welcome Back, {customer.firstName}!</h3>
                  </div>
                ))
              ) : (
                <p className="mt-4">Or Create Account</p>
              )}

              <Link to="/newuser">
                <Button variant="primary">Sign Up</Button>
              </Link>
            </Card.Body>
          </Card>
        </Col>
      </Row>
    </Container>
  );
}
export default Signin;
