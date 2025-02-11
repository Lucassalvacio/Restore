import { createBrowserRouter } from "react-router-dom";
import App from "../../layout/App";
import HomePage from "../home/HomePage"
import Catalog from "../catalog/Catalog";
import ProductDetails from "../catalog/ProductDetails";
import AboutPage from "../about/AboutPage";
import ContactPage from "../contact/ContactPage";


export const router = createBrowserRouter([
    {
        path: '/',
        element: <App />,
        children: [
            {
                path: '',
                element: <HomePage />
            },
            {
                path: '/catalog',
                element: <Catalog  />
            },
            {
                path: '/catalog/:id',
                element: <ProductDetails />
            },
            {
                path: '/contacts',
                element: <ContactPage />
            },
            {
                path: '/about',
                element: <AboutPage />
            }
        ]
    }
])