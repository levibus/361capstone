import React from "react";
import { Container, Row } from "react-bootstrap";
import CreateAccount from "../../components/user/CreateAccountComponent";
// import { variables } from ".../Variables";

function CreateAccountPage() {
  return (
    <Container>
      <Row className="justify-content-md-center">
        {/* <Col xs={12} sm={10} md={9} lg={8} xl={6}> */}
        {/* <Card className="p-4 mt-4 mb-5 shadow-sm"> */}
        <CreateAccount />
        {/* <p>Create Account Page</p> */}
        {/* <h2 className="text-center mb-4">Create Your Account</h2> */}
        {/* </Col> */}
      </Row>
    </Container>
  );
}

export default CreateAccountPage;
