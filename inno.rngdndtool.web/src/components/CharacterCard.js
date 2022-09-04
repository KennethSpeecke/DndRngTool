import * as React from 'react';
import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Typography from '@mui/material/Typography';
import { CardActionArea, CardActions } from '@mui/material';
import {
  Link,
} from "react-router-dom";

const CharacterCard = ({id, name}) => {
  
  return (
    <div>
      <Card sx={{ maxWidth: 345 }}>
        <CardActionArea>
          <CardMedia
            component="img"
            height="140"
            image="https://static8.depositphotos.com/1001024/961/i/450/depositphotos_9617381-stock-photo-man-in-an-medieval-hood.jpg"
            alt="Anon Character Image"
          />
          <CardContent>
            <Typography gutterBottom variant="h5" component="div">
              {name}
            </Typography>
          </CardContent>
        </CardActionArea>
        <CardActions>
          <Link to={`/characterDetails/${id}`}>View character sheet</Link>
        </CardActions>
      </Card>
      
    </div>
  )
}

export default CharacterCard