# Fact 2a0fe600

Store id: c90843f9-f348-4750-8dfd-30db9a71e6a7

## Text

```text
def _set_instance_attribute(self, name, content)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:57.4259590+00:00`

## Data

```json
{
  "end_line": 411,
  "entity_kind": "method",
  "parent": "ImageFieldFile",
  "start_line": 407,
  "symbol": "ImageFieldFile._set_instance_attribute"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":407,"selector":"L407-L411","symbol":"ImageFieldFile._set_instance_attribute"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::ImageFieldFile._set_instance_attribute](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 411,
    "entity_kind": "method",
    "parent": "ImageFieldFile",
    "start_line": 407,
    "symbol": "ImageFieldFile._set_instance_attribute"
  },
  "id": "c90843f9-f348-4750-8dfd-30db9a71e6a7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.4259590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 407,
        "selector": "L407-L411",
        "symbol": "ImageFieldFile._set_instance_attribute"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "d0f66fd4-5a6d-4eca-9f5b-05fdc20dc7b8",
  "subject_name": "django/db/models/fields/files::ImageFieldFile._set_instance_attribute",
  "tags": [
    "entity:method"
  ],
  "text": "def _set_instance_attribute(self, name, content)"
}
```
