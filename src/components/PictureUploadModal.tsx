import { Portal } from "@chakra-ui/react";
import { useState } from "react";

import Uppy from "@uppy/core";
import { DashboardModal } from "@uppy/react";

import "@uppy/core/dist/style.min.css";
import "@uppy/dashboard/dist/style.min.css";
import "./uppy.css";

const uppy = new Uppy({
  restrictions: {
    maxFileSize: 1024 * 1024,
    maxNumberOfFiles: 1,
    minNumberOfFiles: 1,
    allowedFileTypes: ["image/bmp", "image/png"]
  }
});

export type Props = {
  isOpen: boolean;
  onClose: () => void;
};

export const PictureUploadModal = ({ isOpen, onClose }: Props) => {
  const [submitting, setSubmitting] = useState(false);

  const closeModal = () => {
    uppy.cancelAll();
    onClose();
  };

  return (
    <Portal>
      <DashboardModal
        open={isOpen}
        onRequestClose={closeModal}
        uppy={uppy}
        note=".gif and .png files, maximum 1 MB"
        proudlyDisplayPoweredByUppy={false}
        thumbnailType="image/jpeg"
        closeAfterFinish={true}
        hideCancelButton={true}
        plugins={[]}
      />
    </Portal>
  );
};
