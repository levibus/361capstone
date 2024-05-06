import React from "react";
import { Container, Row, Col, Card } from "react-bootstrap";
// import { variables } from "../Variables";
import PantsComponent from "../../components/Categories/PantsComponent";
function PantsPage() {
  return (
    <Container>
      <Row className="justify-content-md-center">
        <Col xs={12} sm={10} md={9} lg={8} xl={6}>
          <Card className="p-4 mt-4 mb-5 shadow-sm">
            <Card.Body>
              <PantsComponent />
            </Card.Body>
          </Card>
        </Col>
      </Row>
    </Container>
  );
}

export default PantsPage;
