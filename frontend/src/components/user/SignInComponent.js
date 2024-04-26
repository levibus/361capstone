import React, { useState } from "react";
import { Container, Row, Col, Card, Form, Button } from "react-bootstrap";
import { Link } from "react-router-dom";function Signin() {
  const [formData, setFormData] = useState({
    username: "",
    password: "",
  });  const handleChange = (e) => {
    const { name, value } = e.target;
    const newFormData = { ...formData, [name]: value };
    setFormData(newFormData);
    localStorage.setItem("formData", JSON.stringify(newFormData));
  };  const handleSubmit = async (e) => {
    e.preventDefault();    try {
      const response = await fetch(
        // Need our backend API url for signup.
        // I believe this is in Program.cs routing function but nothing is defined so ... :O Not sure- ask on wendesday
        // Example of what it would look like-
        "http://localhost:5053/api/customer",
        {
          method: "POST",
          headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
          },
          body: JSON.stringify(formData),
        }
      );      
      console.log("Received sign-in response:", response);
      if (response.ok) {
        console.log("Account signing in successfully!");
      } else {
        console.error("Error signing into account:", response.statusText);
      }
    } catch (error) {
      console.error("Error signing into account:", error);
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
                    value={formData.username}
                    onChange={handleChange}
                  />
                </Form.Group>
                <Form.Label>Password</Form.Label>                <Form.Group controlId="password">
                  <Form.Control
                    type="text"
                    name="password"
                    placeholder="Enter Password"
                    value={formData.password}
                    onChange={handleChange}
                  />
                </Form.Group>
                {/* <Link to="/"> */}
                  <Button
                    variant="primary"
                    type="submit"
                    className="w-100 mt-3"
                  >
                    Sign In
                  </Button>
                {/* </Link> */}
              </Form>
              <p className="mt-4">Or Create Account</p>
              <Link to="/newuser">
                <Button variant="primary">Sign Up</Button>
              </Link>
            </Card.Body>
          </Card>
        </Col>
      </Row>
    </Container>
  );
}export default Signin;