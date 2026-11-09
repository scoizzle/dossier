# Fact c5c06883

Store id: 397ceae3-1c4e-4f01-a18b-04b1869633b8

## Text

```text
def db_type(self, connection)
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
- posted_at: `2026-11-09T22:39:44.2622230+00:00`

## Data

```json
{
  "end_line": 374,
  "entity_kind": "method",
  "parent": "RelatedField",
  "start_line": 371,
  "symbol": "RelatedField.db_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":371,"selector":"L371-L374","symbol":"RelatedField.db_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField.db_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 374,
    "entity_kind": "method",
    "parent": "RelatedField",
    "start_line": 371,
    "symbol": "RelatedField.db_type"
  },
  "id": "397ceae3-1c4e-4f01-a18b-04b1869633b8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.2622230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 371,
        "selector": "L371-L374",
        "symbol": "RelatedField.db_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "393dd373-9a72-4d1a-94d5-5f89c8be0854",
  "subject_name": "django/db/models/fields/related::RelatedField.db_type",
  "tags": [
    "entity:method"
  ],
  "text": "def db_type(self, connection)"
}
```
