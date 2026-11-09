# Fact 1410a1fb

Store id: 6542b46f-b0b4-4b62-afe8-4c5be01bb091

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
- posted_at: `2026-11-09T23:44:58.5932340+00:00`

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
  "id": "6542b46f-b0b4-4b62-afe8-4c5be01bb091",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.5932340+00:00"
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
  "subject_id": "4f97d8fe-6df9-4964-847a-841609b199e2",
  "subject_name": "django/db/models/sql/query::Query.output_field",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def output_field(self)"
}
```
