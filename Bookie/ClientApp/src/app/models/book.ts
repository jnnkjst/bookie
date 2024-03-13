import {BookMetadata} from "./bookMetadata";

export interface Book {
  id: number;
  isbn: number;
  metadata: BookMetadata;
  filePath: string;
}
