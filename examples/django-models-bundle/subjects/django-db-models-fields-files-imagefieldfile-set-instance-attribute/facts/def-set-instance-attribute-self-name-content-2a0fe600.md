# Fact 2a0fe600

Store id: e67fb855-8c6d-454c-8529-7471090912be

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
- posted_at: `2026-11-09T23:44:50.6726930+00:00`

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
  "id": "e67fb855-8c6d-454c-8529-7471090912be",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.6726930+00:00"
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
  "subject_id": "e34539d5-fa85-408e-8cc0-2d53b32ce21e",
  "subject_name": "django/db/models/fields/files::ImageFieldFile._set_instance_attribute",
  "tags": [
    "entity:method"
  ],
  "text": "def _set_instance_attribute(self, name, content)"
}
```
