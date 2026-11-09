# Fact 8f8b07f3

Store id: c68832f5-2c7f-417e-b0a4-c624fd40c44f

## Text

```text
def open(self, mode="rb")
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
- posted_at: `2026-11-09T22:39:43.2044210+00:00`

## Data

```json
{
  "end_line": 87,
  "entity_kind": "method",
  "parent": "FieldFile",
  "start_line": 81,
  "symbol": "FieldFile.open"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":81,"selector":"L81-L87","symbol":"FieldFile.open"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FieldFile.open](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 87,
    "entity_kind": "method",
    "parent": "FieldFile",
    "start_line": 81,
    "symbol": "FieldFile.open"
  },
  "id": "c68832f5-2c7f-417e-b0a4-c624fd40c44f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.2044210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 81,
        "selector": "L81-L87",
        "symbol": "FieldFile.open"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "117d4d3c-11b7-49e9-874d-c1afe6eb76d1",
  "subject_name": "django/db/models/fields/files::FieldFile.open",
  "tags": [
    "entity:method"
  ],
  "text": "def open(self, mode=\"rb\")"
}
```
