import { Breadcrumbs, Link, Typography} from '@mui/material'
import PropTypes from 'prop-types'
import React from 'react'

const headingStyle = {
  color: 'red', 
  backgroundColor: 'lightgray'
}

const Header = ({nav1, nav2, nav3}) => {
  var crumbs = null;
  if(nav1 != undefined)
    crumbs = <Link underline="hover" color="inherit" href="/"> {nav1} </Link>
  if(nav2 != undefined)
    crumbs = <Link underline="hover" color="inherit" href={`/${nav1}/${nav2}`}> {`${nav1} / ${nav2}`} </Link>
  if(nav3 != undefined)
    crumbs = <Link underline="hover" color="inherit" href={`/${nav1}/${nav2}/${nav3}`}> {`${nav1} / ${nav2} / ${nav3}`} </Link>
    
  return (
    <Breadcrumbs aria-label="breadcrumb">
        <Link underline="hover" color="inherit" href="/">
          Home
        </Link>
        {crumbs}
    </Breadcrumbs>
  )
}

Header.defaultProps = {
    nav1: "PageNotFound"
}

Header.propTypes = {
    nav1: PropTypes.string.isRequired,
    nav2: PropTypes.string,
    nav3: PropTypes.string,
}
export default Header