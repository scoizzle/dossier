# Fact 8f8b07f3

Store id: a06040d2-a3c3-4cb6-9f38-0146caa0ed0b

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
- posted_at: `2026-11-09T23:31:57.3624510+00:00`

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
  "id": "a06040d2-a3c3-4cb6-9f38-0146caa0ed0b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.3624510+00:00"
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
  "subject_id": "b1a91e06-5c03-4c16-b34b-aeb61d48af1b",
  "subject_name": "django/db/models/fields/files::FieldFile.open",
  "tags": [
    "entity:method"
  ],
  "text": "def open(self, mode=\"rb\")"
}
```
