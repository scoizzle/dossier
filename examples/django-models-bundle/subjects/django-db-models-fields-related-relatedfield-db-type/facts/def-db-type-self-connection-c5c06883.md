# Fact c5c06883

Store id: a33ba0bd-fa2a-4986-bf68-e6ccc40b333c

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
- posted_at: `2026-11-09T23:44:51.4758470+00:00`

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
  "id": "a33ba0bd-fa2a-4986-bf68-e6ccc40b333c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.4758470+00:00"
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
  "subject_id": "aaf52521-9927-4d4f-8789-6eac177a477d",
  "subject_name": "django/db/models/fields/related::RelatedField.db_type",
  "tags": [
    "entity:method"
  ],
  "text": "def db_type(self, connection)"
}
```
