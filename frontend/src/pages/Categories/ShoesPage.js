import React from "react";
import { Container, Row, Col, Card } from "react-bootstrap";
import ShoesComponent from "../../components/Categories/ShoesComponent";
function ShoesPage() {
  return (
    <Container>
      <Row className="justify-content-md-center">
        <Col xs={12} sm={10} md={9} lg={8} xl={6}>
          <Card className="p-4 mt-4 mb-5 shadow-sm">
            <Card.Body>
              <ShoesComponent />
            </Card.Body>
          </Card>
        </Col>
      </Row>
    </Container>
  );
}export default ShoesPage;