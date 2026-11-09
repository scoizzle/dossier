# Fact 00d2496a

Store id: d401759f-9596-4e66-a089-a8820e17f1ac

## Text

```text
def closed(self)
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
- posted_at: `2026-11-09T23:31:57.3712750+00:00`

## Data

```json
{
  "end_line": 134,
  "entity_kind": "method",
  "parent": "FieldFile",
  "start_line": 131,
  "symbol": "FieldFile.closed"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":131,"selector":"L131-L134","symbol":"FieldFile.closed"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FieldFile.closed](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 134,
    "entity_kind": "method",
    "parent": "FieldFile",
    "start_line": 131,
    "symbol": "FieldFile.closed"
  },
  "id": "d401759f-9596-4e66-a089-a8820e17f1ac",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.3712750+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 131,
        "selector": "L131-L134",
        "symbol": "FieldFile.closed"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "d16db6aa-3e30-4fe7-96c9-107b7ece30e1",
  "subject_name": "django/db/models/fields/files::FieldFile.closed",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def closed(self)"
}
```
