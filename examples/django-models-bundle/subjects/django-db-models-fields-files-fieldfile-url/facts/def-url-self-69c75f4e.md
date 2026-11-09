# Fact 69c75f4e

Store id: a8702677-84eb-41df-9afb-cce154651d68

## Text

```text
def url(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:50.6263510+00:00`

## Data

```json
{
  "end_line": 72,
  "entity_kind": "method",
  "parent": "FieldFile",
  "start_line": 69,
  "symbol": "FieldFile.url"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":69,"selector":"L69-L72","symbol":"FieldFile.url"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FieldFile.url](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 72,
    "entity_kind": "method",
    "parent": "FieldFile",
    "start_line": 69,
    "symbol": "FieldFile.url"
  },
  "id": "a8702677-84eb-41df-9afb-cce154651d68",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.6263510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 69,
        "selector": "L69-L72",
        "symbol": "FieldFile.url"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "e15605a6-411f-41ae-9788-3ea4f2fc618f",
  "subject_name": "django/db/models/fields/files::FieldFile.url",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def url(self)"
}
```
