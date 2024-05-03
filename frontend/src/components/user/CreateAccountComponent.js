import React, { useState } from "react";
import { Container, Row, Col, Card, Form, Button } from "react-bootstrap";
import { Link } from "react-router-dom";
import { useNavigate } from "react-router-dom";
import axios from "axios";

function CreateAccount() {
  const [createAccountForm, setCreateAccountForm] = useState({
    firstName: "",
    lastName: "",
    username: "",
    password: "",
  });
  const navigate = useNavigate();

  const handleChange = (e) => {
    const { name, value } = e.target;
    const newCreateAccountForm = { ...createAccountForm, [name]: value };
    setCreateAccountForm(newCreateAccountForm);
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    const url = `http://localhost:5053/api/customer?firstName=${encodeURIComponent(
      createAccountForm.firstName
    )}&lastName=${encodeURIComponent(
      createAccountForm.lastName
    )}username=${encodeURIComponent(
      createAccountForm.username
    )}&password=${encodeURIComponent(createAccountForm.password)}`;

    try {
      const response = await axios.post(url, createAccountForm, {
        headers: {
          Accept: "application/json",
          "Content-Type": "application/json",
        },
      });

      if (response.status === 200) {
        navigate("/");
        console.log("Account created successfully!");
      } else {
        console.error("Error creating account:", response.statusText);
      }
    } catch (error) {
      console.error("Error creating account:", error);
    }
  };
  return (
    <Container>
      <Row className="justify-content-md-center">
        <Col xs={12} sm={10} md={9} lg={8} xl={6}>
          <Card className="p-4 mt-4 mb-5 shadow-sm">
            <Card.Body>
              <h2 className="text-center mb-4">Sign Up</h2>
              <Form onSubmit={handleSubmit}>
                <Form.Group controlId="firstName">
                  <Form.Label>First Name</Form.Label>
                  <Form.Control
                    type="text"
                    name="firstName"
                    placeholder="Enter First Name"
                    value={createAccountForm.firstName}
                    onChange={handleChange}
                  />
                </Form.Group>
                <Form.Group controlId="lastName">
                  <Form.Label>Last Name </Form.Label>
                  <Form.Control
                    type="text"
                    name="lastName"
                    placeholder="Enter Last Name"
                    value={createAccountForm.lastName}
                    onChange={handleChange}
                  />
                </Form.Group>
                <Form.Group controlId="newUser">
                  <Form.Label>Username</Form.Label>
                  <Form.Control
                    type="username"
                    name="username"
                    placeholder="Enter username"
                    value={createAccountForm.username}
                    onChange={handleChange}
                  />
                </Form.Group>

                <Form.Group controlId="newPassword">
                  <Form.Label>Password</Form.Label>
                  <Form.Control
                    type="password"
                    name="password"
                    placeholder="Password"
                    value={createAccountForm.password}
                    onChange={handleChange}
                  />
                </Form.Group>
                <Button variant="primary" type="submit" className="w-100 mt-3">
                  Create Account
                </Button>
              </Form>
              <p className="mt-4">Returning User?</p>
              <Link to="/signin">
                <Button variant="primary">Sign In</Button>
              </Link>
            </Card.Body>
          </Card>
        </Col>
      </Row>
    </Container>
  );
}

export default CreateAccount;
