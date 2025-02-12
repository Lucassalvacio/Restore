import { Button, Card, CardActions, CardContent, CardMedia, Typography } from "@mui/material"
import { Product } from "../../model/product"
import classes from "./ProductCard.module.css"
import { Link } from "react-router-dom"
type Props = {
    product: Product
}

const ProductCard = ({product}: Props) => {
    
  return (
    <Card
        elevation={3}
        sx={{
            width: 270,
            borderRadius: 2,
            display: "flex",
            flexDirection: "column",
            justifyContent: 'space-between'
        }}
    >
            <CardMedia
                sx={{height: 240, backgroundSize: 'cover'}}
                image={product.pictureUrl}
                title={product.name}
                className={classes.test}
            > <div className={classes.test1}></div></CardMedia>
            <CardContent>
                <Typography
                    gutterBottom
                    sx={{textTransform: 'uppercase'}}
                    variant="subtitle2">
                        {product.name}
                </Typography>
                <Typography
                    variant="h6"
                    sx={{color: 'secondary.main'}}>
                        ${(product.price/100).toFixed(2)}
                </Typography>

                <CardActions
                sx={{justifyContent: 'space-between'}}>
                    <Button>Add to Cart</Button>
                    <Button component={Link} to={`/catalog/${product.id}`}>View Details</Button>
                </CardActions>
            </CardContent>
    </Card>
  )
}
export default ProductCard