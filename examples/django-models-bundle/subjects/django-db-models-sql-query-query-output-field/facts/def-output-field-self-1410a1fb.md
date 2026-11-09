# Fact 1410a1fb

Store id: 65859313-3c22-424b-b8ad-e86edccd8d9c

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
- posted_at: `2026-11-09T22:39:51.2221940+00:00`

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
  "id": "65859313-3c22-424b-b8ad-e86edccd8d9c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.2221940+00:00"
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
  "subject_id": "a404dce0-d069-4eb1-8873-2b786bd57e5b",
  "subject_name": "django/db/models/sql/query::Query.output_field",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def output_field(self)"
}
```
