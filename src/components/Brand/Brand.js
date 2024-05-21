import React from 'react';
import { navigate } from 'gatsby';

import * as styles from './Brand.module.css';

const Brand = (props) => {
  return (
    <div
      className={styles.root}
      role={'presentation'}
      onClick={() => navigate('/')}
    >
      {/* <h4>Estilo&Glamour</h4> */}
      <svg xmlns="http://www.w3.org/2000/svg" width="199" height="31">
      <text
        x="0"
        y="22.626"
        fill="#000"
        stroke="#000"
        strokeWidth="0"
        fontFamily="'Bodoni Moda'"
        fontSize="20"
        fontStyle="normal"
        fontWeight="bold"
        textAnchor="start"
        xmlSpace="preserve"
      >
        ESTILO&amp;GLAMOUR
      </text>
    </svg>
    </div>
  );
};

export default Brand;
