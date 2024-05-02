import React from "react";
import { Container, Row, Col } from "react-bootstrap";
import HomePageComponent from "../components/HomePageComponent";
// import { variables } from "../Variables";
function Homepage() {
  return (
    <Container className="py-3">
      <Row>
        <Col xs={12} lg={7} xl={8}>
          <HomePageComponent />
        </Col>
        <Col xs={12} lg={5} xl={4}></Col>
      </Row>
    </Container>
  );
}

export default Homepage;
