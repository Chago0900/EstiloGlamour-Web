module.exports = {
  siteMetadata: {
    title: `Perfumeria Estilo & Glamour Web`,
    siteUrl: `https://jamm.matter.design`,
  },
  plugins: [
    {
      resolve: `gatsby-plugin-manifest`,
      options: {
        name: `Perfumeria Estilo & Glamour Web`,
        short_name: `Estilo y Glamour`,
        start_url: `/`,
        background_color: `#000000`,
        theme_color: `#ffffff`,
        display: `standalone`,
        icon: 'src/assets/favicon.png',
      },
    },
    'gatsby-plugin-netlify',
  ],
};
