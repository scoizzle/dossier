# Fact f1b8d358

Store id: bda0f644-8978-4f6e-bab2-4830a8bee6e9

## Text

```text
def ref_alias(self, alias)
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
- posted_at: `2026-11-09T23:32:06.8358030+00:00`

## Data

```json
{
  "end_line": 928,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 926,
  "symbol": "Query.ref_alias"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":926,"selector":"L926-L928","symbol":"Query.ref_alias"}`

## Items

```json
[
  {
    "text": "Increases the reference count for this alias.",
    "locator": {
      "line": 927
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.ref_alias](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 928,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 926,
    "symbol": "Query.ref_alias"
  },
  "id": "bda0f644-8978-4f6e-bab2-4830a8bee6e9",
  "items": [
    {
      "locator": {
        "line": 927
      },
      "text": "Increases the reference count for this alias."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.8358030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 926,
        "selector": "L926-L928",
        "symbol": "Query.ref_alias"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "b6fa6fdb-1716-4420-946d-c4c9fba8c0c3",
  "subject_name": "django/db/models/sql/query::Query.ref_alias",
  "tags": [
    "entity:method"
  ],
  "text": "def ref_alias(self, alias)"
}
```
