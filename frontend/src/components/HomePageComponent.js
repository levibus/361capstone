import React, { useEffect, useState } from "react";

// import { Container, Row, Col, Modal, Carousel } from "react-bootstrap";

import axios from "axios";

function HomePageComponent() {

  const [products, setProducts] = useState([]);  useEffect(() => {
    axios
      .get("http://localhost:5053/api/product") //product or products, idk
      .then((response) => {
        console.log("Data:", response.data);
        setProducts(response.data);
      })
      .catch((error) => console.error("Error fetching data:", error));
  }, []);  return (
    <div>
      <h1>Products</h1>
      <ul>
        {products.map((product) => (
          <li key={product.sku}>
            {product.itemName} - ${product.price}
          </li>
        ))}
      </ul>
    </div>
  );

  // const [products, setProducts] = useState([]);

  // const [modalShow, setModalShow] = useState(false);

  // const [selectedImageIndex, setSelectedImageIndex] = useState(0);



  // const openModal = (index) => {

  //   setSelectedImageIndex(index);

  //   setModalShow(true);

  // };



  // const closeModal = () => {

  //   setModalShow(false);

  // };



  // const handleSelect = (selectedIndex) => {

  //   setSelectedImageIndex(selectedIndex);

  // };



  // useEffect(() => {

  //   // Define fetchData within useEffect

  //   const fetchData = async () => {

  //     try {

  //       const response = await axios.get("http://localhost:5053/api/product");

  //       console.log("Data:", response.data);

  //       setProducts(response.data); // Assuming the data is an array of product objects

  //     } catch (error) {

  //       console.error("Error fetching data:", error);

  //     }

  //   };



  //   fetchData(); // Call fetchData within the same useEffect

  // }, []); // Empty dependency array ensures this effect runs only once after the initial render



  // // const galleryImages = [

  // //   // For Sale Items we want to highlight on main page

  // //   {

  // //     id: "IM_1",

  // //     src: "https://media.istockphoto.com/id/1149383049/photo/red-white-striped-socks.jpg?s=1024x1024&w=is&k=20&c=dgrkYq5sVfZr2i-TwccFEee-ROKVWBo4e8tUKyYOnvU=",

  // //     alt: "Image 1",

  // //   },

  // //   {

  // //     id: "IM_2",

  // //     src: "https://images.ctfassets.net/ub3bwfd53mwy/6PhlUjXZqaHqu6LqJ5G3X3/ee400fdfaf784e3d530a212ce3453c48/1_Image.jpg?w=750",

  // //     alt: "Image 2",

  // //   },

  // //   {

  // //     id: "IM_3",

  // //     src: "https://images.ctfassets.net/ub3bwfd53mwy/6atCoddzStFzz0RcaztYCh/1c3e8a37eebe3c6a435038f8d9eef7f3/3_Image.jpg?w=750",

  // //     alt: "Image 3",

  // //   },

  // //   {

  // //     id: "IM_4",

  // //     src: "https://images.ctfassets.net/ub3bwfd53mwy/5WFv6lEUb1e6kWeP06CLXr/acd328417f24786af98b1750d90813de/4_Image.jpg?w=750",

  // //     alt: "Image 4",

  // //   },

  // // ];



  // return (

  //   <Container className="mb-4">

  //     <Row className="no-gutters">

  //       {products.map((product, index) => (

  //         <Col

  //           key={product.id}

  //           xs={12}

  //           sm={4}

  //           md={4}

  //           lg={4}

  //           onClick={() => openModal(index)}

  //         >

  //           <div className="full-width-image">

  //             {/* <img

  //               className="IMGrid d-block w-100 mb-4"

  //               src={product.imageUrl} // Assuming each product has an imageUrl

  //               alt={product.itemName}

  //             /> */}

  //           </div>

  //         </Col>

  //       ))}

  //     </Row>



  //     <Modal show={modalShow} onHide={closeModal} centered size="lg">

  //       <Modal.Body>

  //         <Carousel activeIndex={selectedImageIndex} onSelect={handleSelect}>

  //           {products.map((product) => (

  //             <Carousel.Item key={product.itemName}>

  //               <img

  //                 className="d-block w-100"

  //                 src={product.url}

  //                 alt={product.itemName}

  //               />

  //               <Carousel.Caption>

  //                 <h3>{product.itemName}</h3>

  //                 <p>Price: ${product.price}</p>

  //                 <p>SKU: {product.sku}</p>

  //               </Carousel.Caption>

  //             </Carousel.Item>

  //           ))}

  //         </Carousel>

  //       </Modal.Body>

  //     </Modal>

  //   </Container>

  // );

}



export default HomePageComponent;