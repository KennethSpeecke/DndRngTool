import * as React from 'react';
import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Typography from '@mui/material/Typography';
import { Button, CardActionArea, CardActions } from '@mui/material';
import PropTypes from 'prop-types'

const GameCard = ({title, active, id}) => {
  return (
<Card sx={{ maxWidth: 345 }}>
      <CardActionArea>
        <CardMedia
          component="img"
          height="140"
          image="https://via.placeholder.com/150"
          alt="GameMap Image"
        />
        <CardContent>
          <Typography gutterBottom variant="h5" component="div">
            {title}
          </Typography>
          <Typography variant="body2" color="text.secondary">
            Game Status: {active ? "Game is active" : "Game is inactive"}
          </Typography>
        </CardContent>
      </CardActionArea>
      <CardActions>
        <Button size="small" color="primary">
          Details
        </Button>
      </CardActions>
    </Card>
  )
}

GameCard.defaultProps = {
    title : "Default Game",
    active : false
}

GameCard.propTypes = {
    title: PropTypes.string,
    active: PropTypes.bool
}
export default GameCard