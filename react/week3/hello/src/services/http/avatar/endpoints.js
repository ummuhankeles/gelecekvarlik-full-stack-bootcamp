import axios from 'axios'

const service = axios.create({
  baseURL: 'https://api.sampleapis.com/avatar/',
})

export const getFamilyList = () => service.get('characters')

export const getEpisodes = () => service.get('episodes')

