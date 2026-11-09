# Fact 1410a1fb

Store id: ec31190a-47ea-4e02-a74f-bf94c45494e1

## Text

```text
def output_field(self)
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
- posted_at: `2026-11-09T23:32:06.7508940+00:00`

## Data

```json
{
  "end_line": 338,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 332,
  "symbol": "Query.output_field"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":332,"selector":"L332-L338","symbol":"Query.output_field"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.output_field](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 338,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 332,
    "symbol": "Query.output_field"
  },
  "id": "ec31190a-47ea-4e02-a74f-bf94c45494e1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.7508940+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 332,
        "selector": "L332-L338",
        "symbol": "Query.output_field"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "ca04ce5c-df69-4ba6-9f50-73703c23254e",
  "subject_name": "django/db/models/sql/query::Query.output_field",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def output_field(self)"
}
```
