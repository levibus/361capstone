import React from "react";
import { Container, Row, Col, Card, Form, Button } from "react-bootstrap";

function Signin() {
  //   const handleSignUp = () => {
  //     // Implement Later
  //   };

  return (
    <Container>
      <Row className="justify-content-md-center">
        <Col xs={12} sm={10} md={9} lg={8} xl={6}>
          <Card className="p-4 mt-4 mb-5 shadow-sm">
            <Card.Body>
              <h2 className="text-center mb-4">Sign In</h2>
              <Form>
                <Form.Group controlId="returnUser">
                  <Form.Label>Email address</Form.Label>
                  <Form.Control type="email" placeholder="Enter email" />
                </Form.Group>

                <Form.Group controlId="returnPassword">
                  <Form.Label>Password</Form.Label>
                  <Form.Control type="password" placeholder="Password" />
                </Form.Group>

                <Button variant="primary" type="submit" className="w-100 mt-3">
                  Sign In
                </Button>
              </Form>
              <p className="mt-4">Or Create Account</p>
              <Button variant="primary">Sign Up</Button>
            </Card.Body>
          </Card>
        </Col>
      </Row>
    </Container>
  );
}

export default Signin;
